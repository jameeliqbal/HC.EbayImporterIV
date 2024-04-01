Public Class EBayConfig
    Property CredentialPath As String
    Property BasePath As String
    Property Scopes As IList(Of String)
    Property AccessToken As String
    Property AccessTokenType As String
    Property AcesssTokenExpiresOn As Date
    Property RefreshToken As String
    Property RefreshTokenType As String
    Property RefreshTokenExpiresOn As Date
    Property HasAquiredAccessToken As Boolean
    Public ReadOnly Property IsAccessTokenExpired() As Boolean
        Get
            Return Date.Now > AcesssTokenExpiresOn
        End Get
    End Property
    Public ReadOnly Property IsRefreshTokenExpired() As Boolean
        Get
            Return Date.Now > RefreshTokenExpiresOn
        End Get
    End Property

End Class
