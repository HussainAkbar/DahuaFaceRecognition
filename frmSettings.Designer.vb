<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeviceIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDevicePort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDeviceUserId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDevicePassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbChannel8 = New System.Windows.Forms.CheckBox()
        Me.cbChannel7 = New System.Windows.Forms.CheckBox()
        Me.cbChannel6 = New System.Windows.Forms.CheckBox()
        Me.cbChannel5 = New System.Windows.Forms.CheckBox()
        Me.cbChannel4 = New System.Windows.Forms.CheckBox()
        Me.cbChannel3 = New System.Windows.Forms.CheckBox()
        Me.cbChannel2 = New System.Windows.Forms.CheckBox()
        Me.cbChannel1 = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.92701!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.07299!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDeviceIP, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDevicePort, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDeviceUserId, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDevicePassword, 1, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(274, 124)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Device &IP:"
        '
        'txtDeviceIP
        '
        Me.txtDeviceIP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDeviceIP.Location = New System.Drawing.Point(85, 5)
        Me.txtDeviceIP.MaxLength = 64
        Me.txtDeviceIP.Name = "txtDeviceIP"
        Me.txtDeviceIP.Size = New System.Drawing.Size(177, 20)
        Me.txtDeviceIP.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "P&ort:"
        '
        'txtDevicePort
        '
        Me.txtDevicePort.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDevicePort.Location = New System.Drawing.Point(85, 35)
        Me.txtDevicePort.MaxLength = 5
        Me.txtDevicePort.Name = "txtDevicePort"
        Me.txtDevicePort.Size = New System.Drawing.Size(59, 20)
        Me.txtDevicePort.TabIndex = 3
        Me.txtDevicePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&User Id:"
        '
        'txtDeviceUserId
        '
        Me.txtDeviceUserId.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDeviceUserId.Location = New System.Drawing.Point(85, 65)
        Me.txtDeviceUserId.MaxLength = 64
        Me.txtDeviceUserId.Name = "txtDeviceUserId"
        Me.txtDeviceUserId.Size = New System.Drawing.Size(177, 20)
        Me.txtDeviceUserId.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Password:"
        '
        'txtDevicePassword
        '
        Me.txtDevicePassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDevicePassword.Location = New System.Drawing.Point(85, 97)
        Me.txtDevicePassword.MaxLength = 64
        Me.txtDevicePassword.Name = "txtDevicePassword"
        Me.txtDevicePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDevicePassword.Size = New System.Drawing.Size(177, 20)
        Me.txtDevicePassword.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbChannel8)
        Me.GroupBox1.Controls.Add(Me.cbChannel7)
        Me.GroupBox1.Controls.Add(Me.cbChannel6)
        Me.GroupBox1.Controls.Add(Me.cbChannel5)
        Me.GroupBox1.Controls.Add(Me.cbChannel4)
        Me.GroupBox1.Controls.Add(Me.cbChannel3)
        Me.GroupBox1.Controls.Add(Me.cbChannel2)
        Me.GroupBox1.Controls.Add(Me.cbChannel1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monitoring Channels"
        '
        'cbChannel8
        '
        Me.cbChannel8.AutoSize = True
        Me.cbChannel8.Location = New System.Drawing.Point(250, 58)
        Me.cbChannel8.Name = "cbChannel8"
        Me.cbChannel8.Size = New System.Drawing.Size(74, 17)
        Me.cbChannel8.TabIndex = 7
        Me.cbChannel8.Text = "Channel 8"
        Me.cbChannel8.UseVisualStyleBackColor = True
        '
        'cbChannel7
        '
        Me.cbChannel7.AutoSize = True
        Me.cbChannel7.Location = New System.Drawing.Point(169, 58)
        Me.cbChannel7.Name = "cbChannel7"
        Me.cbChannel7.Size = New System.Drawing.Size(74, 17)
        Me.cbChannel7.TabIndex = 6
        Me.cbChannel7.Text = "Channel 7"
        Me.cbChannel7.UseVisualStyleBackColor = True
        '
        'cbChannel6
        '
        Me.cbChannel6.AutoSize = True
        Me.cbChannel6.Location = New System.Drawing.Point(88, 58)
        Me.cbChannel6.Name = "cbChannel6"
        Me.cbChannel6.Size = New System.Drawing.Size(74, 17)
        Me.cbChannel6.TabIndex = 5
        Me.cbChannel6.Text = "Channel 6"
        Me.cbChannel6.UseVisualStyleBackColor = True
        '
        'cbChannel5
        '
        Me.cbChannel5.AutoSize = True
        Me.cbChannel5.Location = New System.Drawing.Point(7, 58)
        Me.cbChannel5.Name = "cbChannel5"
        Me.cbChannel5.Size = New System.Drawing.Size(74, 17)
        Me.cbChannel5.TabIndex = 4
        Me.cbChannel5.Text = "Channel 5"
        Me.cbChannel5.UseVisualStyleBackColor = True
        '
        'cbChannel4
        '
        Me.cbChannel4.AutoSize = True
        Me.cbChannel4.Location = New System.Drawing.Point(250, 28)
        Me.cbChannel4.Name = "cbChannel4"
        Me.cbChannel4.Size = New System.Drawing.Size(74, 17)
        Me.cbChannel4.TabIndex = 3
        Me.cbChannel4.Text = "Channel 4"
        Me.cbChannel4.UseVisualStyleBackColor = True
        '
        'cbChannel3
        '
        Me.cbChannel3.AutoSize = True
        Me.cbChannel3.Location = New System.Drawing.Point(169, 28)
        Me.cbChannel3.Name = "cbChannel3"
        Me.cbChannel3.Size = New System.Drawing.Size(74, 17)
        Me.cbChannel3.TabIndex = 2
        Me.cbChannel3.Text = "Channel 3"
        Me.cbChannel3.UseVisualStyleBackColor = True
        '
        'cbChannel2
        '
        Me.cbChannel2.AutoSize = True
        Me.cbChannel2.Location = New System.Drawing.Point(88, 28)
        Me.cbChannel2.Name = "cbChannel2"
        Me.cbChannel2.Size = New System.Drawing.Size(74, 17)
        Me.cbChannel2.TabIndex = 1
        Me.cbChannel2.Text = "Channel 2"
        Me.cbChannel2.UseVisualStyleBackColor = True
        '
        'cbChannel1
        '
        Me.cbChannel1.AutoSize = True
        Me.cbChannel1.Location = New System.Drawing.Point(7, 28)
        Me.cbChannel1.Name = "cbChannel1"
        Me.cbChannel1.Size = New System.Drawing.Size(74, 17)
        Me.cbChannel1.TabIndex = 0
        Me.cbChannel1.Text = "Channel 1"
        Me.cbChannel1.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeviceIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDevicePort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDeviceUserId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDevicePassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbChannel8 As CheckBox
    Friend WithEvents cbChannel7 As CheckBox
    Friend WithEvents cbChannel6 As CheckBox
    Friend WithEvents cbChannel5 As CheckBox
    Friend WithEvents cbChannel4 As CheckBox
    Friend WithEvents cbChannel3 As CheckBox
    Friend WithEvents cbChannel2 As CheckBox
    Friend WithEvents cbChannel1 As CheckBox
End Class
