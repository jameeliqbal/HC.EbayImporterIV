<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchOrders = New System.Windows.Forms.Button()
        Me.chkIncludeTaxBreakdown = New System.Windows.Forms.CheckBox()
        Me.txtOrdersToSkip = New System.Windows.Forms.TextBox()
        Me.txtOrdersPerPage = New System.Windows.Forms.TextBox()
        Me.cmbOrderFulfillmentStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optOrderSearchPeriodBetween = New System.Windows.Forms.RadioButton()
        Me.optOrderSearchPeriodOnOrAfter = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOrderSearchPeriodOnFrom = New System.Windows.Forms.Label()
        Me.optOrderSearchPeriodTo = New System.Windows.Forms.DateTimePicker()
        Me.optOrderSearchPeriodOnFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optOrderSearchByModifiedDate = New System.Windows.Forms.RadioButton()
        Me.optOrderSearchByCreationDate = New System.Windows.Forms.RadioButton()
        Me.txtLog = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtLog)
        Me.SplitContainer1.Size = New System.Drawing.Size(943, 815)
        Me.SplitContainer1.SplitterDistance = 314
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchOrders)
        Me.GroupBox1.Controls.Add(Me.chkIncludeTaxBreakdown)
        Me.GroupBox1.Controls.Add(Me.txtOrdersToSkip)
        Me.GroupBox1.Controls.Add(Me.txtOrdersPerPage)
        Me.GroupBox1.Controls.Add(Me.cmbOrderFulfillmentStatus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 605)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orders Search"
        '
        'btnSearchOrders
        '
        Me.btnSearchOrders.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSearchOrders.Location = New System.Drawing.Point(3, 535)
        Me.btnSearchOrders.Name = "btnSearchOrders"
        Me.btnSearchOrders.Size = New System.Drawing.Size(308, 67)
        Me.btnSearchOrders.TabIndex = 1
        Me.btnSearchOrders.Text = "Search Orders"
        Me.btnSearchOrders.UseVisualStyleBackColor = True
        '
        'chkIncludeTaxBreakdown
        '
        Me.chkIncludeTaxBreakdown.AutoSize = True
        Me.chkIncludeTaxBreakdown.Location = New System.Drawing.Point(13, 470)
        Me.chkIncludeTaxBreakdown.Name = "chkIncludeTaxBreakdown"
        Me.chkIncludeTaxBreakdown.Size = New System.Drawing.Size(139, 17)
        Me.chkIncludeTaxBreakdown.TabIndex = 8
        Me.chkIncludeTaxBreakdown.Text = "Include Tax Breakdown"
        Me.chkIncludeTaxBreakdown.UseVisualStyleBackColor = True
        '
        'txtOrdersToSkip
        '
        Me.txtOrdersToSkip.Location = New System.Drawing.Point(12, 438)
        Me.txtOrdersToSkip.Name = "txtOrdersToSkip"
        Me.txtOrdersToSkip.Size = New System.Drawing.Size(84, 20)
        Me.txtOrdersToSkip.TabIndex = 7
        Me.txtOrdersToSkip.Text = "0"
        '
        'txtOrdersPerPage
        '
        Me.txtOrdersPerPage.Location = New System.Drawing.Point(9, 389)
        Me.txtOrdersPerPage.Name = "txtOrdersPerPage"
        Me.txtOrdersPerPage.Size = New System.Drawing.Size(84, 20)
        Me.txtOrdersPerPage.TabIndex = 7
        Me.txtOrdersPerPage.Text = "10"
        '
        'cmbOrderFulfillmentStatus
        '
        Me.cmbOrderFulfillmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrderFulfillmentStatus.FormattingEnabled = True
        Me.cmbOrderFulfillmentStatus.Items.AddRange(New Object() {"{NOT_STARTED|IN_PROGRESS}", "{FULFILLED|IN_PROGRESS}"})
        Me.cmbOrderFulfillmentStatus.Location = New System.Drawing.Point(7, 338)
        Me.cmbOrderFulfillmentStatus.Name = "cmbOrderFulfillmentStatus"
        Me.cmbOrderFulfillmentStatus.Size = New System.Drawing.Size(301, 21)
        Me.cmbOrderFulfillmentStatus.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Number of Orders To skip (From the begining)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optOrderSearchPeriodBetween)
        Me.GroupBox3.Controls.Add(Me.optOrderSearchPeriodOnOrAfter)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblOrderSearchPeriodOnFrom)
        Me.GroupBox3.Controls.Add(Me.optOrderSearchPeriodTo)
        Me.GroupBox3.Controls.Add(Me.optOrderSearchPeriodOnFrom)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 205)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Period"
        '
        'optOrderSearchPeriodBetween
        '
        Me.optOrderSearchPeriodBetween.AutoSize = True
        Me.optOrderSearchPeriodBetween.Location = New System.Drawing.Point(23, 55)
        Me.optOrderSearchPeriodBetween.Name = "optOrderSearchPeriodBetween"
        Me.optOrderSearchPeriodBetween.Size = New System.Drawing.Size(67, 17)
        Me.optOrderSearchPeriodBetween.TabIndex = 9
        Me.optOrderSearchPeriodBetween.Text = "Between"
        Me.optOrderSearchPeriodBetween.UseVisualStyleBackColor = True
        '
        'optOrderSearchPeriodOnOrAfter
        '
        Me.optOrderSearchPeriodOnOrAfter.AutoSize = True
        Me.optOrderSearchPeriodOnOrAfter.Location = New System.Drawing.Point(23, 24)
        Me.optOrderSearchPeriodOnOrAfter.Name = "optOrderSearchPeriodOnOrAfter"
        Me.optOrderSearchPeriodOnOrAfter.Size = New System.Drawing.Size(83, 17)
        Me.optOrderSearchPeriodOnOrAfter.TabIndex = 8
        Me.optOrderSearchPeriodOnOrAfter.Text = "On OR After"
        Me.optOrderSearchPeriodOnOrAfter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To"
        '
        'lblOrderSearchPeriodOnFrom
        '
        Me.lblOrderSearchPeriodOnFrom.AutoSize = True
        Me.lblOrderSearchPeriodOnFrom.Location = New System.Drawing.Point(23, 93)
        Me.lblOrderSearchPeriodOnFrom.Name = "lblOrderSearchPeriodOnFrom"
        Me.lblOrderSearchPeriodOnFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblOrderSearchPeriodOnFrom.TabIndex = 7
        Me.lblOrderSearchPeriodOnFrom.Text = "From"
        '
        'optOrderSearchPeriodTo
        '
        Me.optOrderSearchPeriodTo.Location = New System.Drawing.Point(23, 157)
        Me.optOrderSearchPeriodTo.Name = "optOrderSearchPeriodTo"
        Me.optOrderSearchPeriodTo.Size = New System.Drawing.Size(200, 20)
        Me.optOrderSearchPeriodTo.TabIndex = 4
        '
        'optOrderSearchPeriodOnFrom
        '
        Me.optOrderSearchPeriodOnFrom.Location = New System.Drawing.Point(23, 109)
        Me.optOrderSearchPeriodOnFrom.Name = "optOrderSearchPeriodOnFrom"
        Me.optOrderSearchPeriodOnFrom.Size = New System.Drawing.Size(200, 20)
        Me.optOrderSearchPeriodOnFrom.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Orders Per Page"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Order Fulfillment Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optOrderSearchByModifiedDate)
        Me.GroupBox2.Controls.Add(Me.optOrderSearchByCreationDate)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 85)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "By"
        '
        'optOrderSearchByModifiedDate
        '
        Me.optOrderSearchByModifiedDate.AutoSize = True
        Me.optOrderSearchByModifiedDate.Location = New System.Drawing.Point(23, 46)
        Me.optOrderSearchByModifiedDate.Name = "optOrderSearchByModifiedDate"
        Me.optOrderSearchByModifiedDate.Size = New System.Drawing.Size(91, 17)
        Me.optOrderSearchByModifiedDate.TabIndex = 3
        Me.optOrderSearchByModifiedDate.Text = "Modified Date"
        Me.optOrderSearchByModifiedDate.UseVisualStyleBackColor = True
        '
        'optOrderSearchByCreationDate
        '
        Me.optOrderSearchByCreationDate.AutoSize = True
        Me.optOrderSearchByCreationDate.Location = New System.Drawing.Point(23, 23)
        Me.optOrderSearchByCreationDate.Name = "optOrderSearchByCreationDate"
        Me.optOrderSearchByCreationDate.Size = New System.Drawing.Size(90, 17)
        Me.optOrderSearchByCreationDate.TabIndex = 2
        Me.optOrderSearchByCreationDate.Text = "Creation Date"
        Me.optOrderSearchByCreationDate.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(0, 0)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(625, 815)
        Me.txtLog.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 815)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "EBay OAS3v1 API: Orders Search Demo"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optOrderSearchByModifiedDate As RadioButton
    Friend WithEvents optOrderSearchByCreationDate As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbOrderFulfillmentStatus As ComboBox
    Friend WithEvents optOrderSearchPeriodBetween As RadioButton
    Friend WithEvents optOrderSearchPeriodOnOrAfter As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOrderSearchPeriodOnFrom As Label
    Friend WithEvents optOrderSearchPeriodTo As DateTimePicker
    Friend WithEvents optOrderSearchPeriodOnFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOrdersPerPage As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkIncludeTaxBreakdown As CheckBox
    Friend WithEvents txtOrdersToSkip As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSearchOrders As Button
    Friend WithEvents txtLog As TextBox
End Class
