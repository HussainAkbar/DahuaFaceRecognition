Imports System.Runtime.InteropServices

Module DeviceFunctions
    Public Const EVENT_IVS_ALL = &H1                ' Subscribe all events
    Public Const EVENT_IVS_FACEDETECT = &H1A        ' Face detection(Corresponding To DEV_EVENT_FACEDETECT_INFO)
    Public Const EVENT_ALARM_MOTIONDETECT = &H11C
    Public Const EVENT_IVS_FACERECOGNITION = &H117  ' Face recognition(Corresponding to DEV_EVENT_FACERECOGNITION_INFO)
    Public Const DH_EVENT_FACE_DETECTION = &H218B

    'Initialize library
    'Public Declare Function CLIENT_Init Lib "dhnetsdk.dll" (ByVal fDisConnect As Integer, ByVal wDVRPort As Long) As Long
    Public Declare Function CLIENT_Init Lib "dhnetsdk.dll" (ByVal fDisConnect As DeviceDisconnectedDelegate, ByVal dwUser As Int64) As Boolean
    Public Delegate Sub DeviceDisconnectedDelegate(lLoginID As Int64, pchDVRIP As IntPtr, nDVRPort As Int16, dwUser As Int64)

    'Get SDK Version
    Public Declare Function CLIENT_GetSDKVersion Lib "dhnetsdk.dll" () As Long

    'Client cleanup
    Public Declare Sub CLIENT_Cleanup Lib "dhnetsdk.dll" ()

    'Reconnect callback
    Public Declare Sub CLIENT_SetAutoReconnect Lib "dhnetsdk.dll" (ByVal fReconnect As DeviceReconnectDelegate, ByVal dwUser As Int64)
    Public Delegate Sub DeviceReconnectDelegate(lLoginID As Int64, pchDVRIP As IntPtr, nDVRPort As Int16, dwUser As Int64)

    'Set reconnection time
    Public Declare Sub CLIENT_SetConnectTime Lib "dhnetsdk.dll" (ByVal iTimeoutMilliseconds As Int32, ByVal iNumberOfRetries As Int32)

    'Login API
    Public Declare Function CLIENT_LoginWithHighLevelSecurity Lib "dhnetsdk.dll" (ByRef inParam As NET_IN_LOGIN_WITH_HIGHLEVEL_SECURITY, ByRef outParam As NET_OUT_LOGIN_WITH_HIGHLEVEL_SECURITY) As Int64

    'Logout device
    Public Declare Function CLIENT_Logout Lib "dhnetsdk.dll" (ByVal lLoginID As Int64) As Int32

    'Last error
    Public Declare Function CLIENT_GetLastError Lib "dhnetsdk.dll" () As Int32

    'Realplay API
    Public Declare Function CLIENT_RealPlayEx Lib "dhnetsdk.dll" (ByVal lLoginID As Int64, ByVal nChannelID As Int16, ByVal hwnd As IntPtr, ByVal rType As EM_REAL_PLAY_TYPE) As Long

    'Stop Realplay
    Public Declare Function CLIENT_StopRealPlayEx Lib "dhnetsdk.dll" (ByVal lLoginID As Int64) As Long

    'Subscribe to alarm
    Public Declare Function CLIENT_RealLoadPictureEx Lib "dhnetsdk.dll" (ByVal lLoginID As Int64, ByVal nChannelID As Int16, ByVal dwAlarmType As Int32, ByVal bNeedPicFile As Boolean, ByVal fAnalyzerDataCallBack As AnalyzerDataCallBackDelegate, ByVal dwUser As Int64, ByVal Reserved As IntPtr) As Long
    Public Delegate Sub AnalyzerDataCallBackDelegate(lAnalyzerHandle As Int64, dwAlarmType As Int32, AlarmInfo As IntPtr, pBuffer As IntPtr, dwBufferSize As Int32, dwUser As Int64, nSequence As Int16, Reserved As IntPtr)

    'Stop subscription
    Public Declare Function CLIENT_StopLoadPic Lib "dhnetsdk.dll" (ByVal AnalyzerHandle As Long) As Boolean

    'Alarm Listen API
    Public Declare Function CLIENT_StartListen Lib "dhnetsdk.dll" (ByVal lLoginID As Int64) As Long

    'Mess callback API
    Public Declare Function CLIENT_SetDVRMessCallBack Lib "dhnetsdk.dll" (ByVal fMessCallBack As Long, ByVal dwUser As Long) As Long

    Public Enum EM_LOGIN_SPAC_CAP_TYPE
        EM_LOGIN_SPEC_CAP_TCP = 0 ' TCP, default mode
        EM_LOGIN_SPEC_CAP_ANY = 1 ' Login unconditionally
        EM_LOGIN_SPEC_CAP_SERVER_CONN = 2 ' Login of auto registration
        EM_LOGIN_SPEC_CAP_MULTICAST = 3 ' Multicast login, default
        EM_LOGIN_SPEC_CAP_UDP = 4 ' UDP login
        EM_LOGIN_SPEC_CAP_MAIN_CONN_ONLY = 6 ' Only main connection
        EM_LOGIN_SPEC_CAP_SSL = 7 ' SSL encryption mode login
        EM_LOGIN_SPEC_CAP_INTELLIGENT_BOX = 9 ' Log in to the smart box device
        EM_LOGIN_SPEC_CAP_NO_CONFIG = 10 ' Do Not get configuration after login device
        EM_LOGIN_SPEC_CAP_U_LOGIN = 11 ' Login by USB key
        EM_LOGIN_SPEC_CAP_LDAP = 12 ' Login by LDAP
        EM_LOGIN_SPEC_CAP_AD = 13 ' AD（ActiveDirectory）login
        EM_LOGIN_SPEC_CAP_RADIUS = 14 ' Radius login
        EM_LOGIN_SPEC_CAP_SOCKET_5 = 15 ' Socks5 login
        EM_LOGIN_SPEC_CAP_CLOUD = 16 ' Cloud login
        EM_LOGIN_SPEC_CAP_AUTH_TWICE = 17 ' The 2nd verification login
        EM_LOGIN_SPEC_CAP_TS = 18 ' TS bit stream client login
        EM_LOGIN_SPEC_CAP_P2P = 19 ' P2P login
        EM_LOGIN_SPEC_CAP_MOBILE = 20 ' Cellphone client login
        EM_LOGIN_SPEC_CAP_INVALID ' Invalid login
    End Enum

    Public Enum EM_REAL_PLAY_TYPE
        EM_REAL_PLAY_REALPLAY = 0
        EM_REAL_PLAY_MULTIPLAY
        EM_REAL_PLAY_REALPLAY_0
        EM_REAL_PLAY_REALPLAY_1
        EM_REAL_PLAY_REALPLAY_2
        EM_REAL_PLAY_REALPLAY_3
        EM_REAL_PLAY_MULTIPLAY_0
        EM_REAL_PLAY_MULTIPLAY1
        EM_REAL_PLAY_MULTIPLAY_4
        EM_REAL_PLAY_MULTIPLAY_8
        EM_REAL_PLAY_MULTIPLAY_9
        EM_REAL_PLAY_MULTIPLAY_6
        EM_REAL_PLAY_MULTIPLAY_16
        EM_REAL_PLAY_MULTIPLAY_12
        EM_REAL_PLAY_MULTIPLAY_25
        EM_REAL_PLAY_MULTIPLAY_36
    End Enum

    Public Enum EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_UNKNOWN
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_WEAR_GLASSES
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_SMILE
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_ANGER
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_SADNESS
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_DISGUST
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_FEAR
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_SURPRISE
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_NEUTRAL
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_LAUGH
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_NOGLASSES
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_HAPPY
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_CONFUSED
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_SCREAM
        EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE_WEAR_SUNGLASSES
    End Enum

    Public Enum EM_DEV_EVENT_FACEDETECT_SEX_TYPE
        EM_DEV_EVENT_FACEDETECT_SEX_TYPE_UNKNOWN
        EM_DEV_EVENT_FACEDETECT_SEX_TYPE_MAN
        EM_DEV_EVENT_FACEDETECT_SEX_TYPE_WOMAN
    End Enum

    Public Enum EM_RACE_TYPE
        EM_RACE_UNKNOWN
        EM_RACE_NODISTI
        EM_RACE_YELLOW
        EM_RACE_BLACK
        EM_RACE_WHITE
    End Enum

    Public Enum EM_EYE_STATE_TYPE
        EM_EYE_STATE_UNKNOWN
        EM_EYE_STATE_NODISTI  'no disringuish
        EM_EYE_STATE_CLOSE
        EM_EYE_STATE_OPEN
    End Enum

    Public Enum EM_MOUTH_STATE_TYPE
        EM_MOUTH_STATE_UNKNOWN
        EM_MOUTH_STATE_NODISTI ' no distinguish
        EM_MOUTH_STATE_CLOSE
        EM_MOUTH_STATE_OPEN
    End Enum

    Public Enum EM_MASK_STATE_TYPE
        EM_MASK_STATE_UNKNOWN
        EM_MASK_STATE_NODISTI
        EM_MASK_STATE_NOMASK
        EM_MASK_STATE_WEAR
    End Enum

    Public Enum EM_BEARD_STATE_TYPE
        EM_BEARD_STATE_UNKNOWN
        EM_BEARD_STATE_NODISTI
        EM_BEARD_STATE_NOBEARD
        EM_BEARD_STATE_HAVEBEARD
    End Enum

    Public Enum EM_HUMAN_TEMPERATURE_UNIT
        EM_HUMAN_TEMPERATURE_UNKNOWN = -1
        EM_HUMAN_TEMPERATURE_CENTIGRADE
        EM_HUMAN_TEMPERATURE_FAHRENHEIT
        EM_HUMAN_TEMPERATURE_KELVIN
    End Enum

    Public Enum EM_CLOTHES_COLOR
        EM_CLOTHES_COLOR_UNKNOWN
        EM_CLOTHES_COLOR_WHITE
        EM_CLOTHES_COLOR_ORANGE
        EM_CLOTHES_COLOR_PINK
        EM_CLOTHES_COLOR_BLACK
        EM_CLOTHES_COLOR_RED
        EM_CLOTHES_COLOR_YELLOW
        EM_CLOTHES_COLOR_GRAY
        EM_CLOTHES_COLOR_BLUE
        EM_CLOTHES_COLOR_GREEN
        EM_CLOTHES_COLOR_PURPLE
        EM_CLOTHES_COLOR_BROWN
        EM_CLOTHES_COLOR_OTHER
    End Enum

    Public Enum EM_COAT_TYPE
        EM_COAT_TYPE_UNKNOWN
        EM_COAT_TYPE_LONG_SLEEVE
        EM_COAT_TYPE_COTTA
    End Enum

    Public Enum EM_TROUSERS_TYPE
        EM_TROUSERS_TYPE_UNKNOWN
        EM_TROUSERS_TYPE_TROUSERS
        EM_TROUSERS_TYPE_SHORTS
        EM_TROUSERS_TYPE_SKIRT
    End Enum

    Public Enum EM_HAS_HAT
        EM_HAS_HAT_UNKNOWN
        EM_HAS_HAT_NO
        EM_HAS_HAT_YES
    End Enum

    Public Enum EM_HAS_BAG
        EM_HAS_BAG_UNKNOWN
        EM_HAS_BAG_NO
        EM_HAS_BAG_YES
    End Enum

    Public Enum EM_HAS_BACK_BAG
        EM_HAS_BACK_BAG_UNKNOWN
        EM_HAS_BACK_BAG_NO
        EM_HAS_BACK_BAG_YES
    End Enum

    Public Enum EM_HAS_CARRIER_BAG
        EM_HAS_CARRIER_BAG_UNKNOWN
        EM_HAS_CARRIER_BAG_NO
        EM_HAS_CARRIER_BAG_YES
    End Enum

    Public Enum EM_HAS_SHOULDER_BAG
        EM_HAS_SHOULDER_BAG_UNKNOWN
        EM_HAS_SHOULDER_BAG_NO
        EM_HAS_SHOULDER_BAG_YES
    End Enum

    Public Enum EM_HAS_MESSENGER_BAG
        EM_HAS_MESSENGER_BAG_UNKNOWN
        EM_HAS_MESSENGER_BAG_NO
        EM_HAS_MESSENGER_BAG_YES
    End Enum

    Public Enum EM_ANGLE_TYPE
        EM_ANGLE_UNKNOWN = 0
        EM_ANGLE_FRONT
        EM_ANGLE_SIDE
        EM_ANGLE_BACK
    End Enum

    Public Enum EM_HAS_UMBRELLA
        EM_HAS_UMBRELLA_UNKNOWN
        EM_HAS_UMBRELLA_NO
        EM_HAS_UMBRELLA_YES
    End Enum

    Public Enum EM_BAG_TYPE
        EM_BAG_UNKNOWN
        EM_BAG_HANDBAG
        EM_BAG_SHOULDERBAG
        EM_BAG_KNAPSACK
        EM_BAG_DRAWBARBOX
        EM_BAG_WAISTPACK
        EM_BAG_NONE
    End Enum

    Public Enum EM_CAP_TYPE
        EM_CAP_UNKNOWN
        EM_CAP_ORDINARY
        EM_CAP_HELMET
        EM_CAP_SAFE
    End Enum

    Public Enum EM_CLOTHES_PATTERN
        EM_CLOTHES_PATTERN_UNKNOWN
        EM_CLOTHES_PATTERN_PURE
        EM_CLOTHES_PATTERN_STRIPE
        EM_CLOTHES_PATTERN_PATTERN
        EM_CLOTHES_PATTERN_GAP
        EM_CLOTHES_PATTERN_LATTICE
        EM_CLOTHES_PATTERN_SPLITJOIN
    End Enum

    Public Enum EM_HAIR_STYLE
        EM_HAIR_UNKNOWN = 0
        EM_HAIR_LONG_HAIR
        EM_HAIR_SHORT_HAIR
        EM_HAIR_PONYTAIL
        EM_HAIR_UPDO
        EM_HAIR_HEAD_BLOCKED
        EM_HAIR_NONE
    End Enum

    Public Enum EM_SEX_TYPE
        EM_SEX_TYPE_UNKNOWN
        EM_SEX_TYPE_MALE
        EM_SEX_TYPE_FEMALE
    End Enum

    Public Enum EM_CLASS_TYPE
        EM_CLASS_UNKNOWN = 0
        EM_CLASS_VIDEO_SYNOPSIS = 1
        EM_CLASS_TRAFFIV_GATE = 2
        EM_CLASS_ELECTRONIC_POLICE = 3
        EM_CLASS_SINGLE_PTZ_PARKING = 4
        EM_CLASS_PTZ_PARKINBG = 5
        EM_CLASS_TRAFFIC = 6
        EM_CLASS_NORMAL = 7
        EM_CLASS_PRISON = 8
        EM_CLASS_ATM = 9
        EM_CLASS_METRO = 10
        EM_CLASS_FACE_DETECTION = 11
        EM_CLASS_FACE_RECOGNITION = 12
        EM_CLASS_NUMBER_STAT = 13
        EM_CLASS_HEAT_MAP = 14
        EM_CLASS_VIDEO_DIAGNOSIS = 15
        EM_CLASS_VIDEO_ENHANCE = 16
        EM_CLASS_SMOKEFIRE_DETECT = 17
        EM_CLASS_VEHICLE_ANALYSE = 18
        EM_CLASS_PERSON_FEATURE = 19
        EM_CLASS_SDFACEDETECTION = 20
        EM_CLASS_HEAT_MAP_PLAN = 21
        EM_CLASS_NUMBERSTAT_PLAN = 22
        EM_CLASS_ATMFD = 23
        EM_CLASS_HIGHWAY = 24
        EM_CLASS_CITY = 25
        EM_CLASS_LETRACK = 26
        EM_CLASS_SCR = 27
        EM_CLASS_STEREO_VISION = 28
        EM_CLASS_HUMANDETECT = 29
        EM_CLASS_FACE_ANALYSIS = 30
        EM_CALSS_XRAY_DETECTION = 31
        EM_CLASS_STEREO_NUMBER = 32
        EM_CLASS_CROWDDISTRIMAP = 33
        EM_CLASS_OBJECTDETECT = 34
        EM_CLASS_FACEATTRIBUTE = 35
        EM_CLASS_FACECOMPARE = 36
        EM_CALSS_STEREO_BEHAVIOR = 37
        EM_CALSS_INTELLICITYMANAGER = 38
        EM_CALSS_PROTECTIVECABIN = 39
        EM_CALSS_AIRPLANEDETECT = 40
        EM_CALSS_CROWDPOSTURE = 41
        EM_CLASS_PHONECALLDETECT = 42
        EM_CLASS_SMOKEDETECTION = 43
        EM_CLASS_BOATDETECTION = 44
        EM_CLASS_SMOKINGDETECT = 45
        EM_CLASS_WATERMONITOR = 46
        EM_CLASS_GENERATEGRAPHDETECTION = 47
        EM_CLASS_TRAFFIC_PARK = 48
        EM_CLASS_OPERATEMONITOR = 49
        EM_CLASS_INTELLI_RETAIL = 50
        EM_CLASS_CLASSROOM_ANALYSE = 51
        EM_CLASS_FEATURE_ABSTRACT = 52
        EM_CLASS_FACEBODY_DETECT = 53
        EM_CLASS_FACEBODY_ANALYSE = 54
        EM_CLASS_VEHICLES_DISTRI = 55
        EM_CLASS_INTELLI_BREED = 56
        EM_CLASS_INTELLI_PRISON = 57
        EM_CLASS_ELECTRIC_DETECT = 58
        EM_CLASS_RADAR_DETECT = 59
        EM_CLASS_PARKINGSPACE = 60
        EM_CLASS_INTELLI_FINANCE = 61
        EM_CLASS_CROWD_ABNORMAL = 62
        EM_CLASS_ANATOMY_TEMP_DETECT = 63
        EM_CLASS_WEATHER_MONITOR = 64
        EM_CLASS_ELEVATOR_ACCESS_CONTROL = 65
        EM_CLASS_BREAK_RULE_BUILDING = 66
    End Enum

    Public Structure NET_RET_ERROR
        Public errcode As Int32
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_PARAM
        Public Sub New(iSize As Integer)
            Array.Resize(Me.bReserved, 4)
        End Sub
        Public nWaittime As Int32
        Public nConnectTime As Int32
        Public nConnectTryNum As Int32
        Public nSubConnectSpaceTime As Int32
        Public nGetDevInfoTime As Int32
        Public nConnectBufSize As Int32
        Public nGetConnInfoTime As Int32
        Public nSearchRecordTime As Int32
        Public nsubDisconnetTime As Int32
        Public byNetType As Byte
        Public byPlaybackBufSize As Byte
        Public bDetectDisconnTime As Byte
        Public bKeepLifeInterval As Byte
        Public nPicBufSize As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)>
        Public bReserved() As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_IN_LOGIN_WITH_HIGHLEVEL_SECURITY
        Public Sub New(iSize As Integer)
            Array.Resize(Me.szIP, 64)
            Array.Resize(Me.szUserName, 64)
            Array.Resize(Me.szPassword, 64)
            Me.emSpecCap = New EM_LOGIN_SPAC_CAP_TYPE
            Array.Resize(Me.byReserved, 4)
        End Sub
        Public dwSize As UInt32  'DWORD Structure size
        '<MarshalAs(UnmanagedType.SafeArray)>
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)>
        Public szIP() As Byte  ' [64] IP
        Public nPort As Int32  ' Port
        '<MarshalAs(UnmanagedType.SafeArray)>
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)>
        Public szUserName() As Byte  '[64] User name
        '<MarshalAs(UnmanagedType.SafeArray)>
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)>
        Public szPassword() As Byte '[64] Password
        Public emSpecCap As EM_LOGIN_SPAC_CAP_TYPE ' Login mode
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)>
        Public byReserved() As Byte '[4]; // Byte alignment
        Public pCapParam As IntPtr 'A complementary Function of() emSpecCap
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_OUT_LOGIN_WITH_HIGHLEVEL_SECURITY
        Public Sub New(iSize As Integer)
            Me.stuDeviceInfo = New NET_DEVICEINFO_Ex
            Array.Resize(Me.byReserved, 132)
        End Sub
        Public dwSize As UInt32 ' Structure size
        Public stuDeviceInfo As NET_DEVICEINFO_Ex ' Device information
        Public nError As Int32 ' Error code. Refer to error code of CLIENT_Login
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=132)>
        Public byReserved() As Byte '[132]; // Reserved field
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_DEVICEINFO_Ex
        Public Sub New(iSize As Integer)
            Array.Resize(Me.sSerialNumber, 64)
            Array.Resize(Me.byReserved, 2)
            Array.Resize(Me.byReserved2, 24)
        End Sub
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)>
        Public sSerialNumber() As Byte
        Public nAlarmInPortNum As Int32
        Public nAlarmOutPortNum As Int32
        Public nDiskNum As Int32
        Public nDVRType As Int32
        Public nChanNum As Int32
        Public byLimitLoginTime As Byte
        Public byLeftLogTimes As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)>
        Public byReserved() As Byte
        Public nLockLeftTime As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=24)>
        Public byReserved2() As Byte
    End Structure

    Public Structure NET_EULER_ANGLE
        Public nPitch As Int32
        Public nYaw As Int32
        Public nRoll As Int32
    End Structure


    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_FACE_DATA
        Public Sub New(iSize As Integer)
            Me.emSex = New EM_DEV_EVENT_FACEDETECT_SEX_TYPE
            Array.Resize(Me.emFeature, 32)
            Me.emRace = New EM_RACE_TYPE
            Me.emEye = New EM_EYE_STATE_TYPE
            Me.emMouth = New EM_MOUTH_STATE_TYPE
            Me.emMask = New EM_MASK_STATE_TYPE
            Me.emBeard = New EM_BEARD_STATE_TYPE
            Array.Resize(Me.bReserved1, 4)
            Me.stuFaceCaptureAngle = New NET_EULER_ANGLE
            Me.emTemperatureUnit = New EM_HUMAN_TEMPERATURE_UNIT
            Array.Resize(Me.bReserved, 76)
        End Sub
        Public emSex As EM_DEV_EVENT_FACEDETECT_SEX_TYPE
        Public nAge As Int32
        Public nFeatureValidNum As UInt32
        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.Struct, SizeConst:=32)>
        Public emFeature() As EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE ' array of 32[DH_MAX_FACEDETECT_FEATURE_NUM] human face features
        Public emRace As EM_RACE_TYPE
        Public emEye As EM_EYE_STATE_TYPE
        Public emMouth As EM_MOUTH_STATE_TYPE
        Public emMask As EM_MASK_STATE_TYPE
        Public emBeard As EM_BEARD_STATE_TYPE
        Public nAttractive As Int32 ' Attractive value, -1: invalid, 0:no disringuish range: 1-100, the higher value, the higher charm
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)>
        Public bReserved1() As Byte ' (4)
        Public stuFaceCaptureAngle As NET_EULER_ANGLE 'euler angle Of face In the capture picture, nPitch:pitch of the head, nYaw: yaw of the head, nRoll:roll of the head
        ' range of the angle value Is [-90,90], stuFaceCaptureAngle Is invalid if the three angles are 999.
        Public nFaceQuality As UInt32 ' quality about capture picture
        Public nFaceAlignScore As Int32 ' The score Of face picture align.The range Is 0~10000,-1 Is invalid
        Public nFaceClarity As Int32 ' The score Of face picture clarity.The range Is 0~10000,-1 Is invalid
        Public dbTemperature As Double ' Temperature, it Is valid when bAnatomyTempDetect Is true
        Public bAnatomyTempDetect As Boolean ' Is anatomy temperature detection
        Public emTemperatureUnit As EM_HUMAN_TEMPERATURE_UNIT
        Public bIsOverTemp As Boolean ' Is over temperature, it Is valid When bAnatomyTempDetect Is True
        Public bIsUnderTemp As Boolean ' Is under temperature, it Is valid When bAnatomyTempDetect Is True
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=76)>
        Public bReserved() As Byte '[76]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_TIME
        Public dwYear As UInt32
        Public dwMonth As UInt32
        Public dwDay As UInt32
        Public dwHour As UInt32
        Public dwMinute As UInt32
        Public dwSecond As UInt32
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_TIME_EX
        Public dwYear As UInt32
        Public dwMonth As UInt32
        Public dwDay As UInt32
        Public dwHour As UInt32
        Public dwMinute As UInt32
        Public dwSecond As UInt32
        Public dwMillisecond As UInt32 ' Millisecond
        Public dwUTC As UInt32  'utc query: zero means invaild, non-zero means vaild;  Set:invalid
        Public dwReserved As UInt32 '  reserved data
    End Structure
    ', Pack:=1
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure DH_RECT
        Public left As Int32
        Public top As Int32
        Public right As Int32
        Public bottom As Int32
    End Structure
    ', Pack:=1
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure DH_POINT
        Public nx As Int16
        Public ny As Int16
    End Structure
    ', Pack:=1
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure DH_PIC_INFO
        Public Sub New(iSize As Integer)
            Array.Resize(Me.bReserved, 2)
            Me.stuPoint = New DH_POINT
        End Sub
        Public dwOffSet As UInt32 ' current picture file's offset in the binary file, byte
        Public dwFileLenth As UInt32 ' current picture file's size, byte
        Public wWidth As UInt16 ' picture width, pixel
        Public wHeight As UInt16 ' picture high, pixel
        Public pszFilePath As IntPtr ' File path
        ' User use this field need to apply for space for copy And storage
        Public bIsDetected As Byte 'When submit To the server, the algorithm has checked the image Or Not 
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)>
        Public bReserved() As Byte '[2] reserved data
        Public byQualityScore As Byte ' Quality score Of face capture, range:    0-100
        Public nFilePathLen As Int32 ' File path Len Of pszFilePath
        Public stuPoint As DH_POINT     ' The upper left corner Of the figure Is In the big picture. Absolute coordinates are used				
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure DH_MSG_OBJECT
        Public Sub New(iSize As Integer)
            Debug.Write("Initializing struct with " + iSize)
            'Array.Resize(Me.szObjectType, 128)
            Me.BoundingBox = New DH_RECT
            Me.Center = New DH_POINT
            'Array.Resize(Me.Contour, 16)
            'Me.Contour = New DH_POINT(15) {}
            'Array.Resize(Me.szText, 128)
            'Array.Resize(Me.szObjectSubType, 62)
            Me.stPicInfo = New DH_PIC_INFO
            Me.stuCurrentTime = New NET_TIME_EX
            Me.stuStartTime = New NET_TIME_EX
            Me.stuEndTime = New NET_TIME_EX
            Me.stuOriginalBoundingBox = New DH_RECT
            Me.stuSignBoundingBox = New DH_RECT
            'Array.Resize(Me.byColorSimilar, 8)
            Me.byColorSimilar = New Byte(7) {}
            'Array.Resize(Me.byUpperBodyColorSimilar, 8)
            'Array.Resize(Me.byLowerBodyColorSimilar, 8)
            Me.byUpperBodyColorSimilar = New Byte(7) {}
            Me.byLowerBodyColorSimilar = New Byte(7) {}
            'Array.Resize(Me.szSubText, 28)
        End Sub
        Public nObjectID As Int32 ' Object ID,each ID represent a unique object
        '<MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)>
        'Public szObjectType() As Byte '[128] Object type
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
        Public szObjectType As String
        Public nConfidence As Int32 ' Confidence(0~255),a high value indicate a high confidence
        Public nAction As Int32 ' Object action:1:Appear 2:Move 3:Stay 4:Remove 5:Disappear 6:Split 7:Merge 8:Rename
        Public BoundingBox As DH_RECT ' BoundingBox
        Public Center As DH_POINT ' The shape center of the object
        Public nPolygonNum As Int32 ' the number of culminations for the polygon
        '<MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> '
        'Public Contour As DH_POINT()  '16 [DH_MAX_POLYGON_NUM];	// a polygon that have a exactitude figure
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public Contour As String
        Public rgbaMainColor As UInt32 ' The main color of the object;the first byte indicate red value, as byte order as green, blue, transparence, for example:RGB(0,255,0),transparence = 0, rgbaMainColor = 0x00ff0000.
        '<MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)>
        'Public szText() As Byte '[128]  the interrelated text of object,such as number plate,container number
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
        Public szText As String
        ' "ObjectType","Vehicle" or "Logo", try to use Logo.Vehicle is used to be compatible with old product, means logo, support:
        ' "Unknown" Unknown 
        ' "Audi" Audi
        ' "Honda" Honda
        ' "Volkswagen" Volkswagen
        ' "Toyota" Toyota
        ' etc
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=62)>
        Public szObjectSubType As String '[62] Object Sub type, different Object type has different Sub type: 
        ' Vehicle Category:"Unknown","Motor","Non-Motor","Bus","Bicycle","Motorcycle", 
        ' "DregsCar", "Excavator", "Bulldozer", "Crane", "PumpTruck", "MachineshopTruck"
        ' Plate Category:"Unknown","mal","Yellow","DoubleYellow","Police","Armed",
        ' "Military","DoubleMilitary","SAR","Trainning"
        ' "Personal" ,"Agri","Embassy","Moto","Tractor","Other"
        ' HumanFace Category:"Normal","HideEye","HideNose","HideMouth","TankCar"
        Public wColorLogoIndex As UInt16 ' // the index Of car logo
        Public wSubBrand As UInt16 '  Specifies the Sub-brand Of vehicle,the real value can be found In a mapping table from the development manual 
        Public byReserved1 As Byte
        Public bPicEnble As Boolean ' picture info enable
        Public stPicInfo As DH_PIC_INFO  ' picture info
        Public bShotFrame As Boolean ' Is shot frame
        Public bColor As Boolean ' rgbaMainColor Is enable
        Public byReserved2 As Byte
        Public byTimeType As Byte ' Time indicates the type Of detailed instructions, EM_TIME_TYPE
        Public stuCurrentTime As NET_TIME_EX ' In view Of the video compression,current time(When Object snap Or reconfnition, the frame will be attached To the frame In a video Or pictures,means the frame In the original video Of the time)
        Public stuStartTime As NET_TIME_EX ' strart time(Object appearing For the first time)
        Public stuEndTime As NET_TIME_EX ' End time(Object appearing For the last time)
        Public stuOriginalBoundingBox As DH_RECT ' original bounding box(absolute coordinates)
        Public stuSignBoundingBox As DH_RECT ' sign bounding box coordinate
        Public dwCurrentSequence As UInt32 ' The current frame number (frames When grabbing the Object)
        Public dwBeginSequence As UInt32 ' Start frame number (Object appeared When the frame number, 
        Public dwEndSequence As UInt32 ' The End Of the frame number (When the Object disappearing Frame number)
        Public nBeginFileOffset As UInt64 ' At the beginning Of the file offset, Unit: Word Section(when objects began to appear, the video frames in the original video file offset relative to the beginning of the file,
        Public nEndFileOffset As UInt64 ' At the end of the file offset, Unit: Word Section (when the object disappeared, video frames in the original video file offset relative to the beginning of the file)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)>
        Public byColorSimilar() As Byte '8 [NET_COLOR_TYPE_MAX];// Object color similarity, the range :0-100, represents an array subscript Colors, see EM_COLOR_TYPE, 
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)>
        Public byUpperBodyColorSimilar() As Byte ' [NET_COLOR_TYPE_MAX]; // When upper body color similarity (valid Object type man , 
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)>
        Public byLowerBodyColorSimilar() As Byte ' [NET_COLOR_TYPE_MAX]; // Lower body color similarity When objects (Object type human valid , 
        Public nRelativeID As Int32 ' ID Of relative Object
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)>
        Public szSubText As String '[20] "ObjectType"is "Vehicle" or "Logo",  means a certain brand under LOGO, such as Audi A6L, since there are so many brands, SDK sends this field in real-time ,device filled as real.
        Public wBrandYear As UInt16 ' Specifies the model years Of vehicle. the real value can be found In a mapping table from the development manual 
    End Structure


    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure FACERECOGNITION_PERSON_INFO
        Public Sub New(iSize As Integer)
            'Array.Resize(Me.szPersonName, 16)
            'Array.Resize(Me.szID, 32)
            Array.Resize(Me.szFacePicInfo, 48)
            'Array.Resize(Me.szProvince, 64)
            'Array.Resize(Me.szCity, 64)
            'Array.Resize(Me.szPersonNameEx, 64)
            'Array.Resize(Me.szUID, 32)
            'Array.Resize(Me.szProvince, 64)
            Me.emEmotion = New EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE
        End Sub
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)>
        Public szPersonName As String ' 16 [DH_MAX_NAME_LEN] name                 
        Public wYear As UInt16 ' birth year
        Public byMonth As Byte ' birth month
        Public byDay As Byte ' birth day
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szID As String '32 [DH_MAX_PERSON_ID_LEN] the unique ID For the person
        Public bImportantRank As Byte ' importance level, 1~10, the higher value the higher level
        Public bySex As Byte ' sex, 0 - man, 1 - female
        Public wFacePicNum As UInt16 ' picture number
        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.Struct, SizeConst:=48)>
        Public szFacePicInfo() As DH_PIC_INFO '48 [DH_MAX_PERSON_IMAGE_NUM]; // picture info
        Public byType As Byte ' Personnel types, see EM_PERSON_TYPE
        Public byIDType As Byte ' Document types, see EM_CERTIFICATE_TYPE
        Public byGlasses As Byte ' Whether wear glasses Or Not, 0 - unknown, 1 - Not wear glasses, 2 - wear glasses	
        Public byAge As Byte ' Age, 0 means unknown
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szProvince As String '64 [DH_MAX_PROVINCE_NAME_LEN] province
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szCity As String '64 [DH_MAX_CITY_NAME_LEN] city
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szPersonNameEx As String '64[DH_MAX_PERSON_NAME_LEN] Name, the name Is too Long due To the presence Of 16 bytes can Not be Storage problems, the increase In this parameter
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szUID As String '32 [DH_MAX_PERSON_ID_LEN] person unique ID
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=3)>
        Public szCountry As String '3 [NET_COUNTRY_LENGTH] country
        Public byIsCustomType As Byte ' Using person type:  0 using byType, 1 using szPersonName
        Public pszComment As IntPtr ' comment info, When the memory Is alloced by user,
        ' the value of bCommentLen needs to be filled in recommended length Is NET_COMMENT_LENGTH
        Public pszGroupID As IntPtr ' group ID, When the memory Is alloced by user,
        ' the value of bGroupIdLen needs to be filled in recommended length Is NET_GROUPID_LENGTH
        Public pszGroupName As IntPtr ' group name, When the memory Is alloced by user,
        ' the value of bGroupNameLen needs to be filled in recommended length Is NET_GROUPNAME_LENGTH
        Public pszFeatureValue As IntPtr ' the face feature , When the memory Is alloced by user,
        ' the value of bFeatureValueLen needs to be filled in recommended length Is NET_FEATUREVALUE_LENGTH
        Public bGroupIdLen As Byte ' len Of pszGroupID
        Public bGroupNameLen As Byte ' len Of pszGroupName
        Public bFeatureValueLen As Byte ' len Of pszFeatureValue
        Public bCommentLen As Byte ' len Of pszComment
        Public emEmotion As EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure DH_PIC_INFO_EX3
        Public Sub New(iSize As Integer)
            'Array.Resize(Me.szFilePath, 64)
            Array.Resize(Me.bReserved, 11)
        End Sub
        Public dwOffSet As UInt32 ' current picture file's offset in the binary file, byte
        Public dwFileLenth As UInt32 ' current picture file's size, byte
        Public wWidth As UInt16 ' picture width, pixel
        Public wHeight As UInt16 ' picture high, pixel
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szFilePath As String '[64] File path
        Public bIsDetected As Byte ' When submit To the server, the algorithm has checked the image Or Not 
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=11)>
        Public bReserved() As Byte ' [11]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_RECT
        Public nLeft As Int16
        Public nTop As Int16
        Public nRight As Int16
        Public nBottom As Int16
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_HISTORY_HUMAN_IMAGE_INFO
        Public Sub New(iSize As Integer)
            'Array.Resize(Me.szFilePath, 260)
        End Sub
        Public nLength As Int32
        Public nWidth As Int32
        Public nHeight As Int32
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szFilePath As String '[260];    // Image path
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_HISTORY_HUMAN_INFO
        Public Sub New(iSize As Integer)
            Me.emCoatColor = New EM_CLOTHES_COLOR
            Me.emCoatType = New EM_COAT_TYPE
            Me.emTrousersColor = New EM_CLOTHES_COLOR
            Me.emTrousersType = New EM_TROUSERS_TYPE
            Me.emHasHat = New EM_HAS_HAT
            Me.emHasBag = New EM_HAS_BAG
            Me.stuBoundingBox = New NET_RECT
            Me.emSex = New EM_SEX_TYPE
            Me.emAngle = New EM_ANGLE_TYPE
            Me.emHasUmbrella = New EM_HAS_UMBRELLA
            Me.emBag = New EM_BAG_TYPE
            Me.emUpperPattern = New EM_CLOTHES_PATTERN
            Me.emHairStyleas = New EM_HAIR_STYLE
            Me.emCap = New EM_CAP_TYPE
            Me.emHasBackBag = New EM_HAS_BACK_BAG
            Me.emHasCarrierBag = New EM_HAS_CARRIER_BAG
            Me.emHasShoulderBag = New EM_HAS_SHOULDER_BAG
            Me.emMessengerBag = New EM_HAS_MESSENGER_BAG
            Me.stuImageInfo = New NET_HISTORY_HUMAN_IMAGE_INFO
            Me.stuFaceImageInfo = New NET_HISTORY_HUMAN_IMAGE_INFO
        End Sub
        Public emCoatColor As EM_CLOTHES_COLOR ' Coat color
        Public emCoatType As EM_COAT_TYPE   ' Coat type
        Public emTrousersColor As EM_CLOTHES_COLOR ' Trousers color
        Public emTrousersType As EM_TROUSERS_TYPE  ' Trousers type
        Public emHasHat As EM_HAS_HAT   ' Has hat Or Not
        Public emHasBag As EM_HAS_BAG ' Has bag Or Not
        Public stuBoundingBox As NET_RECT  ' Bounding box
        Public nAge As Int16 ' Age
        Public emSex As EM_SEX_TYPE ' Sex
        Public emAngle As EM_ANGLE_TYPE ' Angle
        Public emHasUmbrella As EM_HAS_UMBRELLA ' Has umbrella Or Not
        Public emBag As EM_BAG_TYPE ' Bag type
        Public emUpperPattern As EM_CLOTHES_PATTERN ' Upper pattern
        Public emHairStyleas As EM_HAIR_STYLE ' Hair style
        Public emCap As EM_CAP_TYPE ' Cap type
        Public emHasBackBag As EM_HAS_BACK_BAG  ' Has back bag Or Not
        Public emHasCarrierBag As EM_HAS_CARRIER_BAG ' Has carrier bag Or Not
        Public emHasShoulderBag As EM_HAS_SHOULDER_BAG ' Has shoulder bag Or Not
        Public emMessengerBag As EM_HAS_MESSENGER_BAG ' Has messenger bag Or Not
        Public stuImageInfo As NET_HISTORY_HUMAN_IMAGE_INFO ' Human image info
        Public stuFaceImageInfo As NET_HISTORY_HUMAN_IMAGE_INFO ' Face image info
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)>
        Public byReserved() As Byte '[256]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure CANDIDATE_INFO
        Public Sub New(iSize As Integer)
            Me.stPersonInfo = New FACERECOGNITION_PERSON_INFO
            Me.stTime = New NET_TIME
            'Array.Resize(Me.szAddress, 260)
            Array.Resize(Me.byReserved, 32)
        End Sub
        Public stPersonInfo As FACERECOGNITION_PERSON_INFO
        Public bySimilarity As Byte ' similarity
        Public byRange As Byte ' Range officer's database, see EM_FACE_DB_TYPE
        Public byReserved1 As Byte
        Public byReserved2 As Byte
        Public stTime As NET_TIME ' When byRange historical database effectively, which means that the query time staff appeared
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szAddress As String '260 [MAX_PATH] When byRange historical database effectively, which means that people place a query appears
        Public bIsHit As Boolean ' Is hit, means the result face has compare result In database
        Public stuSceneImage As DH_PIC_INFO_EX3
        Public nChannelID As Int32 ' ChannelID
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)>
        Public byReserved() As Byte ' [32] Reserved bytes
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure CANDIDATE_INFOEX
        Public Sub New(iSize As Integer)
            Me.stPersonInfo = New FACERECOGNITION_PERSON_INFO
            Me.stTime = New NET_TIME
            'Array.Resize(Me.szAddress, 260)
            'Array.Resize(szFilePathEx, 256)
            Me.stuHistoryHumanInfo = New NET_HISTORY_HUMAN_INFO
            Array.Resize(Me.byReserved, 136)
        End Sub
        Public stPersonInfo As FACERECOGNITION_PERSON_INFO
        Public bySimilarity As Byte ' similarity
        Public byRange As Byte ' Range officer's database, see EM_FACE_DB_TYPE
        Public byReserved1 As Byte
        Public byReserved2 As Byte
        Public stTime As NET_TIME ' When byRange historical database effectively, which means that the query time staff appeared
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szAddress As String '260 [MAX_PATH] When byRange historical database effectively, which means that people place a query appears
        Public bIsHit As Boolean ' Is hit, means the result face has compare result In database
        Public stuSceneImage As DH_PIC_INFO_EX3
        Public nChannelID As Int32 ' ChannelID
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)>
        Public szFilePathEx As String ' [256] File path
        Public stuHistoryHumanInfo As NET_HISTORY_HUMAN_INFO ' Human info In history data base
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=136)>
        Public byReserved() As Byte ' [136] Reserved bytes
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure EVENT_INTELLI_COMM_INFO
        Public Sub New(iSize As Integer)
            Me.emClassType = New EM_CLASS_TYPE
            Array.Resize(Me.byReserved, 124)
        End Sub
        Public emClassType As EM_CLASS_TYPE
        Public nPresetID As Int32 ' Preset ID, value range Is 0~255 And When the value Is greater than 0 Is valied
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=124)>
        Public byReserved() As Byte '[124]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_FEATURE_VECTOR
        Public Sub New(iSize As Integer)
            Array.Resize(Me.byReserved, 120)
        End Sub
        Public dwOffset As UInt32 ' Face feature data offset In data block(Unit:Byte)
        Public dwLength As UInt32 ' Face feature data length(Unit:Byte)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=120)>
        Public byReserved() As Byte '[120]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_PASSERBY_INFO
        Public Sub New(iSize As Integer)
            'Array.Resize(Me.szPasserbyUID, 32)
            'Array.Resize(Me.szPasserbyGroupId, 64)
            'Array.Resize(Me.szPasserbyGroupName, 128)
            Array.Resize(Me.byReserved, 128)
        End Sub
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szPasserbyUID As String '[MAX_COMMON_STRING_32] The unique identifier Of the passerby To write To the database
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szPasserbyGroupId As String '[MAX_COMMON_STRING_64] Passerby group ID
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
        Public szPasserbyGroupName As String '[MAX_COMMON_STRING_128] Passerby group name
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)>
        Public byReserved() As Byte '[128]
    End Structure

    Public Enum EM_FACE_DETECT_STATUS
        EM_FACE_DETECT_UNKNOWN
        EM_FACE_DETECT_APPEAR
        EM_FACE_DETECT_INPICTURE
        EM_FACE_DETECT_EXIT
    End Enum

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_GPS_INFO
        Public Sub New(iSize As Integer)
            Array.Resize(Me.byReserved, 8)
        End Sub
        Public nLongitude As UInt16 ' Longitude(unit:1/1000000 degree)
        ' west Longitude: 0 - 180000000            practical value = 180*1000000 - dwLongitude
        ' east Longitude: 180000000 - 360000000    practical value = dwLongitude - 180*1000000
        ' eg: Longitude:300168866  (300168866 - 180*1000000)/1000000  equal east Longitude 120.168866 degree

        Public nLatidude As UInt16 ' Latidude(unit:1/1000000 degree)
        'north Latidude: 0 - 90000000				practical value = 90*1000000 - dwLatidude
        ' south Latidude: 90000000 - 180000000	practical value = dwLatidude - 90*1000000
        ' eg: Latidude:120186268 (120186268 - 90*1000000)/1000000 equal south Latidude 30. 186268 degree
        Public dbAltitude As Double ' altitude, unit:  m
        Public dbSpeed As Double ' Speed, unit:  km/H
        Public dbBearing As Double ' Bearing, unit:  
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)>
        Public byReserved() As Byte '[8]
    End Structure

    Public Enum EM_GLASSES_TYPE
        EM_GLASSES_UNKNOWN
        EM_GLASSES_SUNGLASS
        EM_GLASSES_GLASS
    End Enum

    Public Enum EM_PERSON_FEATURE_STATE
        EM_PERSON_FEATURE_UNKNOWN
        EM_PERSON_FEATURE_FAIL ' failed To model, need To change the picture
        EM_PERSON_FEATURE_USEFUL ' success To model, the data can be used For face recognition
        EM_PERSON_FEATURE_CALCULATING ' under calculating
        EM_PERSON_FEATURE_UNUSEFUL ' once modeling was successful, but became unusable after upgrading, need To abstract
    End Enum

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure CUSTOM_PERSON_INFO
        Public Sub New(iSize As Integer)
            'Array.Resize(Me.szPersonInfo, 64)
            Array.Resize(Me.byReserved, 124)
        End Sub
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szPersonInfo As String '64 [DH_MAX_PERSON_INFO_LEN];     // personnel extension information
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=124)>
        Public byReserved() As Byte ' [124]
    End Structure

    Public Enum EM_REGISTER_DB_TYPE
        EM_REGISTER_DB_TYPE_UNKNOWN
        EM_REGISTER_DB_TYPE_NORMAL
        EM_REGISTER_DB_TYPE_BLACKLIST
        EM_REGISTER_DB_TYPE_WHITELIST
        EM_REGISTER_DB_TYPE_VIP
        EM_REGISTER_DB_TYPE_STAFF
        EM_REGISTER_DB_TYPE_LEADER
    End Enum

    Public Enum EM_PERSON_FEATURE_ERRCODE
        EM_PERSON_FEATURE_ERRCODE_UNKNOWN
        EM_PERSON_FEATURE_ERRCODE_PIC_FORMAT ' invalid picture format
        EM_PERSON_FEATURE_ERRCODE_NO_FACE ' no face Or unclear face
        EM_PERSON_FEATURE_ERRCODE_MULTI_FACE ' multi face
        EM_PERSON_FEATURE_ERRCODE_PIC_DECODE_FAIL ' picture decoding failed
        EM_PERSON_FEATURE_ERRCODE_NOT_RECOMMEND ' Not recommended For storage
        EM_PERSON_FEATURE_ERRCODE_FACEDB_FAIL ' failure Of database operation
        EM_PERSON_FEATURE_ERRCODE_GET_PICTURE ' fail To ge picture
        EM_PERSON_FEATURE_ERRCODE_SYSTEM_ERROR ' system Error
    End Enum

    Public Enum EM_PIC_OPERATE_TYPE
        EM_PIC_OPERATE_UNKNOWN
        EM_PIC_OPERATE_MODIFY
        EM_PIC_OPERATE_ADD
        EM_PIC_OPERATE_DEL
    End Enum

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_FACE_PIC_INFO
        Public Sub New(iSize As Integer)
            'Array.Resize(Me.szPictureID, 32)
            Array.Resize(Me.byReserved, 20)
        End Sub
        Public dwOffSet As UInt32 ' Offset position Of file In binary data block, unit: Byte
        Public dwFileLenth As UInt32 ' File size In bytes
        Public dwWidth As UInt32 ' Picture width In pixels
        Public dwHeight As UInt32 ' Picture height In pixels
        Public bIsDetected As Boolean ' Whether the image Is detected by algorithm. When a detected server Is submitted 
        ' Or identification, it Is Not necessary to detect the location matting again.
        ' TRUE: detected, FALSE: Not detected
        Public nFilePathLen As Int32 ' File path length, it Is the size Of both pszfilepath
        Public pszFilePath As IntPtr ' File path, Space requested by user. It Is Not required As input condition.
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szPictureID As String '[32] Picture ID Is used To distinguish different faces In the Case Of one person With multiple faces
        Public emFeatureState As EM_PERSON_FEATURE_STATE ' Picture modeling status
        Public emFeatureErrCode As EM_PERSON_FEATURE_ERRCODE ' Modeling failure reason
        Public emPicOperate As EM_PIC_OPERATE_TYPE  ' Picture operation type
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)>
        Public byReserved() As Byte '[20]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure FACERECOGNITION_PERSON_INFOEX
        Public Sub New(iSize As Integer)
            'Array.Resize(Me.szPersonName, 64)
            'Array.Resize(Me.szID, 32)
            Array.Resize(Me.szFacePicInfo, 48)
            'Array.Resize(Me.szProvince, 64)
            'Array.Resize(Me.szCity, 64)
            'Array.Resize(Me.szUID, 32)
            'Array.Resize(Me.szCountry, 3)
            'Array.Resize(Me.szCustomType, 16)
            'Array.Resize(Me.szComment, 100)
            Array.Resize(Me.byReserved, 532)
            'Array.Resize(Me.szGroupID, 64)
            'Array.Resize(Me.szGroupName, 128)
            'Array.Resize(Me.szHomeAddress, 128)
            Array.Resize(Me.nAgeRange, 2)
            Array.Resize(Me.emEmotions, 32)
            Array.Resize(Me.szCustomPersonInfo, 4)
            Me.stuEffectiveTime = New NET_TIME
            Array.Resize(Me.szFacePicInfoEx, 6)
            Array.Resize(Me.byReserved, 532)
        End Sub
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szPersonName As String '64 [DH_MAX_PERSON_NAME_LEN];           // person name             
        Public wYear As UInt16 ' birth year, fill 0 Is invalid, When Is As a query condition
        Public byMonth As Byte ' birth month, fill 0 Is invalid, When Is As a query condition
        Public byDay As Byte ' birth day, fill 0 Is invalid, When Is As a query condition
        Public bImportantRank As Byte ' importance level, 1~10, the higher value the higher level. fill 0 Is invalid, When Is As a query condition
        Public bySex As Byte ' sex, 0 - man, 1 - female.fill 0 Is invalid, When Is As a query condition
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szID As String '32[DH_MAX_PERSON_ID_LEN]  the unicle ID For the person
        Public wFacePicNum As UInt16 ' picture number
        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.Struct, SizeConst:=48)>
        Public szFacePicInfo() As DH_PIC_INFO '48 [DH_MAX_PERSON_IMAGE_NUM];         // picture info
        Public byType As Byte ' Personnel types, see EM_PERSON_TYPE
        Public byIDType As Byte ' Document types, see EM_CERTIFICATE_TYPE
        Public byGlasses As Byte ' Whether wear glasses Or Not, 0 - unknown, 1 - Not wear glasses, 2 - wear glasses						
        Public byAge As Byte ' Age, 0 means unknown 
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szProvince As String '64 [DH_MAX_PROVINCE_NAME_LEN] province
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szCity As String '64 [DH_MAX_CITY_NAME_LEN] city
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szUID As String  '32 [DH_MAX_PERSON_ID_LEN] person unique ID
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=3)>
        Public szCountry As String '3 [NET_COUNTRY_LENGTH] country
        Public byIsCustomType As Byte ' Using person type:  0 using byType, 1 using CustomType
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)>
        Public szCustomType As String '16 [DH_COMMON_STRING_16] custom type Of person
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=100)>
        Public szComment As String '100 [NET_COMMENT_LENGTH] comment info
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szGroupID As String '64 [NET_GROUPID_LENGTH] group ID
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
        Public szGroupName As String '128 [NET_GROUPNAME_LENGTH] group name
        Public emEmotion As EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE   ' Emotion
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
        Public szHomeAddress As String '128 [DH_COMMON_STRING_128] home address Of the person
        Public emGlassesType As EM_GLASSES_TYPE  ' glasses type
        Public emRace As EM_RACE_TYPE
        Public emEye As EM_EYE_STATE_TYPE        '  eye state
        Public emMouth As EM_MOUTH_STATE_TYPE         ' mouth state
        Public emMask As EM_MASK_STATE_TYPE          ' mask state
        Public emBeard As EM_BEARD_STATE_TYPE         ' beard state
        Public nAttractive As Int16 ' attractive, -1:invalid, 0:unknown 1-100
        Public emFeatureState As EM_PERSON_FEATURE_STATE    ' person feature state
        Public bAgeEnable As Boolean ' age range Is enabled
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)>
        Public nAgeRange() As Int32 '[2] age range
        Public nEmotionValidNum As Int32 ' invalid number In array emEmotion, 0 means all emotion
        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.Struct, SizeConst:=32)>
        Public emEmotions() As EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE '32 [DH_MAX_FACEDETECT_FEATURE_NUM] human emotion  Set the query condition
        Public nCustomPersonInfoNum As Int32 ' extension number Of registered personnel information
        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.Struct, SizeConst:=4)>
        Public szCustomPersonInfo() As CUSTOM_PERSON_INFO '4  [DH_MAX_CUSTOM_PERSON_INFO_NUM];  // extension Of registered personnel information
        Public emRegisterDbType As EM_REGISTER_DB_TYPE  ' type Of register face DB
        Public stuEffectiveTime As NET_TIME ' effective time
        Public emFeatureErrCode As EM_PERSON_FEATURE_ERRCODE ' Error code Of person feature
        Public wFacePicNumEx As UInt32 ' Number Of face pictures
        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.Struct, SizeConst:=6)>
        Public szFacePicInfoEx() As NET_FACE_PIC_INFO  '   [6] The picture information corresponding To the current person. It Is an extension Of szFacePicInfo. This field will be used first In the future
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=532)>
        Public byReserved() As Byte '[532]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_FACECOMPARISON_PTZ_INFO
        Public Sub New(iSize As Integer)
            'Array.Resize(Me.szPresetName, 64)
            Array.Resize(Me.byReserved1, 4)
            Array.Resize(Me.byReserved, 256)
        End Sub
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szPresetName As String '[64] Preset point name When the ball machine captures the face
        Public dwPresetNumber As UInt32 ' Preset point number When the ball machine captures the face	
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)>
        Public byReserved1() As Byte '[4] Byte alaginment	
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=532)>
        Public byReserved() As Byte ' [256]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure NET_CUSTOM_PROJECTS_INFO
        Public Sub New(iSize As Integer)
            Me.stuGPSInfo = New NET_GPS_INFO
            Me.stuFaceComparisonPTZInfo = New NET_FACECOMPARISON_PTZ_INFO
            'Array.Resize(Me.szPlateNumber, 64)
            Array.Resize(Me.byReserved, 256)
        End Sub
        Public stuGPSInfo As NET_GPS_INFO ' GPS info
        Public stuFaceComparisonPTZInfo As NET_FACECOMPARISON_PTZ_INFO ' Face matching events corresponding To ball machine information
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szPlateNumber As String '[64] License plate information In face comparison
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1024)>
        Public byReserved() As Byte '[1024]
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure DEV_EVENT_FACERECOGNITION_INFO
        Public Sub New(iSize As Integer)
            Me.UTC = New NET_TIME_EX
            Me.stuObject = New DH_MSG_OBJECT
            Me.stuCandidates = New CANDIDATE_INFO(49) {}
            Me.stuGlobalScenePicInfo = New DH_PIC_INFO
            Me.stuIntelliCommInfo = New EVENT_INTELLI_COMM_INFO
            Me.stuFaceData = New NET_FACE_DATA
            Me.stuFeatureVector = New NET_FEATURE_VECTOR
            Me.emFaceDetectStatus = New EM_FACE_DETECT_STATUS
            Me.stuPasserbyInfo = New NET_PASSERBY_INFO
            Me.stuGPSInfo = New NET_GPS_INFO
            Me.bReserved = New Byte(367) {}
            Me.stuCandidatesEx = New CANDIDATE_INFOEX(49) {}
            Me.stuCustomProjects = New NET_CUSTOM_PROJECTS_INFO
            Me.byReserved24 = New Byte(3) {}
        End Sub
        Public nChannelID As Int32 ' ChannelId
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
        Public szName As String '[128] Event name
        Public nEventID As Int32 ' Event ID
        Public UTC As NET_TIME_EX ' the Event happen time
        Public stuObject As DH_MSG_OBJECT ' have being detected Object
        Public nCandidateNum As Int32 ' candidate number
        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.Struct, SizeConst:=50)>
        Public stuCandidates() As CANDIDATE_INFO      '50 [DH_MAX_CANDIDATE_NUM]; // candidate info
        Public bEventAction As Byte ' Event action, 0 means pulse Event, 1 means continuous Event's begin,2means continuous event's end;
        Public byImageIndex As Byte ' Serial number Of the picture, In the same time (accurate To seconds) may have multiple images, starting from 0
        Public byReserved11 As Byte
        Public byReserved12 As Byte
        Public bGlobalScenePic As Boolean ' The existence panorama
        Public stuGlobalScenePicInfo As DH_PIC_INFO ' Panoramic Photos
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szSnapDevAddress As String '260 [MAX_PATH];    Snapshot current face aadevice address  
        Public nOccurrenceCount As UInt32 ' Event trigger accumilated times 
        Public stuIntelliCommInfo As EVENT_INTELLI_COMM_INFO ' intelligent things info
        Public stuFaceData As NET_FACE_DATA     ' the data Of face
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szUID As String '32 [DH_COMMON_STRING_32] The unique identifier Of the snap person To write To the database
        Public stuFeatureVector As NET_FEATURE_VECTOR ' Feature data information
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szFeatureVersion As String '[32] The version Of the feature data algorithm
        Public emFaceDetectStatus As EM_FACE_DETECT_STATUS ' The status Of person In camera picture
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szSourceID As String '[32] Correlate Event ID, events arising from same Object Or picture could have same correlate Event ID
        Public stuPasserbyInfo As NET_PASSERBY_INFO ' passerby info
        Public nStayTime As UInt32 ' stay time Unit:s
        Public stuGPSInfo As NET_GPS_INFO   ' GPS info(consistent With stugpsinfo information under stucustomprojects)
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)>
        Public szCameraID As String '[64]  GB encoding
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=368)>
        Public bReserved() As Byte '[368]
        Public nRetCandidatesExNum As Int32 ' the actual Return number Of stuCandidatesEx
        <MarshalAs(UnmanagedType.ByValArray, ArraySubType:=UnmanagedType.Struct, SizeConst:=50)>
        Public stuCandidatesEx() As CANDIDATE_INFOEX '50 [DH_MAX_CANDIDATE_NUM];     	// the expansion Of candidate information
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=22)>
        Public szSerialUUID As String ' [22] szSerial UUID
        ' The format Is as follows Front 2:%d%d:01-video,02-picture,03-file,99-other;
        ' Middle 14:YYYYMMDDhhmmss:year,month,day,hour,minute,second;Last 5:%u%u%u%u%u object ID as 00001
        Public byReserved1 As Byte
        Public byReserved2 As Byte
        Public stuCustomProjects As NET_CUSTOM_PROJECTS_INFO ' Face recognition project customization information
        Public bIsDuplicateRemove As Boolean ' Smart retail, whether it conforms To the de duplication strategy (True: conforms to false: does Not conform to)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)>
        Public byReserved24() As Byte '[4] Byte alaginment
    End Structure

    Public Sub MessFunc(ByVal lCommand As Long,
      ByVal lLoginID As Long, ByVal pBuf As Long,
      ByVal dwBufLen As Long, ByVal pchDVRIP As Long,
      ByVal nDVRPort As Long, ByVal dwUser As Long)
        MessageBox.Show(lLoginID)
        MessageBox.Show(pBuf)
        MessageBox.Show(pchDVRIP)
    End Sub

    Public Function PtrToLong(ByVal func As Long) As Long
        PtrToLong = func
    End Function

End Module
