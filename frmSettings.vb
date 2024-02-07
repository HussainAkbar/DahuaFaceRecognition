Imports System.Windows.Forms

Public Class frmSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtDeviceIP.TextLength = 0 Or txtDevicePort.TextLength = 0 Or txtDeviceUserId.TextLength = 0 Or txtDevicePassword.TextLength = 0 Then
            MessageBox.Show("Values cannot be left empty", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        My.Settings.DeviceIP = txtDeviceIP.Text
        My.Settings.DevicePort = txtDevicePort.Text
        My.Settings.DeviceUserId = txtDeviceUserId.Text
        My.Settings.DevicePassword = txtDevicePassword.Text
        My.Settings.Channel1 = cbChannel1.Checked
        My.Settings.Channel2 = cbChannel2.Checked
        My.Settings.Channel3 = cbChannel3.Checked
        My.Settings.Channel4 = cbChannel4.Checked
        My.Settings.Channel5 = cbChannel5.Checked
        My.Settings.Channel6 = cbChannel6.Checked
        My.Settings.Channel7 = cbChannel7.Checked
        My.Settings.Channel8 = cbChannel8.Checked
        My.Settings.Save()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtDeviceIP.Text = My.Settings.DeviceIP
        txtDevicePort.Text = My.Settings.DevicePort
        txtDeviceUserId.Text = My.Settings.DeviceUserId
        txtDevicePassword.Text = My.Settings.DevicePassword
        cbChannel1.Checked = My.Settings.Channel1
        cbChannel2.Checked = My.Settings.Channel2
        cbChannel3.Checked = My.Settings.Channel3
        cbChannel4.Checked = My.Settings.Channel4
        cbChannel5.Checked = My.Settings.Channel5
        cbChannel6.Checked = My.Settings.Channel6
        cbChannel7.Checked = My.Settings.Channel7
        cbChannel8.Checked = My.Settings.Channel8
    End Sub
End Class
