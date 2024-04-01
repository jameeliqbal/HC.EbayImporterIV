
Public Class AuthenticatedEventArgs
    Inherits EventArgs

    Public Sub New(ebayconfig As EBayAuthenticationOptions)
        Config = ebayconfig
    End Sub

    Public Property Config As EBayAuthenticationOptions
End Class
Public Class AuthenticationCancelledEventArgs
    Inherits EventArgs

    Public Sub New(message As String)
        Me.Message = message
    End Sub
    Public Property Message As String

End Class

Public Class AccessTokenRefreshedEventArgs
    Inherits EventArgs

    Public Sub New(ebayConfig As EBayAuthenticationOptions)
        Config = ebayConfig
    End Sub
    Public Property Config As EBayAuthenticationOptions
End Class