namespace PrinterSDK {
    public enum Epos2ErrorStatus
    {
        Success = 0,
        ErrParam,
        ErrConnect,
        ErrTimeout,
        ErrMemory,
        ErrIllegal,
        ErrProcessing,
        ErrNotFound,
        ErrInUse,
        ErrTypeInvalid,
        ErrDisconnect,
        ErrAlreadyOpened,
        ErrAlreadyUsed,
        ErrBoxCountOver,
        ErrBoxClientOver,
        ErrUnsupported,
        ErrDeviceBusy,
        ErrRecoveryFailure,
        ErrFailure = 255
    }

    public enum Epos2CallbackCode
    {
        Success = 0,
        ErrTimeout,
        ErrNotFound,
        ErrAutorecover,
        ErrCoverOpen,
        ErrCutter,
        ErrMechanical,
        ErrEmpty,
        ErrUnrecoverable,
        ErrSystem,
        ErrPort,
        ErrInvalidWindow,
        ErrJobNotFound,
        Printing,
        ErrSpooler,
        ErrBatteryLow,
        ErrTooManyRequests,
        ErrRequestEntityTooLarge,
        Canceled,
        ErrNoMicrData,
        ErrIllegalLength,
        ErrNoMagneticData,
        ErrRecognition,
        ErrRead,
        ErrNoiseDetected,
        ErrPaperJam,
        ErrPaperPulledOut,
        ErrCancelFailed,
        ErrPaperType,
        ErrWaitInsertion,
        ErrIllegal,
        ErrInserted,
        ErrWaitRemoval,
        ErrDeviceBusy,
        ErrGetJsonSize,
        ErrInUse,
        ErrConnect,
        ErrDisconnect,
        ErrDifferentModel,
        ErrDifferentVersion,
        ErrMemory,
        ErrProcessing,
        ErrDataCorrupted,
        ErrParam,
        Retry,
        ErrRecoveryFailure,
        ErrJsonFormat,
        NoPassword,
        ErrInvalidPassword,
        ErrInvalidFirmVersion,
        ErrSslCertification,
        ErrFailure = 255
    }

    public enum Epos2PrinterSeries
    {
        MM10 = 0,
        MM30,
        MP20,
        MP60,
        MP60ii,
        MP80,
        MT20,
        MT60,
        MT70,
        MT81,
        MT82,
        MT83,
        MT88,
        MT90,
        MT90kp,
        MU220,
        MU330,
        ML90,
        MH6000,
        MT83iii,
        MT100,
        MM30ii,
        S100,
        MM50,
        MT88vii,
        ML90lfc,
        ML100,
        MP20ii,
        MP80ii,
        MM30iii,
        MM50ii,
        MM55,
        MU220ii
    }

    public enum Epos2DisplayModel
    {
        Epos2DmD30 = 0,
        Epos2DmD110,
        Epos2DmD210,
        Epos2DmD70
    }

    public enum Epos2ModelLang
    {
        Ank = 0,
        Japanese,
        Chinese,
        Taiwan,
        Korean,
        Thai,
        Southasia
    }

    public enum Epos2DeviceModel
    {
        Epos2ModelAll = 0
    }

    public enum Epos2PortType
    {
        All = 0,
        Tcp,
        Bluetooth,
        Usb,
        BluetoothLe
    }

    public enum Epos2StatusPaper
    {
        Ok = 0,
        NearEnd,
        Empty
    }

    public enum Epos2PanelSwitch
    {
        Ff = 0,
        N
    }

    public enum Epos2StatusDrawer
    {
        High = 0,
        Low
    }

    public enum Epos2PrinterError
    {
        NoErr = 0,
        MechanicalErr,
        AutocutterErr,
        UnrecoverErr,
        AutorecoverErr
    }

    public enum Epos2AutoRecoverError
    {
        HeadOverheat = 0,
        MotorOverheat,
        BatteryOverheat,
        WrongPaper,
        CoverOpen
    }

    public enum Epos2BatteryLevel
    {
        Epos2BatteryLevel0 = 0,
        Epos2BatteryLevel1,
        Epos2BatteryLevel2,
        Epos2BatteryLevel3,
        Epos2BatteryLevel4,
        Epos2BatteryLevel5,
        Epos2BatteryLevel6
    }

    public enum Epos2UnrecoverError
    {
        HighVoltageErr,
        LowVoltageErr
    }

    public enum Epos2InsertionWaiting
    {
        Slip = 0,
        Validation,
        Micr,
        None
    }

    public enum Epos2RemovalWaiting
    {
        Paper = 0,
        None
    }

    public enum Epos2PaperTakenSensor
    {
        Paper = 0,
        PaperNone,
        Unknown
    }

    public enum Epos2WifiSignal
    {
        No = 0,
        Fail,
        Good,
        Excellent
    }

    public enum Epos2StatusSlipPaper
    {
        Ok = 0,
        Empty
    }

    public enum Epos2StatusEvent
    {
        Online = 0,
        Offline,
        PowerOff,
        CoverClose,
        CoverOpen,
        PaperOk,
        PaperNearEnd,
        PaperEmpty,
        DrawerHigh,
        DrawerLow,
        BatteryEnough,
        BatteryEmpty,
        InsertionWaitSlip,
        InsertionWaitValidation,
        InsertionWaitMicr,
        InsertionWaitNone,
        RemovalWaitPaper,
        RemovalWaitNone,
        SlipPaperOk,
        SlipPaperEmpty,
        AutoRecoverError,
        AutoRecoverOk,
        UnrecoverableError,
        RemovalDetectPaper,
        RemovalDetectPaperNone,
        RemovalDetectUnkown
    }

    public enum Epos2ConnectionEvent
    {
        Reconnecting = 0,
        Reconnect,
        Disconnect
    }

    public enum Epos2DeviceType
    {
        All = 0,
        Printer,
        HybridPrinter,
        Display,
        Keyboard,
        Scanner,
        Serial,
        Cchanger,
        PosKeyboard,
        Cat,
        Msr,
        OtherPeripheral,
        Gfe
    }

    public enum Epos2Align
    {
        Left = 0,
        Center,
        Right
    }

    public enum Epos2Lang
    {
        En = 0,
        Ja,
        ZhCn,
        ZhTw,
        Ko,
        Th,
        Vi,
        Multi
    }

    public enum Epos2Font
    {
        A = 0,
        B,
        C,
        D,
        E
    }

    public enum Epos2Color
    {
        None = 0,
        Epos2Color1,
        Epos2Color2,
        Epos2Color3,
        Epos2Color4
    }

    public enum Epos2Mode
    {
        Mono = 0,
        Gray16,
        MonoHighDensity
    }

    public enum Epos2Halftone
    {
        Dither = 0,
        ErrorDiffusion,
        Threshold
    }

    public enum Epos2Compress
    {
        Deflate = 0,
        None,
        Auto
    }

    public enum Epos2Barcode
    {
        UpcA = 0,
        UpcE,
        Ean13,
        Jan13,
        Ean8,
        Jan8,
        Code39,
        Itf,
        Codabar,
        Code93,
        Code128,
        Gs1128,
        Gs1DatabarOmnidirectional,
        Gs1DatabarTruncated,
        Gs1DatabarLimited,
        Gs1DatabarExpanded,
        Code128Auto
    }

    public enum Epos2Hri
    {
        None = 0,
        Above,
        Below,
        Both
    }

    public enum Epos2Symbol
    {
        Pdf417Standard = 0,
        Pdf417Truncated,
        QrcodeModel1,
        QrcodeModel2,
        QrcodeMicro,
        MaxicodeMode2,
        MaxicodeMode3,
        MaxicodeMode4,
        MaxicodeMode5,
        MaxicodeMode6,
        Gs1DatabarStacked,
        Gs1DatabarStackedOmnidirectional,
        Gs1DatabarExpandedStacked,
        AzteccodeFullrange,
        AzteccodeCompact,
        DatamatrixSquare,
        DatamatrixRectangle8,
        DatamatrixRectangle12,
        DatamatrixRectangle16
    }

    public enum Epos2Level
    {
        Epos2Level0 = 0,
        Epos2Level1,
        Epos2Level2,
        Epos2Level3,
        Epos2Level4,
        Epos2Level5,
        Epos2Level6,
        Epos2Level7,
        Epos2Level8,
        L,
        M,
        Q,
        H
    }

    public enum Epos2Line
    {
        Thin = 0,
        Medium,
        Thick,
        ThinDouble,
        MediumDouble,
        ThickDouble
    }

    public enum Epos2Direction
    {
        LeftToRight = 0,
        BottomToTop,
        RightToLeft,
        TopToBottom
    }

    public enum Epos2Cut
    {
        CutFeed = 0,
        CutNoFeed,
        CutReserve,
        FullCutFeed,
        FullCutNoFeed,
        FullCutReserve
    }

    public enum Epos2Drawer
    {
        Epos2Drawer2pin = 0,
        Epos2Drawer5pin
    }

    public enum Epos2Pulse
    {
        Epos2Pulse100 = 0,
        Epos2Pulse200,
        Epos2Pulse300,
        Epos2Pulse400,
        Epos2Pulse500
    }

    public enum Epos2Pattern
    {
        None = 0,
        A,
        B,
        C,
        D,
        E,
        Error,
        PaperEmpty,
        Epos2Pattern1,
        Epos2Pattern2,
        Epos2Pattern3,
        Epos2Pattern4,
        Epos2Pattern5,
        Epos2Pattern6,
        Epos2Pattern7,
        Epos2Pattern8,
        Epos2Pattern9,
        Epos2Pattern10
    }

    public enum Epos2FeedPosition
    {
        Peeling = 0,
        Cutting,
        CurrentTof,
        NextTof
    }

    public enum Epos2Layout
    {
        Receipt = 0,
        ReceiptBm,
        Label,
        LabelBm
    }

    public enum Epos2Papertype
    {
        Receipt = 0,
        Slip,
        Endorse,
        Validation
    }

    public enum Epos2MicrFont
    {
        E13b = 0,
        Cmc7
    }

    public enum Epos2HybridPrinterMethod
    {
        Waitinsertion = 0,
        Senddata,
        Cancelinsertion,
        Ejectpaper,
        Readmicrdata,
        Cleanmicrreader
    }

    public enum Epos2Scroll
    {
        Overwrite = 0,
        Vertical,
        Horizontal
    }

    public enum Epos2Format
    {
        Walk = 0,
        Place
    }

    public enum Epos2Brightness
    {
        Epos2Brightness20 = 0,
        Epos2Brightness40,
        Epos2Brightness60,
        Epos2Brightness100
    }

    public enum Epos2CursorPosition
    {
        TopLeft = 0,
        TopRight,
        BottomLeft,
        BottomRight
    }

    public enum Epos2CursorType
    {
        None = 0,
        Underline
    }

    public enum Epos2LayoutMode
    {
        LayoutMode1 = 0,
        LayoutMode2,
        LayoutMode3,
        LayoutMode4,
        LayoutMode5,
        LayoutMode6,
        LayoutMode7,
        LayoutMode8,
        LayoutMode9,
        LayoutMode10,
        LayoutMode11,
        LayoutMode12,
        LayoutMode13,
        LayoutMode14,
        LayoutMode15,
        LandscapeLayoutMode1,
        LandscapeLayoutMode2,
        LandscapeLayoutMode3,
        LandscapeLayoutMode4,
        LandscapeLayoutMode5,
        PortraitLayoutMode1,
        PortraitLayoutMode2,
        PortraitLayoutMode3,
        PortraitLayoutMode4,
        PortraitLayoutMode5,
        PortraitLayoutMode6,
        PortraitLayoutMode7
    }

    public enum Epos2RowType
    {
        EvenRows = -10,
        OddRows = -11,
        AllRows = -12
    }

    public enum Epos2CountMode
    {
        ManualInput = 0,
        AutoCount
    }

    public enum Epos2Deposit
    {
        Change = 0,
        Nochange,
        Repay
    }

    public enum Epos2Collect
    {
        AllCash = 0,
        PartOfCash
    }

    public enum Epos2CChangerStatus
    {
        Busy = 0,
        Pause,
        End,
        Err
    }

    public enum Epos2CashStatus
    {
        Empty = 0,
        NearEmpty,
        Ok,
        NearFull,
        Full
    }

    public enum Epos2CChangerCallbackCode
    {
        Success = 0,
        Busy,
        Discrepancy,
        ErrCashInTray,
        ErrShortage,
        ErrRejectUnit,
        ErrOposcode,
        ErrUnsupported,
        ErrParam,
        ErrCommand,
        ErrDevice,
        ErrSystem,
        ErrFailure
    }

    public enum Epos2CChangerStatusUpdateEvent
    {
        PowerOnline = 2001,
        PowerOff = 2002,
        PowerOffline = 2003,
        PowerOffOffline = 2004,
        StatusEmpty = 11,
        StatusNearempty = 12,
        StatusEmptyok = 13,
        StatusFull = 21,
        StatusNearfull = 22,
        StatusFullok = 23,
        StatusJam = 31,
        StatusJamok = 32
    }

    public enum Epos2CATCallbackCode
    {
        Success = 0,
        Busy,
        ExceedingLimit,
        Disagreement,
        InvalidCard,
        Reset,
        ErrCenter,
        ErrOposcode,
        ErrParam,
        ErrDevice,
        ErrSystem,
        ErrTimeout,
        ErrFailure,
        ErrCommand,
        AbortFailure
    }

    public enum Epos2CATService
    {
        Credit = 0,
        Debit,
        Unionpay,
        Edy,
        Id,
        Nanaco,
        Quicpay,
        Suica,
        Waon,
        Point,
        Common,
        Nfcpayment,
        Pitapa,
        Fisc,
        Qr,
        CreditDebit,
        Multi
    }

    public enum Epos2CATPaymentCondition
    {
        LumpSum = 0,
        Bonus1,
        Bonus2,
        Bonus3,
        Installment1,
        Installment2,
        Revolving,
        Combination1,
        Combination2,
        Debit,
        ElectronicMoney,
        Other,
        Bonus4,
        Bonus5,
        Installment3,
        Combination3,
        Combination4
    }

    public enum Epos2CATStatusUpdateEvent
    {
        PowerOnline = 2001,
        PowerOffOffline = 2004,
        LogstatusOk = 0,
        LogstatusNearfull = 1,
        LogstatusFull = 2
    }

    public enum Epos2LogPeriod
    {
        Temporary = 0,
        Permanent
    }

    public enum Epos2LogOutput
    {
        Disable = 0,
        Storage,
        Tcp
    }

    public enum Epos2LogLevel
    {
        Epos2LoglevelLow = 0
    }

    public enum Epos2MaintenanceCounterType
    {
        Paperfeed = 0,
        Autocutter
    }

    public enum Epos2PrinterSettingType
    {
        Aperwidth = 0,
        Rintdensity,
        Rintspeed
    }

    public enum Epos2PrinterSettingPaperWidth
    {
        Epos2PrinterSettingPaperwidth580 = 2,
        Epos2PrinterSettingPaperwidth600 = 3,
        Epos2PrinterSettingPaperwidth700 = 4,
        Epos2PrinterSettingPaperwidth760 = 5,
        Epos2PrinterSettingPaperwidth800 = 6
    }

    public enum Epos2PrinterSettingPrintDensity
    {
        Dip = 100,
        Epos2PrinterSettingPrintdensity70 = 65530,
        Epos2PrinterSettingPrintdensity75 = 65531,
        Epos2PrinterSettingPrintdensity80 = 65532,
        Epos2PrinterSettingPrintdensity85 = 65533,
        Epos2PrinterSettingPrintdensity90 = 65534,
        Epos2PrinterSettingPrintdensity95 = 65535,
        Epos2PrinterSettingPrintdensity100 = 0,
        Epos2PrinterSettingPrintdensity105 = 1,
        Epos2PrinterSettingPrintdensity110 = 2,
        Epos2PrinterSettingPrintdensity115 = 3,
        Epos2PrinterSettingPrintdensity120 = 4,
        Epos2PrinterSettingPrintdensity125 = 5,
        Epos2PrinterSettingPrintdensity130 = 6
    }

    public enum Epos2PrinterSettingPrintSpeed
    {
        Epos2PrinterSettingPrintspeed1 = 1,
        Epos2PrinterSettingPrintspeed2 = 2,
        Epos2PrinterSettingPrintspeed3 = 3,
        Epos2PrinterSettingPrintspeed4 = 4,
        Epos2PrinterSettingPrintspeed5 = 5,
        Epos2PrinterSettingPrintspeed6 = 6,
        Epos2PrinterSettingPrintspeed7 = 7,
        Epos2PrinterSettingPrintspeed8 = 8,
        Epos2PrinterSettingPrintspeed9 = 9,
        Epos2PrinterSettingPrintspeed10 = 10,
        Epos2PrinterSettingPrintspeed11 = 11,
        Epos2PrinterSettingPrintspeed12 = 12,
        Epos2PrinterSettingPrintspeed13 = 13,
        Epos2PrinterSettingPrintspeed14 = 14,
        Epos2PrinterSettingPrintspeed15 = 15,
        Epos2PrinterSettingPrintspeed16 = 16,
        Epos2PrinterSettingPrintspeed17 = 17
    }

    public enum Epos2BtConnection
    {
        Success = 0,
        ErrParam,
        ErrUnsupported,
        ErrCancel,
        ErrAlreadyConnect,
        ErrIllegalDevice,
        ErrFailure = 255
    }
}


