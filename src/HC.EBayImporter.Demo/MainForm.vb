Imports EBay.OAS3v1IV.Client

Public Class MainForm
    Dim config As Configuration
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized

        config = New Configuration()
        Dim form = New Form1
        form.Config = config
        form.MdiParent = Me
        form.WindowState = FormWindowState.Maximized
        form.Show()

        cmbURL.SelectedIndex = 0


    End Sub

    Private Sub cmbURL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbURL.SelectedIndexChanged
        config.BasePath = cmbURL.SelectedItem.ToString()
    End Sub

    Private Sub txtAccessToken_TextChanged(sender As Object, e As EventArgs) Handles txtAccessToken.TextChanged
        config.AccessToken = txtAccessToken.Text.Trim()
    End Sub
End Class