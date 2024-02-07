<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.tsStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsSDK = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFileStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFileStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbChannel8 = New System.Windows.Forms.PictureBox()
        Me.pbChannel7 = New System.Windows.Forms.PictureBox()
        Me.pbChannel6 = New System.Windows.Forms.PictureBox()
        Me.pbChannel5 = New System.Windows.Forms.PictureBox()
        Me.pbChannel4 = New System.Windows.Forms.PictureBox()
        Me.pbChannel3 = New System.Windows.Forms.PictureBox()
        Me.pbChannel2 = New System.Windows.Forms.PictureBox()
        Me.pbChannel1 = New System.Windows.Forms.PictureBox()
        Me.pbAlarmPicture = New System.Windows.Forms.PictureBox()
        Me.lblAlarmCaption = New System.Windows.Forms.Label()
        Me.pbFacePicture = New System.Windows.Forms.PictureBox()
        Me.ssMain.SuspendLayout()
        Me.msMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbChannel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChannel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChannel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChannel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChannel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChannel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChannel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChannel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAlarmPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFacePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssMain
        '
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatus, Me.tsSDK, Me.tsConnection})
        Me.ssMain.Location = New System.Drawing.Point(0, 573)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(1089, 22)
        Me.ssMain.TabIndex = 1
        Me.ssMain.Text = "StatusStrip1"
        '
        'tsStatus
        '
        Me.tsStatus.Name = "tsStatus"
        Me.tsStatus.Size = New System.Drawing.Size(824, 17)
        Me.tsStatus.Spring = True
        Me.tsStatus.Text = "Not connected"
        Me.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsSDK
        '
        Me.tsSDK.AutoSize = False
        Me.tsSDK.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsSDK.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsSDK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsSDK.Name = "tsSDK"
        Me.tsSDK.Size = New System.Drawing.Size(100, 17)
        Me.tsSDK.Text = "SDK"
        Me.tsSDK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsConnection
        '
        Me.tsConnection.AutoSize = False
        Me.tsConnection.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsConnection.Name = "tsConnection"
        Me.tsConnection.Size = New System.Drawing.Size(150, 17)
        Me.tsConnection.Text = "Not Ready"
        Me.tsConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1089, 24)
        Me.msMain.TabIndex = 2
        Me.msMain.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFileStart, Me.tsmiFileStop, Me.ToolStripSeparator1, Me.tsmiFileExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "&File"
        '
        'tsmiFileStart
        '
        Me.tsmiFileStart.Name = "tsmiFileStart"
        Me.tsmiFileStart.Size = New System.Drawing.Size(180, 22)
        Me.tsmiFileStart.Text = "&Start"
        '
        'tsmiFileStop
        '
        Me.tsmiFileStop.Enabled = False
        Me.tsmiFileStop.Name = "tsmiFileStop"
        Me.tsmiFileStop.Size = New System.Drawing.Size(180, 22)
        Me.tsmiFileStop.Text = "Sto&p"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'tsmiFileExit
        '
        Me.tsmiFileExit.Name = "tsmiFileExit"
        Me.tsmiFileExit.Size = New System.Drawing.Size(180, 22)
        Me.tsmiFileExit.Text = "E&xit"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEditSettings})
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsmiEdit.Text = "&Edit"
        '
        'tsmiEditSettings
        '
        Me.tsmiEditSettings.Name = "tsmiEditSettings"
        Me.tsmiEditSettings.Size = New System.Drawing.Size(180, 22)
        Me.tsmiEditSettings.Text = "&Settings..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbChannel8)
        Me.GroupBox1.Controls.Add(Me.pbChannel7)
        Me.GroupBox1.Controls.Add(Me.pbChannel6)
        Me.GroupBox1.Controls.Add(Me.pbChannel5)
        Me.GroupBox1.Controls.Add(Me.pbChannel4)
        Me.GroupBox1.Controls.Add(Me.pbChannel3)
        Me.GroupBox1.Controls.Add(Me.pbChannel2)
        Me.GroupBox1.Controls.Add(Me.pbChannel1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 531)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Channels"
        '
        'pbChannel8
        '
        Me.pbChannel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbChannel8.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbChannel8.Location = New System.Drawing.Point(251, 357)
        Me.pbChannel8.Name = "pbChannel8"
        Me.pbChannel8.Size = New System.Drawing.Size(234, 156)
        Me.pbChannel8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChannel8.TabIndex = 7
        Me.pbChannel8.TabStop = False
        '
        'pbChannel7
        '
        Me.pbChannel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbChannel7.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbChannel7.Location = New System.Drawing.Point(7, 357)
        Me.pbChannel7.Name = "pbChannel7"
        Me.pbChannel7.Size = New System.Drawing.Size(234, 156)
        Me.pbChannel7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChannel7.TabIndex = 6
        Me.pbChannel7.TabStop = False
        '
        'pbChannel6
        '
        Me.pbChannel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbChannel6.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbChannel6.Location = New System.Drawing.Point(496, 189)
        Me.pbChannel6.Name = "pbChannel6"
        Me.pbChannel6.Size = New System.Drawing.Size(234, 156)
        Me.pbChannel6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChannel6.TabIndex = 5
        Me.pbChannel6.TabStop = False
        '
        'pbChannel5
        '
        Me.pbChannel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbChannel5.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbChannel5.Location = New System.Drawing.Point(251, 189)
        Me.pbChannel5.Name = "pbChannel5"
        Me.pbChannel5.Size = New System.Drawing.Size(234, 156)
        Me.pbChannel5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChannel5.TabIndex = 4
        Me.pbChannel5.TabStop = False
        '
        'pbChannel4
        '
        Me.pbChannel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbChannel4.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbChannel4.Location = New System.Drawing.Point(7, 189)
        Me.pbChannel4.Name = "pbChannel4"
        Me.pbChannel4.Size = New System.Drawing.Size(234, 156)
        Me.pbChannel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChannel4.TabIndex = 3
        Me.pbChannel4.TabStop = False
        '
        'pbChannel3
        '
        Me.pbChannel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbChannel3.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbChannel3.Location = New System.Drawing.Point(496, 20)
        Me.pbChannel3.Name = "pbChannel3"
        Me.pbChannel3.Size = New System.Drawing.Size(234, 156)
        Me.pbChannel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChannel3.TabIndex = 2
        Me.pbChannel3.TabStop = False
        '
        'pbChannel2
        '
        Me.pbChannel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbChannel2.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbChannel2.Location = New System.Drawing.Point(251, 20)
        Me.pbChannel2.Name = "pbChannel2"
        Me.pbChannel2.Size = New System.Drawing.Size(234, 156)
        Me.pbChannel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChannel2.TabIndex = 1
        Me.pbChannel2.TabStop = False
        '
        'pbChannel1
        '
        Me.pbChannel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbChannel1.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbChannel1.Location = New System.Drawing.Point(7, 20)
        Me.pbChannel1.Name = "pbChannel1"
        Me.pbChannel1.Size = New System.Drawing.Size(234, 156)
        Me.pbChannel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChannel1.TabIndex = 0
        Me.pbChannel1.TabStop = False
        '
        'pbAlarmPicture
        '
        Me.pbAlarmPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAlarmPicture.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbAlarmPicture.Location = New System.Drawing.Point(778, 48)
        Me.pbAlarmPicture.Name = "pbAlarmPicture"
        Me.pbAlarmPicture.Size = New System.Drawing.Size(288, 192)
        Me.pbAlarmPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAlarmPicture.TabIndex = 8
        Me.pbAlarmPicture.TabStop = False
        '
        'lblAlarmCaption
        '
        Me.lblAlarmCaption.BackColor = System.Drawing.Color.PowderBlue
        Me.lblAlarmCaption.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmCaption.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblAlarmCaption.Location = New System.Drawing.Point(778, 243)
        Me.lblAlarmCaption.Name = "lblAlarmCaption"
        Me.lblAlarmCaption.Size = New System.Drawing.Size(288, 55)
        Me.lblAlarmCaption.TabIndex = 9
        Me.lblAlarmCaption.Text = "Idle"
        Me.lblAlarmCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbFacePicture
        '
        Me.pbFacePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFacePicture.InitialImage = Global.Facial_Recognition.My.Resources.Resources.tinylogo
        Me.pbFacePicture.Location = New System.Drawing.Point(778, 301)
        Me.pbFacePicture.Name = "pbFacePicture"
        Me.pbFacePicture.Size = New System.Drawing.Size(288, 192)
        Me.pbFacePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFacePicture.TabIndex = 10
        Me.pbFacePicture.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 595)
        Me.Controls.Add(Me.pbFacePicture)
        Me.Controls.Add(Me.lblAlarmCaption)
        Me.Controls.Add(Me.pbAlarmPicture)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMain
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(820, 500)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "FR Attendance Recording"
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbChannel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChannel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChannel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChannel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChannel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChannel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChannel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChannel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAlarmPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFacePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents tsStatus As ToolStripStatusLabel
    Friend WithEvents tsSDK As ToolStripStatusLabel
    Friend WithEvents tsConnection As ToolStripStatusLabel
    Friend WithEvents msMain As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiFileExit As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiEditSettings As ToolStripMenuItem
    Friend WithEvents tsmiFileStart As ToolStripMenuItem
    Friend WithEvents tsmiFileStop As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbChannel1 As PictureBox
    Friend WithEvents pbChannel2 As PictureBox
    Friend WithEvents pbChannel8 As PictureBox
    Friend WithEvents pbChannel7 As PictureBox
    Friend WithEvents pbChannel6 As PictureBox
    Friend WithEvents pbChannel5 As PictureBox
    Friend WithEvents pbChannel4 As PictureBox
    Friend WithEvents pbChannel3 As PictureBox
    Friend WithEvents pbAlarmPicture As PictureBox
    Friend WithEvents lblAlarmCaption As Label
    Friend WithEvents pbFacePicture As PictureBox
End Class
