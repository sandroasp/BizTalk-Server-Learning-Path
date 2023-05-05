
#pragma warning disable 162

namespace POC.DirectBoundPorts
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "EntryOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.__messagetype_POC_DirectBoundPorts_InMsg)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class EntryPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public EntryPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public EntryPortType(EntryPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            EntryPortType p = new EntryPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo EntryOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "EntryOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(EntryPortType),
            typeof(__messagetype_POC_DirectBoundPorts_InMsg),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "EntryOp" ] = EntryOp;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __POC_DirectBoundPorts_FinalMsg__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.DirectBoundPorts.FinalMsg _schema = new POC.DirectBoundPorts.FinalMsg();

        public __POC_DirectBoundPorts_FinalMsg__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.DirectBoundPorts.FinalMsg",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.FinalMsg)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_DirectBoundPorts_FinalMsg__)
        },
        0,
        @"http://POC.DirectBoundPorts.FinalMsg#FinalMsg"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_DirectBoundPorts_FinalMsg : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_DirectBoundPorts_FinalMsg__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_DirectBoundPorts_FinalMsg__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_DirectBoundPorts_FinalMsg(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendToMsgBoxOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.__messagetype_POC_DirectBoundPorts_ToBeRouteMsg)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SendToMsgBoxPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendToMsgBoxPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendToMsgBoxPortType(SendToMsgBoxPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendToMsgBoxPortType p = new SendToMsgBoxPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendToMsgBoxOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendToMsgBoxOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendToMsgBoxPortType),
            typeof(__messagetype_POC_DirectBoundPorts_ToBeRouteMsg),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendToMsgBoxOp" ] = SendToMsgBoxOp;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SubsMsgBoxOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.__messagetype_POC_DirectBoundPorts_ToBeRouteMsg)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class MsgBoxSubsPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public MsgBoxSubsPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public MsgBoxSubsPortType(MsgBoxSubsPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            MsgBoxSubsPortType p = new MsgBoxSubsPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SubsMsgBoxOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SubsMsgBoxOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(MsgBoxSubsPortType),
            typeof(__messagetype_POC_DirectBoundPorts_ToBeRouteMsg),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SubsMsgBoxOp" ] = SubsMsgBoxOp;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendSubsMsgBoxResultOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.__messagetype_POC_DirectBoundPorts_FinalMsg)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SendSubsMsgBoxResultPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendSubsMsgBoxResultPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendSubsMsgBoxResultPortType(SendSubsMsgBoxResultPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendSubsMsgBoxResultPortType p = new SendSubsMsgBoxResultPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendSubsMsgBoxResultOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendSubsMsgBoxResultOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendSubsMsgBoxResultPortType),
            typeof(__messagetype_POC_DirectBoundPorts_FinalMsg),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendSubsMsgBoxResultOp" ] = SendSubsMsgBoxResultOp;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 169 "C:\DEV\POC\POC.DirectBoundPorts\POC.DirectBoundPorts\EntryOrchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "EntryPort", "EntryOp", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.DirectBoundPorts.EntryPortType),
            typeof(POC.DirectBoundPorts.SendToMsgBoxPortType)
        },
        new System.String[] {
            "EntryPort",
            "SendToMsgBoxPort"
        },
        new System.Type[] {
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
    sealed internal class EntryOrchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(EntryOrchestration));
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

        static EntryOrchestration()
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
            _rootContext = new __EntryOrchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public EntryOrchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "EntryOrchestration", tracker)
        {
            ConstructorHelper();
        }

        public EntryOrchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "EntryOrchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>f5d73cdb-e990-413e-b074-0e1319a1f19b</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>2e66ce1f-dfb0-4b7b-945d-6b0115168749</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Inbound Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>3117430b-7e53-4bbe-bed5-8cadba69bb1a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct ToBeRouted Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>332f2c4e-daef-45bf-bb3f-33dabb30999b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ToBeRouted MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>fabe5b9e-3f7d-4d2c-9242-f517a855aeb5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1c8e9b93-8395-4457-add2-addda8ea0702</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send ToMsgBox</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'EntryOrchestration'</ActionName><IsAtomic>0</IsAtomic><Line>169</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>181</Line><Position>22</Position><ShapeID>'2e66ce1f-dfb0-4b7b-945d-6b0115168749'</ShapeID>
<Messages>
	<MsgInfo><name>msgIn</name><part>part</part><schema>POC.DirectBoundPorts.InMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>184</Line><Position>13</Position><ShapeID>'3117430b-7e53-4bbe-bed5-8cadba69bb1a'</ShapeID>
<Messages>
	<MsgInfo><name>msgToBeRouted</name><part>part</part><schema>POC.DirectBoundPorts.ToBeRouteMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>193</Line><Position>13</Position><ShapeID>'1c8e9b93-8395-4457-add2-addda8ea0702'</ShapeID>
<Messages>
	<MsgInfo><name>msgToBeRouted</name><part>part</part><schema>POC.DirectBoundPorts.ToBeRouteMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ba6c2708-5677-4933-9b1f-e5b98af8dd35' LowerBound='1.1' HigherBound='47.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.DirectBoundPorts' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='b170a27c-5827-4119-ba80-0197ba91467d' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='EntryPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='056d3189-ac6a-4644-994e-eacf12c59a0b' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EntryOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='1c82a59d-7024-4efa-9199-6c70a4ca348d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.18'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.InMsg' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='60f2333f-e6df-4ff8-a181-9743d84ee021' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendToMsgBoxPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e6f6bff1-0be0-414e-99ba-a3819d222a81' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendToMsgBoxOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='86772b4d-0d8a-4093-9375-ce252aa5d6d2' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.25'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.ToBeRouteMsg' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='25307081-4b35-4780-9ad3-039afa6d8a2a' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='46.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='EntryOrchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='34f21f54-5890-428a-93b0-1d363a8344a5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='af69ac24-320e-45ab-b264-038e06bbfc92' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.ToBeRouteMsg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgToBeRouted' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8cd1b7d2-deaf-40da-832c-ac48ebfe0e2b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.InMsg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='f5d73cdb-e990-413e-b074-0e1319a1f19b' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='2e66ce1f-dfb0-4b7b-945d-6b0115168749' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='33.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='EntryPort' />
                    <om:Property Name='MessageName' Value='msgIn' />
                    <om:Property Name='OperationName' Value='EntryOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Inbound Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='3117430b-7e53-4bbe-bed5-8cadba69bb1a' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='42.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct ToBeRouted Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='332f2c4e-daef-45bf-bb3f-33dabb30999b' ParentLink='ComplexStatement_Statement' LowerBound='36.1' HigherBound='41.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:ToBeRouteMsg xmlns:ns0=&quot;&quot;http://POC.DirectBoundPorts.ToBeRouteMsg&quot;&quot;&gt;&lt;ByOrch&gt;EntryOrchestration&lt;/ByOrch&gt;&lt;/ns0:ToBeRouteMsg&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgToBeRouted = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='ToBeRouted MsgAssign' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='fabe5b9e-3f7d-4d2c-9242-f517a855aeb5' ParentLink='Construct_MessageRef' LowerBound='34.23' HigherBound='34.36'>
                        <om:Property Name='Ref' Value='msgToBeRouted' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='1c8e9b93-8395-4457-add2-addda8ea0702' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='44.1'>
                    <om:Property Name='PortName' Value='SendToMsgBoxPort' />
                    <om:Property Name='MessageName' Value='msgToBeRouted' />
                    <om:Property Name='OperationName' Value='SendToMsgBoxOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send ToMsgBox' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='19927dd4-eb32-4261-ae51-25cd00a4950f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.EntryPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EntryPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='0d216521-d1f0-4eac-9ece-11bcc4f00a61' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='344aa124-22a4-421f-a527-97d4803adb3b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='14' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.SendToMsgBoxPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendToMsgBoxPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='7a93c6f6-572b-4941-8911-3a4d7649ba7a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __EntryOrchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __EntryOrchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EntryOrchestration")
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
                EntryOrchestration __svc__ = (EntryOrchestration)_service;
                __EntryOrchestration_root_0 __ctx0__ = (__EntryOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.EntryPort != null)
                {
                    __svc__.EntryPort.Close(this, null);
                    __svc__.EntryPort = null;
                }
                if (__svc__.SendToMsgBoxPort != null)
                {
                    __svc__.SendToMsgBoxPort.Close(this, null);
                    __svc__.SendToMsgBoxPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __EntryOrchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __EntryOrchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EntryOrchestration")
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
                EntryOrchestration __svc__ = (EntryOrchestration)_service;
                __EntryOrchestration_1 __ctx1__ = (__EntryOrchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                if (__ctx1__ != null && __ctx1__.__msgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                    __ctx1__.__msgIn = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgToBeRouted != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgToBeRouted);
                    __ctx1__.__msgToBeRouted = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgToBeRouted")]
            public __messagetype_POC_DirectBoundPorts_ToBeRouteMsg __msgToBeRouted;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgIn")]
            public __messagetype_POC_DirectBoundPorts_InMsg __msgIn;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("EntryPort")]
        internal EntryPortType EntryPort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendToMsgBoxPort")]
        internal SendToMsgBoxPortType SendToMsgBoxPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {EntryPortType.EntryOp},
                                               typeof(EntryOrchestration).GetField("EntryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EntryOrchestration), "EntryPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendToMsgBoxPortType.SendToMsgBoxOp},
                                               typeof(EntryOrchestration).GetField("SendToMsgBoxPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EntryOrchestration), "SendToMsgBoxPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "2e66ce1f-dfb0-4b7b-945d-6b0115168749", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "2e66ce1f-dfb0-4b7b-945d-6b0115168749", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "3117430b-7e53-4bbe-bed5-8cadba69bb1a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "3117430b-7e53-4bbe-bed5-8cadba69bb1a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "1c8e9b93-8395-4457-add2-addda8ea0702", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "1c8e9b93-8395-4457-add2-addda8ea0702", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,6,7,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __EntryOrchestration_root_0 __ctx0__ = (__EntryOrchestration_root_0)_stateMgrs[0];
            __EntryOrchestration_1 __ctx1__ = (__EntryOrchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                EntryPort = new EntryPortType(0, this);
                SendToMsgBoxPort = new SendToMsgBoxPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], EntryPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __EntryOrchestration_1(this);
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
            __EntryOrchestration_root_0 __ctx0__ = (__EntryOrchestration_root_0)_stateMgrs[0];
            __EntryOrchestration_1 __ctx1__ = (__EntryOrchestration_1)_stateMgrs[1];

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
                if (!EntryPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                __ctx1__.__msgIn = new __messagetype_POC_DirectBoundPorts_InMsg("msgIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgIn);
                EntryPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (EntryPort != null)
                {
                    EntryPort.Close(__ctx1__, __seg__);
                    EntryPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgIn);
                    __edata.PortName = @"EntryPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                    __ctx1__.__msgIn = null;
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
                    __messagetype_POC_DirectBoundPorts_ToBeRouteMsg __msgToBeRouted = new __messagetype_POC_DirectBoundPorts_ToBeRouteMsg("msgToBeRouted", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:ToBeRouteMsg xmlns:ns0=""http://POC.DirectBoundPorts.ToBeRouteMsg""><ByOrch>EntryOrchestration</ByOrch></ns0:ToBeRouteMsg>");
                    __msgToBeRouted.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgToBeRouted != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgToBeRouted);
                    __ctx1__.__msgToBeRouted = __msgToBeRouted;
                    __ctx1__.RefMessage(__ctx1__.__msgToBeRouted);
                }
                __ctx1__.__msgToBeRouted.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgToBeRouted);
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
                SendToMsgBoxPort.SendMessage(0, __ctx1__.__msgToBeRouted, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendToMsgBoxPort != null)
                {
                    SendToMsgBoxPort.Close(__ctx1__, __seg__);
                    SendToMsgBoxPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgToBeRouted);
                    __edata.PortName = @"SendToMsgBoxPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgToBeRouted != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgToBeRouted);
                    __ctx1__.__msgToBeRouted = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 16;
            case 16:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 169 "C:\DEV\POC\POC.DirectBoundPorts\POC.DirectBoundPorts\OrchSubsMsgBox.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "MsgBoxSubsPort", "SubsMsgBoxOp", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.DirectBoundPorts.MsgBoxSubsPortType),
            typeof(POC.DirectBoundPorts.SendSubsMsgBoxResultPortType)
        },
        new System.String[] {
            "MsgBoxSubsPort",
            "SendSubsMsgBoxResultPort"
        },
        new System.Type[] {
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
    sealed internal class OrchSubsMsgBox : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(OrchSubsMsgBox));
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

        static OrchSubsMsgBox()
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
            _rootContext = new __OrchSubsMsgBox_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public OrchSubsMsgBox(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "OrchSubsMsgBox", tracker)
        {
            ConstructorHelper();
        }

        public OrchSubsMsgBox(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "OrchSubsMsgBox")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>e6e2585c-5030-48bb-9d31-b278b7a62a57</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>349e8d90-16d6-437e-ac49-c4135d6e2a99</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Inbound Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4b83cb6f-a79f-40ec-b061-39f3dedda7e5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct FinalOutput Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>fdf01e88-8d38-495d-9b04-abbacdd2afe9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>FinalOutput  MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3e2cf0e8-06e4-4546-ad31-05a40199d375</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>4495348e-6d55-4f4a-9ead-9b1cdc3c0189</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'OrchSubsMsgBox'</ActionName><IsAtomic>0</IsAtomic><Line>169</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>181</Line><Position>22</Position><ShapeID>'349e8d90-16d6-437e-ac49-c4135d6e2a99'</ShapeID>
<Messages>
	<MsgInfo><name>msgIn</name><part>part</part><schema>POC.DirectBoundPorts.ToBeRouteMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>184</Line><Position>13</Position><ShapeID>'4b83cb6f-a79f-40ec-b061-39f3dedda7e5'</ShapeID>
<Messages>
	<MsgInfo><name>msgFinal</name><part>part</part><schema>POC.DirectBoundPorts.FinalMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>193</Line><Position>13</Position><ShapeID>'4495348e-6d55-4f4a-9ead-9b1cdc3c0189'</ShapeID>
<Messages>
	<MsgInfo><name>msgFinal</name><part>part</part><schema>POC.DirectBoundPorts.FinalMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='65c670f2-dbf2-402d-9f53-c8fc17e4f001' LowerBound='1.1' HigherBound='47.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.DirectBoundPorts' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='9c83864d-060c-4c48-9434-f1babb191c59' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MsgBoxSubsPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6d30cd55-9965-46d5-9af0-ada527541e53' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubsMsgBoxOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='fe00e040-023e-406c-bc95-1a098d7b65a9' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.25'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.ToBeRouteMsg' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='ed82a721-bbaa-453c-9435-0de2aef73c78' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendSubsMsgBoxResultPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c7d25040-8891-4aee-a660-40cd70675f89' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSubsMsgBoxResultOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='69859886-6593-4a90-a960-fdb5d8da12d5' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.21'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.FinalMsg' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='cd4ef9a8-9fab-4120-8abb-6151a22b8d8d' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='46.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrchSubsMsgBox' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='5c8cb901-98fd-4887-8645-76b08390320d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ceee3712-edd3-45bf-a7be-d531c765e04b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.FinalMsg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgFinal' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='75fb8179-e4eb-4050-995b-0f04043edee2' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.ToBeRouteMsg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='e6e2585c-5030-48bb-9d31-b278b7a62a57' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='349e8d90-16d6-437e-ac49-c4135d6e2a99' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='33.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='MsgBoxSubsPort' />
                    <om:Property Name='MessageName' Value='msgIn' />
                    <om:Property Name='OperationName' Value='SubsMsgBoxOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Inbound Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='4b83cb6f-a79f-40ec-b061-39f3dedda7e5' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='42.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct FinalOutput Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='fdf01e88-8d38-495d-9b04-abbacdd2afe9' ParentLink='ComplexStatement_Statement' LowerBound='36.1' HigherBound='41.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:ToBeRouteMsg xmlns:ns0=&quot;&quot;http://POC.DirectBoundPorts.ToBeRouteMsg&quot;&quot;&gt;&lt;ByOrch&gt;EntryOrchestration&lt;/ByOrch&gt;&lt;/ns0:ToBeRouteMsg&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgFinal = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='FinalOutput  MsgAssign' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='3e2cf0e8-06e4-4546-ad31-05a40199d375' ParentLink='Construct_MessageRef' LowerBound='34.23' HigherBound='34.31'>
                        <om:Property Name='Ref' Value='msgFinal' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='4495348e-6d55-4f4a-9ead-9b1cdc3c0189' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='44.1'>
                    <om:Property Name='PortName' Value='SendSubsMsgBoxResultPort' />
                    <om:Property Name='MessageName' Value='msgFinal' />
                    <om:Property Name='OperationName' Value='SendSubsMsgBoxResultOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Result' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='11adbe33-3a69-479f-a852-860378ed4b8e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.MsgBoxSubsPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MsgBoxSubsPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='58d22e83-6120-4551-91db-c8cf9c241f99' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='206a3b76-ec8a-450f-bb42-3a74852585ca' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='14' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.SendSubsMsgBoxResultPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSubsMsgBoxResultPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='9eb6b678-1187-4eca-988f-64268f781ee9' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __OrchSubsMsgBox_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __OrchSubsMsgBox_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchSubsMsgBox")
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
                OrchSubsMsgBox __svc__ = (OrchSubsMsgBox)_service;
                __OrchSubsMsgBox_root_0 __ctx0__ = (__OrchSubsMsgBox_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.MsgBoxSubsPort != null)
                {
                    __svc__.MsgBoxSubsPort.Close(this, null);
                    __svc__.MsgBoxSubsPort = null;
                }
                if (__svc__.SendSubsMsgBoxResultPort != null)
                {
                    __svc__.SendSubsMsgBoxResultPort.Close(this, null);
                    __svc__.SendSubsMsgBoxResultPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __OrchSubsMsgBox_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __OrchSubsMsgBox_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchSubsMsgBox")
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
                OrchSubsMsgBox __svc__ = (OrchSubsMsgBox)_service;
                __OrchSubsMsgBox_1 __ctx1__ = (__OrchSubsMsgBox_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgFinal != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgFinal);
                    __ctx1__.__msgFinal = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                if (__ctx1__ != null && __ctx1__.__msgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                    __ctx1__.__msgIn = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgFinal")]
            public __messagetype_POC_DirectBoundPorts_FinalMsg __msgFinal;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgIn")]
            public __messagetype_POC_DirectBoundPorts_ToBeRouteMsg __msgIn;
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

        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("MsgBoxSubsPort")]
        internal MsgBoxSubsPortType MsgBoxSubsPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendSubsMsgBoxResultPort")]
        internal SendSubsMsgBoxResultPortType SendSubsMsgBoxResultPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {MsgBoxSubsPortType.SubsMsgBoxOp},
                                               typeof(OrchSubsMsgBox).GetField("MsgBoxSubsPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchSubsMsgBox), "MsgBoxSubsPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendSubsMsgBoxResultPortType.SendSubsMsgBoxResultOp},
                                               typeof(OrchSubsMsgBox).GetField("SendSubsMsgBoxResultPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchSubsMsgBox), "SendSubsMsgBoxResultPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "349e8d90-16d6-437e-ac49-c4135d6e2a99", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "349e8d90-16d6-437e-ac49-c4135d6e2a99", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "4b83cb6f-a79f-40ec-b061-39f3dedda7e5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "4b83cb6f-a79f-40ec-b061-39f3dedda7e5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "4495348e-6d55-4f4a-9ead-9b1cdc3c0189", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "4495348e-6d55-4f4a-9ead-9b1cdc3c0189", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,6,7,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __OrchSubsMsgBox_1 __ctx1__ = (__OrchSubsMsgBox_1)_stateMgrs[1];
            __OrchSubsMsgBox_root_0 __ctx0__ = (__OrchSubsMsgBox_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                MsgBoxSubsPort = new MsgBoxSubsPortType(0, this);
                SendSubsMsgBoxResultPort = new SendSubsMsgBoxResultPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], MsgBoxSubsPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __OrchSubsMsgBox_1(this);
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
            __OrchSubsMsgBox_1 __ctx1__ = (__OrchSubsMsgBox_1)_stateMgrs[1];
            __OrchSubsMsgBox_root_0 __ctx0__ = (__OrchSubsMsgBox_root_0)_stateMgrs[0];

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
                if (!MsgBoxSubsPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                __ctx1__.__msgIn = new __messagetype_POC_DirectBoundPorts_ToBeRouteMsg("msgIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgIn);
                MsgBoxSubsPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (MsgBoxSubsPort != null)
                {
                    MsgBoxSubsPort.Close(__ctx1__, __seg__);
                    MsgBoxSubsPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgIn);
                    __edata.PortName = @"MsgBoxSubsPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                    __ctx1__.__msgIn = null;
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
                    __messagetype_POC_DirectBoundPorts_FinalMsg __msgFinal = new __messagetype_POC_DirectBoundPorts_FinalMsg("msgFinal", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:ToBeRouteMsg xmlns:ns0=""http://POC.DirectBoundPorts.ToBeRouteMsg""><ByOrch>EntryOrchestration</ByOrch></ns0:ToBeRouteMsg>");
                    __msgFinal.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgFinal != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgFinal);
                    __ctx1__.__msgFinal = __msgFinal;
                    __ctx1__.RefMessage(__ctx1__.__msgFinal);
                }
                __ctx1__.__msgFinal.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgFinal);
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
                SendSubsMsgBoxResultPort.SendMessage(0, __ctx1__.__msgFinal, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendSubsMsgBoxResultPort != null)
                {
                    SendSubsMsgBoxResultPort.Close(__ctx1__, __seg__);
                    SendSubsMsgBoxResultPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgFinal);
                    __edata.PortName = @"SendSubsMsgBoxResultPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgFinal != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgFinal);
                    __ctx1__.__msgFinal = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 16;
            case 16:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_DirectBoundPorts_InMsg__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.DirectBoundPorts.InMsg _schema = new POC.DirectBoundPorts.InMsg();

        public __POC_DirectBoundPorts_InMsg__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.DirectBoundPorts.InMsg",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.InMsg)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_DirectBoundPorts_InMsg__)
        },
        0,
        @"http://POC.DirectBoundPorts.InMsg#InMsg"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_DirectBoundPorts_InMsg : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_DirectBoundPorts_InMsg__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_DirectBoundPorts_InMsg__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_DirectBoundPorts_InMsg(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_DirectBoundPorts_ToBeRouteMsg__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.DirectBoundPorts.ToBeRouteMsg _schema = new POC.DirectBoundPorts.ToBeRouteMsg();

        public __POC_DirectBoundPorts_ToBeRouteMsg__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.DirectBoundPorts.ToBeRouteMsg",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.ToBeRouteMsg)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_DirectBoundPorts_ToBeRouteMsg__)
        },
        0,
        @"http://POC.DirectBoundPorts.ToBeRouteMsg#ToBeRouteMsg"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_DirectBoundPorts_ToBeRouteMsg : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_DirectBoundPorts_ToBeRouteMsg__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_DirectBoundPorts_ToBeRouteMsg__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_DirectBoundPorts_ToBeRouteMsg(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
