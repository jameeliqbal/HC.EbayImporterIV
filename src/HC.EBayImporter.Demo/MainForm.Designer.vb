<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAccessToken = New System.Windows.Forms.TextBox()
        Me.cmbURL = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbURL)
        Me.GroupBox1.Controls.Add(Me.txtAccessToken)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 181)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "API Settings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Sandbox or Production URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Access Token"
        '
        'txtAccessToken
        '
        Me.txtAccessToken.Location = New System.Drawing.Point(12, 95)
        Me.txtAccessToken.Multiline = True
        Me.txtAccessToken.Name = "txtAccessToken"
        Me.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAccessToken.Size = New System.Drawing.Size(714, 75)
        Me.txtAccessToken.TabIndex = 1
        '
        'cmbURL
        '
        Me.cmbURL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbURL.FormattingEnabled = True
        Me.cmbURL.Items.AddRange(New Object() {"https://api.sandbox.ebay.com/sell/fulfillment/v1", "https://api.ebay.com/sell/fulfillment/v1"})
        Me.cmbURL.Location = New System.Drawing.Point(12, 46)
        Me.cmbURL.Name = "cmbURL"
        Me.cmbURL.Size = New System.Drawing.Size(714, 21)
        Me.cmbURL.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbURL As ComboBox
    Friend WithEvents txtAccessToken As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
