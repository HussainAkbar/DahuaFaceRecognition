Module ClientErrors
    Public Enum DEVICE_ERROR As Int32
        NET_NOERROR = 0          ' No error 
        NET_ERROR = -1         ' Unknown error
        NET_SYSTEM_ERROR = 1      ' system error
        NET_NETWORK_ERROR = 2      ' Protocol error it may result from network timeout
        NET_DEV_VER_NOMATCH = 3      ' Device protocol does not match 
        NET_INVALID_HANDLE = 4      ' Handle is invalid
        NET_OPEN_CHANNEL_ERROR = 5      ' Failed to open channel 
        NET_CLOSE_CHANNEL_ERROR = 6      ' Failed to close channel 
        NET_ILLEGAL_PARAM = 7      ' User parameter is illegal 
        NET_SDK_INIT_ERROR = 8      ' SDK initialization error 
        NET_SDK_UNINIT_ERROR = 9      ' SDK clear error 
        NET_RENDER_OPEN_ERROR = 10     ' Error occurs when apply for render resources.
        NET_DEC_OPEN_ERROR = 11     ' Error occurs when opening the decoder library 
        NET_DEC_CLOSE_ERROR = 12     ' Error occurs when closing the decoder library 
        NET_MULTIPLAY_NOCHANNEL = 13     ' The detected channel number is 0 in multiple-channel preview. 
        NET_TALK_INIT_ERROR = 14     ' Failed to initialize record library 
        NET_TALK_NOT_INIT = 15     ' The record library has not been initialized
        NET_TALK_SENDDATA_ERROR = 16     ' Error occurs when sending out audio data 
        NET_REAL_ALREADY_SAVING = 17     ' The real-time has been protected.
        NET_NOT_SAVING = 18     ' The real-time data has not been save.
        NET_OPEN_FILE_ERROR = 19     ' Error occurs when opening the file.
        NET_PTZ_SET_TIMER_ERROR = 20     ' Failed to enable PTZ to control timer.
        NET_RETURN_DATA_ERROR = 21     ' Error occurs when verify returned data.
        NET_INSUFFICIENT_BUFFER = 22     ' There is no sufficient buffer.
        NET_NOT_SUPPORTED = 23     ' The current SDK does not support this funcntion.
        NET_NO_RECORD_FOUND = 24     ' There is no searched result.
        NET_NOT_AUTHORIZED = 25     ' You have no operation right.
        NET_NOT_NOW = 26     ' Can not operate right now. 
        NET_NO_TALK_CHANNEL = 27     ' There is no audio talk channel.
        NET_NO_AUDIO = 28     ' There is no audio.
        NET_NO_INIT = 29     ' The network SDK has not been initialized.
        NET_DOWNLOAD_END = 30     ' The download completed.
        NET_EMPTY_LIST = 31     ' There is no searched result.
        NET_ERROR_GETCFG_SYSATTR = 32     ' Failed to get system property setup.
        NET_ERROR_GETCFG_SERIAL = 33     ' Failed to get SN.
        NET_ERROR_GETCFG_GENERAL = 34     ' Failed to get general property.
        NET_ERROR_GETCFG_DSPCAP = 35     ' Failed to get DSP capacity description.
        NET_ERROR_GETCFG_NETCFG = 36     ' Failed to get network channel setup.
        NET_ERROR_GETCFG_CHANNAME = 37     ' Failed to get channel name.
        NET_ERROR_GETCFG_VIDEO = 38     ' Failed to get video property.
        NET_ERROR_GETCFG_RECORD = 39     ' Failed to get record setup
        NET_ERROR_GETCFG_PRONAME = 40     ' Failed to get decoder protocol name 
        NET_ERROR_GETCFG_FUNCNAME = 41     ' Failed to get 232 COM function name.
        NET_ERROR_GETCFG_485DECODER = 42     ' Failed to get decoder property
        NET_ERROR_GETCFG_232COM = 43     ' Failed to get 232 COM setup
        NET_ERROR_GETCFG_ALARMIN = 44     ' Failed to get external alarm input setup
        NET_ERROR_GETCFG_ALARMDET = 45     ' Failed to get motion detection alarm
        NET_ERROR_GETCFG_SYSTIME = 46     ' Failed to get device time
        NET_ERROR_GETCFG_PREVIEW = 47     ' Failed to get preview parameter
        NET_ERROR_GETCFG_AUTOMT = 48     ' Failed to get audio maintenance setup
        NET_ERROR_GETCFG_VIDEOMTRX = 49     ' Failed to get video matrix setup
        NET_ERROR_GETCFG_COVER = 50     ' Failed to get privacy mask zone setup
        NET_ERROR_GETCFG_WATERMAKE = 51     ' Failed to get video watermark setup
        NET_ERROR_GETCFG_MULTICAST = 52     ' Failed to get config, omulticast port by channel
        NET_ERROR_SETCFG_GENERAL = 55     ' Failed to modify general property
        NET_ERROR_SETCFG_NETCFG = 56     ' Failed to modify channel setup
        NET_ERROR_SETCFG_CHANNAME = 57     ' Failed to modify channel name
        NET_ERROR_SETCFG_VIDEO = 58     ' Failed to modify video channel 
        NET_ERROR_SETCFG_RECORD = 59     ' Failed to modify record setup 
        NET_ERROR_SETCFG_485DECODER = 60     ' Failed to modify decoder property 
        NET_ERROR_SETCFG_232COM = 61     ' Failed to modify 232 COM setup 
        NET_ERROR_SETCFG_ALARMIN = 62     ' Failed to modify external input alarm setup
        NET_ERROR_SETCFG_ALARMDET = 63     ' Failed to modify motion detection alarm setup 
        NET_ERROR_SETCFG_SYSTIME = 64     ' Failed to modify device time 
        NET_ERROR_SETCFG_PREVIEW = 65     ' Failed to modify preview parameter
        NET_ERROR_SETCFG_AUTOMT = 66     ' Failed to modify auto maintenance setup 
        NET_ERROR_SETCFG_VIDEOMTRX = 67     ' Failed to modify video matrix setup 
        NET_ERROR_SETCFG_COVER = 68     ' Failed to modify privacy mask zone
        NET_ERROR_SETCFG_WATERMAKE = 69     ' Failed to modify video watermark setup 
        NET_ERROR_SETCFG_WLAN = 70     ' Failed to modify wireless network information 
        NET_ERROR_SETCFG_WLANDEV = 71     ' Failed to select wireless network device
        NET_ERROR_SETCFG_REGISTER = 72     ' Failed to modify the actively registration parameter setup.
        NET_ERROR_SETCFG_CAMERA = 73     ' Failed to modify camera property
        NET_ERROR_SETCFG_INFRARED = 74     ' Failed to modify IR alarm setup
        NET_ERROR_SETCFG_SOUNDALARM = 75     ' Failed to modify audio alarm setup
        NET_ERROR_SETCFG_STORAGE = 76     ' Failed to modify storage position setup
        NET_AUDIOENCODE_NOTINIT = 77     ' The audio encode port has not been successfully initialized. 
        NET_DATA_TOOLONGH = 78     ' The data are too long.
        NET_UNSUPPORTED = 79     ' The device does not support current operation. 
        NET_DEVICE_BUSY = 80     ' Device resources is not sufficient.
        NET_SERVER_STARTED = 81     ' The server has boot up 
        NET_SERVER_STOPPED = 82     ' The server has not fully boot up 
        NET_LISTER_INCORRECT_SERIAL = 83     ' Input serial number is not correct.
        NET_QUERY_DISKINFO_FAILED = 84     ' Failed to get HDD information.
        NET_ERROR_GETCFG_SESSION = 85     ' Failed to get connect session information.
        NET_USER_FLASEPWD_TRYTIME = 86     ' The password you typed is incorrect. You have exceeded the maximum number of retries.
        NET_LOGIN_ERROR_PASSWORD_EXPIRED = 99     ' password expired
        NET_LOGIN_ERROR_PASSWORD = 100    ' Password is not correct
        NET_LOGIN_ERROR_USER = 101    ' The account does not exist
        NET_LOGIN_ERROR_TIMEOUT = 102    ' Time out for log in returned value.
        NET_LOGIN_ERROR_RELOGGIN = 103    ' The account has logged in 
        NET_LOGIN_ERROR_LOCKED = 104    ' The account has been locked
        NET_LOGIN_ERROR_BLACKLIST = 105    ' The account has been in the black list
        NET_LOGIN_ERROR_BUSY = 106    ' Resources are not sufficient. System is busy now.
        NET_LOGIN_ERROR_CONNECT = 107    ' Time out. Please check network and try again.
        NET_LOGIN_ERROR_NETWORK = 108    ' Network connection failed.
        NET_LOGIN_ERROR_SUBCONNECT = 109    ' Successfully logged in the device but can not create video channel. Please check network connection.
        NET_LOGIN_ERROR_MAXCONNECT = 110    ' exceed the max connect number
        NET_LOGIN_ERROR_PROTOCOL3_ONLY = 111    ' protocol 3 support
        NET_LOGIN_ERROR_UKEY_LOST = 112    ' There is no USB or USB info error
        NET_LOGIN_ERROR_NO_AUTHORIZED = 113    ' Client-end IP address has no right to login
        NET_LOGIN_ERROR_USER_OR_PASSOWRD = 117    ' user or password error 
        NET_LOGIN_ERROR_DEVICE_NOT_INIT = 118   ' cannot login because the device has not been init,please init the device and then login
        NET_LOGIN_ERROR_LIMITED = 119    ' Limited login, it could be IP limited, time limited or expiration limited
        NET_RENDER_SOUND_ON_ERROR = 120    ' Error occurs when Render library open audio.
        NET_RENDER_SOUND_OFF_ERROR = 121    ' Error occurs when Render library close audio 
        NET_RENDER_SET_VOLUME_ERROR = 122    ' Error occurs when Render library control volume
        NET_RENDER_ADJUST_ERROR = 123    ' Error occurs when Render library set video parameter
        NET_RENDER_PAUSE_ERROR = 124    ' Error occurs when Render library pause play
        NET_RENDER_SNAP_ERROR = 125    ' Render library snapshot error
        NET_RENDER_STEP_ERROR = 126    ' Render library stepper error
        NET_RENDER_FRAMERATE_ERROR = 127    ' Error occurs when Render library set frame rate.
        NET_RENDER_DISPLAYREGION_ERROR = 128    ' Error occurs when Render lib setting show region
        NET_RENDER_GETOSDTIME_ERROR = 129    ' An error occurred when Render library getting current play time
        NET_GROUP_EXIST = 140    ' Group name has been existed.
        NET_GROUP_NOEXIST = 141    ' The group name does not exist. 
        NET_GROUP_RIGHTOVER = 142    ' The group right exceeds the right list!
        NET_GROUP_HAVEUSER = 143    ' The group can not be removed since there is user in it!
        NET_GROUP_RIGHTUSE = 144    ' The user has used one of the group right. It can not be removed. 
        NET_GROUP_SAMENAME = 145    ' New group name has been existed
        NET_USER_EXIST = 146    ' The user name has been existed
        NET_USER_NOEXIST = 147    ' The account does not exist.
        NET_USER_RIGHTOVER = 148    ' User right exceeds the group right. 
        NET_USER_PWD = 149    ' Reserved account. It does not allow to be modified.
        NET_USER_FLASEPWD = 150    ' password is not correct
        NET_USER_NOMATCHING = 151    ' Password is invalid
        NET_USER_INUSE = 152    ' account in use
        NET_ERROR_GETCFG_ETHERNET = 300    ' Failed to get network card setup.
        NET_ERROR_GETCFG_WLAN = 301    ' Failed to get wireless network information.
        NET_ERROR_GETCFG_WLANDEV = 302    ' Failed to get wireless network device.
        NET_ERROR_GETCFG_REGISTER = 303    ' Failed to get actively registration parameter.
        NET_ERROR_GETCFG_CAMERA = 304    ' Failed to get camera property 
        NET_ERROR_GETCFG_INFRARED = 305    ' Failed to get IR alarm setup
        NET_ERROR_GETCFG_SOUNDALARM = 306    ' Failed to get audio alarm setup
        NET_ERROR_GETCFG_STORAGE = 307    ' Failed to get storage position 
        NET_ERROR_GETCFG_MAIL = 308    ' Failed to get mail setup.
        NET_CONFIG_DEVBUSY = 309    ' Can not set right now. 
        NET_CONFIG_DATAILLEGAL = 310    ' The configuration setup data are illegal.
        NET_ERROR_GETCFG_DST = 311    ' Failed to get DST setup
        NET_ERROR_SETCFG_DST = 312    ' Failed to set DST 
        NET_ERROR_GETCFG_VIDEO_OSD = 313    ' Failed to get video OSD setup.
        NET_ERROR_SETCFG_VIDEO_OSD = 314    ' Failed to set video OSD 
        NET_ERROR_GETCFG_GPRSCDMA = 315    ' Failed to get CDMA\GPRS configuration
        NET_ERROR_SETCFG_GPRSCDMA = 316    ' Failed to set CDMA\GPRS configuration
        NET_ERROR_GETCFG_IPFILTER = 317    ' Failed to get IP Filter configuration
        NET_ERROR_SETCFG_IPFILTER = 318    ' Failed to set IP Filter configuration
        NET_ERROR_GETCFG_TALKENCODE = 319    ' Failed to get Talk Encode configuration
        NET_ERROR_SETCFG_TALKENCODE = 320    ' Failed to set Talk Encode configuration
        NET_ERROR_GETCFG_RECORDLEN = 321    ' Failed to get The length of the video package configuration
        NET_ERROR_SETCFG_RECORDLEN = 322    ' Failed to set The length of the video package configuration
        NET_DONT_SUPPORT_SUBAREA = 323    ' Not support Network hard disk partition
        NET_ERROR_GET_AUTOREGSERVER = 324    ' Failed to get the register server information
        NET_ERROR_CONTROL_AUTOREGISTER = 325    ' Failed to control actively registration
        NET_ERROR_DISCONNECT_AUTOREGISTER = 326    ' Failed to disconnect actively registration
        NET_ERROR_GETCFG_MMS = 327    ' Failed to get mms configuration
        NET_ERROR_SETCFG_MMS = 328    ' Failed to set mms configuration
        NET_ERROR_GETCFG_SMSACTIVATION = 329    ' Failed to get SMS configuration
        NET_ERROR_SETCFG_SMSACTIVATION = 330    ' Failed to set SMS configuration
        NET_ERROR_GETCFG_DIALINACTIVATION = 331    ' Failed to get activation of a wireless connection
        NET_ERROR_SETCFG_DIALINACTIVATION = 332    ' Failed to set activation of a wireless connection
        NET_ERROR_GETCFG_VIDEOOUT = 333    ' Failed to get the parameter of video output
        NET_ERROR_SETCFG_VIDEOOUT = 334    ' Failed to set the configuration of video output
        NET_ERROR_GETCFG_OSDENABLE = 335    ' Failed to get osd overlay enabling
        NET_ERROR_SETCFG_OSDENABLE = 336    ' Failed to set OSD overlay enabling
        NET_ERROR_SETCFG_ENCODERINFO = 337    ' Failed to set digital input configuration of front encoders
        NET_ERROR_GETCFG_TVADJUST = 338    ' Failed to get TV adjust configuration
        NET_ERROR_SETCFG_TVADJUST = 339    ' Failed to set TV adjust configuration
        NET_ERROR_CONNECT_FAILED = 340    ' Failed to request to establish a connection
        NET_ERROR_SETCFG_BURNFILE = 341    ' Failed to request to upload burn files
        NET_ERROR_SNIFFER_GETCFG = 342    ' Failed to get capture configuration information
        NET_ERROR_SNIFFER_SETCFG = 343    ' Failed to set capture configuration information
        NET_ERROR_DOWNLOADRATE_GETCFG = 344    ' Failed to get download restrictions information
        NET_ERROR_DOWNLOADRATE_SETCFG = 345    ' Failed to set download restrictions information
        NET_ERROR_SEARCH_TRANSCOM = 346    ' Failed to query serial port parameters
        NET_ERROR_GETCFG_POINT = 347    ' Failed to get the preset info
        NET_ERROR_SETCFG_POINT = 348    ' Failed to set the preset info
        NET_SDK_LOGOUT_ERROR = 349    ' SDK log out the device abnormally
        NET_ERROR_GET_VEHICLE_CFG = 350    ' Failed to get vehicle configuration
        NET_ERROR_SET_VEHICLE_CFG = 351    ' Failed to set vehicle configuration
        NET_ERROR_GET_ATM_OVERLAY_CFG = 352    ' Failed to get ATM overlay configuration
        NET_ERROR_SET_ATM_OVERLAY_CFG = 353    ' Failed to set ATM overlay configuration
        NET_ERROR_GET_ATM_OVERLAY_ABILITY = 354    ' Failed to get ATM overlay ability
        NET_ERROR_GET_DECODER_TOUR_CFG = 355    ' Failed to get decoder tour configuration
        NET_ERROR_SET_DECODER_TOUR_CFG = 356    ' Failed to set decoder tour configuration
        NET_ERROR_CTRL_DECODER_TOUR = 357    ' Failed to control decoder tour
        NET_GROUP_OVERSUPPORTNUM = 358    ' Beyond the device supports for the largest number of user groups
        NET_USER_OVERSUPPORTNUM = 359    ' Beyond the device supports for the largest number of users 
        NET_ERROR_GET_SIP_CFG = 368    ' Failed to get SIP configuration
        NET_ERROR_SET_SIP_CFG = 369    ' Failed to set SIP configuration
        NET_ERROR_GET_SIP_ABILITY = 370    ' Failed to get SIP capability
        NET_ERROR_GET_WIFI_AP_CFG = 371    ' Failed to get "WIFI ap' configuration 
        NET_ERROR_SET_WIFI_AP_CFG = 372    ' Failed to set "WIFI ap" configuration  
        NET_ERROR_GET_DECODE_POLICY = 373    ' Failed to get decode policy 
        NET_ERROR_SET_DECODE_POLICY = 374    ' Failed to set decode policy 
        NET_ERROR_TALK_REJECT = 375    ' refuse talk
        NET_ERROR_TALK_OPENED = 376    ' talk has opened by other client
        NET_ERROR_TALK_RESOURCE_CONFLICT = 377    ' resource conflict
        NET_ERROR_TALK_UNSUPPORTED_ENCODE = 378    ' unsupported encode type
        NET_ERROR_TALK_RIGHTLESS = 379    ' no right
        NET_ERROR_TALK_FAILED = 380    ' request failed
        NET_ERROR_GET_MACHINE_CFG = 381    ' Failed to get device relative config
        NET_ERROR_SET_MACHINE_CFG = 382    ' Failed to set device relative config
        NET_ERROR_GET_DATA_FAILED = 383    ' get data failed
        NET_ERROR_MAC_VALIDATE_FAILED = 384    ' MAC validate failed
        NET_ERROR_GET_INSTANCE = 385    ' Failed to get server instance 
        NET_ERROR_JSON_REQUEST = 386    ' Generated json string is error
        NET_ERROR_JSON_RESPONSE = 387    ' The responding json string is error
        NET_ERROR_VERSION_HIGHER = 388    ' The protocol version is lower than current version
        NET_SPARE_NO_CAPACITY = 389    ' Hotspare disk operation failed. The capacity is low
        NET_ERROR_SOURCE_IN_USE = 390    ' Display source is used by other output
        NET_ERROR_REAVE = 391    ' advanced users grab low-level user resource
        NET_ERROR_NETFORBID = 392    ' net forbid
        NET_ERROR_GETCFG_MACFILTER = 393    ' get MAC filter configuration error
        NET_ERROR_SETCFG_MACFILTER = 394    ' set MAC filter configuration error
        NET_ERROR_GETCFG_IPMACFILTER = 395    ' get IP/MAC filter configuration error
        NET_ERROR_SETCFG_IPMACFILTER = 396    ' set IP/MAC filter configuration error
        NET_ERROR_OPERATION_OVERTIME = 397    ' operation over time 
        NET_ERROR_SENIOR_VALIDATE_FAILED = 398    ' senior validation failure
        NET_ERROR_DEVICE_ID_NOT_EXIST = 399    ' device ID is not exist
        NET_ERROR_UNSUPPORTED = 400    ' unsupport operation
        NET_ERROR_PROXY_DLLLOAD = 401    ' proxy dll load error
        NET_ERROR_PROXY_ILLEGAL_PARAM = 402    ' proxy user parameter is not legal
        NET_ERROR_PROXY_INVALID_HANDLE = 403    ' handle invalid
        NET_ERROR_PROXY_LOGIN_DEVICE_ERROR = 404    ' login device error
        NET_ERROR_PROXY_START_SERVER_ERROR = 405    ' start proxy server error
        NET_ERROR_SPEAK_FAILED = 406    ' request speak failed
        NET_ERROR_NOT_SUPPORT_F6 = 407    ' unsupport F6
        NET_ERROR_CD_UNREADY = 408    ' CD is not ready
        NET_ERROR_DIR_NOT_EXIST = 409    ' Directory does not exist
        NET_ERROR_UNSUPPORTED_SPLIT_MODE = 410    ' The device does not support the segmentation model
        NET_ERROR_OPEN_WND_PARAM = 411    ' Open the window parameter is illegal
        NET_ERROR_LIMITED_WND_COUNT = 412    ' Open the window more than limit
        NET_ERROR_UNMATCHED_REQUEST = 413    ' Request command with the current pattern don't match
        NET_RENDER_ENABLELARGEPICADJUSTMENT_ERROR = 414 ' Render Library to enable high-definition image internal adjustment strategy error
        NET_ERROR_UPGRADE_FAILED = 415    ' Upgrade equipment failure
        NET_ERROR_NO_TARGET_DEVICE = 416    ' Can't find the target device
        NET_ERROR_NO_VERIFY_DEVICE = 417    ' Can't find the verify device 
        NET_ERROR_CASCADE_RIGHTLESS = 418    ' No cascade permissions
        NET_ERROR_LOW_PRIORITY = 419    ' low priority
        NET_ERROR_REMOTE_REQUEST_TIMEOUT = 420    ' The remote device request timeout
        NET_ERROR_LIMITED_INPUT_SOURCE = 421    ' Input source beyond maximum route restrictions
        NET_ERROR_SET_LOG_PRINT_INFO = 422    ' Failed to set log print
        NET_ERROR_PARAM_DWSIZE_ERROR = 423    ' "dwSize" is not initialized in input param
        NET_ERROR_LIMITED_MONITORWALL_COUNT = 424    ' TV wall exceed limit
        NET_ERROR_PART_PROCESS_FAILED = 425    ' Fail to execute part of the process
        NET_ERROR_TARGET_NOT_SUPPORT = 426    ' Fail to transmit due to not supported by target
        NET_ERROR_VISITE_FILE = 510    ' Access to the file failed
        NET_ERROR_DEVICE_STATUS_BUSY = 511    ' Device busy
        NET_USER_PWD_NOT_AUTHORIZED = 512    ' Fail to change the password
        NET_USER_PWD_NOT_STRONG = 513    ' Password strength is not enough
        NET_ERROR_NO_SUCH_CONFIG = 514    ' No corresponding setup
        NET_ERROR_AUDIO_RECORD_FAILED = 515    ' Failed to record audio
        NET_ERROR_SEND_DATA_FAILED = 516    ' Failed to send out data 
        NET_ERROR_OBSOLESCENT_INTERFACE = 517    ' Abandoned port 
        NET_ERROR_INSUFFICIENT_INTERAL_BUF = 518    ' Internal buffer is not sufficient 
        NET_ERROR_NEED_ENCRYPTION_PASSWORD = 519    ' verify password when changing device IP
        NET_ERROR_NOSUPPORT_RECORD = 520    ' device not support the record
        NET_ERROR_SERIALIZE_ERROR = 1010   ' Failed to serialize data
        NET_ERROR_DESERIALIZE_ERROR = 1011   ' Failed to deserialize data
        NET_ERROR_LOWRATEWPAN_ID_EXISTED = 1012   ' the wireless id is already existed
        NET_ERROR_LOWRATEWPAN_ID_LIMIT = 1013   ' the wireless id limited
        NET_ERROR_LOWRATEWPAN_ID_ABNORMAL = 1014   ' add the wireless id abnormaly
        NET_ERROR_ENCRYPT = 1015    ' encrypt data fail
        NET_ERROR_PWD_ILLEGAL = 1016    ' new password illegal
        NET_ERROR_DEVICE_ALREADY_INIT = 1017    ' device is already init
        NET_ERROR_SECURITY_CODE = 1018    ' security code check out fail
        NET_ERROR_SECURITY_CODE_TIMEOUT = 1019    ' security code out of time
        NET_ERROR_GET_PWD_SPECI = 1020    ' get passwd specification fail
        NET_ERROR_NO_AUTHORITY_OF_OPERATION = 1021    ' no authority of operation 
        NET_ERROR_DECRYPT = 1022    ' decrypt data fail
        NET_ERROR_2D_CODE = 1023    ' 2D code check out fail
        NET_ERROR_INVALID_REQUEST = 1024    ' invalid request
        NET_ERROR_PWD_RESET_DISABLE = 1025   ' pwd reset disabled
        NET_ERROR_PLAY_PRIVATE_DATA = 1026    ' failed to display private data,such as rule box
        NET_ERROR_ROBOT_OPERATE_FAILED = 1027    ' robot operate failed
        NET_ERROR_PHOTOSIZE_EXCEEDSLIMIT = 1028    ' photosize exceeds limit
        NET_ERROR_USERID_INVALID = 1029    ' userid invalid
        NET_ERROR_EXTRACTFEATURE_FAILED = 1030    ' photo extract feature failed
        NET_ERROR_PHOTO_EXIST = 1031    ' photo exist
        NET_ERROR_PHOTO_OVERFLOW = 1032    ' photo over flow
        NET_ERROR_CHANNEL_ALREADY_OPENED = 1033  ' channel has already been opened
        NET_ERROR_CREATE_SOCKET = 1034   ' create socket error
        NET_ERROR_CHANNEL_NUM = 1035     ' invalid channel num
        NET_ERROR_PHOTO_FORMAT = 1036    ' photo format error
    End Enum

    Public Function GetClientErrorDescription(nDeviceError As DEVICE_ERROR) As String

        Select Case nDeviceError
            Case DEVICE_ERROR.NET_NOERROR
                Return "No error "
            Case DEVICE_ERROR.NET_ERROR
                Return "Unknown error"
            Case DEVICE_ERROR.NET_SYSTEM_ERROR
                Return "system error"
            Case DEVICE_ERROR.NET_NETWORK_ERROR
                Return "Protocol error it may result from network timeout"
            Case DEVICE_ERROR.NET_DEV_VER_NOMATCH
                Return "Device protocol does not match "
            Case DEVICE_ERROR.NET_INVALID_HANDLE
                Return "Handle is invalid"
            Case DEVICE_ERROR.NET_OPEN_CHANNEL_ERROR
                Return "Failed to open channel "
            Case DEVICE_ERROR.NET_CLOSE_CHANNEL_ERROR
                Return "Failed to close channel "
            Case DEVICE_ERROR.NET_ILLEGAL_PARAM
                Return "User parameter is illegal "
            Case DEVICE_ERROR.NET_SDK_INIT_ERROR
                Return "SDK initialization error "
            Case DEVICE_ERROR.NET_SDK_UNINIT_ERROR
                Return "SDK clear error "
            Case DEVICE_ERROR.NET_RENDER_OPEN_ERROR
                Return "Error occurs when apply for render resources."
            Case DEVICE_ERROR.NET_DEC_OPEN_ERROR
                Return "Error occurs when opening the decoder library "
            Case DEVICE_ERROR.NET_DEC_CLOSE_ERROR
                Return "Error occurs when closing the decoder library "
            Case DEVICE_ERROR.NET_MULTIPLAY_NOCHANNEL
                Return "The detected channel number is 0 in multiple-channel preview. "
            Case DEVICE_ERROR.NET_TALK_INIT_ERROR
                Return "Failed to initialize record library "
            Case DEVICE_ERROR.NET_TALK_NOT_INIT
                Return "The record library has not been initialized"
            Case DEVICE_ERROR.NET_TALK_SENDDATA_ERROR
                Return "Error occurs when sending out audio data "
            Case DEVICE_ERROR.NET_REAL_ALREADY_SAVING
                Return "The real-time has been protected."
            Case DEVICE_ERROR.NET_NOT_SAVING
                Return "The real-time data has not been save."
            Case DEVICE_ERROR.NET_OPEN_FILE_ERROR
                Return "Error occurs when opening the file."
            Case DEVICE_ERROR.NET_PTZ_SET_TIMER_ERROR
                Return "Failed to enable PTZ to control timer."
            Case DEVICE_ERROR.NET_RETURN_DATA_ERROR
                Return "Error occurs when verify returned data."
            Case DEVICE_ERROR.NET_INSUFFICIENT_BUFFER
                Return "There is no sufficient buffer."
            Case DEVICE_ERROR.NET_NOT_SUPPORTED
                Return "The current SDK does not support this funcntion."
            Case DEVICE_ERROR.NET_NO_RECORD_FOUND
                Return "There is no searched result."
            Case DEVICE_ERROR.NET_NOT_AUTHORIZED
                Return "You have no operation right."
            Case DEVICE_ERROR.NET_NOT_NOW
                Return "Can not operate right now. "
            Case DEVICE_ERROR.NET_NO_TALK_CHANNEL
                Return "There is no audio talk channel."
            Case DEVICE_ERROR.NET_NO_AUDIO
                Return "There is no audio."
            Case DEVICE_ERROR.NET_NO_INIT
                Return "The network SDK has not been initialized."
            Case DEVICE_ERROR.NET_DOWNLOAD_END
                Return "The download completed."
            Case DEVICE_ERROR.NET_EMPTY_LIST
                Return "There is no searched result."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_SYSATTR
                Return "Failed to get system property setup."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_SERIAL
                Return "Failed to get SN."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_GENERAL
                Return "Failed to get general property."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_DSPCAP
                Return "Failed to get DSP capacity description."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_NETCFG
                Return "Failed to get network channel setup."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_CHANNAME
                Return "Failed to get channel name."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_VIDEO
                Return "Failed to get video property."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_RECORD
                Return "Failed to get record setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_PRONAME
                Return "Failed to get decoder protocol name "
            Case DEVICE_ERROR.NET_ERROR_GETCFG_FUNCNAME
                Return "Failed to get 232 COM function name."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_485DECODER
                Return "Failed to get decoder property"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_232COM
                Return "Failed to get 232 COM setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_ALARMIN
                Return "Failed to get external alarm input setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_ALARMDET
                Return "Failed to get motion detection alarm"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_SYSTIME
                Return "Failed to get device time"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_PREVIEW
                Return "Failed to get preview parameter"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_AUTOMT
                Return "Failed to get audio maintenance setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_VIDEOMTRX
                Return "Failed to get video matrix setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_COVER
                Return "Failed to get privacy mask zone setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_WATERMAKE
                Return "Failed to get video watermark setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_MULTICAST
                Return "Failed to get config, omulticast port by channel"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_GENERAL
                Return "Failed to modify general property"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_NETCFG
                Return "Failed to modify channel setup"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_CHANNAME
                Return "Failed to modify channel name"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_VIDEO
                Return "Failed to modify video channel "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_RECORD
                Return "Failed to modify record setup "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_485DECODER
                Return "Failed to modify decoder property "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_232COM
                Return "Failed to modify 232 COM setup "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_ALARMIN
                Return "Failed to modify external input alarm setup"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_ALARMDET
                Return "Failed to modify motion detection alarm setup "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_SYSTIME
                Return "Failed to modify device time "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_PREVIEW
                Return "Failed to modify preview parameter"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_AUTOMT
                Return "Failed to modify auto maintenance setup "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_VIDEOMTRX
                Return "Failed to modify video matrix setup "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_COVER
                Return "Failed to modify privacy mask zone"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_WATERMAKE
                Return "Failed to modify video watermark setup "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_WLAN
                Return "Failed to modify wireless network information "
            Case DEVICE_ERROR.NET_ERROR_SETCFG_WLANDEV
                Return "Failed to select wireless network device"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_REGISTER
                Return "Failed to modify the actively registration parameter setup."
            Case DEVICE_ERROR.NET_ERROR_SETCFG_CAMERA
                Return "Failed to modify camera property"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_INFRARED
                Return "Failed to modify IR alarm setup"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_SOUNDALARM
                Return "Failed to modify audio alarm setup"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_STORAGE
                Return "Failed to modify storage position setup"
            Case DEVICE_ERROR.NET_AUDIOENCODE_NOTINIT
                Return "The audio encode port has not been successfully initialized. "
            Case DEVICE_ERROR.NET_DATA_TOOLONGH
                Return "The data are too long."
            Case DEVICE_ERROR.NET_UNSUPPORTED
                Return "The device does not support current operation. "
            Case DEVICE_ERROR.NET_DEVICE_BUSY
                Return "Device resources is not sufficient."
            Case DEVICE_ERROR.NET_SERVER_STARTED
                Return "The server has boot up "
            Case DEVICE_ERROR.NET_SERVER_STOPPED
                Return "The server has not fully boot up "
            Case DEVICE_ERROR.NET_LISTER_INCORRECT_SERIAL
                Return "Input serial number is not correct."
            Case DEVICE_ERROR.NET_QUERY_DISKINFO_FAILED
                Return "Failed to get HDD information."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_SESSION
                Return "Failed to get connect session information."
            Case DEVICE_ERROR.NET_USER_FLASEPWD_TRYTIME
                Return "The password you typed is incorrect. You have exceeded the maximum number of retries."
            Case DEVICE_ERROR.NET_LOGIN_ERROR_PASSWORD_EXPIRED
                Return "password expired"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_PASSWORD
                Return "Password is not correct"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_USER
                Return "The account does not exist"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_TIMEOUT
                Return "Time out for log in returned value."
            Case DEVICE_ERROR.NET_LOGIN_ERROR_RELOGGIN
                Return "The account has logged in "
            Case DEVICE_ERROR.NET_LOGIN_ERROR_LOCKED
                Return "The account has been locked"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_BLACKLIST
                Return "The account has been in the black list"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_BUSY
                Return "Resources are not sufficient. System is busy now."
            Case DEVICE_ERROR.NET_LOGIN_ERROR_CONNECT
                Return "Time out. Please check network and try again."
            Case DEVICE_ERROR.NET_LOGIN_ERROR_NETWORK
                Return "Network connection failed."
            Case DEVICE_ERROR.NET_LOGIN_ERROR_SUBCONNECT
                Return "Successfully logged in the device but can not create video channel. Please check network connection."
            Case DEVICE_ERROR.NET_LOGIN_ERROR_MAXCONNECT
                Return "exceed the max connect number"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_PROTOCOL3_ONLY
                Return "protocol 3 support"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_UKEY_LOST
                Return "There is no USB or USB info error"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_NO_AUTHORIZED
                Return "Client-end IP address has no right to login"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_USER_OR_PASSOWRD
                Return "user or password error "
            Case DEVICE_ERROR.NET_LOGIN_ERROR_DEVICE_NOT_INIT
                Return "cannot login because the device has not been init,please init the device and then login"
            Case DEVICE_ERROR.NET_LOGIN_ERROR_LIMITED
                Return "Limited login, it could be IP limited, time limited or expiration limited"
            Case DEVICE_ERROR.NET_RENDER_SOUND_ON_ERROR
                Return "Error occurs when Render library open audio."
            Case DEVICE_ERROR.NET_RENDER_SOUND_OFF_ERROR
                Return "Error occurs when Render library close audio "
            Case DEVICE_ERROR.NET_RENDER_SET_VOLUME_ERROR
                Return "Error occurs when Render library control volume"
            Case DEVICE_ERROR.NET_RENDER_ADJUST_ERROR
                Return "Error occurs when Render library set video parameter"
            Case DEVICE_ERROR.NET_RENDER_PAUSE_ERROR
                Return "Error occurs when Render library pause play"
            Case DEVICE_ERROR.NET_RENDER_SNAP_ERROR
                Return "Render library snapshot error"
            Case DEVICE_ERROR.NET_RENDER_STEP_ERROR
                Return "Render library stepper error"
            Case DEVICE_ERROR.NET_RENDER_FRAMERATE_ERROR
                Return "Error occurs when Render library set frame rate."
            Case DEVICE_ERROR.NET_RENDER_DISPLAYREGION_ERROR
                Return "Error occurs when Render lib setting show region"
            Case DEVICE_ERROR.NET_RENDER_GETOSDTIME_ERROR
                Return "An error occurred when Render library getting current play time"
            Case DEVICE_ERROR.NET_GROUP_EXIST
                Return "Group name has been existed."
            Case DEVICE_ERROR.NET_GROUP_NOEXIST
                Return "The group name does not exist. "
            Case DEVICE_ERROR.NET_GROUP_RIGHTOVER
                Return "The group right exceeds the right list!"
            Case DEVICE_ERROR.NET_GROUP_HAVEUSER
                Return "The group can not be removed since there is user in it!"
            Case DEVICE_ERROR.NET_GROUP_RIGHTUSE
                Return "The user has used one of the group right. It can not be removed. "
            Case DEVICE_ERROR.NET_GROUP_SAMENAME
                Return "New group name has been existed"
            Case DEVICE_ERROR.NET_USER_EXIST
                Return "The user name has been existed"
            Case DEVICE_ERROR.NET_USER_NOEXIST
                Return "The account does not exist."
            Case DEVICE_ERROR.NET_USER_RIGHTOVER
                Return "User right exceeds the group right. "
            Case DEVICE_ERROR.NET_USER_PWD
                Return "Reserved account. It does not allow to be modified."
            Case DEVICE_ERROR.NET_USER_FLASEPWD
                Return "password is not correct"
            Case DEVICE_ERROR.NET_USER_NOMATCHING
                Return "Password is invalid"
            Case DEVICE_ERROR.NET_USER_INUSE
                Return "account in use"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_ETHERNET
                Return "Failed to get network card setup."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_WLAN
                Return "Failed to get wireless network information."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_WLANDEV
                Return "Failed to get wireless network device."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_REGISTER
                Return "Failed to get actively registration parameter."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_CAMERA
                Return "Failed to get camera property "
            Case DEVICE_ERROR.NET_ERROR_GETCFG_INFRARED
                Return "Failed to get IR alarm setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_SOUNDALARM
                Return "Failed to get audio alarm setup"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_STORAGE
                Return "Failed to get storage position "
            Case DEVICE_ERROR.NET_ERROR_GETCFG_MAIL
                Return "Failed to get mail setup."
            Case DEVICE_ERROR.NET_CONFIG_DEVBUSY
                Return "Can not set right now. "
            Case DEVICE_ERROR.NET_CONFIG_DATAILLEGAL
                Return "The configuration setup data are illegal."
            Case DEVICE_ERROR.NET_ERROR_GETCFG_DST
                Return "Failed to get DST setup"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_DST
                Return "Failed to set DST "
            Case DEVICE_ERROR.NET_ERROR_GETCFG_VIDEO_OSD
                Return "Failed to get video OSD setup."
            Case DEVICE_ERROR.NET_ERROR_SETCFG_VIDEO_OSD
                Return "Failed to set video OSD "
            Case DEVICE_ERROR.NET_ERROR_GETCFG_GPRSCDMA
                Return "Failed to get CDMA\GPRS configuration"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_GPRSCDMA
                Return "Failed to set CDMA\GPRS configuration"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_IPFILTER
                Return "Failed to get IP Filter configuration"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_IPFILTER
                Return "Failed to set IP Filter configuration"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_TALKENCODE
                Return "Failed to get Talk Encode configuration"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_TALKENCODE
                Return "Failed to set Talk Encode configuration"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_RECORDLEN
                Return "Failed to get The length of the video package configuration"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_RECORDLEN
                Return "Failed to set The length of the video package configuration"
            Case DEVICE_ERROR.NET_DONT_SUPPORT_SUBAREA
                Return "Not support Network hard disk partition"
            Case DEVICE_ERROR.NET_ERROR_GET_AUTOREGSERVER
                Return "Failed to get the register server information"
            Case DEVICE_ERROR.NET_ERROR_CONTROL_AUTOREGISTER
                Return "Failed to control actively registration"
            Case DEVICE_ERROR.NET_ERROR_DISCONNECT_AUTOREGISTER
                Return "Failed to disconnect actively registration"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_MMS
                Return "Failed to get mms configuration"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_MMS
                Return "Failed to set mms configuration"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_SMSACTIVATION
                Return "Failed to get SMS configuration"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_SMSACTIVATION
                Return "Failed to set SMS configuration"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_DIALINACTIVATION
                Return "Failed to get activation of a wireless connection"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_DIALINACTIVATION
                Return "Failed to set activation of a wireless connection"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_VIDEOOUT
                Return "Failed to get the parameter of video output"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_VIDEOOUT
                Return "Failed to set the configuration of video output"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_OSDENABLE
                Return "Failed to get osd overlay enabling"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_OSDENABLE
                Return "Failed to set OSD overlay enabling"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_ENCODERINFO
                Return "Failed to set digital input configuration of front encoders"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_TVADJUST
                Return "Failed to get TV adjust configuration"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_TVADJUST
                Return "Failed to set TV adjust configuration"
            Case DEVICE_ERROR.NET_ERROR_CONNECT_FAILED
                Return "Failed to request to establish a connection"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_BURNFILE
                Return "Failed to request to upload burn files"
            Case DEVICE_ERROR.NET_ERROR_SNIFFER_GETCFG
                Return "Failed to get capture configuration information"
            Case DEVICE_ERROR.NET_ERROR_SNIFFER_SETCFG
                Return "Failed to set capture configuration information"
            Case DEVICE_ERROR.NET_ERROR_DOWNLOADRATE_GETCFG
                Return "Failed to get download restrictions information"
            Case DEVICE_ERROR.NET_ERROR_DOWNLOADRATE_SETCFG
                Return "Failed to set download restrictions information"
            Case DEVICE_ERROR.NET_ERROR_SEARCH_TRANSCOM
                Return "Failed to query serial port parameters"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_POINT
                Return "Failed to get the preset info"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_POINT
                Return "Failed to set the preset info"
            Case DEVICE_ERROR.NET_SDK_LOGOUT_ERROR
                Return "SDK log out the device abnormally"
            Case DEVICE_ERROR.NET_ERROR_GET_VEHICLE_CFG
                Return "Failed to get vehicle configuration"
            Case DEVICE_ERROR.NET_ERROR_SET_VEHICLE_CFG
                Return "Failed to set vehicle configuration"
            Case DEVICE_ERROR.NET_ERROR_GET_ATM_OVERLAY_CFG
                Return "Failed to get ATM overlay configuration"
            Case DEVICE_ERROR.NET_ERROR_SET_ATM_OVERLAY_CFG
                Return "Failed to set ATM overlay configuration"
            Case DEVICE_ERROR.NET_ERROR_GET_ATM_OVERLAY_ABILITY
                Return "Failed to get ATM overlay ability"
            Case DEVICE_ERROR.NET_ERROR_GET_DECODER_TOUR_CFG
                Return "Failed to get decoder tour configuration"
            Case DEVICE_ERROR.NET_ERROR_SET_DECODER_TOUR_CFG
                Return "Failed to set decoder tour configuration"
            Case DEVICE_ERROR.NET_ERROR_CTRL_DECODER_TOUR
                Return "Failed to control decoder tour"
            Case DEVICE_ERROR.NET_GROUP_OVERSUPPORTNUM
                Return "Beyond the device supports for the largest number of user groups"
            Case DEVICE_ERROR.NET_USER_OVERSUPPORTNUM
                Return "Beyond the device supports for the largest number of users "
            Case DEVICE_ERROR.NET_ERROR_GET_SIP_CFG
                Return "Failed to get SIP configuration"
            Case DEVICE_ERROR.NET_ERROR_SET_SIP_CFG
                Return "Failed to set SIP configuration"
            Case DEVICE_ERROR.NET_ERROR_GET_SIP_ABILITY
                Return "Failed to get SIP capability"
            Case DEVICE_ERROR.NET_ERROR_GET_WIFI_AP_CFG
                Return "Failed to get WIFI ap configuration "
            Case DEVICE_ERROR.NET_ERROR_SET_WIFI_AP_CFG
                Return "Failed To Set WIFI ap configuration  "
            Case DEVICE_ERROR.NET_ERROR_GET_DECODE_POLICY
                Return "Failed to get decode policy "
            Case DEVICE_ERROR.NET_ERROR_SET_DECODE_POLICY
                Return "Failed to set decode policy "
            Case DEVICE_ERROR.NET_ERROR_TALK_REJECT
                Return "refuse talk"
            Case DEVICE_ERROR.NET_ERROR_TALK_OPENED
                Return "talk has opened by other client"
            Case DEVICE_ERROR.net_ERROR_TALK_RESOURCE_CONFLICT
                Return "resource conflict"
            Case DEVICE_ERROR.NET_ERROR_TALK_UNSUPPORTED_ENCODE
                Return "unsupported encode type"
            Case DEVICE_ERROR.NET_ERROR_TALK_RIGHTLESS
                Return "no right"
            Case DEVICE_ERROR.NET_ERROR_TALK_FAILED
                Return "request failed"
            Case DEVICE_ERROR.NET_ERROR_GET_MACHINE_CFG
                Return "Failed to get device relative config"
            Case DEVICE_ERROR.NET_ERROR_SET_MACHINE_CFG
                Return "Failed to set device relative config"
            Case DEVICE_ERROR.NET_ERROR_GET_DATA_FAILED
                Return "get data failed"
            Case DEVICE_ERROR.NET_ERROR_MAC_VALIDATE_FAILED
                Return "MAC validate failed"
            Case DEVICE_ERROR.NET_ERROR_GET_INSTANCE
                Return "Failed to get server instance "
            Case DEVICE_ERROR.NET_ERROR_JSON_REQUEST
                Return "Generated json string is error"
            Case DEVICE_ERROR.NET_ERROR_JSON_RESPONSE
                Return "The responding json string is error"
            Case DEVICE_ERROR.NET_ERROR_VERSION_HIGHER
                Return "The protocol version is lower than current version"
            Case DEVICE_ERROR.NET_SPARE_NO_CAPACITY
                Return "Hotspare disk operation failed. The capacity is low"
            Case DEVICE_ERROR.NET_ERROR_SOURCE_IN_USE
                Return "Display source is used by other output"
            Case DEVICE_ERROR.NET_ERROR_REAVE
                Return "advanced users grab low-level user resource"
            Case DEVICE_ERROR.NET_ERROR_NETFORBID
                Return "net forbid"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_MACFILTER
                Return "get MAC filter configuration error"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_MACFILTER
                Return "set MAC filter configuration error"
            Case DEVICE_ERROR.NET_ERROR_GETCFG_IPMACFILTER
                Return "get IP/MAC filter configuration error"
            Case DEVICE_ERROR.NET_ERROR_SETCFG_IPMACFILTER
                Return "set IP/MAC filter configuration error"
            Case DEVICE_ERROR.NET_ERROR_OPERATION_OVERTIME
                Return "operation over time "
            Case DEVICE_ERROR.NET_ERROR_SENIOR_VALIDATE_FAILED
                Return "senior validation failure"
            Case DEVICE_ERROR.NET_ERROR_DEVICE_ID_NOT_EXIST
                Return "device ID is not exist"
            Case DEVICE_ERROR.NET_ERROR_UNSUPPORTED
                Return "unsupport operation"
            Case DEVICE_ERROR.NET_ERROR_PROXY_DLLLOAD
                Return "proxy dll load error"
            Case DEVICE_ERROR.NET_ERROR_PROXY_ILLEGAL_PARAM
                Return "proxy user parameter is not legal"
            Case DEVICE_ERROR.NET_ERROR_PROXY_INVALID_HANDLE
                Return "handle invalid"
            Case DEVICE_ERROR.NET_ERROR_PROXY_LOGIN_DEVICE_ERROR
                Return "login device error"
            Case DEVICE_ERROR.NET_ERROR_PROXY_START_SERVER_ERROR
                Return "start proxy server error"
            Case DEVICE_ERROR.NET_ERROR_SPEAK_FAILED
                Return "request speak failed"
            Case DEVICE_ERROR.NET_ERROR_NOT_SUPPORT_F6
                Return "unsupport F6"
            Case DEVICE_ERROR.NET_ERROR_CD_UNREADY
                Return "CD is not ready"
            Case DEVICE_ERROR.NET_ERROR_DIR_NOT_EXIST
                Return "Directory does not exist"
            Case DEVICE_ERROR.NET_ERROR_UNSUPPORTED_SPLIT_MODE
                Return "The device does not support the segmentation model"
            Case DEVICE_ERROR.NET_ERROR_OPEN_WND_PARAM
                Return "Open the window parameter is illegal"
            Case DEVICE_ERROR.NET_ERROR_LIMITED_WND_COUNT
                Return "Open the window more than limit"
            Case DEVICE_ERROR.NET_ERROR_UNMATCHED_REQUEST
                Return "Request command with the current pattern don't match"
            Case DEVICE_ERROR.NET_RENDER_ENABLELARGEPICADJUSTMENT_ERROR
                Return "Render Library to enable high-definition image internal adjustment strategy error"
            Case DEVICE_ERROR.NET_ERROR_UPGRADE_FAILED
                Return "Upgrade equipment failure"
            Case DEVICE_ERROR.NET_ERROR_NO_TARGET_DEVICE
                Return "Can't find the target device"
            Case DEVICE_ERROR.NET_ERROR_NO_VERIFY_DEVICE
                Return "Can't find the verify device "
            Case DEVICE_ERROR.NET_ERROR_CASCADE_RIGHTLESS
                Return "No cascade permissions"
            Case DEVICE_ERROR.NET_ERROR_LOW_PRIORITY
                Return "low priority"
            Case DEVICE_ERROR.NET_ERROR_REMOTE_REQUEST_TIMEOUT
                Return "The remote device request timeout"
            Case DEVICE_ERROR.NET_ERROR_LIMITED_INPUT_SOURCE
                Return "Input source beyond maximum route restrictions"
            Case DEVICE_ERROR.NET_ERROR_SET_LOG_PRINT_INFO
                Return "Failed to set log print"
            Case DEVICE_ERROR.NET_ERROR_PARAM_DWSIZE_ERROR
                Return "dwSize is not initialized in input param"
            Case DEVICE_ERROR.NET_ERROR_LIMITED_MONITORWALL_COUNT
                Return "TV wall exceed limit"
            Case DEVICE_ERROR.NET_ERROR_PART_PROCESS_FAILED
                Return "Fail to execute part of the process"
            Case DEVICE_ERROR.NET_ERROR_TARGET_NOT_SUPPORT
                Return "Fail to transmit due to not supported by target"
            Case DEVICE_ERROR.NET_ERROR_VISITE_FILE
                Return "Access to the file failed"
            Case DEVICE_ERROR.NET_ERROR_DEVICE_STATUS_BUSY
                Return "Device busy"
            Case DEVICE_ERROR.NET_USER_PWD_NOT_AUTHORIZED
                Return "Fail to change the password"
            Case DEVICE_ERROR.NET_USER_PWD_NOT_STRONG
                Return "Password strength is not enough"
            Case DEVICE_ERROR.NET_ERROR_NO_SUCH_CONFIG
                Return "No corresponding setup"
            Case DEVICE_ERROR.NET_ERROR_AUDIO_RECORD_FAILED
                Return "Failed to record audio"
            Case DEVICE_ERROR.NET_ERROR_SEND_DATA_FAILED
                Return "Failed to send out data "
            Case DEVICE_ERROR.NET_ERROR_OBSOLESCENT_INTERFACE
                Return "Abandoned port "
            Case DEVICE_ERROR.NET_ERROR_INSUFFICIENT_INTERAL_BUF
                Return "Internal buffer is not sufficient "
            Case DEVICE_ERROR.NET_ERROR_NEED_ENCRYPTION_PASSWORD
                Return "verify password when changing device IP"
            Case DEVICE_ERROR.NET_ERROR_NOSUPPORT_RECORD
                Return "device not support the record"
            Case DEVICE_ERROR.NET_ERROR_SERIALIZE_ERROR
                Return "Failed to serialize data"
            Case DEVICE_ERROR.NET_ERROR_DESERIALIZE_ERROR
                Return "Failed to deserialize data"
            Case DEVICE_ERROR.NET_ERROR_LOWRATEWPAN_ID_EXISTED
                Return "the wireless id is already existed"
            Case DEVICE_ERROR.NET_ERROR_LOWRATEWPAN_ID_LIMIT
                Return "the wireless id limited"
            Case DEVICE_ERROR.NET_ERROR_LOWRATEWPAN_ID_ABNORMAL
                Return "add the wireless id abnormaly"
            Case DEVICE_ERROR.NET_ERROR_ENCRYPT
                Return "encrypt data fail"
            Case DEVICE_ERROR.NET_ERROR_PWD_ILLEGAL
                Return "new password illegal"
            Case DEVICE_ERROR.NET_ERROR_DEVICE_ALREADY_INIT
                Return "device is already init"
            Case DEVICE_ERROR.NET_ERROR_SECURITY_CODE
                Return "security code check out fail"
            Case DEVICE_ERROR.NET_ERROR_SECURITY_CODE_TIMEOUT
                Return "security code out of time"
            Case DEVICE_ERROR.NET_ERROR_GET_PWD_SPECI
                Return "get passwd specification fail"
            Case DEVICE_ERROR.NET_ERROR_NO_AUTHORITY_OF_OPERATION
                Return "no authority of operation "
            Case DEVICE_ERROR.NET_ERROR_DECRYPT
                Return "decrypt data fail"
            Case DEVICE_ERROR.NET_ERROR_2D_CODE
                Return "2D code check out fail"
            Case DEVICE_ERROR.NET_ERROR_INVALID_REQUEST
                Return "invalid request"
            Case DEVICE_ERROR.NET_ERROR_PWD_RESET_DISABLE
                Return "pwd reset disabled"
            Case DEVICE_ERROR.NET_ERROR_PLAY_PRIVATE_DATA
                Return "failed to display private data,such as rule box"
            Case DEVICE_ERROR.NET_ERROR_ROBOT_OPERATE_FAILED
                Return "robot operate failed"
            Case DEVICE_ERROR.NET_ERROR_PHOTOSIZE_EXCEEDSLIMIT
                Return "photosize exceeds limit"
            Case DEVICE_ERROR.NET_ERROR_USERID_INVALID
                Return "userid invalid"
            Case DEVICE_ERROR.NET_ERROR_EXTRACTFEATURE_FAILED
                Return "photo extract feature failed"
            Case DEVICE_ERROR.NET_ERROR_PHOTO_EXIST
                Return "photo exist"
            Case DEVICE_ERROR.NET_ERROR_PHOTO_OVERFLOW
                Return "photo over flow"
            Case DEVICE_ERROR.NET_ERROR_CHANNEL_ALREADY_OPENED
                Return "channel has already been opened"
            Case DEVICE_ERROR.NET_ERROR_CREATE_SOCKET
                Return "create socket error"
            Case DEVICE_ERROR.NET_ERROR_CHANNEL_NUM
                Return "invalid channel num"
            Case DEVICE_ERROR.NET_ERROR_PHOTO_FORMAT
                Return "photo format error"
            Case Else
                Return "Unknown error code: " & nDeviceError
        End Select
    End Function
End Module
