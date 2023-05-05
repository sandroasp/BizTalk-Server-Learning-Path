
#pragma warning disable 162

namespace POC.DirectBoundPorts.Partner
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "RcvPartnerRouteOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.Partner.__messagetype_POC_DirectBoundPorts_Partner_RoutedMsg)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ReceivePartnerRoutedPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceivePartnerRoutedPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceivePartnerRoutedPortType(ReceivePartnerRoutedPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceivePartnerRoutedPortType p = new ReceivePartnerRoutedPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo RcvPartnerRouteOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "RcvPartnerRouteOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceivePartnerRoutedPortType),
            typeof(__messagetype_POC_DirectBoundPorts_Partner_RoutedMsg),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "RcvPartnerRouteOp" ] = RcvPartnerRouteOp;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "FinalMsgOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.Partner.__messagetype_POC_DirectBoundPorts_Partner_FinalMsg)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SendFinalPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendFinalPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendFinalPortType(SendFinalPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendFinalPortType p = new SendFinalPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo FinalMsgOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "FinalMsgOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendFinalPortType),
            typeof(__messagetype_POC_DirectBoundPorts_Partner_FinalMsg),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "FinalMsgOp" ] = FinalMsgOp;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "RcvInboundOp",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.Partner.__messagetype_POC_DirectBoundPorts_Partner_InMsg)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RcvInboundPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RcvInboundPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RcvInboundPortType(RcvInboundPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RcvInboundPortType p = new RcvInboundPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo RcvInboundOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "RcvInboundOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RcvInboundPortType),
            typeof(__messagetype_POC_DirectBoundPorts_Partner_InMsg),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "RcvInboundOp" ] = RcvInboundOp;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 171 "C:\DEV\POC\POC.DirectBoundPorts.Partner\POC.DirectBoundPorts.Partner\ReceiverParnerOrch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceivePartnerRoutedPort", "RcvPartnerRouteOp", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.DirectBoundPorts.Partner.ReceivePartnerRoutedPortType),
            typeof(POC.DirectBoundPorts.Partner.SendFinalPortType)
        },
        new System.String[] {
            "ReceivePartnerRoutedPort",
            "SendFinalPort"
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
    sealed internal class ReceiverParnerOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ReceiverParnerOrch));
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

        static ReceiverParnerOrch()
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
            _rootContext = new __ReceiverParnerOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ReceiverParnerOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ReceiverParnerOrch", tracker)
        {
            ConstructorHelper();
        }

        public ReceiverParnerOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ReceiverParnerOrch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>dd3b4be5-7e5b-4baf-9a47-e83a737ff0b2</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>abf74d24-8bad-4fec-a70c-e6c55cf22d6e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Routed Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4ad36499-0711-4593-910d-4724e3d3c7b1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Final Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>9a441f73-38f9-4dec-8816-ace621a6c29f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Final MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9df0b116-05d1-4964-b49c-c239102ce2f4</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0868a815-143e-4f28-ba0a-7aaf4da343ab</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Final Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ReceiverParnerOrch'</ActionName><IsAtomic>0</IsAtomic><Line>171</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>183</Line><Position>22</Position><ShapeID>'abf74d24-8bad-4fec-a70c-e6c55cf22d6e'</ShapeID>
<Messages>
	<MsgInfo><name>msgRoutedMsg</name><part>part</part><schema>POC.DirectBoundPorts.Partner.RoutedMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>186</Line><Position>13</Position><ShapeID>'4ad36499-0711-4593-910d-4724e3d3c7b1'</ShapeID>
<Messages>
	<MsgInfo><name>msgFinal</name><part>part</part><schema>POC.DirectBoundPorts.Partner.FinalMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>195</Line><Position>13</Position><ShapeID>'0868a815-143e-4f28-ba0a-7aaf4da343ab'</ShapeID>
<Messages>
	<MsgInfo><name>msgFinal</name><part>part</part><schema>POC.DirectBoundPorts.Partner.FinalMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='0df0a38d-19d4-439a-8697-7f0d8c9359ae' LowerBound='1.1' HigherBound='47.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.DirectBoundPorts.Partner' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='44a8d8cb-e977-44bb-8a8c-6e8f34aed062' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='46.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiverParnerOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='89aaa18a-1b05-41a2-a88b-79b2bc9cb433' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='495625a0-bdc8-4258-973f-f4b6fc873839' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.Partner.FinalMsg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgFinal' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3bd40aa5-c2d4-40a7-9081-4887f3aadcdb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.Partner.RoutedMsg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgRoutedMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='dd3b4be5-7e5b-4baf-9a47-e83a737ff0b2' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='abf74d24-8bad-4fec-a70c-e6c55cf22d6e' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='33.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceivePartnerRoutedPort' />
                    <om:Property Name='MessageName' Value='msgRoutedMsg' />
                    <om:Property Name='OperationName' Value='RcvPartnerRouteOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Routed Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='4ad36499-0711-4593-910d-4724e3d3c7b1' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='42.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Final Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='9a441f73-38f9-4dec-8816-ace621a6c29f' ParentLink='ComplexStatement_Statement' LowerBound='36.1' HigherBound='41.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:FinalMsg xmlns:ns0=&quot;&quot;http://POC.DirectBoundPorts.Partner.FinalMsg&quot;&quot;&gt;&lt;Message&gt;Partner routed Message&lt;/Message&gt;&lt;/ns0:FinalMsg&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgFinal = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Final MsgAssign' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='9df0b116-05d1-4964-b49c-c239102ce2f4' ParentLink='Construct_MessageRef' LowerBound='34.23' HigherBound='34.31'>
                        <om:Property Name='Ref' Value='msgFinal' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='0868a815-143e-4f28-ba0a-7aaf4da343ab' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='44.1'>
                    <om:Property Name='PortName' Value='SendFinalPort' />
                    <om:Property Name='MessageName' Value='msgFinal' />
                    <om:Property Name='OperationName' Value='FinalMsgOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Final Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1e5172fb-debf-424b-8063-7837da5009c9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.Partner.ReceivePartnerRoutedPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceivePartnerRoutedPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='d2f20fb0-c29b-466a-91a8-88a667d60bdb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='PartnerPort' Value='ReceivePartnerRoutedPort' />
                    <om:Property Name='PartnerService' Value='POC.DirectBoundPorts.Partner.ReceiverParnerOrch' />
                    <om:Property Name='DirectBindingType' Value='PartnerPort' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='220fafd1-02b4-43ba-8cfc-e2d7b95d1df3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='16' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.Partner.SendFinalPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendFinalPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='9a81169d-d9ec-4b5d-8f35-5d27371849a5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='ab72d899-9a7a-4428-a7e0-69154df81909' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceivePartnerRoutedPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cfd314c9-7bf0-46cf-941f-00b3400a6549' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvPartnerRouteOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='8b84582d-39d5-4e60-a4ba-3f9a3e7b0ff1' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.22'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.Partner.RoutedMsg' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='013c2b43-dc74-4bd6-a170-a4c1be69239b' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendFinalPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='5547d989-9052-4e42-ba3e-c8290e6235fe' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FinalMsgOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='fe967011-503a-431a-9c2b-c1ba04b8fb95' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.21'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.Partner.FinalMsg' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ReceiverParnerOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ReceiverParnerOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ReceiverParnerOrch")
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
                ReceiverParnerOrch __svc__ = (ReceiverParnerOrch)_service;
                __ReceiverParnerOrch_root_0 __ctx0__ = (__ReceiverParnerOrch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceivePartnerRoutedPort != null)
                {
                    __svc__.ReceivePartnerRoutedPort.Close(this, null);
                    __svc__.ReceivePartnerRoutedPort = null;
                }
                if (__svc__.SendFinalPort != null)
                {
                    __svc__.SendFinalPort.Close(this, null);
                    __svc__.SendFinalPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ReceiverParnerOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ReceiverParnerOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ReceiverParnerOrch")
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
                ReceiverParnerOrch __svc__ = (ReceiverParnerOrch)_service;
                __ReceiverParnerOrch_1 __ctx1__ = (__ReceiverParnerOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgRoutedMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgRoutedMsg);
                    __ctx1__.__msgRoutedMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgFinal != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgFinal);
                    __ctx1__.__msgFinal = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgFinal")]
            public __messagetype_POC_DirectBoundPorts_Partner_FinalMsg __msgFinal;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgRoutedMsg")]
            public __messagetype_POC_DirectBoundPorts_Partner_RoutedMsg __msgRoutedMsg;
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

        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(typeof(ReceiverParnerOrch), "ReceivePartnerRoutedPort")]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceivePartnerRoutedPort")]
        internal ReceivePartnerRoutedPortType ReceivePartnerRoutedPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendFinalPort")]
        internal SendFinalPortType SendFinalPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceivePartnerRoutedPortType.RcvPartnerRouteOp},
                                               typeof(ReceiverParnerOrch).GetField("ReceivePartnerRoutedPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ReceiverParnerOrch), "ReceivePartnerRoutedPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendFinalPortType.FinalMsgOp},
                                               typeof(ReceiverParnerOrch).GetField("SendFinalPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ReceiverParnerOrch), "SendFinalPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "abf74d24-8bad-4fec-a70c-e6c55cf22d6e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "abf74d24-8bad-4fec-a70c-e6c55cf22d6e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "4ad36499-0711-4593-910d-4724e3d3c7b1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "4ad36499-0711-4593-910d-4724e3d3c7b1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "0868a815-143e-4f28-ba0a-7aaf4da343ab", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "0868a815-143e-4f28-ba0a-7aaf4da343ab", 1, false)
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
            __ReceiverParnerOrch_1 __ctx1__ = (__ReceiverParnerOrch_1)_stateMgrs[1];
            __ReceiverParnerOrch_root_0 __ctx0__ = (__ReceiverParnerOrch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                ReceivePartnerRoutedPort = new ReceivePartnerRoutedPortType(0, this);
                SendFinalPort = new SendFinalPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceivePartnerRoutedPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ReceiverParnerOrch_1(this);
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
            __ReceiverParnerOrch_1 __ctx1__ = (__ReceiverParnerOrch_1)_stateMgrs[1];
            __ReceiverParnerOrch_root_0 __ctx0__ = (__ReceiverParnerOrch_root_0)_stateMgrs[0];

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
                if (!ReceivePartnerRoutedPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgRoutedMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgRoutedMsg);
                __ctx1__.__msgRoutedMsg = new __messagetype_POC_DirectBoundPorts_Partner_RoutedMsg("msgRoutedMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgRoutedMsg);
                ReceivePartnerRoutedPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgRoutedMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceivePartnerRoutedPort != null)
                {
                    ReceivePartnerRoutedPort.Close(__ctx1__, __seg__);
                    ReceivePartnerRoutedPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgRoutedMsg);
                    __edata.PortName = @"ReceivePartnerRoutedPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgRoutedMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgRoutedMsg);
                    __ctx1__.__msgRoutedMsg = null;
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
                    __messagetype_POC_DirectBoundPorts_Partner_FinalMsg __msgFinal = new __messagetype_POC_DirectBoundPorts_Partner_FinalMsg("msgFinal", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:FinalMsg xmlns:ns0=""http://POC.DirectBoundPorts.Partner.FinalMsg""><Message>Partner routed Message</Message></ns0:FinalMsg>");
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
                SendFinalPort.SendMessage(0, __ctx1__.__msgFinal, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendFinalPort != null)
                {
                    SendFinalPort.Close(__ctx1__, __seg__);
                    SendFinalPort = null;
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
                    __edata.PortName = @"SendFinalPort";
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
    //#line 145 "C:\DEV\POC\POC.DirectBoundPorts.Partner\POC.DirectBoundPorts.Partner\SenderPartnerOrch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvInboundPort", "RcvInboundOp", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.DirectBoundPorts.Partner.RcvInboundPortType),
            typeof(POC.DirectBoundPorts.Partner.ReceivePartnerRoutedPortType)
        },
        new System.String[] {
            "RcvInboundPort",
            "SendPartnerPort"
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
    sealed internal class SenderPartnerOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(SenderPartnerOrch));
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

        static SenderPartnerOrch()
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
            _rootContext = new __SenderPartnerOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public SenderPartnerOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "SenderPartnerOrch", tracker)
        {
            ConstructorHelper();
        }

        public SenderPartnerOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "SenderPartnerOrch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>fe6a3a2a-f8da-4e6b-934c-6f4cd8ac55fa</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>3e71ca5d-bc65-4272-a1d3-bc98c988eedd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive In Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8ed47a91-fa46-483f-b827-455b80e263b8</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Route Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>8954e22b-ad18-464a-bc46-ac810b8fb99d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Route MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>13cdac13-a0f7-48cb-b748-20bf38a946fe</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f0d22658-8b44-45a4-b440-9119448e273c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send RouteMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'SenderPartnerOrch'</ActionName><IsAtomic>0</IsAtomic><Line>145</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>157</Line><Position>22</Position><ShapeID>'3e71ca5d-bc65-4272-a1d3-bc98c988eedd'</ShapeID>
<Messages>
	<MsgInfo><name>msgIn</name><part>part</part><schema>POC.DirectBoundPorts.Partner.InMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>160</Line><Position>13</Position><ShapeID>'8ed47a91-fa46-483f-b827-455b80e263b8'</ShapeID>
<Messages>
	<MsgInfo><name>msgRoutedMsg</name><part>part</part><schema>POC.DirectBoundPorts.Partner.RoutedMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>169</Line><Position>13</Position><ShapeID>'f0d22658-8b44-45a4-b440-9119448e273c'</ShapeID>
<Messages>
	<MsgInfo><name>msgRoutedMsg</name><part>part</part><schema>POC.DirectBoundPorts.Partner.RoutedMsg</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='b6b88cb8-1a20-4742-8091-7f57e29136d5' LowerBound='1.1' HigherBound='40.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.DirectBoundPorts.Partner' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='b8af70b1-78ea-4b08-ac34-f240be277c77' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvInboundPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='773b230c-967a-451a-b1e8-f83848dd2431' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvInboundOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ceafd8f6-4037-4411-b658-099cc89fe16f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.18'>
                    <om:Property Name='Ref' Value='POC.DirectBoundPorts.Partner.InMsg' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='75128676-7bbd-4718-9e09-3fbae6ec511e' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='39.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SenderPartnerOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='75a2ab99-877d-42cb-a551-062ac04f9856' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f2d58b20-5503-4c6c-8878-1d84cc33237a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.Partner.RoutedMsg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgRoutedMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6c18e92b-297e-44a0-b67b-a0f63c98e3ef' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='Type' Value='POC.DirectBoundPorts.Partner.InMsg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='fe6a3a2a-f8da-4e6b-934c-6f4cd8ac55fa' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='3e71ca5d-bc65-4272-a1d3-bc98c988eedd' ParentLink='ServiceBody_Statement' LowerBound='23.1' HigherBound='26.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvInboundPort' />
                    <om:Property Name='MessageName' Value='msgIn' />
                    <om:Property Name='OperationName' Value='RcvInboundOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive In Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='8ed47a91-fa46-483f-b827-455b80e263b8' ParentLink='ServiceBody_Statement' LowerBound='26.1' HigherBound='35.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Route Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='8954e22b-ad18-464a-bc46-ac810b8fb99d' ParentLink='ComplexStatement_Statement' LowerBound='29.1' HigherBound='34.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:RoutedMsg xmlns:ns0=&quot;&quot;http://POC.DirectBoundPorts.Partner.RoutedMsg&quot;&quot;&gt;&lt;Message&gt;Partner to be route&lt;/Message&gt;&lt;/ns0:RoutedMsg&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgRoutedMsg = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Route MsgAssign' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='13cdac13-a0f7-48cb-b748-20bf38a946fe' ParentLink='Construct_MessageRef' LowerBound='27.23' HigherBound='27.35'>
                        <om:Property Name='Ref' Value='msgRoutedMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='f0d22658-8b44-45a4-b440-9119448e273c' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='37.1'>
                    <om:Property Name='PortName' Value='SendPartnerPort' />
                    <om:Property Name='MessageName' Value='msgRoutedMsg' />
                    <om:Property Name='OperationName' Value='RcvPartnerRouteOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send RouteMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='50af5b8d-e735-41c2-b9a7-b5bb64150375' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.Partner.RcvInboundPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvInboundPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='1ec813e9-c645-4d5d-994d-442bca9e383d' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='eace1784-508c-4524-8616-99683687de60' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='16.1' HigherBound='18.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='16' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.DirectBoundPorts.Partner.ReceivePartnerRoutedPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPartnerPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='e7ecc9bc-fb78-42f7-83bc-e61244672c7e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='16.1' HigherBound='17.1'>
                    <om:Property Name='PartnerPort' Value='ReceivePartnerRoutedPort' />
                    <om:Property Name='PartnerService' Value='POC.DirectBoundPorts.Partner.ReceiverParnerOrch' />
                    <om:Property Name='DirectBindingType' Value='PartnerPort' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __SenderPartnerOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __SenderPartnerOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SenderPartnerOrch")
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
                SenderPartnerOrch __svc__ = (SenderPartnerOrch)_service;
                __SenderPartnerOrch_root_0 __ctx0__ = (__SenderPartnerOrch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendPartnerPort != null)
                {
                    __svc__.SendPartnerPort.Close(this, null);
                    __svc__.SendPartnerPort = null;
                }
                if (__svc__.RcvInboundPort != null)
                {
                    __svc__.RcvInboundPort.Close(this, null);
                    __svc__.RcvInboundPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __SenderPartnerOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __SenderPartnerOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SenderPartnerOrch")
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
                SenderPartnerOrch __svc__ = (SenderPartnerOrch)_service;
                __SenderPartnerOrch_1 __ctx1__ = (__SenderPartnerOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgRoutedMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgRoutedMsg);
                    __ctx1__.__msgRoutedMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                    __ctx1__.__msgIn = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgRoutedMsg")]
            public __messagetype_POC_DirectBoundPorts_Partner_RoutedMsg __msgRoutedMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgIn")]
            public __messagetype_POC_DirectBoundPorts_Partner_InMsg __msgIn;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvInboundPort")]
        internal RcvInboundPortType RcvInboundPort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute(typeof(ReceiverParnerOrch), "ReceivePartnerRoutedPort")]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendPartnerPort")]
        internal ReceivePartnerRoutedPortType SendPartnerPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RcvInboundPortType.RcvInboundOp},
                                               typeof(SenderPartnerOrch).GetField("RcvInboundPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SenderPartnerOrch), "RcvInboundPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceivePartnerRoutedPortType.RcvPartnerRouteOp},
                                               typeof(SenderPartnerOrch).GetField("SendPartnerPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SenderPartnerOrch), "SendPartnerPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "3e71ca5d-bc65-4272-a1d3-bc98c988eedd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "3e71ca5d-bc65-4272-a1d3-bc98c988eedd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "8ed47a91-fa46-483f-b827-455b80e263b8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "8ed47a91-fa46-483f-b827-455b80e263b8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f0d22658-8b44-45a4-b440-9119448e273c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "f0d22658-8b44-45a4-b440-9119448e273c", 1, false)
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
            __SenderPartnerOrch_1 __ctx1__ = (__SenderPartnerOrch_1)_stateMgrs[1];
            __SenderPartnerOrch_root_0 __ctx0__ = (__SenderPartnerOrch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RcvInboundPort = new RcvInboundPortType(0, this);
                SendPartnerPort = new ReceivePartnerRoutedPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvInboundPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __SenderPartnerOrch_1(this);
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
            __SenderPartnerOrch_1 __ctx1__ = (__SenderPartnerOrch_1)_stateMgrs[1];
            __SenderPartnerOrch_root_0 __ctx0__ = (__SenderPartnerOrch_root_0)_stateMgrs[0];

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
                if (!RcvInboundPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                __ctx1__.__msgIn = new __messagetype_POC_DirectBoundPorts_Partner_InMsg("msgIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgIn);
                RcvInboundPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvInboundPort != null)
                {
                    RcvInboundPort.Close(__ctx1__, __seg__);
                    RcvInboundPort = null;
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
                    __edata.PortName = @"RcvInboundPort";
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
                    __messagetype_POC_DirectBoundPorts_Partner_RoutedMsg __msgRoutedMsg = new __messagetype_POC_DirectBoundPorts_Partner_RoutedMsg("msgRoutedMsg", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:RoutedMsg xmlns:ns0=""http://POC.DirectBoundPorts.Partner.RoutedMsg""><Message>Partner to be route</Message></ns0:RoutedMsg>");
                    __msgRoutedMsg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgRoutedMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgRoutedMsg);
                    __ctx1__.__msgRoutedMsg = __msgRoutedMsg;
                    __ctx1__.RefMessage(__ctx1__.__msgRoutedMsg);
                }
                __ctx1__.__msgRoutedMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgRoutedMsg);
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
                SendPartnerPort.SendMessage(0, __ctx1__.__msgRoutedMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendPartnerPort != null)
                {
                    SendPartnerPort.Close(__ctx1__, __seg__);
                    SendPartnerPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgRoutedMsg);
                    __edata.PortName = @"SendPartnerPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgRoutedMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgRoutedMsg);
                    __ctx1__.__msgRoutedMsg = null;
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
    sealed public class __POC_DirectBoundPorts_Partner_RoutedMsg__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.DirectBoundPorts.Partner.RoutedMsg _schema = new POC.DirectBoundPorts.Partner.RoutedMsg();

        public __POC_DirectBoundPorts_Partner_RoutedMsg__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.DirectBoundPorts.Partner.RoutedMsg",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.Partner.RoutedMsg)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_DirectBoundPorts_Partner_RoutedMsg__)
        },
        0,
        @"http://POC.DirectBoundPorts.Partner.RoutedMsg#RoutedMsg"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_DirectBoundPorts_Partner_RoutedMsg : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_DirectBoundPorts_Partner_RoutedMsg__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_DirectBoundPorts_Partner_RoutedMsg__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_DirectBoundPorts_Partner_RoutedMsg(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_DirectBoundPorts_Partner_FinalMsg__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.DirectBoundPorts.Partner.FinalMsg _schema = new POC.DirectBoundPorts.Partner.FinalMsg();

        public __POC_DirectBoundPorts_Partner_FinalMsg__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.DirectBoundPorts.Partner.FinalMsg",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.Partner.FinalMsg)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_DirectBoundPorts_Partner_FinalMsg__)
        },
        0,
        @"http://POC.DirectBoundPorts.Partner.FinalMsg#FinalMsg"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_DirectBoundPorts_Partner_FinalMsg : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_DirectBoundPorts_Partner_FinalMsg__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_DirectBoundPorts_Partner_FinalMsg__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_DirectBoundPorts_Partner_FinalMsg(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_DirectBoundPorts_Partner_InMsg__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.DirectBoundPorts.Partner.InMsg _schema = new POC.DirectBoundPorts.Partner.InMsg();

        public __POC_DirectBoundPorts_Partner_InMsg__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.DirectBoundPorts.Partner.InMsg",
        new System.Type[]{
            typeof(POC.DirectBoundPorts.Partner.InMsg)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_DirectBoundPorts_Partner_InMsg__)
        },
        0,
        @"http://POC.DirectBoundPorts.Partner.InMsg#InMsg"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_DirectBoundPorts_Partner_InMsg : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_DirectBoundPorts_Partner_InMsg__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_DirectBoundPorts_Partner_InMsg__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_DirectBoundPorts_Partner_InMsg(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
