
Imports System.IO
Imports System.Net
Imports eBay.ApiClient.Auth.OAuth2
Imports eBay.ApiClient.Auth.OAuth2.Model
Imports Microsoft.Win32
Imports System.Timers
Imports System.Runtime.InteropServices
Imports WForms = System.Windows.Forms
Imports eBay.OAS3v1IV.SellApi.FulfillmentApis
Imports eBay.OAS3v1IV.Client
''' <summary>
''' AUTHENTICATION
''' </summary>
Partial Public Class EBayConnector
    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(hWnd As IntPtr) As Boolean
    End Function


    Private ReadOnly config As EBayConfig
    Private apiCallConfig As Configuration
    Private ReadOnly oauth As OAuth2Api

    Private userAuthorizationURI As Uri
    Private authProcess As Process
    Private EBayLoginPageWindowHandle As IntPtr
    Private http As HttpListener
    Private EBayLoopbackHost As String = "http://127.0.0.1:52475/"   '"http://redirect.hcbay.in:52475/"   ' ' "https://signin.ebay.com:443/" "http://127.0.0.1:52475/
    Private processTimer As Timer
    Private hasTimedOut As Boolean
    Private cancelAuthentication As Boolean

    Private ebayOrderAPI As OrderApi

    ' URL to receive OAuth 2 redirect from EBay server.
    Public EBayRedirectUri As Uri

    ' URL to receive access token from JS.
    Private EBayJSRedirectUri As Uri

    'PUBLIC EVENTS :REF:= https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler?view=netframework-4.8
    Public Event Authenticated As EventHandler
    Public Event AuthenticationTimedout As EventHandler
    Public Event AuthenticationCancelled As EventHandler(Of EbayAuthenticationCancelledEventArgs)
    Public Event AccessTokenRefreshed As EventHandler(Of EBayAccessTokenRefreshedEventArgs)

    Sub New(config As EBayConfig)
        Me.config = config
        oauth = New OAuth2Api()
        apiCallConfig = New Configuration With {
            .AccessToken = config.AccessToken,
            .BasePath = config.BasePath
        }
        ebayOrderAPI = New OrderApi(apiCallConfig)
    End Sub

    Async Function Login() As Task

        Try
            cancelAuthentication = False
            Dim IsTokenAcquired = Await AcquireAccessToken()

            If hasTimedOut Or cancelAuthentication Then

                Return
            End If

            If (IsTokenAcquired) Then

                OnAuthenticated()

            End If



        Catch
            Throw
        End Try
    End Function

    Private Sub OnAuthenticated()
        RaiseEvent Authenticated(Me, EventArgs.Empty)
    End Sub

    Private Sub OnAccessTokenRefreshed(e As EBayAccessTokenRefreshedEventArgs)
        RaiseEvent AccessTokenRefreshed(Me, e)
    End Sub
#Region "Authentication"
    Private Async Function AcquireAccessToken() As Task(Of Boolean)


        Try

            Dim oauthEnvironment As OAuthEnvironment = GetEnvironment()

            Dim tokenResult = Await LoginToEBay(oauthEnvironment)

            If hasTimedOut Or cancelAuthentication Then
                Return False
            End If

            If tokenResult Is Nothing Then Return False

            config.AccessToken = tokenResult.AccessToken.Token
            config.AccessTokenType = tokenResult.AccessToken.TokenType
            config.AcesssTokenExpiresOn = tokenResult.AccessToken.ExpiresOn
            config.RefreshToken = tokenResult.RefreshToken.Token
            config.RefreshTokenType = tokenResult.RefreshToken.TokenType
            config.RefreshTokenExpiresOn = tokenResult.RefreshToken.ExpiresOn
            config.HasAquiredAccessToken = True

            'Debug.WriteLine("Uid: {0}", account.UID)
            Debug.WriteLine("AccessToken: {0}", tokenResult.AccessToken)

            If tokenResult.RefreshToken IsNot Nothing Then
                Console.WriteLine("RefreshToken: {0}", tokenResult.RefreshToken)
            End If

            Return True
        Catch ocx As OperationCanceledException

            cancelAuthentication = True
            AbortSignin()
            CloseBrowser()

            Dim eaCancellation = New EbayAuthenticationCancelledEventArgs(ocx.Message)
            OnSignInCancelledEvent(eaCancellation)

        Catch ex As Exception
            Debug.WriteLine("Error: {0}", ex.Message)
            Throw
        End Try


    End Function

    Private Function GetEnvironment() As OAuthEnvironment
        CredentialUtil.Load(config.CredentialPath)
        Dim oauthEnvironment As OAuthEnvironment

        Dim IsSandBoxEnvironment = config.BasePath.Contains("sandbox")

        If IsSandBoxEnvironment Then
            oauthEnvironment = OAuthEnvironment.SANDBOX
        Else
            oauthEnvironment = OAuthEnvironment.PRODUCTION
        End If
        Return oauthEnvironment
    End Function

    Private Async Function LoginToEBay(oauthEnvironment As OAuthEnvironment) As Task(Of OAuthResponse)
        Dim userAuthorizationURL As String
        Try
            Dim state As String = Guid.NewGuid().ToString("N")

            http = Nothing

            userAuthorizationURL = oauth.GenerateUserAuthorizationUrl(oauthEnvironment, config.Scopes, state)
            Debug.WriteLine("userAuthorizationURL: " & userAuthorizationURL)
            userAuthorizationURI = New Uri(userAuthorizationURL)
            EBayRedirectUri = New Uri(EBayLoopbackHost + "redirect/index.html")
            EBayJSRedirectUri = New Uri(EBayLoopbackHost + "redirect/token.html")

            'login to EBay in the browser to Authorize  
            authProcess = LaunchBrowser(userAuthorizationURI)
            authProcess.Refresh()
            EBayLoginPageWindowHandle = authProcess.Handle
            Debug.WriteLine("pROcess started: " + authProcess.StartInfo.FileName)

            'Start local server to listen to reponse from EBay page on browser
            StartHTTPListener()
            Debug.WriteLine("http listener started ")

            ' countdown for auto cancellation
            StartTimer(45000)

            If cancelAuthentication Then
                Return Nothing
            End If

            'Handle OAuth redirect And send URL fragment to local server using JS.
            Debug.WriteLine("calling HandleOAuth2Redirect   ")
            Await HandleOAuth2Redirect(http)

            If hasTimedOut Or cancelAuthentication Then
                Return Nothing
            End If

            Debug.WriteLine("HandleOAuth2Redirect  complete")


            'Handle OAuth redirect And send URL fragment to local server using JS.
            Debug.WriteLine("retreive the code from response")
            Dim redirectUri = Await RetreiveCodeFromResponse(http)
            If hasTimedOut Or cancelAuthentication Then
                Return Nothing
            End If



            'end this session
            StopHTTPListener()
            StopTimer()
            'CloseBrowser()

            'start New session to Notifiy Token Received message in the browser to  the user 
            StartHTTPListener()
            Await HandleTokenReceivedRedirect(http)

            ''Handle redirect from JS And process OAuth response.
            'Debug.WriteLine("redirect from JS calling")
            'Dim redirectUri = Await HandleJSRedirect(http)
            If redirectUri Is Nothing Then Return Nothing

            Dim result = redirectUri.Query.Split("&"c)
            If result(0).Contains("error") Then

                Dim errorMessage = result(0).Split("="c)(1)
                errorMessage += " - " + result(1).Split("="c)(1).Replace("+", " ")

                Throw New OperationCanceledException(errorMessage)
            End If
            'StopTimer()
            StopHTTPListener()
            CloseBrowser()


            'If hasTimedOut Or cancelAuthentication Then
            '    Return Nothing
            'End If
            Debug.WriteLine("retreive the code from response   complete")

            Dim code = result(1)
            Debug.WriteLine("Exchanging code for token")
            Dim tokenResult = oauth.ExchangeCodeForAccessToken(oauthEnvironment, code)
            Debug.WriteLine("Finished Exchanging Code for Token")
            If (tokenResult.AccessToken Is Nothing) Then
                Throw New Exception("Access token not received after exchanging code")
            End If





            Debug.WriteLine("AccessToken: " & tokenResult.AccessToken?.Token)
            Debug.WriteLine("AccessToken ExpiresOn: " & tokenResult.AccessToken?.ExpiresOn.ToString())
            Debug.WriteLine("AccessToken TokenType: " & tokenResult.AccessToken?.TokenType.ToString())
            Debug.WriteLine("RefreshToken: " & tokenResult.RefreshToken?.Token)
            Debug.WriteLine("RefreshToken ExpiresOn: " & tokenResult.RefreshToken?.ExpiresOn.ToString())
            Debug.WriteLine("RefreshToken TokenType: " & tokenResult.RefreshToken?.TokenType.ToString())


            Return tokenResult

        Catch ex As OperationCanceledException

            StopTimer()

            StopHTTPListener()
            CloseBrowser()

            Throw
        End Try
    End Function

    ''' <summary>
    ''' Handle the redirect from JS And process raw redirect URI with fragment to
    ''' complete the authorization flow.
    ''' </summary>
    ''' <param name="http">The http listener.</param>
    ''' <returns>The <see cref="Uri"/></returns>
    Private Async Function HandleJSRedirect(http As HttpListener) As Task(Of Uri)

        Try

            Dim context = Await http.GetContextAsync()

            'We only care about request to TokenRedirectUri endpoint.
            While context.Request.Url.AbsolutePath <> EBayJSRedirectUri.AbsolutePath
                Console.WriteLine("context.Request.Url.AbsolutePath::JsRedirecet = " & context.Request.Url.AbsolutePath)
                context = Await http.GetContextAsync()
            End While

            Dim redirectUri = New Uri(context.Request.QueryString("code"))

            Return redirectUri

        Catch nrex As NullReferenceException
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Handle the redirect from JS And process raw redirect URI with fragment to
    ''' complete the authorization flow.
    ''' </summary>
    ''' <param name="http">The http listener.</param>
    ''' <returns>The <see cref="String"/></returns>
    Private Async Function RetreiveCodeFromResponse(http As HttpListener) As Task(Of Uri)

        Try

            Dim context = Await http.GetContextAsync()
            Debug.WriteLine("context.Request.Url.AbsolutePath:" & context.Request.Url.AbsolutePath)
            'We only care about request to TokenRedirectUri endpoint.
            'While context.Request.Url.AbsolutePath <> EBayRedirectUri.AbsolutePath
            While context.Request.Url.AbsolutePath <> EBayJSRedirectUri.AbsolutePath
                context = Await http.GetContextAsync()
            End While

            Dim redirectUri = New Uri(context.Request.Url.OriginalString)


            Return redirectUri

        Catch nrex As NullReferenceException
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Handles the redirect from EBay server. Because we are using token flow, the local
    ''' http server cannot directly receive the URL fragment. We need to return a HTML page with
    ''' inline JS which can send URL fragment to local server as URL parameter.
    ''' </summary>
    ''' <param name="http">The http listener.</param>
    ''' <returns>The <see cref="Task"/></returns>
    Private Async Function HandleOAuth2Redirect(http As HttpListener) As Task
        Try
            Debug.WriteLine("getting http context-strted")
            Dim context = Await http.GetContextAsync()
            Debug.WriteLine("getting http context -complete")

            ' We only care about request to RedirectUri endpoint.
            While context.Request.Url.AbsolutePath <> EBayRedirectUri.AbsolutePath
                Debug.WriteLine("getting http context-started2")
                Debug.WriteLine(context.Request.Url.AbsolutePath)

                context = Await http.GetContextAsync()
            End While
            Debug.WriteLine("getting http context -complete2")

            ' Respond with a page which runs JS And sends URL fragment as query string
            ' to TokenRedirectUri.
            context.Response.ContentType = "text/html"
            Using indexFile = File.OpenRead("redirect\\index.html")
                indexFile.CopyTo(context.Response.OutputStream)
            End Using
            context.Response.OutputStream.Close()

        Catch hlex As HttpListenerException
            Throw New Exception("HttpListenerException- Cancelled or timedout")
        Catch odex As ObjectDisposedException
            Throw New Exception("ObjectDisposedException -Cancelled or timedout")
        End Try
    End Function

    Private Async Function HandleTokenReceivedRedirect(http As HttpListener) As Task
        Dim context = Await http.GetContextAsync()

        ' We only care about request to RedirectUri endpoint.
        Console.WriteLine("context.Request.Url.AbsolutePath: " & context.Request.Url.AbsolutePath)
        While context.Request.Url.AbsolutePath <> EBayJSRedirectUri.AbsolutePath
            context = Await http.GetContextAsync()
        End While

        context.Response.ContentType = "text/html"

        ' Respond with a page which runs JS And sends URL fragment as query string
        ' to TokenRedirectUri.
        Using tokenFile = File.OpenRead("redirect\\token.html")
            tokenFile.CopyTo(context.Response.OutputStream)
        End Using

        context.Response.OutputStream.Close()
    End Function

    Private Function GetNewAccessTokenIfExpired() As Boolean
        'if access token is not expired then use the same token. do not get a new token.
        If Not config.IsAccessTokenExpired() Then Return False

        config.HasAquiredAccessToken = False

        Dim oauthEnvironment As OAuthEnvironment = GetEnvironment()

        Dim response = oauth.GetAccessToken(oauthEnvironment, config.RefreshToken, config.Scopes)
        If response.ErrorMessage IsNot Nothing Then
            Throw New Exception("Error while Refreshing Token:" & Environment.NewLine & response.ErrorMessage)
        End If

        config.AccessToken = response.AccessToken.Token
        config.AccessTokenType = response.AccessToken.TokenType
        config.AcesssTokenExpiresOn = response.AccessToken.ExpiresOn
        'config.RefreshToken = response.RefreshToken.Token
        'config.RefreshTokenType = response.RefreshToken.TokenType
        'config.RefreshTokenExpiresOn = response.RefreshToken.ExpiresOn
        config.HasAquiredAccessToken = True

        'update client in frontend by triggering AccessTokenRefreshed.
        Dim e = New EBayAccessTokenRefreshedEventArgs(config)
        OnAccessTokenRefreshed(e)
        Return True
    End Function



    Private Function LaunchBrowser(authorizeUri As Uri) As Process

        'detect browser
        Dim browserPath As String = DetectDefaultBrowser()

        Dim chromiumCLISwitches = " --app-auto-launched --new-window"
        Dim processArgs = authorizeUri.ToString() + chromiumCLISwitches

        Dim psi As ProcessStartInfo = New ProcessStartInfo With
            {
                .WindowStyle = ProcessWindowStyle.Normal,
                .FileName = browserPath,
                .Arguments = processArgs,
                .UseShellExecute = True
            }

        Return Process.Start(psi)
    End Function

    Private Function DetectDefaultBrowser() As String
        Dim browserPath As String = String.Empty

        Const defaultBrowserKeyPath As String = "SOFTWARE\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"

        Using defaultBrowserKey = Registry.CurrentUser.OpenSubKey(defaultBrowserKeyPath)
            Dim defaultBrowserId = defaultBrowserKey.GetValue("ProgId")

            Dim defaultBrowserExecutablePath = $"{defaultBrowserId}\shell\open\command"

            Using defaultBrowserExecutableKey = Registry.ClassesRoot.OpenSubKey(defaultBrowserExecutablePath)
                Dim defaultValueName = String.Empty ' //(Default) registry item
                Dim defaultBrowserExecutableKeyValue = defaultBrowserExecutableKey.GetValue(defaultValueName)
                Dim seperator = """"c                           '***REF: https://stackoverflow.com/questions/33544544/how-do-i-correctly-escape-the-double-quotation-mark-when-using-string-split
                Dim doubleQuotes = """"c
                browserPath = defaultBrowserExecutableKeyValue.ToString().Split(seperator)(1).Replace(doubleQuotes, String.Empty).Trim()
            End Using

            Return browserPath
        End Using

    End Function

    Private Sub StartHTTPListener()

        http = New HttpListener()
        http.Prefixes.Add(EBayLoopbackHost)
        http.Start()
    End Sub

    Private Sub StopHTTPListener(Optional abort As Boolean = False)
        If http IsNot Nothing Then

            Try

                If abort Then
                    http.Abort()
                Else

                    If (http.IsListening) Then
                        http.Stop()
                        http.Close()
                    End If

                    http.Prefixes?.Remove(EBayLoopbackHost)
                End If


            Catch odex As ObjectDisposedException
                Debug.WriteLine("http has already aborted!")
            End Try
            http = Nothing
        End If
    End Sub

    Private Sub StartTimer(intervalDuration As Double)
        processTimer = New System.Timers.Timer(intervalDuration)
        processTimer.AutoReset = False
        AddHandler processTimer.Elapsed, AddressOf ProcessTimer_Elapsed
        processTimer.Enabled = True
        processTimer.Start()
        Debug.WriteLine("Timer started ")
    End Sub

    Private Sub StopTimer()

        If processTimer Is Nothing Then Return
        If hasTimedOut Then Return

        hasTimedOut = False
        processTimer.Stop()
        processTimer.Enabled = False
        processTimer.Dispose()
        processTimer = Nothing

    End Sub

    Private Sub ProcessTimer_Elapsed(source As Object, e As ElapsedEventArgs)

        If authProcess Is Nothing Or http Is Nothing Then Return

        hasTimedOut = True

        StopHTTPListener(True)
        CloseAuthProcess()
        CloseBrowser()

        'notifiy ui of timeout
        OnAuthenticationTimedout()

        hasTimedOut = False


    End Sub

    Protected Overridable Sub OnAuthenticationTimedout()
        RaiseEvent AuthenticationTimedout(Me, EventArgs.Empty)

    End Sub

    Private Sub OnSignInCancelledEvent(e As EbayAuthenticationCancelledEventArgs)
        RaiseEvent AuthenticationCancelled(Me, e)

    End Sub

    Private Sub CloseAuthProcess()
        Try
            authProcess.Close()
            authProcess.Dispose()
            authProcess = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub CloseBrowser()



        For Each p In Process.GetProcesses()
            Debug.WriteLine("Main window handle = " + p.ProcessName + " - " + p.MainWindowTitle + " - " + p.MainWindowHandle.ToString() + "EBW: " + EBayLoginPageWindowHandle.ToString())
            If (p.MainWindowTitle.Contains("Loading...") _
                    Or p.MainWindowTitle.Contains("Authorizing HC Application") _
                    Or p.MainWindowTitle.Contains("auth.ebay.com") _
                    Or p.MainWindowTitle.Contains("Sign in or Register | eBay") _
                    Or p.MainWindowTitle.Contains(EBayRedirectUri.Host) _
                    Or p.MainWindowTitle.Contains("Service Unavailable")) _
                And p.MainWindowHandle <> IntPtr.Zero Then

                SetForegroundWindow(p.MainWindowHandle)
                WForms.SendKeys.SendWait("^{F4}")
                Exit For
            End If
        Next

    End Sub


    Private Sub AbortSignin()

        StopTimer()
        StopHTTPListener(True)

        hasTimedOut = False
        cancelAuthentication = False
    End Sub






#End Region
End Class

Public Class EbayAuthenticationCancelledEventArgs
    Inherits EventArgs

    Public Sub New(message As String)
        message = message
    End Sub

    Public Property Message As String
End Class

Public Class EBayAccessTokenRefreshedEventArgs
    Inherits EventArgs

    Public Sub New(ebayConfig As EBayConfig)
        Config = ebayConfig
    End Sub
    Public Property Config As EBayConfig
End Class