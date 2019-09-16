
#pragma warning disable 162

namespace HowToSendOrchestrationVariablesIntoMaps
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ReceiveCustomerOrder",
        new System.Type[]{
            typeof(HowToSendOrchestrationVariablesIntoMaps.__messagetype_HowToSendOrchestrationVariablesIntoMaps_Order)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class CustomerOrderInputType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public CustomerOrderInputType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public CustomerOrderInputType(CustomerOrderInputType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            CustomerOrderInputType p = new CustomerOrderInputType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ReceiveCustomerOrder = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ReceiveCustomerOrder",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(CustomerOrderInputType),
            typeof(__messagetype_HowToSendOrchestrationVariablesIntoMaps_Order),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ReceiveCustomerOrder" ] = ReceiveCustomerOrder;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendSAPOrder",
        new System.Type[]{
            typeof(HowToSendOrchestrationVariablesIntoMaps.__messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class SAPorderType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SAPorderType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SAPorderType(SAPorderType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SAPorderType p = new SAPorderType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendSAPOrder = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendSAPOrder",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SAPorderType),
            typeof(__messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendSAPOrder" ] = SendSAPOrder;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 240 "C:\Development\03- HowToSendOrchestrationVariablesIntoMaps\HowToSendOrchestrationVariablesIntoMaps\SendOrchestrationVariablesIntoMaps.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "CustomerOrderPort", "ReceiveCustomerOrder", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(HowToSendOrchestrationVariablesIntoMaps.CustomerOrderInputType),
            typeof(HowToSendOrchestrationVariablesIntoMaps.SAPorderType)
        },
        new System.String[] {
            "CustomerOrderPort",
            "SAPPort"
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
    sealed internal class SendOrchestrationVariablesIntoMaps : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(SendOrchestrationVariablesIntoMaps));
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

        static SendOrchestrationVariablesIntoMaps()
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
            _rootContext = new __SendOrchestrationVariablesIntoMaps_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public SendOrchestrationVariablesIntoMaps(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "SendOrchestrationVariablesIntoMaps", tracker)
        {
            ConstructorHelper();
        }

        public SendOrchestrationVariablesIntoMaps(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "SendOrchestrationVariablesIntoMaps")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>c18f64c0-e55b-475f-9887-7c2c5c4e7099</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>65d32721-4e6b-48d4-9ef6-cf261a838faa</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Customer Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>397706d5-211c-466d-9884-a8579da3ad41</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Set Variables Expr</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>9131725a-0bc1-4a33-beb8-74526172e2f9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Orchestration Support Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>9a933643-9823-44bc-b3e3-f77f42573458</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>OrchestrationSupportMsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>fc78e7f8-71a3-467f-9048-66fdf3c94938</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>0f502f0f-874a-4ae4-b60d-0e1a930508ca</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct SAP Order Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>13028e27-7c33-4b88-8993-f26ecfc81879</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>OrderToSAPOrderTransformation</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5015394b-b3f2-4da8-93e0-3648788b8df2</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>32e2820b-4cc1-4ffd-abbc-5b7af5e62a27</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5bdc0c0c-6bc4-4f76-a1c0-481122bb38bb</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>5258ac60-646e-4ce9-9e13-1a56f289c0b5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>effba7d2-3cf1-4a35-9f50-040d269a4f29</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SAP Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'SendOrchestrationVariablesIntoMaps'</ActionName><IsAtomic>0</IsAtomic><Line>240</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>256</Line><Position>22</Position><ShapeID>'65d32721-4e6b-48d4-9ef6-cf261a838faa'</ShapeID>
<Messages>
	<MsgInfo><name>msgOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>262</Line><Position>28</Position><ShapeID>'397706d5-211c-466d-9884-a8579da3ad41'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>265</Line><Position>13</Position><ShapeID>'9131725a-0bc1-4a33-beb8-74526172e2f9'</ShapeID>
<Messages>
	<MsgInfo><name>msgOrchestrationSupport</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>278</Line><Position>13</Position><ShapeID>'0f502f0f-874a-4ae4-b60d-0e1a930508ca'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.SAPOrder</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.Order</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>msgOrchestrationSupport</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>284</Line><Position>13</Position><ShapeID>'effba7d2-3cf1-4a35-9f50-040d269a4f29'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.SAPOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='4cde29ca-1c1d-4fbc-b52b-d3f9972ff244' LowerBound='1.1' HigherBound='67.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='HowToSendOrchestrationVariablesIntoMaps' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='19abaf47-1cd8-4f6e-852b-098b7acf3b2b' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CustomerOrderInputType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='0fd90c9f-aa5f-4336-a933-46f00aea4893' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveCustomerOrder' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='68c1417b-ebe1-4ef9-b33f-2d49fb43307e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.18'>
                    <om:Property Name='Ref' Value='HowToSendOrchestrationVariablesIntoMaps.Order' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='fb90b779-fa53-4d24-b01d-11f213c0d9e5' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SAPorderType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ae471067-c15c-464e-a53a-662957174856' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSAPOrder' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='b81f3f49-afa1-42d5-b21f-e7cfd66359d1' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.21'>
                    <om:Property Name='Ref' Value='HowToSendOrchestrationVariablesIntoMaps.SAPOrder' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='746b13d0-f503-48a5-984c-9a5d7609f271' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='66.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendOrchestrationVariablesIntoMaps' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='b5a38131-774e-4341-8229-d55692005197' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varHasDiscount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ae5d9b05-a72b-427f-a46b-45a5b1580362' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varDiscountType' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8fc4305c-1fcf-4b04-8f95-619019e4c586' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='79aa7e9b-8ff0-4790-8997-2c479f1d2bf7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Variable_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='75b43868-4f79-4e80-ba7e-e1a3f2385cee' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.Order' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d4098a29-5726-4dc1-94c5-2814da83300b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.SAPOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSAPOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='003aa591-01a8-42be-87fb-a0713420b0c5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOrchestrationSupport' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='c18f64c0-e55b-475f-9887-7c2c5c4e7099' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='65d32721-4e6b-48d4-9ef6-cf261a838faa' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='40.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='CustomerOrderPort' />
                    <om:Property Name='MessageName' Value='msgOrder' />
                    <om:Property Name='OperationName' Value='ReceiveCustomerOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Customer Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='397706d5-211c-466d-9884-a8579da3ad41' ParentLink='ServiceBody_Statement' LowerBound='40.1' HigherBound='43.1'>
                    <om:Property Name='Expression' Value='varHasDiscount = true;&#xD;&#xA;varDiscountType = &quot;25%&quot;;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Set Variables Expr' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='9131725a-0bc1-4a33-beb8-74526172e2f9' ParentLink='ServiceBody_Statement' LowerBound='43.1' HigherBound='56.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Orchestration Support Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='9a933643-9823-44bc-b3e3-f77f42573458' ParentLink='ComplexStatement_Statement' LowerBound='46.1' HigherBound='55.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:Support xmlns:ns0=&quot;&quot;http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport&quot;&quot;&gt;&#xD;&#xA;                    &lt;HasDiscount&gt;true&lt;/HasDiscount&gt;&lt;DiscountType&gt;10&lt;/DiscountType&gt;&lt;/ns0:Support&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgOrchestrationSupport = varXML;&#xD;&#xA;&#xD;&#xA;msgOrchestrationSupport.HasDiscount = varHasDiscount;&#xD;&#xA;msgOrchestrationSupport.DiscountType = varDiscountType;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='OrchestrationSupportMsgAssign' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='fc78e7f8-71a3-467f-9048-66fdf3c94938' ParentLink='Construct_MessageRef' LowerBound='44.23' HigherBound='44.46'>
                        <om:Property Name='Ref' Value='msgOrchestrationSupport' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='0f502f0f-874a-4ae4-b60d-0e1a930508ca' ParentLink='ServiceBody_Statement' LowerBound='56.1' HigherBound='62.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct SAP Order Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='13028e27-7c33-4b88-8993-f26ecfc81879' ParentLink='ComplexStatement_Statement' LowerBound='59.1' HigherBound='61.1'>
                        <om:Property Name='ClassName' Value='HowToSendOrchestrationVariablesIntoMaps.OrderToSAPOrderTransformation' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='OrderToSAPOrderTransformation' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='5015394b-b3f2-4da8-93e0-3648788b8df2' ParentLink='Transform_InputMessagePartRef' LowerBound='60.114' HigherBound='60.122'>
                            <om:Property Name='MessageRef' Value='msgOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='32e2820b-4cc1-4ffd-abbc-5b7af5e62a27' ParentLink='Transform_InputMessagePartRef' LowerBound='60.124' HigherBound='60.147'>
                            <om:Property Name='MessageRef' Value='msgOrchestrationSupport' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='5bdc0c0c-6bc4-4f76-a1c0-481122bb38bb' ParentLink='Transform_OutputMessagePartRef' LowerBound='60.28' HigherBound='60.39'>
                            <om:Property Name='MessageRef' Value='msgSAPOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='5258ac60-646e-4ce9-9e13-1a56f289c0b5' ParentLink='Construct_MessageRef' LowerBound='57.23' HigherBound='57.34'>
                        <om:Property Name='Ref' Value='msgSAPOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='effba7d2-3cf1-4a35-9f50-040d269a4f29' ParentLink='ServiceBody_Statement' LowerBound='62.1' HigherBound='64.1'>
                    <om:Property Name='PortName' Value='SAPPort' />
                    <om:Property Name='MessageName' Value='msgSAPOrder' />
                    <om:Property Name='OperationName' Value='SendSAPOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SAP Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1c813f6b-6201-41e5-a9ab-ad8da862cff9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.CustomerOrderInputType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustomerOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='55c027f3-31f9-4bee-95f5-94b82c45c926' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='7fa11de2-cf79-4300-990b-6b86eeb5299d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='32' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.SAPorderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SAPPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='5cc70f77-c883-4f39-97cc-72dfe0072256' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __SendOrchestrationVariablesIntoMaps_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __SendOrchestrationVariablesIntoMaps_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SendOrchestrationVariablesIntoMaps")
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
                SendOrchestrationVariablesIntoMaps __svc__ = (SendOrchestrationVariablesIntoMaps)_service;
                __SendOrchestrationVariablesIntoMaps_root_0 __ctx0__ = (__SendOrchestrationVariablesIntoMaps_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.CustomerOrderPort != null)
                {
                    __svc__.CustomerOrderPort.Close(this, null);
                    __svc__.CustomerOrderPort = null;
                }
                if (__svc__.SAPPort != null)
                {
                    __svc__.SAPPort.Close(this, null);
                    __svc__.SAPPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __SendOrchestrationVariablesIntoMaps_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __SendOrchestrationVariablesIntoMaps_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SendOrchestrationVariablesIntoMaps")
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
                SendOrchestrationVariablesIntoMaps __svc__ = (SendOrchestrationVariablesIntoMaps)_service;
                __SendOrchestrationVariablesIntoMaps_1 __ctx1__ = (__SendOrchestrationVariablesIntoMaps_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                    __ctx1__.__msgOrder = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOrchestrationSupport != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrchestrationSupport);
                    __ctx1__.__msgOrchestrationSupport = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varDiscountType = null;
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                if (__ctx1__ != null)
                    __ctx1__.__Variable_1 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOrder")]
            public __messagetype_HowToSendOrchestrationVariablesIntoMaps_Order __msgOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSAPOrder")]
            public __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder __msgSAPOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOrchestrationSupport")]
            public __messagetype_HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport __msgOrchestrationSupport;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varHasDiscount")]
            internal System.Boolean __varHasDiscount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varDiscountType")]
            internal System.String __varDiscountType;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varXML")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __varXML;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Variable_1")]
            internal System.String __Variable_1;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("CustomerOrderPort")]
        internal CustomerOrderInputType CustomerOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SAPPort")]
        internal SAPorderType SAPPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CustomerOrderInputType.ReceiveCustomerOrder},
                                               typeof(SendOrchestrationVariablesIntoMaps).GetField("CustomerOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SendOrchestrationVariablesIntoMaps), "CustomerOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SAPorderType.SendSAPOrder},
                                               typeof(SendOrchestrationVariablesIntoMaps).GetField("SAPPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SendOrchestrationVariablesIntoMaps), "SAPPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "65d32721-4e6b-48d4-9ef6-cf261a838faa", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "65d32721-4e6b-48d4-9ef6-cf261a838faa", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "397706d5-211c-466d-9884-a8579da3ad41", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "397706d5-211c-466d-9884-a8579da3ad41", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "9131725a-0bc1-4a33-beb8-74526172e2f9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "9131725a-0bc1-4a33-beb8-74526172e2f9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "0f502f0f-874a-4ae4-b60d-0e1a930508ca", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "0f502f0f-874a-4ae4-b60d-0e1a930508ca", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "effba7d2-3cf1-4a35-9f50-040d269a4f29", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "effba7d2-3cf1-4a35-9f50-040d269a4f29", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,4,4,5,5,6,6,7,8,8,9,10,10,10,11,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __SendOrchestrationVariablesIntoMaps_root_0 __ctx0__ = (__SendOrchestrationVariablesIntoMaps_root_0)_stateMgrs[0];
            __SendOrchestrationVariablesIntoMaps_1 __ctx1__ = (__SendOrchestrationVariablesIntoMaps_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                CustomerOrderPort = new CustomerOrderInputType(0, this);
                SAPPort = new SAPorderType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], CustomerOrderPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __SendOrchestrationVariablesIntoMaps_1(this);
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
            __SendOrchestrationVariablesIntoMaps_root_0 __ctx0__ = (__SendOrchestrationVariablesIntoMaps_root_0)_stateMgrs[0];
            __SendOrchestrationVariablesIntoMaps_1 __ctx1__ = (__SendOrchestrationVariablesIntoMaps_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varHasDiscount = default(System.Boolean);
                __ctx1__.__varDiscountType = default(System.String);
                __ctx1__.__varXML = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__Variable_1 = default(System.String);
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
                if (!CustomerOrderPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgOrder != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                __ctx1__.__msgOrder = new __messagetype_HowToSendOrchestrationVariablesIntoMaps_Order("msgOrder", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgOrder);
                CustomerOrderPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgOrder, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (CustomerOrderPort != null)
                {
                    CustomerOrderPort.Close(__ctx1__, __seg__);
                    CustomerOrderPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgOrder);
                    __edata.PortName = @"CustomerOrderPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__varHasDiscount = true;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__varDiscountType = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__Variable_1 = "";
                if (__ctx1__ != null)
                    __ctx1__.__Variable_1 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__varHasDiscount = true;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__varDiscountType = "25%";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    __messagetype_HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport __msgOrchestrationSupport = new __messagetype_HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport("msgOrchestrationSupport", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:Support xmlns:ns0=""http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport"">
                                    <HasDiscount>true</HasDiscount><DiscountType>10</DiscountType></ns0:Support>");
                    __msgOrchestrationSupport.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;
                    __msgOrchestrationSupport.part.SetDistinguishedField("HasDiscount", __ctx1__.__varHasDiscount);
                    __msgOrchestrationSupport.part.SetDistinguishedField("DiscountType", __ctx1__.__varDiscountType);
                    if (__ctx1__ != null)
                        __ctx1__.__varDiscountType = null;

                    if (__ctx1__.__msgOrchestrationSupport != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOrchestrationSupport);
                    __ctx1__.__msgOrchestrationSupport = __msgOrchestrationSupport;
                    __ctx1__.RefMessage(__ctx1__.__msgOrchestrationSupport);
                }
                __ctx1__.__msgOrchestrationSupport.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOrchestrationSupport);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                {
                    __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder __msgSAPOrder = new __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder("msgSAPOrder", __ctx1__);

                    ApplyTransform(typeof(HowToSendOrchestrationVariablesIntoMaps.OrderToSAPOrderTransformation), new object[] {__msgSAPOrder.part}, new object[] {__ctx1__.__msgOrder.part, __ctx1__.__msgOrchestrationSupport.part});

                    if (__ctx1__.__msgSAPOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = __msgSAPOrder;
                    __ctx1__.RefMessage(__ctx1__.__msgSAPOrder);
                }
                __ctx1__.__msgSAPOrder.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.Messages.Add(__ctx1__.__msgOrder);
                    __edata.Messages.Add(__ctx1__.__msgOrchestrationSupport);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOrchestrationSupport != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrchestrationSupport);
                    __ctx1__.__msgOrchestrationSupport = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                    __ctx1__.__msgOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SAPPort.SendMessage(0, __ctx1__.__msgSAPOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SAPPort != null)
                {
                    SAPPort.Close(__ctx1__, __seg__);
                    SAPPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.PortName = @"SAPPort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 26;
            case 26:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 143 "C:\Development\03- HowToSendOrchestrationVariablesIntoMaps\HowToSendOrchestrationVariablesIntoMaps\UsingFunctoid\AccessOrchestrationVarUsingFunctoi.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "CustomerOrderPort", "ReceiveCustomerOrder", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(HowToSendOrchestrationVariablesIntoMaps.CustomerOrderInputType),
            typeof(HowToSendOrchestrationVariablesIntoMaps.SAPorderType)
        },
        new System.String[] {
            "CustomerOrderPort",
            "SAPPort"
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
    sealed internal class AccessOrchestrationVarUsingFunctoi : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(AccessOrchestrationVarUsingFunctoi));
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

        static AccessOrchestrationVarUsingFunctoi()
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
            _rootContext = new __AccessOrchestrationVarUsingFunctoi_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public AccessOrchestrationVarUsingFunctoi(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "AccessOrchestrationVarUsingFunctoi", tracker)
        {
            ConstructorHelper();
        }

        public AccessOrchestrationVarUsingFunctoi(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "AccessOrchestrationVarUsingFunctoi")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>ddebded0-35b5-44e4-9e2b-455fe57cfeaa</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>ccdaa2e7-ab66-4c74-8841-7e76bc00800e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Customer Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8a08b94d-2cc2-4118-ae8c-374e5c19c67e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Set Variables Expr</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>de511644-87c8-4032-8051-f69f9b96357b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct SAP Order Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>eb228a9b-7b6c-4394-84d7-4e2560787369</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>OrderToSAPOrderTransformation</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0f3dcc4a-ae53-4028-9dcd-34e4bc92eb93</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>da7a41e6-b445-4ad7-b36b-12d33145221c</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>52bbf810-77d7-4707-8cb6-38e29b0ddb39</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>55153b95-c757-452e-86fa-e8e254bcecbb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SAP Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'AccessOrchestrationVarUsingFunctoi'</ActionName><IsAtomic>0</IsAtomic><Line>143</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>156</Line><Position>22</Position><ShapeID>'ccdaa2e7-ab66-4c74-8841-7e76bc00800e'</ShapeID>
<Messages>
	<MsgInfo><name>msgOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>160</Line><Position>28</Position><ShapeID>'8a08b94d-2cc2-4118-ae8c-374e5c19c67e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>163</Line><Position>13</Position><ShapeID>'de511644-87c8-4032-8051-f69f9b96357b'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.SAPOrder</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.Order</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>169</Line><Position>13</Position><ShapeID>'55153b95-c757-452e-86fa-e8e254bcecbb'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.SAPOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='60530c31-0ff9-4551-b3ed-602f48efa3d0' LowerBound='1.1' HigherBound='35.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='HowToSendOrchestrationVariablesIntoMaps' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='ecdf4abe-ec42-4099-863b-b7e5e0ef261d' ParentLink='Module_ServiceDeclaration' LowerBound='4.1' HigherBound='34.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='AccessOrchestrationVarUsingFunctoi' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='907ee9d9-9702-4176-bf20-72110e563ba1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='13.1' HigherBound='14.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varHasDiscount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='07062dc3-1c43-43ab-a4e9-23fe81122129' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varDiscountType' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='940639ee-b05d-4c0d-86f8-4c9af1d119b5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='11.1' HigherBound='12.1'>
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.SAPOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSAPOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0b47fb1f-92db-471a-8e7f-35e821076a58' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='12.1' HigherBound='13.1'>
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.Order' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='ddebded0-35b5-44e4-9e2b-455fe57cfeaa' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='ccdaa2e7-ab66-4c74-8841-7e76bc00800e' ParentLink='ServiceBody_Statement' LowerBound='17.1' HigherBound='21.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='CustomerOrderPort' />
                    <om:Property Name='MessageName' Value='msgOrder' />
                    <om:Property Name='OperationName' Value='ReceiveCustomerOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Customer Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='8a08b94d-2cc2-4118-ae8c-374e5c19c67e' ParentLink='ServiceBody_Statement' LowerBound='21.1' HigherBound='24.1'>
                    <om:Property Name='Expression' Value='varHasDiscount = true;&#xD;&#xA;varDiscountType = &quot;25%&quot;;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Set Variables Expr' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='de511644-87c8-4032-8051-f69f9b96357b' ParentLink='ServiceBody_Statement' LowerBound='24.1' HigherBound='30.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct SAP Order Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='eb228a9b-7b6c-4394-84d7-4e2560787369' ParentLink='ComplexStatement_Statement' LowerBound='27.1' HigherBound='29.1'>
                        <om:Property Name='ClassName' Value='HowToSendOrchestrationVariablesIntoMaps.UsingFunctoid.OrderToSAPOrderAccessOrcVarFunctoids' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='OrderToSAPOrderTransformation' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='0f3dcc4a-ae53-4028-9dcd-34e4bc92eb93' ParentLink='Transform_InputMessagePartRef' LowerBound='28.135' HigherBound='28.143'>
                            <om:Property Name='MessageRef' Value='msgOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='da7a41e6-b445-4ad7-b36b-12d33145221c' ParentLink='Transform_OutputMessagePartRef' LowerBound='28.28' HigherBound='28.39'>
                            <om:Property Name='MessageRef' Value='msgSAPOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='52bbf810-77d7-4707-8cb6-38e29b0ddb39' ParentLink='Construct_MessageRef' LowerBound='25.23' HigherBound='25.34'>
                        <om:Property Name='Ref' Value='msgSAPOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='55153b95-c757-452e-86fa-e8e254bcecbb' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='32.1'>
                    <om:Property Name='PortName' Value='SAPPort' />
                    <om:Property Name='MessageName' Value='msgSAPOrder' />
                    <om:Property Name='OperationName' Value='SendSAPOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SAP Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e451de94-4e5e-4ee8-b0fb-a0338fcc8d95' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='7.1' HigherBound='9.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.CustomerOrderInputType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustomerOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='874ddbfd-3004-4147-8382-a2df9b3b5635' ParentLink='PortDeclaration_CLRAttribute' LowerBound='7.1' HigherBound='8.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e7318f0e-4dee-4b81-8fcd-b851eb84611d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='9.1' HigherBound='11.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='22' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.SAPorderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SAPPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='0a283fa8-b714-42c6-83af-4e459879bf9e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='9.1' HigherBound='10.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __AccessOrchestrationVarUsingFunctoi_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __AccessOrchestrationVarUsingFunctoi_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "AccessOrchestrationVarUsingFunctoi")
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
                AccessOrchestrationVarUsingFunctoi __svc__ = (AccessOrchestrationVarUsingFunctoi)_service;
                __AccessOrchestrationVarUsingFunctoi_root_0 __ctx0__ = (__AccessOrchestrationVarUsingFunctoi_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.CustomerOrderPort != null)
                {
                    __svc__.CustomerOrderPort.Close(this, null);
                    __svc__.CustomerOrderPort = null;
                }
                if (__svc__.SAPPort != null)
                {
                    __svc__.SAPPort.Close(this, null);
                    __svc__.SAPPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __AccessOrchestrationVarUsingFunctoi_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __AccessOrchestrationVarUsingFunctoi_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "AccessOrchestrationVarUsingFunctoi")
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
                AccessOrchestrationVarUsingFunctoi __svc__ = (AccessOrchestrationVarUsingFunctoi)_service;
                __AccessOrchestrationVarUsingFunctoi_1 __ctx1__ = (__AccessOrchestrationVarUsingFunctoi_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                    __ctx1__.__msgOrder = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varDiscountType = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSAPOrder")]
            public __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder __msgSAPOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOrder")]
            public __messagetype_HowToSendOrchestrationVariablesIntoMaps_Order __msgOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varHasDiscount")]
            internal System.Boolean __varHasDiscount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varDiscountType")]
            internal System.String __varDiscountType;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("CustomerOrderPort")]
        internal CustomerOrderInputType CustomerOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SAPPort")]
        internal SAPorderType SAPPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CustomerOrderInputType.ReceiveCustomerOrder},
                                               typeof(AccessOrchestrationVarUsingFunctoi).GetField("CustomerOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(AccessOrchestrationVarUsingFunctoi), "CustomerOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SAPorderType.SendSAPOrder},
                                               typeof(AccessOrchestrationVarUsingFunctoi).GetField("SAPPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(AccessOrchestrationVarUsingFunctoi), "SAPPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "ccdaa2e7-ab66-4c74-8841-7e76bc00800e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "ccdaa2e7-ab66-4c74-8841-7e76bc00800e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "8a08b94d-2cc2-4118-ae8c-374e5c19c67e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "8a08b94d-2cc2-4118-ae8c-374e5c19c67e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "de511644-87c8-4032-8051-f69f9b96357b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "de511644-87c8-4032-8051-f69f9b96357b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "55153b95-c757-452e-86fa-e8e254bcecbb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "55153b95-c757-452e-86fa-e8e254bcecbb", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,4,4,5,5,6,6,7,8,8,8,9,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __AccessOrchestrationVarUsingFunctoi_1 __ctx1__ = (__AccessOrchestrationVarUsingFunctoi_1)_stateMgrs[1];
            __AccessOrchestrationVarUsingFunctoi_root_0 __ctx0__ = (__AccessOrchestrationVarUsingFunctoi_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                CustomerOrderPort = new CustomerOrderInputType(0, this);
                SAPPort = new SAPorderType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], CustomerOrderPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __AccessOrchestrationVarUsingFunctoi_1(this);
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
            __AccessOrchestrationVarUsingFunctoi_1 __ctx1__ = (__AccessOrchestrationVarUsingFunctoi_1)_stateMgrs[1];
            __AccessOrchestrationVarUsingFunctoi_root_0 __ctx0__ = (__AccessOrchestrationVarUsingFunctoi_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varHasDiscount = default(System.Boolean);
                __ctx1__.__varDiscountType = default(System.String);
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
                if (!CustomerOrderPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgOrder != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                __ctx1__.__msgOrder = new __messagetype_HowToSendOrchestrationVariablesIntoMaps_Order("msgOrder", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgOrder);
                CustomerOrderPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgOrder, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (CustomerOrderPort != null)
                {
                    CustomerOrderPort.Close(__ctx1__, __seg__);
                    CustomerOrderPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgOrder);
                    __edata.PortName = @"CustomerOrderPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__varHasDiscount = true;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__varDiscountType = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx1__.__varHasDiscount = true;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__varDiscountType = "25%";
                if (__ctx1__ != null)
                    __ctx1__.__varDiscountType = null;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder __msgSAPOrder = new __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder("msgSAPOrder", __ctx1__);

                    ApplyTransform(typeof(HowToSendOrchestrationVariablesIntoMaps.UsingFunctoid.OrderToSAPOrderAccessOrcVarFunctoids), new object[] {__msgSAPOrder.part}, new object[] {__ctx1__.__msgOrder.part});

                    if (__ctx1__.__msgSAPOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = __msgSAPOrder;
                    __ctx1__.RefMessage(__ctx1__.__msgSAPOrder);
                }
                __ctx1__.__msgSAPOrder.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.Messages.Add(__ctx1__.__msgOrder);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                    __ctx1__.__msgOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SAPPort.SendMessage(0, __ctx1__.__msgSAPOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SAPPort != null)
                {
                    SAPPort.Close(__ctx1__, __seg__);
                    SAPPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.PortName = @"SAPPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 21;
            case 21:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 143 "C:\Development\03- HowToSendOrchestrationVariablesIntoMaps\HowToSendOrchestrationVariablesIntoMaps\UsingHelperClass\AccessOrchestrationVarUsingHC.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "CustomerOrderPort", "ReceiveCustomerOrder", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(HowToSendOrchestrationVariablesIntoMaps.CustomerOrderInputType),
            typeof(HowToSendOrchestrationVariablesIntoMaps.SAPorderType)
        },
        new System.String[] {
            "CustomerOrderPort",
            "SAPPort"
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
    sealed internal class AccessOrchestrationVarUsingHC : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(AccessOrchestrationVarUsingHC));
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

        static AccessOrchestrationVarUsingHC()
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
            _rootContext = new __AccessOrchestrationVarUsingHC_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public AccessOrchestrationVarUsingHC(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "AccessOrchestrationVarUsingHC", tracker)
        {
            ConstructorHelper();
        }

        public AccessOrchestrationVarUsingHC(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "AccessOrchestrationVarUsingHC")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>19522e09-2c4b-4613-b1f6-729c05e7d1b6</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>be83d50a-5377-4161-bfb8-f152f55b10bf</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Customer Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f97b4c11-0ba9-4212-8630-679559fa962a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Set Variables Expr</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>d17f4ef9-4cfa-4224-ab54-931c9f0401b6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct SAP Order Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>80608532-e5a0-47cb-bb5a-5a7c2ecee235</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>OrderToSAPOrderTransformation</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8b3033f0-a862-4de2-964f-a5f3a271173d</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>cfc7c21f-0546-4f9b-8cfd-01755991b4b6</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>cac75457-57fd-456c-bc85-4814fc1af547</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>39148815-8382-48af-b8b8-aa8bb943c684</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SAP Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'AccessOrchestrationVarUsingHC'</ActionName><IsAtomic>0</IsAtomic><Line>143</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>156</Line><Position>22</Position><ShapeID>'be83d50a-5377-4161-bfb8-f152f55b10bf'</ShapeID>
<Messages>
	<MsgInfo><name>msgOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>160</Line><Position>28</Position><ShapeID>'f97b4c11-0ba9-4212-8630-679559fa962a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>166</Line><Position>13</Position><ShapeID>'d17f4ef9-4cfa-4224-ab54-931c9f0401b6'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.SAPOrder</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.Order</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>172</Line><Position>13</Position><ShapeID>'39148815-8382-48af-b8b8-aa8bb943c684'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>HowToSendOrchestrationVariablesIntoMaps.SAPOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='d91a290a-8f94-45d8-8a49-1f985c6b5477' LowerBound='1.1' HigherBound='38.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='HowToSendOrchestrationVariablesIntoMaps' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='9847a3fc-c118-4426-bf02-627131cbe208' ParentLink='Module_ServiceDeclaration' LowerBound='4.1' HigherBound='37.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='AccessOrchestrationVarUsingHC' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='b17197e4-bbdd-4f68-8152-e5a334a2db21' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='13.1' HigherBound='14.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varHasDiscount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3f6bdcb7-ff7a-4073-9183-52f19e82d5ec' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varDiscountType' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='87b112fc-a64b-4a35-8c8a-d7a615937c2e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='11.1' HigherBound='12.1'>
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.SAPOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSAPOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0929909a-937c-4c5d-8fc1-e6d2bcf0d377' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='12.1' HigherBound='13.1'>
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.Order' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='19522e09-2c4b-4613-b1f6-729c05e7d1b6' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='be83d50a-5377-4161-bfb8-f152f55b10bf' ParentLink='ServiceBody_Statement' LowerBound='17.1' HigherBound='21.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='CustomerOrderPort' />
                    <om:Property Name='MessageName' Value='msgOrder' />
                    <om:Property Name='OperationName' Value='ReceiveCustomerOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Customer Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='f97b4c11-0ba9-4212-8630-679559fa962a' ParentLink='ServiceBody_Statement' LowerBound='21.1' HigherBound='27.1'>
                    <om:Property Name='Expression' Value='varHasDiscount = true;&#xD;&#xA;varDiscountType = &quot;25%&quot;;&#xD;&#xA;&#xD;&#xA;StoreValuesHelperClass.StoreValues.SetDataValue(&quot;varHasDiscount&quot;, varHasDiscount.ToString());&#xD;&#xA;StoreValuesHelperClass.StoreValues.SetDataValue(&quot;varDiscountType&quot;, varDiscountType.ToString());' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Set Variables Expr' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='d17f4ef9-4cfa-4224-ab54-931c9f0401b6' ParentLink='ServiceBody_Statement' LowerBound='27.1' HigherBound='33.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct SAP Order Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='80608532-e5a0-47cb-bb5a-5a7c2ecee235' ParentLink='ComplexStatement_Statement' LowerBound='30.1' HigherBound='32.1'>
                        <om:Property Name='ClassName' Value='HowToSendOrchestrationVariablesIntoMaps.UsingHelperClass.OrderToSAPOrderAccOrcVarHC' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='OrderToSAPOrderTransformation' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='8b3033f0-a862-4de2-964f-a5f3a271173d' ParentLink='Transform_InputMessagePartRef' LowerBound='31.128' HigherBound='31.136'>
                            <om:Property Name='MessageRef' Value='msgOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='cfc7c21f-0546-4f9b-8cfd-01755991b4b6' ParentLink='Transform_OutputMessagePartRef' LowerBound='31.28' HigherBound='31.39'>
                            <om:Property Name='MessageRef' Value='msgSAPOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='cac75457-57fd-456c-bc85-4814fc1af547' ParentLink='Construct_MessageRef' LowerBound='28.23' HigherBound='28.34'>
                        <om:Property Name='Ref' Value='msgSAPOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='39148815-8382-48af-b8b8-aa8bb943c684' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='PortName' Value='SAPPort' />
                    <om:Property Name='MessageName' Value='msgSAPOrder' />
                    <om:Property Name='OperationName' Value='SendSAPOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SAP Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3454850c-ad70-4913-8573-05ce9e6104ea' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='7.1' HigherBound='9.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.CustomerOrderInputType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustomerOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c2288e43-63c6-4bce-839e-1745c8328816' ParentLink='PortDeclaration_CLRAttribute' LowerBound='7.1' HigherBound='8.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='99f80690-7854-4ead-9d28-dec4d0dee27b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='9.1' HigherBound='11.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='22' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowToSendOrchestrationVariablesIntoMaps.SAPorderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SAPPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='06ed6073-7f13-44d5-b865-e0efb59494d2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='9.1' HigherBound='10.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __AccessOrchestrationVarUsingHC_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __AccessOrchestrationVarUsingHC_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "AccessOrchestrationVarUsingHC")
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
                AccessOrchestrationVarUsingHC __svc__ = (AccessOrchestrationVarUsingHC)_service;
                __AccessOrchestrationVarUsingHC_root_0 __ctx0__ = (__AccessOrchestrationVarUsingHC_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.CustomerOrderPort != null)
                {
                    __svc__.CustomerOrderPort.Close(this, null);
                    __svc__.CustomerOrderPort = null;
                }
                if (__svc__.SAPPort != null)
                {
                    __svc__.SAPPort.Close(this, null);
                    __svc__.SAPPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __AccessOrchestrationVarUsingHC_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __AccessOrchestrationVarUsingHC_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "AccessOrchestrationVarUsingHC")
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
                AccessOrchestrationVarUsingHC __svc__ = (AccessOrchestrationVarUsingHC)_service;
                __AccessOrchestrationVarUsingHC_1 __ctx1__ = (__AccessOrchestrationVarUsingHC_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                    __ctx1__.__msgOrder = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varDiscountType = null;
                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSAPOrder")]
            public __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder __msgSAPOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOrder")]
            public __messagetype_HowToSendOrchestrationVariablesIntoMaps_Order __msgOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varHasDiscount")]
            internal System.Boolean __varHasDiscount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varDiscountType")]
            internal System.String __varDiscountType;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("CustomerOrderPort")]
        internal CustomerOrderInputType CustomerOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SAPPort")]
        internal SAPorderType SAPPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CustomerOrderInputType.ReceiveCustomerOrder},
                                               typeof(AccessOrchestrationVarUsingHC).GetField("CustomerOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(AccessOrchestrationVarUsingHC), "CustomerOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SAPorderType.SendSAPOrder},
                                               typeof(AccessOrchestrationVarUsingHC).GetField("SAPPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(AccessOrchestrationVarUsingHC), "SAPPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "be83d50a-5377-4161-bfb8-f152f55b10bf", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "be83d50a-5377-4161-bfb8-f152f55b10bf", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "f97b4c11-0ba9-4212-8630-679559fa962a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "f97b4c11-0ba9-4212-8630-679559fa962a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "d17f4ef9-4cfa-4224-ab54-931c9f0401b6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "d17f4ef9-4cfa-4224-ab54-931c9f0401b6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "39148815-8382-48af-b8b8-aa8bb943c684", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "39148815-8382-48af-b8b8-aa8bb943c684", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,4,4,5,5,5,5,6,6,7,8,8,8,9,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __AccessOrchestrationVarUsingHC_root_0 __ctx0__ = (__AccessOrchestrationVarUsingHC_root_0)_stateMgrs[0];
            __AccessOrchestrationVarUsingHC_1 __ctx1__ = (__AccessOrchestrationVarUsingHC_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                CustomerOrderPort = new CustomerOrderInputType(0, this);
                SAPPort = new SAPorderType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], CustomerOrderPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __AccessOrchestrationVarUsingHC_1(this);
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
            __AccessOrchestrationVarUsingHC_root_0 __ctx0__ = (__AccessOrchestrationVarUsingHC_root_0)_stateMgrs[0];
            __AccessOrchestrationVarUsingHC_1 __ctx1__ = (__AccessOrchestrationVarUsingHC_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varHasDiscount = default(System.Boolean);
                __ctx1__.__varDiscountType = default(System.String);
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
                if (!CustomerOrderPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgOrder != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                __ctx1__.__msgOrder = new __messagetype_HowToSendOrchestrationVariablesIntoMaps_Order("msgOrder", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgOrder);
                CustomerOrderPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgOrder, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (CustomerOrderPort != null)
                {
                    CustomerOrderPort.Close(__ctx1__, __seg__);
                    CustomerOrderPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgOrder);
                    __edata.PortName = @"CustomerOrderPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__varHasDiscount = true;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__varDiscountType = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx1__.__varHasDiscount = true;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__varDiscountType = "25%";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                StoreValuesHelperClass.StoreValues.SetDataValue("varHasDiscount", __ctx1__.__varHasDiscount.ToString());
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                StoreValuesHelperClass.StoreValues.SetDataValue("varDiscountType", __ctx1__.__varDiscountType.ToString());
                if (__ctx1__ != null)
                    __ctx1__.__varDiscountType = null;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder __msgSAPOrder = new __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder("msgSAPOrder", __ctx1__);

                    ApplyTransform(typeof(HowToSendOrchestrationVariablesIntoMaps.UsingHelperClass.OrderToSAPOrderAccOrcVarHC), new object[] {__msgSAPOrder.part}, new object[] {__ctx1__.__msgOrder.part});

                    if (__ctx1__.__msgSAPOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = __msgSAPOrder;
                    __ctx1__.RefMessage(__ctx1__.__msgSAPOrder);
                }
                __ctx1__.__msgSAPOrder.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.Messages.Add(__ctx1__.__msgOrder);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrder);
                    __ctx1__.__msgOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
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
                SAPPort.SendMessage(0, __ctx1__.__msgSAPOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SAPPort != null)
                {
                    SAPPort.Close(__ctx1__, __seg__);
                    SAPPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.PortName = @"SAPPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
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
    }

    [System.SerializableAttribute]
    sealed public class __HowToSendOrchestrationVariablesIntoMaps_Order__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToSendOrchestrationVariablesIntoMaps.Order _schema = new HowToSendOrchestrationVariablesIntoMaps.Order();

        public __HowToSendOrchestrationVariablesIntoMaps_Order__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToSendOrchestrationVariablesIntoMaps.Order",
        new System.Type[]{
            typeof(HowToSendOrchestrationVariablesIntoMaps.Order)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToSendOrchestrationVariablesIntoMaps_Order__)
        },
        0,
        @"http://HowToSendOrchestrationVariablesIntoMaps.Order#Order"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToSendOrchestrationVariablesIntoMaps_Order : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToSendOrchestrationVariablesIntoMaps_Order__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToSendOrchestrationVariablesIntoMaps_Order__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToSendOrchestrationVariablesIntoMaps_Order(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowToSendOrchestrationVariablesIntoMaps_SAPOrder__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToSendOrchestrationVariablesIntoMaps.SAPOrder _schema = new HowToSendOrchestrationVariablesIntoMaps.SAPOrder();

        public __HowToSendOrchestrationVariablesIntoMaps_SAPOrder__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToSendOrchestrationVariablesIntoMaps.SAPOrder",
        new System.Type[]{
            typeof(HowToSendOrchestrationVariablesIntoMaps.SAPOrder)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToSendOrchestrationVariablesIntoMaps_SAPOrder__)
        },
        0,
        @"http://HowToSendOrchestrationVariablesIntoMaps.SAPOrder#SAPOrder"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToSendOrchestrationVariablesIntoMaps_SAPOrder__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToSendOrchestrationVariablesIntoMaps_SAPOrder__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToSendOrchestrationVariablesIntoMaps_SAPOrder(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport _schema = new HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport();

        public __HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport",
        new System.Type[]{
            typeof(HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport__)
        },
        0,
        @"http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport#Support"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowToSendOrchestrationVariablesIntoMaps_OrchestrationSupport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
