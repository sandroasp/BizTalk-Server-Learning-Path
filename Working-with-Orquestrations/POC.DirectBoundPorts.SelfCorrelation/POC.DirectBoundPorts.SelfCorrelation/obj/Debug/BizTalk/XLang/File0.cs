
#pragma warning disable 162

namespace POC.DirectBoundPorts.SelfCorrelation
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "TriggerOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.SelfCorrelation.__messagetype_POC_DirectBoundPorts_SelfCorrelation_TriggerProcess)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class TriggerProcessPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public TriggerProcessPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public TriggerProcessPortType(TriggerProcessPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            TriggerProcessPortType p = new TriggerProcessPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo TriggerOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "TriggerOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(TriggerProcessPortType),
            typeof(__messagetype_POC_DirectBoundPorts_SelfCorrelation_TriggerProcess),
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
        "GetDataOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.SelfCorrelation.__messagetype_POC_DirectBoundPorts_SelfCorrelation_Data)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SelfCorrelationPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SelfCorrelationPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SelfCorrelationPortType(SelfCorrelationPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SelfCorrelationPortType p = new SelfCorrelationPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo GetDataOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "GetDataOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SelfCorrelationPortType),
            typeof(__messagetype_POC_DirectBoundPorts_SelfCorrelation_Data),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "GetDataOp" ] = GetDataOp;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SndDataOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.SelfCorrelation.__messagetype_POC_DirectBoundPorts_SelfCorrelation_Data)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SendDataPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendDataPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendDataPortType(SendDataPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendDataPortType p = new SendDataPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SndDataOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SndDataOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendDataPortType),
            typeof(__messagetype_POC_DirectBoundPorts_SelfCorrelation_Data),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SndDataOp" ] = SndDataOp;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 209 "C:\DEV\POC\POC.DirectBoundPorts.SelfCorrelation\POC.DirectBoundPorts.SelfCorrelation\ReceiverSelfCorrelationOrch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "TriggerProcessPort", "TriggerOp", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.DirectBoundPorts.SelfCorrelation.TriggerProcessPortType),
            typeof(POC.DirectBoundPorts.SelfCorrelation.SelfCorrelationPortType),
            typeof(POC.DirectBoundPorts.SelfCorrelation.SendDataPortType)
        },
        new System.String[] {
            "TriggerProcessPort",
            "SelfCorrelationPort",
            "SendDataPort"
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
    sealed internal class ReceiverSelfCorrelationOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ReceiverSelfCorrelationOrch));
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

        static ReceiverSelfCorrelationOrch()
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
            _rootContext = new __ReceiverSelfCorrelationOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ReceiverSelfCorrelationOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ReceiverSelfCorrelationOrch", tracker)
        {
            ConstructorHelper();
        }

        public ReceiverSelfCorrelationOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ReceiverSelfCorrelationOrch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>348d36ed-7caf-4f2a-a4d6-2e7a17a60889</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>d77a9052-4ad4-4495-b845-71f2e378617e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive StartMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ExecShape</shapeType>      <ShapeID>05fb5393-8fcd-4035-8e9b-1247cc9d57b7</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>StartOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>fce1882f-cfb4-4ef4-b9b2-a5941f15002b</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SelfCorrelationPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f4b2360a-606e-421c-88a0-d7669aa583a8</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Data</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7ae41aa5-47f3-4d76-b02c-696073f7c587</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Data</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ReceiverSelfCorrelationOrch'</ActionName><IsAtomic>0</IsAtomic><Line>209</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>222</Line><Position>22</Position><ShapeID>'d77a9052-4ad4-4495-b845-71f2e378617e'</ShapeID>
<Messages>
	<MsgInfo><name>msgStart</name><part>part</part><schema>POC.DirectBoundPorts.SelfCorrelation.TriggerProcess</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>224</Line><Position>79</Position><ShapeID>'05fb5393-8fcd-4035-8e9b-1247cc9d57b7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>226</Line><Position>13</Position><ShapeID>'f4b2360a-606e-421c-88a0-d7669aa583a8'</ShapeID>
<Messages>
	<MsgInfo><name>msgData</name><part>part</part><schema>POC.DirectBoundPorts.SelfCorrelation.Data</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>228</Line><Position>13</Position><ShapeID>'7ae41aa5-47f3-4d76-b02c-696073f7c587'</ShapeID>
<Messages>
	<MsgInfo><name>msgData</name><part>part</part><schema>POC.DirectBoundPorts.SelfCorrelation.Data</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='5d3f5076-051b-4d3a-a620-4cccafab515d' LowerBound='1.1' HigherBound='49.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.DirectBoundPorts.SelfCorrelation' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5c44bea5-47bf-4e7e-94ed-0181b4c623cc' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='TriggerProcessPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2e576d6d-9e8c-4b6c-beb1-086f89e02422' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TriggerOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='69430126-0299-4c0f-a442-ce00fe33cfd8' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.27'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.SelfCorrelation.TriggerProcess' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='9f210ac3-6a77-4a41-8959-53add3c020cd' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SelfCorrelationPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='07c5000e-a106-4e66-890d-562be4eb7ed9' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GetDataOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='eb212283-aaa3-46bb-bca7-a89cde459e2b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.17'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.SelfCorrelation.Data' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='bb6e283b-43a1-4d73-8763-5dbd0abcd636' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendDataPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='58d6d97d-7339-4f00-990a-baee9336af85' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SndDataOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='93e965c4-f670-414f-8182-75d8c758f0ba' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.17'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.SelfCorrelation.Data' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='038bce7d-d723-4517-9f76-d4e0334ae7a4' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='48.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiverSelfCorrelationOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='c4e6a672-187b-4037-a0d5-4147ceaf4e09' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.SelfCorrelation.TriggerProcess' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgStart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d395fbe1-215f-4855-b5dc-323c90016067' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.SelfCorrelation.Data' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgData' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='348d36ed-7caf-4f2a-a4d6-2e7a17a60889' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='d77a9052-4ad4-4495-b845-71f2e378617e' ParentLink='ServiceBody_Statement' LowerBound='38.1' HigherBound='40.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='TriggerProcessPort' />
                    <om:Property Name='MessageName' Value='msgStart' />
                    <om:Property Name='OperationName' Value='TriggerOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive StartMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Exec' OID='05fb5393-8fcd-4035-8e9b-1247cc9d57b7' ParentLink='ServiceBody_Statement' LowerBound='40.1' HigherBound='42.1'>
                    <om:Property Name='Invokee' Value='POC.DirectBoundPorts.SelfCorrelation.SendSelfCorrelationOrch' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StartOrchestration_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Parameter' OID='fce1882f-cfb4-4ef4-b9b2-a5941f15002b' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='SelfCorrelationPort' />
                        <om:Property Name='Type' Value='POC.DirectBoundPorts.SelfCorrelation.SelfCorrelationPortType' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Receive' OID='f4b2360a-606e-421c-88a0-d7669aa583a8' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='44.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SelfCorrelationPort' />
                    <om:Property Name='MessageName' Value='msgData' />
                    <om:Property Name='OperationName' Value='GetDataOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Data' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='7ae41aa5-47f3-4d76-b02c-696073f7c587' ParentLink='ServiceBody_Statement' LowerBound='44.1' HigherBound='46.1'>
                    <om:Property Name='PortName' Value='SendDataPort' />
                    <om:Property Name='MessageName' Value='msgData' />
                    <om:Property Name='OperationName' Value='SndDataOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Data' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='2dd907bd-ea27-4ebb-b91d-1fa7a197d145' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.SelfCorrelation.TriggerProcessPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TriggerProcessPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='526cbc63-b193-42ee-8646-4e740dfb3cbf' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8eb063e3-b5fb-4532-92d3-3516c686334d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='8' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.SelfCorrelation.SelfCorrelationPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SelfCorrelationPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='c101dd52-245e-4184-b355-fefc015618e9' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='DirectBindingType' Value='SelfCorrelating' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='9630dc73-7c8d-4fe0-abdb-15df2a15b380' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='11' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.SelfCorrelation.SendDataPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendDataPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='9aa49f4b-d172-48fd-99a2-d857469bc9a2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ReceiverSelfCorrelationOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ReceiverSelfCorrelationOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ReceiverSelfCorrelationOrch")
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
                ReceiverSelfCorrelationOrch __svc__ = (ReceiverSelfCorrelationOrch)_service;
                __ReceiverSelfCorrelationOrch_root_0 __ctx0__ = (__ReceiverSelfCorrelationOrch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.TriggerProcessPort != null)
                {
                    __svc__.TriggerProcessPort.Close(this, null);
                    __svc__.TriggerProcessPort = null;
                }
                if (__svc__.SelfCorrelationPort != null)
                {
                    __svc__.SelfCorrelationPort.Close(this, null);
                    __svc__.SelfCorrelationPort = null;
                }
                if (__svc__.SendDataPort != null)
                {
                    __svc__.SendDataPort.Close(this, null);
                    __svc__.SendDataPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __ReceiverSelfCorrelationOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ReceiverSelfCorrelationOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ReceiverSelfCorrelationOrch")
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
                ReceiverSelfCorrelationOrch __svc__ = (ReceiverSelfCorrelationOrch)_service;
                __ReceiverSelfCorrelationOrch_root_0 __ctx0__ = (__ReceiverSelfCorrelationOrch_root_0)(__svc__._stateMgrs[0]);
                __ReceiverSelfCorrelationOrch_1 __ctx1__ = (__ReceiverSelfCorrelationOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgStart != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgStart);
                    __ctx1__.__msgStart = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgData != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgData);
                    __ctx1__.__msgData = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgStart")]
            public __messagetype_POC_DirectBoundPorts_SelfCorrelation_TriggerProcess __msgStart;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgData")]
            public __messagetype_POC_DirectBoundPorts_SelfCorrelation_Data __msgData;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("TriggerProcessPort")]
        internal TriggerProcessPortType TriggerProcessPort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(Microsoft.XLANGs.BaseTypes.DirectBindingAttribute.SelfCorrelating.On)]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SelfCorrelationPort")]
        internal SelfCorrelationPortType SelfCorrelationPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendDataPort")]
        internal SendDataPortType SendDataPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {TriggerProcessPortType.TriggerOp},
                                               typeof(ReceiverSelfCorrelationOrch).GetField("TriggerProcessPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ReceiverSelfCorrelationOrch), "TriggerProcessPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SelfCorrelationPortType.GetDataOp},
                                               typeof(ReceiverSelfCorrelationOrch).GetField("SelfCorrelationPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ReceiverSelfCorrelationOrch), "SelfCorrelationPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendDataPortType.SndDataOp},
                                               typeof(ReceiverSelfCorrelationOrch).GetField("SendDataPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ReceiverSelfCorrelationOrch), "SendDataPort"),
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
                    typeof(POC.DirectBoundPorts.SelfCorrelation.SendSelfCorrelationOrch)                    
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "d77a9052-4ad4-4495-b845-71f2e378617e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "d77a9052-4ad4-4495-b845-71f2e378617e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "05fb5393-8fcd-4035-8e9b-1247cc9d57b7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "05fb5393-8fcd-4035-8e9b-1247cc9d57b7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "f4b2360a-606e-421c-88a0-d7669aa583a8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f4b2360a-606e-421c-88a0-d7669aa583a8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "7ae41aa5-47f3-4d76-b02c-696073f7c587", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "7ae41aa5-47f3-4d76-b02c-696073f7c587", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Exec),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Exec),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,9,9,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,4,5,5,6,7,7,7,8,9,9,9,9,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ReceiverSelfCorrelationOrch_root_0 __ctx0__ = (__ReceiverSelfCorrelationOrch_root_0)_stateMgrs[0];
            __ReceiverSelfCorrelationOrch_1 __ctx1__ = (__ReceiverSelfCorrelationOrch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                TriggerProcessPort = new TriggerProcessPortType(0, this);
                SelfCorrelationPort = new SelfCorrelationPortType(1, this);
                SendDataPort = new SendDataPortType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], TriggerProcessPort, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(0, System.Guid.Empty, SelfCorrelationPort, 0, __ctx0__);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ReceiverSelfCorrelationOrch_1(this);
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
            __ReceiverSelfCorrelationOrch_root_0 __ctx0__ = (__ReceiverSelfCorrelationOrch_root_0)_stateMgrs[0];
            __ReceiverSelfCorrelationOrch_1 __ctx1__ = (__ReceiverSelfCorrelationOrch_1)_stateMgrs[1];

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
                if (!TriggerProcessPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgStart != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgStart);
                __ctx1__.__msgStart = new __messagetype_POC_DirectBoundPorts_SelfCorrelation_TriggerProcess("msgStart", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgStart);
                TriggerProcessPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgStart, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (TriggerProcessPort != null)
                {
                    TriggerProcessPort.Close(__ctx1__, __seg__);
                    TriggerProcessPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgStart);
                    __edata.PortName = @"TriggerProcessPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgStart != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgStart);
                    __ctx1__.__msgStart = null;
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
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ExecService(__ctx1__, typeof(POC.DirectBoundPorts.SelfCorrelation.SendSelfCorrelationOrch), new object[] {SelfCorrelationPort.BindingInfo});
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!SelfCorrelationPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgData != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgData);
                __ctx1__.__msgData = new __messagetype_POC_DirectBoundPorts_SelfCorrelation_Data("msgData", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgData);
                SelfCorrelationPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgData, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SelfCorrelationPort != null)
                {
                    SelfCorrelationPort.Close(__ctx1__, __seg__);
                    SelfCorrelationPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgData);
                    __edata.PortName = @"SelfCorrelationPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendDataPort.SendMessage(0, __ctx1__.__msgData, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendDataPort != null)
                {
                    SendDataPort.Close(__ctx1__, __seg__);
                    SendDataPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgData);
                    __edata.PortName = @"SendDataPort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgData != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgData);
                    __ctx1__.__msgData = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 19;
            case 19:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{E24B9AFA-EF37-4FD6-A385-2CE0BEE4C463}"))
        };

    }
    //#line 83 "C:\DEV\POC\POC.DirectBoundPorts.SelfCorrelation\POC.DirectBoundPorts.SelfCorrelation\SendSelfCorrelationOrch.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.DirectBoundPorts.SelfCorrelation.SelfCorrelationPortType)
        },
        new System.String[] {
            "SelfCorrelationPort"
        },
        new System.Type[] {
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class SendSelfCorrelationOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses, "") ] POC.DirectBoundPorts.SelfCorrelation.SelfCorrelationPortType SelfCorrelationPort)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(SendSelfCorrelationOrch));
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

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static SendSelfCorrelationOrch()
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
            _rootContext = new __SendSelfCorrelationOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        [System.SerializableAttribute]
        public class BodyCallSite : Microsoft.BizTalk.XLANGs.BTXEngine.BTXCallSite
        {

            public override Microsoft.XLANGs.Core.PortInfo[] PortInformation { get { return SendSelfCorrelationOrch._portInfo; } }

            public override System.Guid ServiceId { get { return SendSelfCorrelationOrch._serviceId; } }

            public BodyCallSite(Microsoft.XLANGs.Core.Context ctx, Microsoft.XLANGs.Core.CallSite.ConvoyMap[] convoyMap, Microsoft.XLANGs.Core.PortBase SelfCorrelationPort)
                : base( convoyMap )
            {
            }

            public override void Destroy(Microsoft.XLANGs.Core.Context ctx)
            {
            }
        }

        public SendSelfCorrelationOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent, BodyCallSite callSite)
            : base(callIndex, instanceId, parent, "SendSelfCorrelationOrch")
        {
            ConstructorHelper();
        }

        public SendSelfCorrelationOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "SendSelfCorrelationOrch", tracker)
        {
            ConstructorHelper();
            IsExeced = true;
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>0fe07acb-d5ee-40c2-8dc0-32aba6ed6334</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>PortDeclarationShape</shapeType>      <ShapeID>de581473-7f74-4898-abbd-73448254eb6a</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>SelfCorrelationPort</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LogicalBindingAttributeShape</shapeType>      <ShapeID>a17f9152-169d-42c0-917f-eeda471465cb</ShapeID>      <ParentLink>PortDeclaration_CLRAttribute</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>29d61064-8270-4ff0-b980-f48142928f63</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Data Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>62799683-5f19-4e94-a940-e03abb6d54dd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Data MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>03115112-86b1-42f7-b3d8-d0182da5beb6</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>cd38b80e-d5ae-47ae-98c7-af86f9709edf</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_ DAta</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'SendSelfCorrelationOrch'</ActionName><IsAtomic>0</IsAtomic><Line>83</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>91</Line><Position>13</Position><ShapeID>'29d61064-8270-4ff0-b980-f48142928f63'</ShapeID>
<Messages>
	<MsgInfo><name>msgData</name><part>part</part><schema>POC.DirectBoundPorts.SelfCorrelation.Data</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>101</Line><Position>13</Position><ShapeID>'cd38b80e-d5ae-47ae-98c7-af86f9709edf'</ShapeID>
<Messages>
	<MsgInfo><name>msgData</name><part>part</part><schema>POC.DirectBoundPorts.SelfCorrelation.Data</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='26ecb5b6-699f-4377-bf28-503f9f9b6477' LowerBound='1.1' HigherBound='27.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.DirectBoundPorts.SelfCorrelation' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='de447c30-cf79-42d0-a1d7-6cdef43a904c' ParentLink='Module_ServiceDeclaration' LowerBound='4.1' HigherBound='26.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendSelfCorrelationOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='d4557641-9449-4088-a3c3-ad8b0ae0cb98' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='8.1' HigherBound='9.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='81ecc59e-02d6-45ce-aa90-bb69b5535685' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='7.1' HigherBound='8.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.SelfCorrelation.Data' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgData' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='0fe07acb-d5ee-40c2-8dc0-32aba6ed6334' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PortDeclaration' OID='de581473-7f74-4898-abbd-73448254eb6a' ParentLink='ServiceBody_Declaration' LowerBound='9.15' HigherBound='9.68'>
                    <om:Property Name='PortModifier' Value='Uses' />
                    <om:Property Name='Orientation' Value='Left' />
                    <om:Property Name='PortIndex' Value='13' />
                    <om:Property Name='IsWebPort' Value='False' />
                    <om:Property Name='OrderedDelivery' Value='False' />
                    <om:Property Name='DeliveryNotification' Value='None' />
                    <om:Property Name='Type' Value='POC.DirectBoundPorts.SelfCorrelation.SelfCorrelationPortType' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SelfCorrelationPort' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='LogicalBindingAttribute' OID='a17f9152-169d-42c0-917f-eeda471465cb' ParentLink='PortDeclaration_CLRAttribute'>
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='29d61064-8270-4ff0-b980-f48142928f63' ParentLink='ServiceBody_Statement' LowerBound='12.1' HigherBound='22.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Data Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='62799683-5f19-4e94-a940-e03abb6d54dd' ParentLink='ComplexStatement_Statement' LowerBound='15.1' HigherBound='21.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:Data xmlns:ns0=&quot;&quot;http://POC.DirectBoundPorts.SelfCorrelation.Data&quot;&quot;&gt;&lt;SomeData&gt;SomeData_0&lt;/SomeData&gt;&lt;/ns0:Data&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgData = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Data MsgAssign' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='03115112-86b1-42f7-b3d8-d0182da5beb6' ParentLink='Construct_MessageRef' LowerBound='13.23' HigherBound='13.30'>
                        <om:Property Name='Ref' Value='msgData' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='cd38b80e-d5ae-47ae-98c7-af86f9709edf' ParentLink='ServiceBody_Statement' LowerBound='22.1' HigherBound='24.1'>
                    <om:Property Name='PortName' Value='SelfCorrelationPort' />
                    <om:Property Name='MessageName' Value='msgData' />
                    <om:Property Name='OperationName' Value='GetDataOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_ DAta' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __SendSelfCorrelationOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __SendSelfCorrelationOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SendSelfCorrelationOrch")
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
                SendSelfCorrelationOrch __svc__ = (SendSelfCorrelationOrch)_service;
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __SendSelfCorrelationOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __SendSelfCorrelationOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SendSelfCorrelationOrch")
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
                SendSelfCorrelationOrch __svc__ = (SendSelfCorrelationOrch)_service;
                __SendSelfCorrelationOrch_1 __ctx1__ = (__SendSelfCorrelationOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgData != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgData);
                    __ctx1__.__msgData = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgData")]
            public __messagetype_POC_DirectBoundPorts_SelfCorrelation_Data __msgData;
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

        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SelfCorrelationPort")]
        internal SelfCorrelationPortType SelfCorrelationPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SelfCorrelationPortType.GetDataOp},
                                               typeof(SendSelfCorrelationOrch).GetField("SelfCorrelationPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SendSelfCorrelationOrch), "SelfCorrelationPort"),
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


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "29d61064-8270-4ff0-b980-f48142928f63", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "29d61064-8270-4ff0-b980-f48142928f63", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "cd38b80e-d5ae-47ae-98c7-af86f9709edf", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "cd38b80e-d5ae-47ae-98c7-af86f9709edf", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,3,4,4,4,5,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __SendSelfCorrelationOrch_root_0 __ctx0__ = (__SendSelfCorrelationOrch_root_0)_stateMgrs[0];
            __SendSelfCorrelationOrch_1 __ctx1__ = (__SendSelfCorrelationOrch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                SelfCorrelationPort = new SelfCorrelationPortType(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __SendSelfCorrelationOrch_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __SendSelfCorrelationOrch_root_0 __ctx0__ = (__SendSelfCorrelationOrch_root_0)_stateMgrs[0];
            __SendSelfCorrelationOrch_1 __ctx1__ = (__SendSelfCorrelationOrch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                SelfCorrelationPort.BindingInfo = Args[0];
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__varXML = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                {
                    __messagetype_POC_DirectBoundPorts_SelfCorrelation_Data __msgData = new __messagetype_POC_DirectBoundPorts_SelfCorrelation_Data("msgData", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:Data xmlns:ns0=""http://POC.DirectBoundPorts.SelfCorrelation.Data""><SomeData>SomeData_0</SomeData></ns0:Data>");
                    __msgData.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgData != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgData);
                    __ctx1__.__msgData = __msgData;
                    __ctx1__.RefMessage(__ctx1__.__msgData);
                }
                __ctx1__.__msgData.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgData);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SelfCorrelationPort.SendMessage(0, __ctx1__.__msgData, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgData);
                    __edata.PortName = @"SelfCorrelationPort";
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgData != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgData);
                    __ctx1__.__msgData = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 14;
            case 14:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_DirectBoundPorts_SelfCorrelation_TriggerProcess__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.DirectBoundPorts.SelfCorrelation.TriggerProcess _schema = new POC.DirectBoundPorts.SelfCorrelation.TriggerProcess();

        public __POC_DirectBoundPorts_SelfCorrelation_TriggerProcess__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.DirectBoundPorts.SelfCorrelation.TriggerProcess",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.SelfCorrelation.TriggerProcess)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_DirectBoundPorts_SelfCorrelation_TriggerProcess__)
        },
        0,
        @"http://POC.DirectBoundPorts.SelfCorrelation.TriggerProcess#Trigger"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_DirectBoundPorts_SelfCorrelation_TriggerProcess : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_DirectBoundPorts_SelfCorrelation_TriggerProcess__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_DirectBoundPorts_SelfCorrelation_TriggerProcess__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_DirectBoundPorts_SelfCorrelation_TriggerProcess(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_DirectBoundPorts_SelfCorrelation_Data__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.DirectBoundPorts.SelfCorrelation.Data _schema = new POC.DirectBoundPorts.SelfCorrelation.Data();

        public __POC_DirectBoundPorts_SelfCorrelation_Data__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.DirectBoundPorts.SelfCorrelation.Data",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.SelfCorrelation.Data)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_DirectBoundPorts_SelfCorrelation_Data__)
        },
        0,
        @"http://POC.DirectBoundPorts.SelfCorrelation.Data#Data"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_DirectBoundPorts_SelfCorrelation_Data : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_DirectBoundPorts_SelfCorrelation_Data__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_DirectBoundPorts_SelfCorrelation_Data__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_DirectBoundPorts_SelfCorrelation_Data(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
