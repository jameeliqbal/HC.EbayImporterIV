Imports HC.EBayModule
Partial Public Class EBayImporterClient

    Private WithEvents ebayConnector As EBayConnector
    Private ReadOnly config As EBayConfig

    Public Event Authenticated As EventHandler
    Public Event AuthenticationTimedout As EventHandler
    Public Event AuthenticationCancelled As EventHandler(Of AuthenticationCancelledEventArgs)
    Public Event AccessTokenRefreshed As EventHandler(Of AccessTokenRefreshedEventArgs)
    Public Sub New(options As EBayAuthenticationOptions)
        Me.config = New EBayConfig()
        InitializeConfig(options)
        ebayConnector = New EBayConnector(config)
    End Sub

    Public Async Function Login() As Task
        Await ebayConnector.Login()
    End Function


    Private Sub InitializeConfig(options As EBayAuthenticationOptions)
        Me.config.CredentialPath = options.CredentialPath
        Me.config.Scopes = options.Scopes
        Me.config.BasePath = options.BasePath
        Me.config.AccessToken = options.AccessToken
        Me.config.AccessTokenType = options.AccessTokenType
        Me.config.AcesssTokenExpiresOn = options.AccessTokenExpiresOn
        Me.config.HasAquiredAccessToken = options.HasAquiredAccessToken
        Me.config.RefreshToken = options.RefreshToken
        Me.config.RefreshTokenType = options.RefreshTokenType
        Me.config.RefreshTokenExpiresOn = options.RefreshTokenExpiresOn
    End Sub


#Region "Handle Events"

    Private Sub ebayConnector_Authenticated(sender As Object, e As EventArgs) Handles ebayConnector.Authenticated
        Dim ebayoptions = New EBayAuthenticationOptions With {
            .AccessToken = config.AccessToken,
            .AccessTokenType = config.AccessTokenType,
            .AccessTokenExpiresOn = config.AcesssTokenExpiresOn,
            .RefreshToken = config.RefreshToken,
            .RefreshTokenExpiresOn = config.RefreshTokenExpiresOn,
            .RefreshTokenType = config.RefreshTokenType,
            .HasAquiredAccessToken = config.HasAquiredAccessToken
        }

        Dim authenticatedEventArgs = New AuthenticatedEventArgs(ebayoptions)

        OnAuthenticatedEvent(authenticatedEventArgs)
    End Sub


    Private Sub ebayConnector_AuthenticationTimedout(sender As Object, e As EventArgs) Handles ebayConnector.AuthenticationTimedout
        OnAuthenticationTimedoutEvent(e)
    End Sub

    Private Sub ebayConnector_AuthenticationCancelled(sender As Object, e As EbayAuthenticationCancelledEventArgs) Handles ebayConnector.AuthenticationCancelled
        Dim authenticationCancelledEventArgs = New AuthenticationCancelledEventArgs(e.Message)
        OnAuthenticationCancelledEvent(authenticationCancelledEventArgs)
    End Sub

    Private Sub ebayConnector_AccessTokenRefreshed(sender As Object, e As EBayAccessTokenRefreshedEventArgs) Handles ebayConnector.AccessTokenRefreshed
        Dim options = New EBayAuthenticationOptions With {
            .HasAquiredAccessToken = e.Config.HasAquiredAccessToken,
            .AccessToken = e.Config.AccessToken,
            .AccessTokenType = e.Config.AccessTokenType,
            .AccessTokenExpiresOn = e.Config.AcesssTokenExpiresOn
        }
        Dim accessTokenRefreshedEventArgs = New AccessTokenRefreshedEventArgs(options)
        OnAccessTokenRefreshed(accessTokenRefreshedEventArgs)
    End Sub



#End Region

#Region "Raise Events"
    Private Sub OnAuthenticatedEvent(e As AuthenticatedEventArgs)
        RaiseEvent Authenticated(Me, e)
    End Sub

    Private Sub OnAuthenticationCancelledEvent(e As AuthenticationCancelledEventArgs)
        RaiseEvent AuthenticationCancelled(Me, e)
    End Sub

    Private Sub OnAuthenticationTimedoutEvent(e As EventArgs)
        RaiseEvent AuthenticationTimedout(Me, e)
    End Sub

    Private Sub OnAccessTokenRefreshed(e As AccessTokenRefreshedEventArgs)
        RaiseEvent AccessTokenRefreshed(Me, e)
    End Sub

#End Region

End Class
