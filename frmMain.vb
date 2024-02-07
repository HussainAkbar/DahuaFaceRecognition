Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.ComponentModel

Public Class frmMain

    <DllImport("Kernel32.dll", CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function SetDllDirectory(ByVal lpPathName As String) As Boolean
    End Function


    Private bDeviceInitialized As Boolean = False, bLoggedIn As Boolean = False
    Private hLoginId As Int64
    Private err As NET_RET_ERROR
    Private devInfo As NET_DEVICEINFO_Ex
    Private netParam As NET_PARAM
    Private netInLoginWithHighLevelSecurity As New NET_IN_LOGIN_WITH_HIGHLEVEL_SECURITY, pNetInLoginWithHighLevelSecurity As IntPtr
    Private netOutLoginWithHighLevelSecurity As New NET_OUT_LOGIN_WITH_HIGHLEVEL_SECURITY, pNetOutLoginWithHighLevelSecurity As IntPtr
    Private Shared lMonitorChannel(8) As Long, lAlarmFaceDetection(8) As Long, lAlarmFaceRecognition(8)
    Private Shared fMain As frmMain
    Private fAnalyzer As AnalyzerDataCallBackDelegate

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim strPath As String = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
        strPath = Path.Combine(strPath, "x86")
        'Debug.Print("DLL Path: " & strPath)
        Dim bSetDLLDir As Boolean = SetDllDirectory(strPath)
        If (Not bSetDLLDir) Then
            Throw New System.ComponentModel.Win32Exception()
        End If
        fMain = Me

        'ReDim netParam.bReserved(4)
        ReDim devInfo.sSerialNumber(64)
        ReDim netOutLoginWithHighLevelSecurity.byReserved(132)
        ReDim netInLoginWithHighLevelSecurity.szIP(64)
        ReDim netInLoginWithHighLevelSecurity.szUserName(64)
        ReDim netInLoginWithHighLevelSecurity.szPassword(64)
        ReDim netInLoginWithHighLevelSecurity.byReserved(4)
        Call SetCameraImages()
    End Sub


#Region "Menu functions"

    Private Sub tsmiFileExit_Click(sender As Object, e As EventArgs) Handles tsmiFileExit.Click
        CloseDevice()
        Me.Close()
    End Sub

    Private Sub tsmiEditSettings_Click(sender As Object, e As EventArgs) Handles tsmiEditSettings.Click
        frmSettings.ShowDialog()
        Call SetCameraImages()
    End Sub

    Private Sub tsmiFileStart_Click(sender As Object, e As EventArgs) Handles tsmiFileStart.Click
        If My.Settings.DeviceIP.Length < 7 Then
            MessageBox.Show("Set the device parameters from the Settings dialog", "Missing Parameters", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        bDeviceInitialized = CLIENT_Init(AddressOf DeviceDisconnected, 0)
        If Not bDeviceInitialized Then
            MessageBox.Show("Failed to initialize device", "Init Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End If
        Dim lSDKVersion As Long
        lSDKVersion = CLIENT_GetSDKVersion()
        tsSDK.Text = "SDK: " + lSDKVersion.ToString.Substring(0, 1) + "." + lSDKVersion.ToString.Substring(1, 2) + " " + lSDKVersion.ToString.Substring(3)

        fAnalyzer = AddressOf AnalyzerDataCallBack

        'Set reconnect callback
        CLIENT_SetAutoReconnect(AddressOf DeviceReconnected, 0)

        ' Set device connection timeout And trial times.
        ' Optional operation
        Dim nWaitTime As Integer = 5000 ' Timeout Is 5 seconds.
        Dim nTryTimes As Integer = 3    ' If timeout, it will try to log in three times.
        CLIENT_SetConnectTime(nWaitTime, nTryTimes)
        'A wait is required
        System.Threading.Thread.Sleep(1000)

        netInLoginWithHighLevelSecurity.dwSize = Marshal.SizeOf(netInLoginWithHighLevelSecurity)
        Array.Copy(System.Text.Encoding.Default.GetBytes(My.Settings.DeviceIP), netInLoginWithHighLevelSecurity.szIP, My.Settings.DeviceIP.Length)
        netInLoginWithHighLevelSecurity.nPort = CInt(My.Settings.DevicePort)
        Array.Copy(System.Text.Encoding.Default.GetBytes(My.Settings.DeviceUserId), netInLoginWithHighLevelSecurity.szUserName, My.Settings.DeviceUserId.Length)
        Array.Copy(System.Text.Encoding.Default.GetBytes(My.Settings.DevicePassword), netInLoginWithHighLevelSecurity.szPassword, My.Settings.DevicePassword.Length)
        netInLoginWithHighLevelSecurity.emSpecCap = EM_LOGIN_SPAC_CAP_TYPE.EM_LOGIN_SPEC_CAP_TCP
        'Create a pointer for the structure
        'pNetInLoginWithHighLevelSecurity = Marshal.AllocHGlobal(Marshal.SizeOf(netInLoginWithHighLevelSecurity))
        'Copy the structure and data to the pointer in memory
        'Marshal.StructureToPtr(netInLoginWithHighLevelSecurity, pNetInLoginWithHighLevelSecurity, False)

        netOutLoginWithHighLevelSecurity.stuDeviceInfo = devInfo
        netOutLoginWithHighLevelSecurity.dwSize = Marshal.SizeOf(netOutLoginWithHighLevelSecurity)
        'Create a pointer for the structure
        'pNetOutLoginWithHighLevelSecurity = Marshal.AllocHGlobal(Marshal.SizeOf(netOutLoginWithHighLevelSecurity))
        'Copy the structure and data to the pointer in memory
        'Marshal.StructureToPtr(netOutLoginWithHighLevelSecurity, pNetOutLoginWithHighLevelSecurity, False)

        Dim lDeviceError As DEVICE_ERROR
        hLoginId = CLIENT_LoginWithHighLevelSecurity(netInLoginWithHighLevelSecurity, netOutLoginWithHighLevelSecurity)
        If hLoginId = 0 Then
            'Marshal.FreeHGlobal(pNetInLoginWithHighLevelSecurity)
            'Marshal.FreeHGlobal(pNetOutLoginWithHighLevelSecurity)
            lDeviceError = CLIENT_GetLastError
            MessageBox.Show(GetClientErrorDescription(lDeviceError), "Device Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the serial number of the NVR
        Dim i As Integer = 0
        Dim strSerial As String = ""
        While i < 64 And netOutLoginWithHighLevelSecurity.stuDeviceInfo.sSerialNumber(i) <> 0
            strSerial &= Chr(netOutLoginWithHighLevelSecurity.stuDeviceInfo.sSerialNumber(i))
            i += 1
        End While

        ' Enable cameras
        Dim dwUser As Int64 = 0
        Dim oReserved As IntPtr = 0
        Dim nChannel As Int16

        If My.Settings.Channel1 Then
            nChannel = 0
            lMonitorChannel(nChannel) = CLIENT_RealPlayEx(hLoginId, nChannel, pbChannel1.Handle, EM_REAL_PLAY_TYPE.EM_REAL_PLAY_REALPLAY)
            lAlarmFaceDetection(nChannel) = CLIENT_RealLoadPictureEx(hLoginId, nChannel, EVENT_IVS_ALL, True, fAnalyzer, dwUser, Nothing)
            If lAlarmFaceDetection(nChannel) = 0 Then
                lDeviceError = CLIENT_GetLastError
                Console.WriteLine("Failed to set detection: " & GetClientErrorDescription(lDeviceError))
            End If
        Else
            lMonitorChannel(0) = 0
        End If
        If My.Settings.Channel2 Then
            nChannel = 1
            lMonitorChannel(nChannel) = CLIENT_RealPlayEx(hLoginId, nChannel, pbChannel2.Handle, EM_REAL_PLAY_TYPE.EM_REAL_PLAY_REALPLAY)
            lAlarmFaceDetection(nChannel) = CLIENT_RealLoadPictureEx(hLoginId, nChannel, EVENT_IVS_FACEDETECT, True, fAnalyzer, dwUser, Nothing)
            If lAlarmFaceDetection(nChannel) = 0 Then
                lDeviceError = CLIENT_GetLastError
                Console.WriteLine("Failed to set detection: " & GetClientErrorDescription(lDeviceError))
            End If
        Else
            lMonitorChannel(1) = 0
        End If
        If My.Settings.Channel3 Then
            nChannel = 2
            lMonitorChannel(nChannel) = CLIENT_RealPlayEx(hLoginId, nChannel, pbChannel3.Handle, EM_REAL_PLAY_TYPE.EM_REAL_PLAY_REALPLAY)
            lAlarmFaceDetection(nChannel) = CLIENT_RealLoadPictureEx(hLoginId, nChannel, EVENT_IVS_FACEDETECT, True, fAnalyzer, dwUser, Nothing)
        Else
            lMonitorChannel(2) = 0
        End If
        If My.Settings.Channel4 Then
            nChannel = 3
            lMonitorChannel(nChannel) = CLIENT_RealPlayEx(hLoginId, nChannel, pbChannel4.Handle, EM_REAL_PLAY_TYPE.EM_REAL_PLAY_REALPLAY)
            lAlarmFaceDetection(nChannel) = CLIENT_RealLoadPictureEx(hLoginId, nChannel, EVENT_IVS_FACEDETECT, True, fAnalyzer, dwUser, Nothing)
        Else
            lMonitorChannel(3) = 0
        End If
        If My.Settings.Channel5 Then
            nChannel = 4
            lMonitorChannel(nChannel) = CLIENT_RealPlayEx(hLoginId, nChannel, pbChannel5.Handle, EM_REAL_PLAY_TYPE.EM_REAL_PLAY_REALPLAY)
            lAlarmFaceDetection(nChannel) = CLIENT_RealLoadPictureEx(hLoginId, nChannel, EVENT_IVS_FACEDETECT, True, fAnalyzer, dwUser, Nothing)
        Else
            lMonitorChannel(4) = 0
        End If
        If My.Settings.Channel6 Then
            nChannel = 5
            lMonitorChannel(nChannel) = CLIENT_RealPlayEx(hLoginId, nChannel, pbChannel6.Handle, EM_REAL_PLAY_TYPE.EM_REAL_PLAY_REALPLAY)
            lAlarmFaceDetection(nChannel) = CLIENT_RealLoadPictureEx(hLoginId, nChannel, EVENT_IVS_FACEDETECT, True, fAnalyzer, dwUser, Nothing)
        Else
            lMonitorChannel(5) = 0
        End If
        If My.Settings.Channel7 Then
            nChannel = 6
            lMonitorChannel(nChannel) = CLIENT_RealPlayEx(hLoginId, nChannel, pbChannel7.Handle, EM_REAL_PLAY_TYPE.EM_REAL_PLAY_REALPLAY)
            lAlarmFaceDetection(nChannel) = CLIENT_RealLoadPictureEx(hLoginId, nChannel, EVENT_IVS_FACEDETECT, True, fAnalyzer, dwUser, Nothing)
        Else
            lMonitorChannel(6) = 0
        End If
        If My.Settings.Channel8 Then
            nChannel = 7
            lMonitorChannel(nChannel) = CLIENT_RealPlayEx(hLoginId, nChannel, pbChannel8.Handle, EM_REAL_PLAY_TYPE.EM_REAL_PLAY_REALPLAY)
            lAlarmFaceDetection(nChannel) = CLIENT_RealLoadPictureEx(hLoginId, nChannel, EVENT_IVS_FACEDETECT, True, fAnalyzer, dwUser, Nothing)
        Else
            lMonitorChannel(7) = 0
        End If

        bLoggedIn = True
        tsmiFileStart.Enabled = False
        tsmiFileStop.Enabled = True
        tsmiEditSettings.Enabled = False

        tsStatus.Text = "Logged in to " & My.Settings.DeviceIP & " as " & My.Settings.DeviceUserId & " Serial: " & strSerial
        tsConnection.Text = "Logged in"
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CloseDevice()
    End Sub

    Private Sub tsmiFileStop_Click(sender As Object, e As EventArgs) Handles tsmiFileStop.Click
        CloseDevice()
    End Sub

#End Region

#Region "General functions"

    Private Sub SetCameraImages()
        If My.Settings.Channel1 Then
            pbChannel1.Image = My.Resources.cameraoff
        Else
            pbChannel1.Image = My.Resources.nocamera
        End If
        If My.Settings.Channel2 Then
            pbChannel2.Image = My.Resources.cameraoff
        Else
            pbChannel2.Image = My.Resources.nocamera
        End If
        If My.Settings.Channel3 Then
            pbChannel3.Image = My.Resources.cameraoff
        Else
            pbChannel3.Image = My.Resources.nocamera
        End If
        If My.Settings.Channel4 Then
            pbChannel4.Image = My.Resources.cameraoff
        Else
            pbChannel4.Image = My.Resources.nocamera
        End If
        If My.Settings.Channel5 Then
            pbChannel5.Image = My.Resources.cameraoff
        Else
            pbChannel5.Image = My.Resources.nocamera
        End If
        If My.Settings.Channel6 Then
            pbChannel6.Image = My.Resources.cameraoff
        Else
            pbChannel6.Image = My.Resources.nocamera
        End If
        If My.Settings.Channel7 Then
            pbChannel7.Image = My.Resources.cameraoff
        Else
            pbChannel7.Image = My.Resources.nocamera
        End If
        If My.Settings.Channel8 Then
            pbChannel8.Image = My.Resources.cameraoff
        Else
            pbChannel8.Image = My.Resources.nocamera
        End If
    End Sub


    ' Close device and connections
    Private Sub CloseDevice()
        CLIENT_Cleanup()
        tsStatus.Text = "Not connected"
        tsConnection.Text = "Not Ready"
        If bLoggedIn Then
            If lMonitorChannel(0) > 0 Then
                CLIENT_StopRealPlayEx(lMonitorChannel(0))
                lMonitorChannel(0) = 0
                CLIENT_StopLoadPic(lAlarmFaceDetection(0))
            End If
            If lMonitorChannel(1) > 0 Then
                CLIENT_StopRealPlayEx(lMonitorChannel(1))
                lMonitorChannel(1) = 0
                CLIENT_StopLoadPic(lAlarmFaceDetection(1))
            End If
            If lMonitorChannel(2) > 0 Then
                CLIENT_StopRealPlayEx(lMonitorChannel(2))
                lMonitorChannel(2) = 0
                CLIENT_StopLoadPic(lAlarmFaceDetection(2))
            End If
            If lMonitorChannel(3) > 0 Then
                CLIENT_StopRealPlayEx(lMonitorChannel(3))
                lMonitorChannel(3) = 0
                CLIENT_StopLoadPic(lAlarmFaceDetection(3))
            End If
            If lMonitorChannel(4) > 0 Then
                CLIENT_StopRealPlayEx(lMonitorChannel(4))
                lMonitorChannel(4) = 0
                CLIENT_StopLoadPic(lAlarmFaceDetection(4))
            End If
            If lMonitorChannel(5) > 0 Then
                CLIENT_StopRealPlayEx(lMonitorChannel(5))
                lMonitorChannel(5) = 0
                CLIENT_StopLoadPic(lAlarmFaceDetection(5))
            End If
            If lMonitorChannel(6) > 0 Then
                CLIENT_StopRealPlayEx(lMonitorChannel(6))
                lMonitorChannel(6) = 0
                CLIENT_StopLoadPic(lAlarmFaceDetection(6))
            End If
            If lMonitorChannel(7) > 0 Then
                CLIENT_StopRealPlayEx(lMonitorChannel(7))
                lMonitorChannel(7) = 0
                CLIENT_StopLoadPic(lAlarmFaceDetection(7))
            End If
            'Marshal.FreeHGlobal(pNetInLoginWithHighLevelSecurity)
            'Marshal.FreeHGlobal(pNetOutLoginWithHighLevelSecurity)
            CLIENT_Logout(hLoginId)
            fAnalyzer = Nothing

            tsmiEditSettings.Enabled = True
            tsmiFileStart.Enabled = True
            tsmiFileStop.Enabled = False
        End If
    End Sub

#End Region

#Region "Device Callbacks"

    ' Called when device disconnects
    Public Sub DeviceDisconnected(ByVal lLoginID As Int64, ByVal pchDVRIP As Int16, ByVal nDVRPort As Int16, ByVal dwUser As Int64)
        tsConnection.Text = "Disconnected"
        Console.WriteLine("Login ID: " + lLoginID, "Device Disconnected")

    End Sub

    ' Called when device reconnects
    Public Sub DeviceReconnected(ByVal lLoginID As Int64, ByVal pchDVRIP As Int16, ByVal nDVRPort As Int16, ByVal dwUser As Int64)
        tsConnection.Text = "Reconnected"
        Console.WriteLine("Login ID: " + lLoginID, "Device Reconnected")
    End Sub

    'Called when alarm is detected
    Public Shared Sub AnalyzerDataCallBack(ByVal lAnalyzerHandle As Int64, ByVal dwAlarmType As Int32, ByVal AlarmInfo As IntPtr, ByVal pBuffer As IntPtr, ByVal dwBufferSize As Int32, ByVal dwUser As Int64, ByVal nSequence As Int16, ByVal Reserved As IntPtr)
        Dim strAlarmType As String, nChannel As Short
        Dim structFaceRecognitionInfo As New DEV_EVENT_FACERECOGNITION_INFO
        Dim bImage() As Byte
        If dwAlarmType <> EVENT_ALARM_MOTIONDETECT And dwAlarmType <> EVENT_IVS_FACERECOGNITION Then
            Console.WriteLine("Alarm: " & dwAlarmType & " - " & Hex(dwAlarmType))
        End If
        Select Case dwAlarmType
            Case EVENT_IVS_FACEDETECT
                strAlarmType = "Face Detected"
            Case EVENT_ALARM_MOTIONDETECT
                strAlarmType = "Motion"
            Case EVENT_IVS_FACERECOGNITION
                structFaceRecognitionInfo = New DEV_EVENT_FACERECOGNITION_INFO
                Dim isSize As Integer = Marshal.SizeOf(structFaceRecognitionInfo)
                Dim iByte As Byte() = New Byte(isSize - 1) {}
                Marshal.Copy(AlarmInfo, iByte, 0, isSize)

                structFaceRecognitionInfo = DirectCast(Marshal.PtrToStructure(AlarmInfo, GetType(DEV_EVENT_FACERECOGNITION_INFO)), DEV_EVENT_FACERECOGNITION_INFO)
                'structFaceRecognitionInfo = New DEV_EVENT_FACERECOGNITION_INFO
                'structFaceRecognitionInfo.stuObject.Contour = New DH_POINT(15) {}
                'structFaceRecognitionInfo.stuObject.byColorSimilar = New Byte(7) {}
                'structFaceRecognitionInfo.stuObject.byUpperBodyColorSimilar = New Byte(7) {}
                'structFaceRecognitionInfo.stuObject.byLowerBodyColorSimilar = New Byte(7) {}
                'Marshal.PtrToStructure(AlarmInfo, structFaceRecognitionInfo)
                strAlarmType = structFaceRecognitionInfo.szName
                Select Case structFaceRecognitionInfo.emFaceDetectStatus
                    Case EM_FACE_DETECT_STATUS.EM_FACE_DETECT_UNKNOWN
                        strAlarmType &= " - Unknown"
                    Case EM_FACE_DETECT_STATUS.EM_FACE_DETECT_INPICTURE
                        strAlarmType &= " - In picture"
                    Case EM_FACE_DETECT_STATUS.EM_FACE_DETECT_APPEAR
                        strAlarmType &= " - Appear"
                    Case EM_FACE_DETECT_STATUS.EM_FACE_DETECT_EXIT
                        strAlarmType &= " - Exit"
                    Case Else
                        strAlarmType &= " - Other"
                End Select
                fMain.lblAlarmCaption.Invoke(Sub() fMain.lblAlarmCaption.Text = strAlarmType & " on channel " & (structFaceRecognitionInfo.nChannelID + 1).ToString)
                ReDim bImage(dwBufferSize)
                Marshal.Copy(pBuffer, bImage, 0, dwBufferSize)
                fMain.pbFacePicture.Image = Image.FromStream(New MemoryStream(bImage))
            Case Else
                strAlarmType = "Unknown event " & Hex(dwAlarmType)
        End Select

        For nChannel = 0 To 7
            If lAlarmFaceDetection(nChannel) = lAnalyzerHandle Then
                Exit For
            End If
        Next
        ReDim bImage(dwBufferSize)
        Marshal.Copy(pBuffer, bImage, 0, dwBufferSize)
        fMain.pbAlarmPicture.Image = Image.FromStream(New MemoryStream(bImage))
        Console.WriteLine("Analyzer: " & lAnalyzerHandle & " Alarm: " & Hex(dwAlarmType) & "/" & strAlarmType & " Seq: " & nSequence)
    End Sub

    ''' <summary>
    ''' Copy characters from a byte array to a string object
    ''' </summary>
    ''' <param name="baArray">Array to copy from</param>
    ''' <param name="iMaxLength">Maximum numbers of bytes to copy</param>
    ''' <returns>String object</returns>
    ''' <remarks>Function will copy up to the first 0 value</remarks>
    Private Shared Function ByteArrayToString(baArray() As Byte, iMaxLength As Integer) As String
        Dim strString As String = ""
        Dim i As Integer = 0

        While i < iMaxLength And baArray(i) <> 0
            strString &= Chr(baArray(i))
            i += 1
        End While
        Return strString
    End Function
#End Region


End Class
