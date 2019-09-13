
#pragma warning disable 162

namespace HowToCallSQLStoredProcedureWithoutInputs
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class RcvTriggerCommonType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RcvTriggerCommonType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RcvTriggerCommonType(RcvTriggerCommonType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RcvTriggerCommonType p = new RcvTriggerCommonType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RcvTriggerCommonType),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToCallSQLStoredProcedureWithoutInputs.TriggerSchema _schema = new HowToCallSQLStoredProcedureWithoutInputs.TriggerSchema();

        public __HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToCallSQLStoredProcedureWithoutInputs.TriggerSchema",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.TriggerSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema__)
        },
        0,
        @"http://HowToCallSQLStoredProcedureWithoutInputs.TriggerSchema#TriggerSchema"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes _schema = new HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes();

        public __HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#usp_GetCodes"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse _schema = new HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse();

        public __HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#usp_GetCodesResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "GetCodes",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput), 
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLOrdersCommonSPType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLOrdersCommonSPType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLOrdersCommonSPType(SQLOrdersCommonSPType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLOrdersCommonSPType p = new SQLOrdersCommonSPType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo GetCodes = new Microsoft.XLANGs.Core.OperationInfo
        (
            "GetCodes",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SQLOrdersCommonSPType),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "GetCodes" ] = GetCodes;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy _schema = new HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy();

        public __HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy__)
        },
        0,
        @"http://HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy#TriggerCrazy"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary _schema = new HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary();

        public __HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary__)
        },
        0,
        @"http://HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary#TriggerUnnecessary"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SendSQLResultCommonType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendSQLResultCommonType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendSQLResultCommonType(SendSQLResultCommonType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendSQLResultCommonType p = new SendSQLResultCommonType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendSQLResultCommonType),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "TriggerOp",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class RcvTriggerType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RcvTriggerType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RcvTriggerType(RcvTriggerType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RcvTriggerType p = new RcvTriggerType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo TriggerOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "TriggerOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RcvTriggerType),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "TriggerOp" ] = TriggerOp;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "GetCodes",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes), 
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLOrdersType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLOrdersType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLOrdersType(SQLOrdersType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLOrdersType p = new SQLOrdersType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo GetCodes = new Microsoft.XLANGs.Core.OperationInfo
        (
            "GetCodes",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SQLOrdersType),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "GetCodes" ] = GetCodes;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SendSQLResultType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendSQLResultType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendSQLResultType(SendSQLResultType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendSQLResultType p = new SendSQLResultType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendSQLResultType),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class RcvTriggerCrazyType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RcvTriggerCrazyType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RcvTriggerCrazyType(RcvTriggerCrazyType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RcvTriggerCrazyType p = new RcvTriggerCrazyType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RcvTriggerCrazyType),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.__messagetype_HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class RcvTriggerUnnecessarType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RcvTriggerUnnecessarType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RcvTriggerUnnecessarType(RcvTriggerUnnecessarType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RcvTriggerUnnecessarType p = new RcvTriggerUnnecessarType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RcvTriggerUnnecessarType),
            typeof(__messagetype_HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 246 "C:\Development\HowToCallSQLStoredProcedureWithoutInputs\HowToCallSQLStoredProcedureWithoutInputs\01-MostCommonSituation\MostCommonSituationCallSQLStoredProcedure.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvTriggerCommonPort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(HowToCallSQLStoredProcedureWithoutInputs.RcvTriggerCommonType),
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SQLOrdersCommonSPType),
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SendSQLResultCommonType)
        },
        new System.String[] {
            "RcvTriggerCommonPort",
            "SQLOrdersCommonSPPort",
            "SendSQLResultCommonPort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class MostCommonSituationCallSQLStoredProcedure : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(MostCommonSituationCallSQLStoredProcedure));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static MostCommonSituationCallSQLStoredProcedure()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __MostCommonSituationCallSQLStoredProcedure_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public MostCommonSituationCallSQLStoredProcedure(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "MostCommonSituationCallSQLStoredProcedure", tracker)
        {
            ConstructorHelper();
        }

        public MostCommonSituationCallSQLStoredProcedure(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "MostCommonSituationCallSQLStoredProcedure")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>ee3c0eb9-538b-427e-b48d-214ae827c077</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b057303b-29b5-4a18-bc32-02e754f74f93</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Trigger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a7639265-f3e0-49af-80b1-8cf10c4b78c5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct SQL GetCodes Req Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>a6affb42-13f0-45da-9173-4c3d4492355d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>GetCodes Transform</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>e69f64e5-c2d1-4e7c-96a9-d3f61f836cb1</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5a1a0c57-da95-4838-a2f7-9e6f98696758</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a78ddacc-4d0b-452b-842b-79f9658474ce</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>ce378774-1e0f-4653-a0ac-21ba3f88a9bb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send GetCodes</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>2c51241b-1ffb-4dbb-874a-d963dd24ef7b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive GetCodes Resp</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>915e6b1c-60cc-4313-ab0f-2062096ce527</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SQL Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'MostCommonSituationCallSQLStoredProcedure'</ActionName><IsAtomic>0</IsAtomic><Line>246</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>260</Line><Position>22</Position><ShapeID>'b057303b-29b5-4a18-bc32-02e754f74f93'</ShapeID>
<Messages>
	<MsgInfo><name>msgTriggerCommon</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>262</Line><Position>13</Position><ShapeID>'a7639265-f3e0-49af-80b1-8cf10c4b78c5'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesReq</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo+usp_GetCodesWithDummyInput</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgTriggerCommon</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>268</Line><Position>13</Position><ShapeID>'ce378774-1e0f-4653-a0ac-21ba3f88a9bb'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesReq</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo+usp_GetCodesWithDummyInput</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>270</Line><Position>13</Position><ShapeID>'2c51241b-1ffb-4dbb-874a-d963dd24ef7b'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesResp</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo+usp_GetCodesWithDummyInputResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>272</Line><Position>13</Position><ShapeID>'915e6b1c-60cc-4313-ab0f-2062096ce527'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesResp</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo+usp_GetCodesWithDummyInputResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='e4d1394d-3345-46e8-bbed-ac1072d0302a' LowerBound='1.1' HigherBound='56.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='HowToCallSQLStoredProcedureWithoutInputs' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8da9c206-d294-4dde-a93e-1f9404a69a1c' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvTriggerCommonType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ddd65f8f-2e93-4652-b94f-bd2b471fe1af' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='7bbc47eb-ba16-4092-9e3c-127e30ef969f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.50'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='d32589f6-d5b2-442f-9c13-046d69470bf4' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SQLOrdersCommonSPType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6a7ea0c4-a522-4aab-8785-b6d385ab8ddf' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GetCodes' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='9843cfce-ca66-49a2-a9c3-f2fed4dadd0d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.69'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInput' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='8a8bdc34-579a-4e39-85a1-5571a28992b3' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.71' HigherBound='15.135'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInputResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='4af0ad8e-50c7-4ef5-ba3e-3323a3094330' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendSQLResultCommonType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e9b97aba-92e6-406e-8001-45797242ea15' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='8a6cca0a-d7b4-4df7-ab61-6d2d2924cc44' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.77'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInputResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='57bbf11b-91f0-4e53-9cba-6db60e57dc15' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='55.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MostCommonSituationCallSQLStoredProcedure' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='4b80b84d-05c7-486c-893e-8aed0d0ceab8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgTriggerCommon' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='934c31be-8ff0-4524-8ef3-151f2cf23d83' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInput' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLGetCodesReq' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='125c0769-a60b-4f96-acd9-b1604a822b56' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInputResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLGetCodesResp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='ee3c0eb9-538b-427e-b48d-214ae827c077' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='b057303b-29b5-4a18-bc32-02e754f74f93' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='41.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvTriggerCommonPort' />
                    <om:Property Name='MessageName' Value='msgTriggerCommon' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Trigger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='a7639265-f3e0-49af-80b1-8cf10c4b78c5' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='47.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct SQL GetCodes Req Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='a6affb42-13f0-45da-9173-4c3d4492355d' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='46.1'>
                        <om:Property Name='ClassName' Value='HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.mapTriggerToSQLGetCodes' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='GetCodes Transform' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='e69f64e5-c2d1-4e7c-96a9-d3f61f836cb1' ParentLink='Transform_InputMessagePartRef' LowerBound='45.139' HigherBound='45.155'>
                            <om:Property Name='MessageRef' Value='msgTriggerCommon' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='5a1a0c57-da95-4838-a2f7-9e6f98696758' ParentLink='Transform_OutputMessagePartRef' LowerBound='45.28' HigherBound='45.45'>
                            <om:Property Name='MessageRef' Value='msgSQLGetCodesReq' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='a78ddacc-4d0b-452b-842b-79f9658474ce' ParentLink='Construct_MessageRef' LowerBound='42.23' HigherBound='42.40'>
                        <om:Property Name='Ref' Value='msgSQLGetCodesReq' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='ce378774-1e0f-4653-a0ac-21ba3f88a9bb' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='49.1'>
                    <om:Property Name='PortName' Value='SQLOrdersCommonSPPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesReq' />
                    <om:Property Name='OperationName' Value='GetCodes' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send GetCodes' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='2c51241b-1ffb-4dbb-874a-d963dd24ef7b' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='51.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SQLOrdersCommonSPPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesResp' />
                    <om:Property Name='OperationName' Value='GetCodes' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive GetCodes Resp' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='915e6b1c-60cc-4313-ab0f-2062096ce527' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='53.1'>
                    <om:Property Name='PortName' Value='SendSQLResultCommonPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesResp' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SQL Result' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d46741dc-8203-4e3b-8572-82b8ac929f2d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.RcvTriggerCommonType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvTriggerCommonPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='19a11cf1-fa94-46bf-876e-d21a0e414933' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='342b9668-952d-4e04-9261-3972b41a43ee' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='13' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQLOrdersCommonSPType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLOrdersCommonSPPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='36f92278-f85b-4cb0-a80c-3effe43eabe6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='93a3c97a-d7a9-4e0a-92d4-9356e43f06af' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='18' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SendSQLResultCommonType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSQLResultCommonPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='b8e10d45-37ca-4ca7-9ef1-1d819359e75a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __MostCommonSituationCallSQLStoredProcedure_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __MostCommonSituationCallSQLStoredProcedure_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MostCommonSituationCallSQLStoredProcedure")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                MostCommonSituationCallSQLStoredProcedure __svc__ = (MostCommonSituationCallSQLStoredProcedure)_service;
                __MostCommonSituationCallSQLStoredProcedure_root_0 __ctx0__ = (__MostCommonSituationCallSQLStoredProcedure_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RcvTriggerCommonPort != null)
                {
                    __svc__.RcvTriggerCommonPort.Close(this, null);
                    __svc__.RcvTriggerCommonPort = null;
                }
                if (__svc__.SendSQLResultCommonPort != null)
                {
                    __svc__.SendSQLResultCommonPort.Close(this, null);
                    __svc__.SendSQLResultCommonPort = null;
                }
                if (__svc__.SQLOrdersCommonSPPort != null)
                {
                    __svc__.SQLOrdersCommonSPPort.Close(this, null);
                    __svc__.SQLOrdersCommonSPPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __MostCommonSituationCallSQLStoredProcedure_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __MostCommonSituationCallSQLStoredProcedure_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MostCommonSituationCallSQLStoredProcedure")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                MostCommonSituationCallSQLStoredProcedure __svc__ = (MostCommonSituationCallSQLStoredProcedure)_service;
                __MostCommonSituationCallSQLStoredProcedure_root_0 __ctx0__ = (__MostCommonSituationCallSQLStoredProcedure_root_0)(__svc__._stateMgrs[0]);
                __MostCommonSituationCallSQLStoredProcedure_1 __ctx1__ = (__MostCommonSituationCallSQLStoredProcedure_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgTriggerCommon != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerCommon);
                    __ctx1__.__msgTriggerCommon = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesResp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                    __ctx1__.__msgSQLGetCodesResp = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgTriggerCommon")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon __msgTriggerCommon;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLGetCodesReq")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput __msgSQLGetCodesReq;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLGetCodesResp")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse __msgSQLGetCodesResp;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvTriggerCommonPort")]
        internal RcvTriggerCommonType RcvTriggerCommonPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SQLOrdersCommonSPPort")]
        internal SQLOrdersCommonSPType SQLOrdersCommonSPPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendSQLResultCommonPort")]
        internal SendSQLResultCommonType SendSQLResultCommonPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RcvTriggerCommonType.Operation_1},
                                               typeof(MostCommonSituationCallSQLStoredProcedure).GetField("RcvTriggerCommonPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MostCommonSituationCallSQLStoredProcedure), "RcvTriggerCommonPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SQLOrdersCommonSPType.GetCodes},
                                               typeof(MostCommonSituationCallSQLStoredProcedure).GetField("SQLOrdersCommonSPPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MostCommonSituationCallSQLStoredProcedure), "SQLOrdersCommonSPPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendSQLResultCommonType.Operation_1},
                                               typeof(MostCommonSituationCallSQLStoredProcedure).GetField("SendSQLResultCommonPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MostCommonSituationCallSQLStoredProcedure), "SendSQLResultCommonPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "b057303b-29b5-4a18-bc32-02e754f74f93", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "b057303b-29b5-4a18-bc32-02e754f74f93", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "a7639265-f3e0-49af-80b1-8cf10c4b78c5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "a7639265-f3e0-49af-80b1-8cf10c4b78c5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "ce378774-1e0f-4653-a0ac-21ba3f88a9bb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "ce378774-1e0f-4653-a0ac-21ba3f88a9bb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "2c51241b-1ffb-4dbb-874a-d963dd24ef7b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "2c51241b-1ffb-4dbb-874a-d963dd24ef7b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "915e6b1c-60cc-4313-ab0f-2062096ce527", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "915e6b1c-60cc-4313-ab0f-2062096ce527", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __MostCommonSituationCallSQLStoredProcedure_root_0 __ctx0__ = (__MostCommonSituationCallSQLStoredProcedure_root_0)_stateMgrs[0];
            __MostCommonSituationCallSQLStoredProcedure_1 __ctx1__ = (__MostCommonSituationCallSQLStoredProcedure_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                RcvTriggerCommonPort = new RcvTriggerCommonType(0, this);
                SQLOrdersCommonSPPort = new SQLOrdersCommonSPType(1, this);
                SendSQLResultCommonPort = new SendSQLResultCommonType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvTriggerCommonPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __MostCommonSituationCallSQLStoredProcedure_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __MostCommonSituationCallSQLStoredProcedure_root_0 __ctx0__ = (__MostCommonSituationCallSQLStoredProcedure_root_0)_stateMgrs[0];
            __MostCommonSituationCallSQLStoredProcedure_1 __ctx1__ = (__MostCommonSituationCallSQLStoredProcedure_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!RcvTriggerCommonPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgTriggerCommon != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerCommon);
                __ctx1__.__msgTriggerCommon = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon("msgTriggerCommon", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgTriggerCommon);
                RcvTriggerCommonPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgTriggerCommon, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvTriggerCommonPort != null)
                {
                    RcvTriggerCommonPort.Close(__ctx1__, __seg__);
                    RcvTriggerCommonPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgTriggerCommon);
                    __edata.PortName = @"RcvTriggerCommonPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput __msgSQLGetCodesReq = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput("msgSQLGetCodesReq", __ctx1__);

                    ApplyTransform(typeof(HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.mapTriggerToSQLGetCodes), new object[] {__msgSQLGetCodesReq.part}, new object[] {__ctx1__.__msgTriggerCommon.part});

                    if (__ctx1__.__msgSQLGetCodesReq != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = __msgSQLGetCodesReq;
                    __ctx1__.RefMessage(__ctx1__.__msgSQLGetCodesReq);
                }
                __ctx1__.__msgSQLGetCodesReq.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesReq);
                    __edata.Messages.Add(__ctx1__.__msgTriggerCommon);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgTriggerCommon != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerCommon);
                    __ctx1__.__msgTriggerCommon = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SQLOrdersCommonSPPort.SendMessage(0, __ctx1__.__msgSQLGetCodesReq, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesReq);
                    __edata.PortName = @"SQLOrdersCommonSPPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!SQLOrdersCommonSPPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgSQLGetCodesResp != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                __ctx1__.__msgSQLGetCodesResp = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse("msgSQLGetCodesResp", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgSQLGetCodesResp);
                SQLOrdersCommonSPPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgSQLGetCodesResp, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SQLOrdersCommonSPPort != null)
                {
                    SQLOrdersCommonSPPort.Close(__ctx1__, __seg__);
                    SQLOrdersCommonSPPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesResp);
                    __edata.PortName = @"SQLOrdersCommonSPPort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendSQLResultCommonPort.SendMessage(0, __ctx1__.__msgSQLGetCodesResp, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendSQLResultCommonPort != null)
                {
                    SendSQLResultCommonPort.Close(__ctx1__, __seg__);
                    SendSQLResultCommonPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesResp);
                    __edata.PortName = @"SendSQLResultCommonPort";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesResp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                    __ctx1__.__msgSQLGetCodesResp = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 22;
            case 22:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{FC68A91B-F9AD-4132-BCED-F59BC90A591A}"))
        };

    }
    //#line 242 "C:\Development\HowToCallSQLStoredProcedureWithoutInputs\HowToCallSQLStoredProcedureWithoutInputs\CallSQLStoredProcedure.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvTriggerPort", "TriggerOp", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(HowToCallSQLStoredProcedureWithoutInputs.RcvTriggerType),
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SQLOrdersType),
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SendSQLResultType)
        },
        new System.String[] {
            "RcvTriggerPort",
            "SQLOrdersPort",
            "SendSQLResultPort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class CallSQLStoredProcedure : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(CallSQLStoredProcedure));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static CallSQLStoredProcedure()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __CallSQLStoredProcedure_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public CallSQLStoredProcedure(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "CallSQLStoredProcedure", tracker)
        {
            ConstructorHelper();
        }

        public CallSQLStoredProcedure(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "CallSQLStoredProcedure")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>33fbe054-483d-496a-8060-bdb483c1e86e</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>d53f7aea-2227-4bee-b8e9-9048f3445ec6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Trigger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>9840e70a-714c-4b0e-b103-d46df5ebab6e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct SQL GetCodes Req Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>eeca612b-2939-4c56-a04c-be4a557f2d74</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>GetCodes MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>532ddcb1-9c09-4c11-9bf8-603690dba861</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>797a6444-cf2c-455a-af36-e8a07505673a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send GetCodes</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>0351fe9f-1a7c-46de-a613-885bd6bea5fd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive GetCodes Resp</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9fdcd42f-8d54-4e3d-8f13-ed1a3cc0f63c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SQL Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'CallSQLStoredProcedure'</ActionName><IsAtomic>0</IsAtomic><Line>242</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>257</Line><Position>22</Position><ShapeID>'d53f7aea-2227-4bee-b8e9-9048f3445ec6'</ShapeID>
<Messages>
	<MsgInfo><name>msgTrigger</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.TriggerSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>260</Line><Position>13</Position><ShapeID>'9840e70a-714c-4b0e-b103-d46df5ebab6e'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesReq</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>268</Line><Position>13</Position><ShapeID>'797a6444-cf2c-455a-af36-e8a07505673a'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesReq</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>270</Line><Position>13</Position><ShapeID>'0351fe9f-1a7c-46de-a613-885bd6bea5fd'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesResp</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodesResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>272</Line><Position>13</Position><ShapeID>'9fdcd42f-8d54-4e3d-8f13-ed1a3cc0f63c'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesResp</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodesResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='abf47476-1d9c-41d5-b1fe-1398084d8171' LowerBound='1.1' HigherBound='60.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='HowToCallSQLStoredProcedureWithoutInputs' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='32361bd7-2f35-46d6-a019-069f9c6909ca' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvTriggerType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ae24ba88-4a9c-4541-b696-86a7c815e1f5' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TriggerOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='a3eda4e9-51ce-4a64-aa86-49f373f8ac40' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.26'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs.TriggerSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='7911346c-c75b-440d-a08d-1b170b91268e' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SQLOrdersType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b880e994-18fa-4d27-88af-8f111fa4892c' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GetCodes' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='2a8ffe63-0103-44e6-a18c-b8378efe4a53' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.48'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='1a800ea9-fbfa-426b-96cc-6948bbf6a234' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.50' HigherBound='15.93'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='4cd2c5fc-5cdb-494d-8921-e6bc6b13dd74' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendSQLResultType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='9ee6bf95-c244-4272-aac6-c5e636143806' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='1acedab5-feab-4df3-9950-0a564c938cd3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.56'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='8cb5b59d-5b8c-4b4b-8aaa-e0dfbaf67c3b' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='59.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CallSQLStoredProcedure' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='566f29d8-c0d1-47ee-ad59-75380966a14f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='12f440c8-b0ff-4a25-9199-771d9c895e10' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.TriggerSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgTrigger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='1404f768-ec3e-4cd3-92cb-297bfcfdb987' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLGetCodesReq' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='104b2620-9581-4b1c-8ba9-682857eca170' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLGetCodesResp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='33fbe054-483d-496a-8060-bdb483c1e86e' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='d53f7aea-2227-4bee-b8e9-9048f3445ec6' ParentLink='ServiceBody_Statement' LowerBound='40.1' HigherBound='43.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvTriggerPort' />
                    <om:Property Name='MessageName' Value='msgTrigger' />
                    <om:Property Name='OperationName' Value='TriggerOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Trigger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='9840e70a-714c-4b0e-b103-d46df5ebab6e' ParentLink='ServiceBody_Statement' LowerBound='43.1' HigherBound='51.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct SQL GetCodes Req Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='eeca612b-2939-4c56-a04c-be4a557f2d74' ParentLink='ComplexStatement_Statement' LowerBound='46.1' HigherBound='50.1'>
                        <om:Property Name='Expression' Value='varXML  = new System.Xml.XmlDocument();&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:usp_GetCodes xmlns:ns0=&quot;&quot;http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo&quot;&quot; /&gt; &quot;);&#xD;&#xA;msgSQLGetCodesReq = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='GetCodes MsgAssign' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='532ddcb1-9c09-4c11-9bf8-603690dba861' ParentLink='Construct_MessageRef' LowerBound='44.23' HigherBound='44.40'>
                        <om:Property Name='Ref' Value='msgSQLGetCodesReq' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='797a6444-cf2c-455a-af36-e8a07505673a' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='53.1'>
                    <om:Property Name='PortName' Value='SQLOrdersPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesReq' />
                    <om:Property Name='OperationName' Value='GetCodes' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send GetCodes' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='0351fe9f-1a7c-46de-a613-885bd6bea5fd' ParentLink='ServiceBody_Statement' LowerBound='53.1' HigherBound='55.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SQLOrdersPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesResp' />
                    <om:Property Name='OperationName' Value='GetCodes' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive GetCodes Resp' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='9fdcd42f-8d54-4e3d-8f13-ed1a3cc0f63c' ParentLink='ServiceBody_Statement' LowerBound='55.1' HigherBound='57.1'>
                    <om:Property Name='PortName' Value='SendSQLResultPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesResp' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SQL Result' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='2ba444ce-e5f4-438e-8dfd-64dfb3c1ae8c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.RcvTriggerType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvTriggerPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='239c215f-6290-44a8-bb52-05ed6a29702d' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8707d9a5-eb6f-4fb6-b3b4-23cbafcf0bd5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='17' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQLOrdersType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLOrdersPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='d29a0d48-6035-465a-acf7-735f9b28e5b3' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='657123ba-8326-4f7b-88f3-99e5a5402c01' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='20' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SendSQLResultType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSQLResultPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='38770f6e-e30c-4de5-ba40-4826d1597f64' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __CallSQLStoredProcedure_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __CallSQLStoredProcedure_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CallSQLStoredProcedure")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CallSQLStoredProcedure __svc__ = (CallSQLStoredProcedure)_service;
                __CallSQLStoredProcedure_root_0 __ctx0__ = (__CallSQLStoredProcedure_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SQLOrdersPort != null)
                {
                    __svc__.SQLOrdersPort.Close(this, null);
                    __svc__.SQLOrdersPort = null;
                }
                if (__svc__.SendSQLResultPort != null)
                {
                    __svc__.SendSQLResultPort.Close(this, null);
                    __svc__.SendSQLResultPort = null;
                }
                if (__svc__.RcvTriggerPort != null)
                {
                    __svc__.RcvTriggerPort.Close(this, null);
                    __svc__.RcvTriggerPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __CallSQLStoredProcedure_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __CallSQLStoredProcedure_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CallSQLStoredProcedure")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CallSQLStoredProcedure __svc__ = (CallSQLStoredProcedure)_service;
                __CallSQLStoredProcedure_1 __ctx1__ = (__CallSQLStoredProcedure_1)(__svc__._stateMgrs[1]);
                __CallSQLStoredProcedure_root_0 __ctx0__ = (__CallSQLStoredProcedure_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesResp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                    __ctx1__.__msgSQLGetCodesResp = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgTrigger != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTrigger);
                    __ctx1__.__msgTrigger = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgTrigger")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema __msgTrigger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLGetCodesReq")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes __msgSQLGetCodesReq;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLGetCodesResp")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse __msgSQLGetCodesResp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varXML")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __varXML;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvTriggerPort")]
        internal RcvTriggerType RcvTriggerPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SQLOrdersPort")]
        internal SQLOrdersType SQLOrdersPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendSQLResultPort")]
        internal SendSQLResultType SendSQLResultPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RcvTriggerType.TriggerOp},
                                               typeof(CallSQLStoredProcedure).GetField("RcvTriggerPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CallSQLStoredProcedure), "RcvTriggerPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SQLOrdersType.GetCodes},
                                               typeof(CallSQLStoredProcedure).GetField("SQLOrdersPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CallSQLStoredProcedure), "SQLOrdersPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendSQLResultType.Operation_1},
                                               typeof(CallSQLStoredProcedure).GetField("SendSQLResultPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CallSQLStoredProcedure), "SendSQLResultPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "d53f7aea-2227-4bee-b8e9-9048f3445ec6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "d53f7aea-2227-4bee-b8e9-9048f3445ec6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "9840e70a-714c-4b0e-b103-d46df5ebab6e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "9840e70a-714c-4b0e-b103-d46df5ebab6e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "797a6444-cf2c-455a-af36-e8a07505673a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "797a6444-cf2c-455a-af36-e8a07505673a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "0351fe9f-1a7c-46de-a613-885bd6bea5fd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "0351fe9f-1a7c-46de-a613-885bd6bea5fd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "9fdcd42f-8d54-4e3d-8f13-ed1a3cc0f63c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "9fdcd42f-8d54-4e3d-8f13-ed1a3cc0f63c", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,6,7,8,8,9,10,10,10,11,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CallSQLStoredProcedure_1 __ctx1__ = (__CallSQLStoredProcedure_1)_stateMgrs[1];
            __CallSQLStoredProcedure_root_0 __ctx0__ = (__CallSQLStoredProcedure_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RcvTriggerPort = new RcvTriggerType(0, this);
                SQLOrdersPort = new SQLOrdersType(1, this);
                SendSQLResultPort = new SendSQLResultType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvTriggerPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __CallSQLStoredProcedure_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __CallSQLStoredProcedure_1 __ctx1__ = (__CallSQLStoredProcedure_1)_stateMgrs[1];
            __CallSQLStoredProcedure_root_0 __ctx0__ = (__CallSQLStoredProcedure_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varXML = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!RcvTriggerPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgTrigger != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgTrigger);
                __ctx1__.__msgTrigger = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_TriggerSchema("msgTrigger", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgTrigger);
                RcvTriggerPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgTrigger, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvTriggerPort != null)
                {
                    RcvTriggerPort.Close(__ctx1__, __seg__);
                    RcvTriggerPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgTrigger);
                    __edata.PortName = @"RcvTriggerPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgTrigger != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTrigger);
                    __ctx1__.__msgTrigger = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes __msgSQLGetCodesReq = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes("msgSQLGetCodesReq", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:usp_GetCodes xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" /> ");
                    __msgSQLGetCodesReq.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgSQLGetCodesReq != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = __msgSQLGetCodesReq;
                    __ctx1__.RefMessage(__ctx1__.__msgSQLGetCodesReq);
                }
                __ctx1__.__msgSQLGetCodesReq.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesReq);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SQLOrdersPort.SendMessage(0, __ctx1__.__msgSQLGetCodesReq, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesReq);
                    __edata.PortName = @"SQLOrdersPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!SQLOrdersPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgSQLGetCodesResp != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                __ctx1__.__msgSQLGetCodesResp = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse("msgSQLGetCodesResp", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgSQLGetCodesResp);
                SQLOrdersPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgSQLGetCodesResp, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SQLOrdersPort != null)
                {
                    SQLOrdersPort.Close(__ctx1__, __seg__);
                    SQLOrdersPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesResp);
                    __edata.PortName = @"SQLOrdersPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendSQLResultPort.SendMessage(0, __ctx1__.__msgSQLGetCodesResp, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendSQLResultPort != null)
                {
                    SendSQLResultPort.Close(__ctx1__, __seg__);
                    SendSQLResultPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesResp);
                    __edata.PortName = @"SendSQLResultPort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesResp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                    __ctx1__.__msgSQLGetCodesResp = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 23;
            case 23:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{B1D18C05-AC73-46D6-B5CC-94F5F144090C}"))
        };

    }
    //#line 188 "C:\Development\HowToCallSQLStoredProcedureWithoutInputs\HowToCallSQLStoredProcedureWithoutInputs\02-CrazyApproach\CrazyApproachCallSQLStoredProcedure.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvTriggerCrazyPort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(HowToCallSQLStoredProcedureWithoutInputs.RcvTriggerCrazyType),
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SQLOrdersType),
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SendSQLResultType)
        },
        new System.String[] {
            "RcvTriggerCrazyPort",
            "SQLOrdersCrazySPPort",
            "SendSQLResultCrazyPort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class CrazyApproachCallSQLStoredProcedure : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(CrazyApproachCallSQLStoredProcedure));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static CrazyApproachCallSQLStoredProcedure()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __CrazyApproachCallSQLStoredProcedure_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public CrazyApproachCallSQLStoredProcedure(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "CrazyApproachCallSQLStoredProcedure", tracker)
        {
            ConstructorHelper();
        }

        public CrazyApproachCallSQLStoredProcedure(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "CrazyApproachCallSQLStoredProcedure")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>3b6b0510-efa8-4a66-ad1a-80447ea73d5b</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>5cf42d42-c193-4102-ba06-943c97765ec1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Trigger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>02a88abf-d6d0-4c50-ba13-b01ea142c6d9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct SQL GetCodes Req Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>d8aeecc6-c3a3-4769-b475-3c8b8eb9f4f7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>GetCodes Transform</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>54ae983c-4dfa-4e73-9078-cea41092ae22</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>db7d9380-25b0-4b03-917b-e5cedfb926ae</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>460d4270-3297-4603-ba67-bd463f4c85f7</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1483c556-458a-4938-b19e-dddb69ef1371</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send GetCodes</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f5118cca-a1b1-4966-86fa-296d1164394c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive GetCodes Resp</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>33ef0cf8-be04-4ee1-a857-ba367d22f449</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SQL Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'CrazyApproachCallSQLStoredProcedure'</ActionName><IsAtomic>0</IsAtomic><Line>188</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>202</Line><Position>22</Position><ShapeID>'5cf42d42-c193-4102-ba06-943c97765ec1'</ShapeID>
<Messages>
	<MsgInfo><name>msgTriggerCrazy</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>204</Line><Position>13</Position><ShapeID>'02a88abf-d6d0-4c50-ba13-b01ea142c6d9'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesReq</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgTriggerCrazy</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>210</Line><Position>13</Position><ShapeID>'1483c556-458a-4938-b19e-dddb69ef1371'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesReq</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>212</Line><Position>13</Position><ShapeID>'f5118cca-a1b1-4966-86fa-296d1164394c'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesResp</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodesResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>214</Line><Position>13</Position><ShapeID>'33ef0cf8-be04-4ee1-a857-ba367d22f449'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesResp</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodesResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='79a4b31b-815a-408d-94e0-26c7a5d458a8' LowerBound='1.1' HigherBound='42.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='HowToCallSQLStoredProcedureWithoutInputs' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='821e7114-0d40-45a2-992a-6c6c6a00d886' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvTriggerCrazyType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='a576c050-5596-4f32-8752-0ab4e25f8653' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='7319a3e1-2d13-4444-9883-fa47065a30b7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.43'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='3a61fbe7-87cc-4b6d-b3cd-f7b1319fd5b5' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='41.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CrazyApproachCallSQLStoredProcedure' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='3ce03e12-ffe3-4ba0-bd3b-783748fd48cf' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLGetCodesResp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aa57fe6b-776f-41c4-87ad-a9c08aad2f21' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLGetCodesReq' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e4d398b8-3702-44a2-81fb-a96a2397b7a7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.TriggerCrazy' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgTriggerCrazy' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='3b6b0510-efa8-4a66-ad1a-80447ea73d5b' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='5cf42d42-c193-4102-ba06-943c97765ec1' ParentLink='ServiceBody_Statement' LowerBound='25.1' HigherBound='27.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvTriggerCrazyPort' />
                    <om:Property Name='MessageName' Value='msgTriggerCrazy' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Trigger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='02a88abf-d6d0-4c50-ba13-b01ea142c6d9' ParentLink='ServiceBody_Statement' LowerBound='27.1' HigherBound='33.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct SQL GetCodes Req Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='d8aeecc6-c3a3-4769-b475-3c8b8eb9f4f7' ParentLink='ComplexStatement_Statement' LowerBound='30.1' HigherBound='32.1'>
                        <om:Property Name='ClassName' Value='HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.mapTriggerCrazyToSQLGetCodes' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='GetCodes Transform' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='54ae983c-4dfa-4e73-9078-cea41092ae22' ParentLink='Transform_InputMessagePartRef' LowerBound='31.138' HigherBound='31.153'>
                            <om:Property Name='MessageRef' Value='msgTriggerCrazy' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='db7d9380-25b0-4b03-917b-e5cedfb926ae' ParentLink='Transform_OutputMessagePartRef' LowerBound='31.28' HigherBound='31.45'>
                            <om:Property Name='MessageRef' Value='msgSQLGetCodesReq' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='460d4270-3297-4603-ba67-bd463f4c85f7' ParentLink='Construct_MessageRef' LowerBound='28.23' HigherBound='28.40'>
                        <om:Property Name='Ref' Value='msgSQLGetCodesReq' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='1483c556-458a-4938-b19e-dddb69ef1371' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='PortName' Value='SQLOrdersCrazySPPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesReq' />
                    <om:Property Name='OperationName' Value='GetCodes' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send GetCodes' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='f5118cca-a1b1-4966-86fa-296d1164394c' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='37.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SQLOrdersCrazySPPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesResp' />
                    <om:Property Name='OperationName' Value='GetCodes' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive GetCodes Resp' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='33ef0cf8-be04-4ee1-a857-ba367d22f449' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='39.1'>
                    <om:Property Name='PortName' Value='SendSQLResultCrazyPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesResp' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SQL Result' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='066a1385-b71a-48c9-9114-d2a2b10c87a1' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.RcvTriggerCrazyType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvTriggerCrazyPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='00a394f5-1031-4d7a-af88-504b7dfee8f5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='da56e883-854d-4155-af50-34263b0ffec1' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='16.1' HigherBound='18.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='20' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SendSQLResultType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSQLResultCrazyPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='5429fd74-4294-4c6d-b697-697810af408a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='16.1' HigherBound='17.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ef728ecf-de9a-4389-8245-fd9d09fd4d65' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='17' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQLOrdersType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLOrdersCrazySPPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2ab3030d-3684-42ac-8dc1-e4142da24fc2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __CrazyApproachCallSQLStoredProcedure_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __CrazyApproachCallSQLStoredProcedure_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CrazyApproachCallSQLStoredProcedure")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CrazyApproachCallSQLStoredProcedure __svc__ = (CrazyApproachCallSQLStoredProcedure)_service;
                __CrazyApproachCallSQLStoredProcedure_root_0 __ctx0__ = (__CrazyApproachCallSQLStoredProcedure_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendSQLResultCrazyPort != null)
                {
                    __svc__.SendSQLResultCrazyPort.Close(this, null);
                    __svc__.SendSQLResultCrazyPort = null;
                }
                if (__svc__.SQLOrdersCrazySPPort != null)
                {
                    __svc__.SQLOrdersCrazySPPort.Close(this, null);
                    __svc__.SQLOrdersCrazySPPort = null;
                }
                if (__svc__.RcvTriggerCrazyPort != null)
                {
                    __svc__.RcvTriggerCrazyPort.Close(this, null);
                    __svc__.RcvTriggerCrazyPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __CrazyApproachCallSQLStoredProcedure_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __CrazyApproachCallSQLStoredProcedure_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CrazyApproachCallSQLStoredProcedure")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CrazyApproachCallSQLStoredProcedure __svc__ = (CrazyApproachCallSQLStoredProcedure)_service;
                __CrazyApproachCallSQLStoredProcedure_root_0 __ctx0__ = (__CrazyApproachCallSQLStoredProcedure_root_0)(__svc__._stateMgrs[0]);
                __CrazyApproachCallSQLStoredProcedure_1 __ctx1__ = (__CrazyApproachCallSQLStoredProcedure_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgTriggerCrazy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerCrazy);
                    __ctx1__.__msgTriggerCrazy = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesResp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                    __ctx1__.__msgSQLGetCodesResp = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLGetCodesResp")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse __msgSQLGetCodesResp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLGetCodesReq")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes __msgSQLGetCodesReq;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgTriggerCrazy")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy __msgTriggerCrazy;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvTriggerCrazyPort")]
        internal RcvTriggerCrazyType RcvTriggerCrazyPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SQLOrdersCrazySPPort")]
        internal SQLOrdersType SQLOrdersCrazySPPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendSQLResultCrazyPort")]
        internal SendSQLResultType SendSQLResultCrazyPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RcvTriggerCrazyType.Operation_1},
                                               typeof(CrazyApproachCallSQLStoredProcedure).GetField("RcvTriggerCrazyPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CrazyApproachCallSQLStoredProcedure), "RcvTriggerCrazyPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SQLOrdersType.GetCodes},
                                               typeof(CrazyApproachCallSQLStoredProcedure).GetField("SQLOrdersCrazySPPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CrazyApproachCallSQLStoredProcedure), "SQLOrdersCrazySPPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendSQLResultType.Operation_1},
                                               typeof(CrazyApproachCallSQLStoredProcedure).GetField("SendSQLResultCrazyPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CrazyApproachCallSQLStoredProcedure), "SendSQLResultCrazyPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "5cf42d42-c193-4102-ba06-943c97765ec1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "5cf42d42-c193-4102-ba06-943c97765ec1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "02a88abf-d6d0-4c50-ba13-b01ea142c6d9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "02a88abf-d6d0-4c50-ba13-b01ea142c6d9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "1483c556-458a-4938-b19e-dddb69ef1371", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "1483c556-458a-4938-b19e-dddb69ef1371", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "f5118cca-a1b1-4966-86fa-296d1164394c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "f5118cca-a1b1-4966-86fa-296d1164394c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "33ef0cf8-be04-4ee1-a857-ba367d22f449", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "33ef0cf8-be04-4ee1-a857-ba367d22f449", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CrazyApproachCallSQLStoredProcedure_root_0 __ctx0__ = (__CrazyApproachCallSQLStoredProcedure_root_0)_stateMgrs[0];
            __CrazyApproachCallSQLStoredProcedure_1 __ctx1__ = (__CrazyApproachCallSQLStoredProcedure_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                RcvTriggerCrazyPort = new RcvTriggerCrazyType(0, this);
                SendSQLResultCrazyPort = new SendSQLResultType(2, this);
                SQLOrdersCrazySPPort = new SQLOrdersType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvTriggerCrazyPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __CrazyApproachCallSQLStoredProcedure_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __CrazyApproachCallSQLStoredProcedure_root_0 __ctx0__ = (__CrazyApproachCallSQLStoredProcedure_root_0)_stateMgrs[0];
            __CrazyApproachCallSQLStoredProcedure_1 __ctx1__ = (__CrazyApproachCallSQLStoredProcedure_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!RcvTriggerCrazyPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgTriggerCrazy != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerCrazy);
                __ctx1__.__msgTriggerCrazy = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs__02_CrazyApproach_TriggerCrazy("msgTriggerCrazy", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgTriggerCrazy);
                RcvTriggerCrazyPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgTriggerCrazy, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvTriggerCrazyPort != null)
                {
                    RcvTriggerCrazyPort.Close(__ctx1__, __seg__);
                    RcvTriggerCrazyPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgTriggerCrazy);
                    __edata.PortName = @"RcvTriggerCrazyPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes __msgSQLGetCodesReq = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes("msgSQLGetCodesReq", __ctx1__);

                    ApplyTransform(typeof(HowToCallSQLStoredProcedureWithoutInputs._02_CrazyApproach.mapTriggerCrazyToSQLGetCodes), new object[] {__msgSQLGetCodesReq.part}, new object[] {__ctx1__.__msgTriggerCrazy.part});

                    if (__ctx1__.__msgSQLGetCodesReq != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = __msgSQLGetCodesReq;
                    __ctx1__.RefMessage(__ctx1__.__msgSQLGetCodesReq);
                }
                __ctx1__.__msgSQLGetCodesReq.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesReq);
                    __edata.Messages.Add(__ctx1__.__msgTriggerCrazy);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgTriggerCrazy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerCrazy);
                    __ctx1__.__msgTriggerCrazy = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SQLOrdersCrazySPPort.SendMessage(0, __ctx1__.__msgSQLGetCodesReq, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesReq);
                    __edata.PortName = @"SQLOrdersCrazySPPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!SQLOrdersCrazySPPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgSQLGetCodesResp != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                __ctx1__.__msgSQLGetCodesResp = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse("msgSQLGetCodesResp", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgSQLGetCodesResp);
                SQLOrdersCrazySPPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgSQLGetCodesResp, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SQLOrdersCrazySPPort != null)
                {
                    SQLOrdersCrazySPPort.Close(__ctx1__, __seg__);
                    SQLOrdersCrazySPPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesResp);
                    __edata.PortName = @"SQLOrdersCrazySPPort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendSQLResultCrazyPort.SendMessage(0, __ctx1__.__msgSQLGetCodesResp, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendSQLResultCrazyPort != null)
                {
                    SendSQLResultCrazyPort.Close(__ctx1__, __seg__);
                    SendSQLResultCrazyPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesResp);
                    __edata.PortName = @"SendSQLResultCrazyPort";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesResp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                    __ctx1__.__msgSQLGetCodesResp = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 22;
            case 22:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{C72EF34D-4187-45E9-9624-9385D4735BE6}"))
        };

    }
    //#line 188 "C:\Development\HowToCallSQLStoredProcedureWithoutInputs\HowToCallSQLStoredProcedureWithoutInputs\03-UnnecessaryApproach\UnnecessaryApproachCallSQLStoredProcedure.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvTriggerUnnecessaryPort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(HowToCallSQLStoredProcedureWithoutInputs.RcvTriggerUnnecessarType),
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SQLOrdersType),
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SendSQLResultType)
        },
        new System.String[] {
            "RcvTriggerUnnecessaryPort",
            "SQLOrdersUnnecessaryPort",
            "SendSQLResultUnnecessaryPort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class UnnecessaryApproachCallSQLStoredProcedure : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(UnnecessaryApproachCallSQLStoredProcedure));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static UnnecessaryApproachCallSQLStoredProcedure()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __UnnecessaryApproachCallSQLStoredProcedure_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public UnnecessaryApproachCallSQLStoredProcedure(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "UnnecessaryApproachCallSQLStoredProcedure", tracker)
        {
            ConstructorHelper();
        }

        public UnnecessaryApproachCallSQLStoredProcedure(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "UnnecessaryApproachCallSQLStoredProcedure")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>0ee70b60-3b93-4b0d-b679-c943038c8839</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>0d91f22d-c797-4d72-9ac2-9d69398a5226</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Trigger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>81ac9815-e184-46b4-ae90-8659ce47f60c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct SQL GetCodes Req Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>802112b8-5cda-4a9e-89cd-e25a382ba13c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>GetCodes Transform</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fd2c0f91-0f6b-4f6e-b30c-ee3ffd63c4e4</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a29544a6-bd70-4830-a429-910281e776dc</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>27671434-6e0c-4dff-b9b0-72a09e817fb2</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f48f9726-9796-4f8b-9dca-4e72a82a9514</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send GetCodes</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>532079db-2f53-4e2a-a599-65ab5b601d5f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive GetCodes Resp</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>53ef4f02-61bb-432e-8c53-2e44cf6d2c4b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SQL Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'UnnecessaryApproachCallSQLStoredProcedure'</ActionName><IsAtomic>0</IsAtomic><Line>188</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>202</Line><Position>22</Position><ShapeID>'0d91f22d-c797-4d72-9ac2-9d69398a5226'</ShapeID>
<Messages>
	<MsgInfo><name>msgTriggerUnnecessary</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>204</Line><Position>13</Position><ShapeID>'81ac9815-e184-46b4-ae90-8659ce47f60c'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesReq</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgTriggerUnnecessary</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>210</Line><Position>13</Position><ShapeID>'f48f9726-9796-4f8b-9dca-4e72a82a9514'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesReq</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>212</Line><Position>13</Position><ShapeID>'532079db-2f53-4e2a-a599-65ab5b601d5f'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesResp</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodesResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>214</Line><Position>13</Position><ShapeID>'53ef4f02-61bb-432e-8c53-2e44cf6d2c4b'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLGetCodesResp</name><part>part</part><schema>HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodesResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='f291c86d-3fc5-4695-abde-b751e7ccf2ac' LowerBound='1.1' HigherBound='42.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='HowToCallSQLStoredProcedureWithoutInputs' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='882e0b61-288a-4b5b-9277-351adae567f3' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvTriggerUnnecessarType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='52852a55-8363-4466-9589-1cabbc0eb019' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ffe516ad-e2ad-47d7-a5ff-bafcfc420771' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.55'>
                    <om:Property Name='Ref' Value='HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='e6c209fd-ced7-4dfa-9629-6c17098c8a3b' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='41.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='UnnecessaryApproachCallSQLStoredProcedure' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='6cca9b2d-c814-46f3-b290-f8d700fb0d51' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodesResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLGetCodesResp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4977a24c-173d-4bd7-ba96-fe6807e6c1b3' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLGetCodesReq' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='a912d7aa-b280-415b-9c0c-5f892d7d4a27' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgTriggerUnnecessary' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='0ee70b60-3b93-4b0d-b679-c943038c8839' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='0d91f22d-c797-4d72-9ac2-9d69398a5226' ParentLink='ServiceBody_Statement' LowerBound='25.1' HigherBound='27.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvTriggerUnnecessaryPort' />
                    <om:Property Name='MessageName' Value='msgTriggerUnnecessary' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Trigger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='81ac9815-e184-46b4-ae90-8659ce47f60c' ParentLink='ServiceBody_Statement' LowerBound='27.1' HigherBound='33.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct SQL GetCodes Req Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='802112b8-5cda-4a9e-89cd-e25a382ba13c' ParentLink='ComplexStatement_Statement' LowerBound='30.1' HigherBound='32.1'>
                        <om:Property Name='ClassName' Value='HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.mapTriggerUnnecessaryToSQLGetCodes' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='GetCodes Transform' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='fd2c0f91-0f6b-4f6e-b30c-ee3ffd63c4e4' ParentLink='Transform_InputMessagePartRef' LowerBound='31.150' HigherBound='31.171'>
                            <om:Property Name='MessageRef' Value='msgTriggerUnnecessary' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='a29544a6-bd70-4830-a429-910281e776dc' ParentLink='Transform_OutputMessagePartRef' LowerBound='31.28' HigherBound='31.45'>
                            <om:Property Name='MessageRef' Value='msgSQLGetCodesReq' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='27671434-6e0c-4dff-b9b0-72a09e817fb2' ParentLink='Construct_MessageRef' LowerBound='28.23' HigherBound='28.40'>
                        <om:Property Name='Ref' Value='msgSQLGetCodesReq' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='f48f9726-9796-4f8b-9dca-4e72a82a9514' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='PortName' Value='SQLOrdersUnnecessaryPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesReq' />
                    <om:Property Name='OperationName' Value='GetCodes' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send GetCodes' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='532079db-2f53-4e2a-a599-65ab5b601d5f' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='37.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SQLOrdersUnnecessaryPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesResp' />
                    <om:Property Name='OperationName' Value='GetCodes' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive GetCodes Resp' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='53ef4f02-61bb-432e-8c53-2e44cf6d2c4b' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='39.1'>
                    <om:Property Name='PortName' Value='SendSQLResultUnnecessaryPort' />
                    <om:Property Name='MessageName' Value='msgSQLGetCodesResp' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SQL Result' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cfdbb359-49cf-44ec-b877-37b05825487f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.RcvTriggerUnnecessarType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvTriggerUnnecessaryPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='3c45f41d-2b44-47c2-ba06-42a07a9a2e8b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d1a77ae3-e4b0-4be9-9f98-33c92e3270e5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='16.1' HigherBound='18.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='21' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SendSQLResultType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSQLResultUnnecessaryPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='845937f5-8911-44d0-9122-25c856d7a37e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='16.1' HigherBound='17.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='6e995f89-2adc-4852-8773-32a570e06fa7' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='18' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToCallSQLStoredProcedureWithoutInputs.SQLOrdersType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLOrdersUnnecessaryPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6b13e3be-fbbf-4e2f-bfb8-45846c490deb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __UnnecessaryApproachCallSQLStoredProcedure_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __UnnecessaryApproachCallSQLStoredProcedure_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "UnnecessaryApproachCallSQLStoredProcedure")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                UnnecessaryApproachCallSQLStoredProcedure __svc__ = (UnnecessaryApproachCallSQLStoredProcedure)_service;
                __UnnecessaryApproachCallSQLStoredProcedure_root_0 __ctx0__ = (__UnnecessaryApproachCallSQLStoredProcedure_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendSQLResultUnnecessaryPort != null)
                {
                    __svc__.SendSQLResultUnnecessaryPort.Close(this, null);
                    __svc__.SendSQLResultUnnecessaryPort = null;
                }
                if (__svc__.RcvTriggerUnnecessaryPort != null)
                {
                    __svc__.RcvTriggerUnnecessaryPort.Close(this, null);
                    __svc__.RcvTriggerUnnecessaryPort = null;
                }
                if (__svc__.SQLOrdersUnnecessaryPort != null)
                {
                    __svc__.SQLOrdersUnnecessaryPort.Close(this, null);
                    __svc__.SQLOrdersUnnecessaryPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __UnnecessaryApproachCallSQLStoredProcedure_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __UnnecessaryApproachCallSQLStoredProcedure_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "UnnecessaryApproachCallSQLStoredProcedure")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                UnnecessaryApproachCallSQLStoredProcedure __svc__ = (UnnecessaryApproachCallSQLStoredProcedure)_service;
                __UnnecessaryApproachCallSQLStoredProcedure_1 __ctx1__ = (__UnnecessaryApproachCallSQLStoredProcedure_1)(__svc__._stateMgrs[1]);
                __UnnecessaryApproachCallSQLStoredProcedure_root_0 __ctx0__ = (__UnnecessaryApproachCallSQLStoredProcedure_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null && __ctx1__.__msgTriggerUnnecessary != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerUnnecessary);
                    __ctx1__.__msgTriggerUnnecessary = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesResp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                    __ctx1__.__msgSQLGetCodesResp = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLGetCodesResp")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse __msgSQLGetCodesResp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLGetCodesReq")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes __msgSQLGetCodesReq;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgTriggerUnnecessary")]
            public __messagetype_HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary __msgTriggerUnnecessary;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvTriggerUnnecessaryPort")]
        internal RcvTriggerUnnecessarType RcvTriggerUnnecessaryPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SQLOrdersUnnecessaryPort")]
        internal SQLOrdersType SQLOrdersUnnecessaryPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendSQLResultUnnecessaryPort")]
        internal SendSQLResultType SendSQLResultUnnecessaryPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RcvTriggerUnnecessarType.Operation_1},
                                               typeof(UnnecessaryApproachCallSQLStoredProcedure).GetField("RcvTriggerUnnecessaryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(UnnecessaryApproachCallSQLStoredProcedure), "RcvTriggerUnnecessaryPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SQLOrdersType.GetCodes},
                                               typeof(UnnecessaryApproachCallSQLStoredProcedure).GetField("SQLOrdersUnnecessaryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(UnnecessaryApproachCallSQLStoredProcedure), "SQLOrdersUnnecessaryPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendSQLResultType.Operation_1},
                                               typeof(UnnecessaryApproachCallSQLStoredProcedure).GetField("SendSQLResultUnnecessaryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(UnnecessaryApproachCallSQLStoredProcedure), "SendSQLResultUnnecessaryPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "0d91f22d-c797-4d72-9ac2-9d69398a5226", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "0d91f22d-c797-4d72-9ac2-9d69398a5226", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "81ac9815-e184-46b4-ae90-8659ce47f60c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "81ac9815-e184-46b4-ae90-8659ce47f60c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "f48f9726-9796-4f8b-9dca-4e72a82a9514", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f48f9726-9796-4f8b-9dca-4e72a82a9514", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "532079db-2f53-4e2a-a599-65ab5b601d5f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "532079db-2f53-4e2a-a599-65ab5b601d5f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "53ef4f02-61bb-432e-8c53-2e44cf6d2c4b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "53ef4f02-61bb-432e-8c53-2e44cf6d2c4b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __UnnecessaryApproachCallSQLStoredProcedure_1 __ctx1__ = (__UnnecessaryApproachCallSQLStoredProcedure_1)_stateMgrs[1];
            __UnnecessaryApproachCallSQLStoredProcedure_root_0 __ctx0__ = (__UnnecessaryApproachCallSQLStoredProcedure_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RcvTriggerUnnecessaryPort = new RcvTriggerUnnecessarType(0, this);
                SendSQLResultUnnecessaryPort = new SendSQLResultType(2, this);
                SQLOrdersUnnecessaryPort = new SQLOrdersType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvTriggerUnnecessaryPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __UnnecessaryApproachCallSQLStoredProcedure_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __UnnecessaryApproachCallSQLStoredProcedure_1 __ctx1__ = (__UnnecessaryApproachCallSQLStoredProcedure_1)_stateMgrs[1];
            __UnnecessaryApproachCallSQLStoredProcedure_root_0 __ctx0__ = (__UnnecessaryApproachCallSQLStoredProcedure_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!RcvTriggerUnnecessaryPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgTriggerUnnecessary != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerUnnecessary);
                __ctx1__.__msgTriggerUnnecessary = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs__03_UnnecessaryApproach_TriggerUnnecessary("msgTriggerUnnecessary", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgTriggerUnnecessary);
                RcvTriggerUnnecessaryPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgTriggerUnnecessary, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvTriggerUnnecessaryPort != null)
                {
                    RcvTriggerUnnecessaryPort.Close(__ctx1__, __seg__);
                    RcvTriggerUnnecessaryPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgTriggerUnnecessary);
                    __edata.PortName = @"RcvTriggerUnnecessaryPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes __msgSQLGetCodesReq = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodes("msgSQLGetCodesReq", __ctx1__);

                    ApplyTransform(typeof(HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.mapTriggerUnnecessaryToSQLGetCodes), new object[] {__msgSQLGetCodesReq.part}, new object[] {__ctx1__.__msgTriggerUnnecessary.part});

                    if (__ctx1__.__msgSQLGetCodesReq != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = __msgSQLGetCodesReq;
                    __ctx1__.RefMessage(__ctx1__.__msgSQLGetCodesReq);
                }
                __ctx1__.__msgSQLGetCodesReq.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesReq);
                    __edata.Messages.Add(__ctx1__.__msgTriggerUnnecessary);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgTriggerUnnecessary != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTriggerUnnecessary);
                    __ctx1__.__msgTriggerUnnecessary = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SQLOrdersUnnecessaryPort.SendMessage(0, __ctx1__.__msgSQLGetCodesReq, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesReq);
                    __edata.PortName = @"SQLOrdersUnnecessaryPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesReq);
                    __ctx1__.__msgSQLGetCodesReq = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!SQLOrdersUnnecessaryPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgSQLGetCodesResp != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                __ctx1__.__msgSQLGetCodesResp = new __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_TypedProcedure_dbo_usp_GetCodesResponse("msgSQLGetCodesResp", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgSQLGetCodesResp);
                SQLOrdersUnnecessaryPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgSQLGetCodesResp, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SQLOrdersUnnecessaryPort != null)
                {
                    SQLOrdersUnnecessaryPort.Close(__ctx1__, __seg__);
                    SQLOrdersUnnecessaryPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesResp);
                    __edata.PortName = @"SQLOrdersUnnecessaryPort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendSQLResultUnnecessaryPort.SendMessage(0, __ctx1__.__msgSQLGetCodesResp, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendSQLResultUnnecessaryPort != null)
                {
                    SendSQLResultUnnecessaryPort.Close(__ctx1__, __seg__);
                    SendSQLResultUnnecessaryPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLGetCodesResp);
                    __edata.PortName = @"SendSQLResultUnnecessaryPort";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLGetCodesResp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLGetCodesResp);
                    __ctx1__.__msgSQLGetCodesResp = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 22;
            case 22:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{C9DFF69E-6F74-4729-A040-4398CB2A6C2D}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon _schema = new HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon();

        public __HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon__)
        },
        0,
        @"http://HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon#TriggerCommon"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToCallSQLStoredProcedureWithoutInputs__01_MostCommonSituation_TriggerCommon(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInput _schema = new HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInput();

        public __HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInput",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInput)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#usp_GetCodesWithDummyInput"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInput(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInputResponse _schema = new HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInputResponse();

        public __HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInputResponse",
        new System.Type[]{
            typeof(HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInputResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#usp_GetCodesWithDummyInputResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToCallSQLStoredProcedureWithoutInputs_SQL_COMMON_TypedProcedure_dbo_usp_GetCodesWithDummyInputResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
