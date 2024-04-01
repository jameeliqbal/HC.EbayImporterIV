Imports eBay.OAS3v1IV.Client
Imports eBay.ApiClient.Auth.OAuth2
Imports System.IO
Imports eBay.ApiClient.Auth.OAuth2.Model
Imports HC.EBayImporter.Core

Public Class MainForm
    Dim ebayOptions As EBayAuthenticationOptions
    Dim WithEvents eBayImporter As EBayImporterClient

    Dim config As Configuration
    Dim oauth As OAuth2Api
    Dim IsFormLoading As Boolean

    Private Const EBayBaseAPIPathSandbox As String = "https://api.sandbox.ebay.com/sell/fulfillment/v1" '" 

#Region "MainForm Events"
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsFormLoading = True

        WindowState = FormWindowState.Maximized
        cmbURL.SelectedIndex = 0
        txtEBayConfigFile.Text = "C:\Users\Jameel\Source\Repos\HC.EbayImporterIV\src\HC.EBayImporter.Demo\ebay-config.yaml"

        InitializeEBayOptions()
        SetAuthenticationControlsState()
        IsFormLoading = False
        Return

        CredentialUtil.Load(New StreamReader("C:\Users\Jameel\Source\Repos\HC.EbayImporterIV\src\HC.EBayImporter.Demo\ebay-config.yaml"))
        oauth = New OAuth2Api()
        Dim scopes = New List(Of String)
        For Each scope In txtScopes.Lines
            scopes.Add(System.Web.HttpUtility.UrlEncode(scope.Trim()))
        Next

        'scopes.Add(System.Web.HttpUtility.UrlEncode(""))
        'Dim response = oauth.GetApplicationToken(OAuthEnvironment.SANDBOX, scopes)
        Dim code = oauth.GenerateUserAuthorizationUrl(OAuthEnvironment.SANDBOX, scopes, "xys")
        Dim response = oauth.ExchangeCodeForAccessToken(OAuthEnvironment.SANDBOX, code)

        If Not response.ErrorMessage Is Nothing Then
            MessageBox.Show(response.ErrorMessage)
            Return
        End If

        config = New Configuration With {
            .AccessToken = response.AccessToken.Token(),'"v^1.1#i^1#f^0#I^3#r^0#p^3#t^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",
             .BasePath = EBayBaseAPIPathSandbox
        }




    End Sub

    Private Sub cmbURL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbURL.SelectedIndexChanged
        'config.BasePath = cmbURL.SelectedItem.ToString()
        If IsFormLoading Then Return

    End Sub

    Private Sub txtAccessToken_TextChanged(sender As Object, e As EventArgs)
        'config.AccessToken = txtAccessToken.Text.Trim()
        If IsFormLoading Then Return

    End Sub

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Cursor.Current = Cursors.WaitCursor
            InitializeEBayOptions()
            btnCancelSignIn.Visible = False
            btnLogin.Enabled = False
            btnlogout.Enabled = False

            eBayImporter = New EBayImporterClient(ebayOptions)
            Await eBayImporter.Login()

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Dim errorMessage = "Error while logging in:" & Environment.NewLine & Environment.NewLine
            errorMessage &= "HRESULT = 0x" & ex.HResult & " " & ex.Message & Environment.NewLine & ex.InnerException?.Message
            MessageBox.Show(errorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            logSyncInfo(errorMessage)
            btnLogin.Enabled = True
        End Try
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Try
            btnlogout.Enabled = False
            'reset values
            ResetEBayOptions()

            'save eBayOptions
            SaveEbayOptions()

            txtLog.Clear()
            SetAuthenticationControlsState()

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Dim errorMessage = "Error while logging out:" & Environment.NewLine & Environment.NewLine
            errorMessage &= "HRESULT = 0x" & ex.HResult & " " & ex.Message & Environment.NewLine & ex.InnerException?.Message
            MessageBox.Show(errorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            logSyncInfo(errorMessage)
            btnlogout.Enabled = True
        End Try
    End Sub


    Private Sub txtEBayConfigFile_TextChanged(sender As Object, e As EventArgs) Handles txtEBayConfigFile.TextChanged
        If IsFormLoading Then Return
        ebayOptions.CredentialPath = txtEBayConfigFile.Text.Trim()
    End Sub

    Private Sub GetOrdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetOrdToolStripMenuItem.Click
        Dim orderForm = New Form1
        eBayImporter = New EBayImporterClient(ebayOptions)
        orderForm.EbayImporter = eBayImporter
        ShowThisForm(orderForm)
    End Sub

#End Region

#Region "Local Methods"
    Private Sub InitializeEBayOptions()
        ebayOptions = New EBayAuthenticationOptions()
        ebayOptions.HasAquiredAccessToken = My.Settings.HasAquiredAccessToken
        If (ebayOptions.HasAquiredAccessToken) Then
            ebayOptions.AccessToken = My.Settings.AccessToken
            ebayOptions.AccessTokenType = My.Settings.AccessTokenType
            ebayOptions.AccessTokenExpiresOn = My.Settings.AccessTokenExpiresOn
            ebayOptions.RefreshToken = My.Settings.RefreshToken
            ebayOptions.RefreshTokenType = My.Settings.RefreshTokenType
            ebayOptions.RefreshTokenExpiresOn = My.Settings.RefreshTokenExpiresOn
            logSyncInfo("Logged in Using existing Access Token" & vbNewLine & vbTab & "Token Expires on " & ebayOptions.AccessTokenExpiresOn.ToString())

        End If

        ebayOptions.CredentialPath = txtEBayConfigFile.Text.Trim()
        ebayOptions.Scopes = GetLatestScopes()
        ebayOptions.BasePath = cmbURL.SelectedItem.ToString().Trim()
    End Sub

    Private Function GetLatestScopes() As IList(Of String)
        Dim scopes = New List(Of String)
        For Each scope In txtScopes.Lines
            scopes.Add(System.Web.HttpUtility.UrlEncode(scope.Trim()))
        Next
        Return scopes
    End Function


    Private Sub SetAuthenticationControlsState()

        If ebayOptions.HasAquiredAccessToken Then
            btnLogin.Enabled = False
            btnlogout.Enabled = True
            'logSyncInfo("dropboxAccount.Email")
            'logSyncInfo("dropboxAccount.Name")
        Else
            btnLogin.Enabled = True
            btnlogout.Enabled = False

            logSyncInfo("Not logged in")
            logSyncInfo("Click Login button to connect to eBay")
        End If

        btnCancelSignIn.Visible = False
    End Sub

    Private Sub logSyncInfo(text As String)
        If InvokeRequired Then

            Me.Invoke(Sub() logSyncInfo(text))
            Return
        End If

        txtLog.AppendText($"[{DateTime.Now}] {text}{Environment.NewLine}")
    End Sub

    Private Sub SaveEbayOptions()
        My.Settings.AccessToken = ebayOptions.AccessToken
        My.Settings.AccessTokenType = ebayOptions.AccessTokenType
        My.Settings.AccessTokenExpiresOn = ebayOptions.AccessTokenExpiresOn
        My.Settings.RefreshToken = ebayOptions.RefreshToken
        My.Settings.RefreshTokenType = ebayOptions.RefreshTokenType
        My.Settings.RefreshTokenExpiresOn = ebayOptions.RefreshTokenExpiresOn
        My.Settings.HasAquiredAccessToken = ebayOptions.HasAquiredAccessToken
        My.Settings.Save()
    End Sub

    Private Sub ResetEBayOptions()
        ebayOptions.AccessToken = Nothing
        ebayOptions.AccessTokenType = Nothing
        ebayOptions.AccessTokenExpiresOn = Nothing
        ebayOptions.RefreshToken = Nothing
        ebayOptions.RefreshTokenType = Nothing
        ebayOptions.AccessTokenExpiresOn = Nothing
        ebayOptions.HasAquiredAccessToken = False
    End Sub

    Private Sub ShowThisForm(formToShow As Form)
        formToShow.MdiParent = Me
        formToShow.WindowState = FormWindowState.Maximized
        formToShow.Show()

    End Sub



#End Region



#Region "EBayImporter Events"
    Private Async Sub EBayImporter_Authenticated(sender As Object, e As AuthenticatedEventArgs) Handles eBayImporter.Authenticated
        ebayOptions.AccessToken = e.Config.AccessToken
        ebayOptions.AccessTokenType = e.Config.AccessTokenType
        ebayOptions.AccessTokenExpiresOn = e.Config.AccessTokenExpiresOn
        ebayOptions.RefreshToken = e.Config.RefreshToken
        ebayOptions.RefreshTokenType = e.Config.RefreshTokenType
        ebayOptions.RefreshTokenExpiresOn = e.Config.RefreshTokenExpiresOn
        ebayOptions.HasAquiredAccessToken = e.Config.HasAquiredAccessToken

        'Save ebayOptions to settings
        SaveEbayOptions()

        'get current user info
        'to do

        Invoke(Sub()
                   Dim message = "Authentication Completed!  Access Token Acquired" & vbNewLine & vbTab & "Token Expires on " & ebayOptions.AccessTokenExpiresOn.ToString()
                   logSyncInfo(message)
                   SetAuthenticationControlsState()
                   Activate()
                   MessageBox.Show(message, "USER AUTHENTICATED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End Sub)

    End Sub



    Private Async Sub EBayImporter_AuthenticationTimedOut(sender As Object, e As EventArgs) Handles eBayImporter.AuthenticationTimedout

        Invoke(Sub()
                   logSyncInfo("Authentication Timed out!")
                   SetAuthenticationControlsState()
               End Sub)

    End Sub



    Private Sub eBayImporter_AuthenticationCancelled(sender As Object, e As AuthenticationCancelledEventArgs) Handles eBayImporter.AuthenticationCancelled
        Cursor = Cursors.Default
        Invoke(Sub()
                   Dim Message = "Authentication Cancelled! - " & e.Message
                   logSyncInfo(Message)
                   SetAuthenticationControlsState()
               End Sub
             )
    End Sub



    Private Sub EBayImporter_AccessTokenRefreshed(sender As Object, e As AccessTokenRefreshedEventArgs) Handles eBayImporter.AccessTokenRefreshed
        ebayOptions.AccessToken = e.Config.AccessToken
        ebayOptions.AccessTokenType = e.Config.AccessTokenType
        ebayOptions.AccessTokenExpiresOn = e.Config.AccessTokenExpiresOn
        'ebayOptions.RefreshToken = e.Config.RefreshToken
        'ebayOptions.RefreshTokenType = e.Config.RefreshTokenType
        'ebayOptions.RefreshTokenExpiresOn = e.Config.RefreshTokenExpiresOn
        ebayOptions.HasAquiredAccessToken = e.Config.HasAquiredAccessToken
        logSyncInfo("Access Token Refreshed" & vbNewLine & vbTab & "Token Expires on " & ebayOptions.AccessTokenExpiresOn.ToString())
        SaveEbayOptions()

    End Sub

#End Region


End Class