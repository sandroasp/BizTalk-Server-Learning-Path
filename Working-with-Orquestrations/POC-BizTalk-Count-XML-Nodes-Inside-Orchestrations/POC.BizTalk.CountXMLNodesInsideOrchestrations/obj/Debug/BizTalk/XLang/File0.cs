
#pragma warning disable 162

namespace POC.BizTalk.CountXMLNodesInsideOrchestrations
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "RcvSampleOp",
        new System.Type[]{
            typeof(POC.BizTalk.CountXMLNodesInsideOrchestrations.__messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RcvInputPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RcvInputPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RcvInputPortType(RcvInputPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RcvInputPortType p = new RcvInputPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo RcvSampleOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "RcvSampleOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RcvInputPortType),
            typeof(__messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "RcvSampleOp" ] = RcvSampleOp;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "CountOutputOp",
        new System.Type[]{
            typeof(POC.BizTalk.CountXMLNodesInsideOrchestrations.__messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SndCountPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SndCountPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SndCountPortType(SndCountPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SndCountPortType p = new SndCountPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo CountOutputOp = new Microsoft.XLANGs.Core.OperationInfo
        (
            "CountOutputOp",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SndCountPortType),
            typeof(__messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "CountOutputOp" ] = CountOutputOp;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 198 "C:\DEV\POC\POC.BizTalk.CountXMLNodesInsideOrchestrations\POC.BizTalk.CountXMLNodesInsideOrchestrations\orchCountXMLNodes.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvInputPort", "RcvSampleOp", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.BizTalk.CountXMLNodesInsideOrchestrations.RcvInputPortType),
            typeof(POC.BizTalk.CountXMLNodesInsideOrchestrations.SndCountPortType)
        },
        new System.String[] {
            "RcvInputPort",
            "SndCountPort"
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
    sealed internal class orchCountXMLNodes : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(orchCountXMLNodes));
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

        static orchCountXMLNodes()
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
            _rootContext = new __orchCountXMLNodes_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public orchCountXMLNodes(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "orchCountXMLNodes", tracker)
        {
            ConstructorHelper();
        }

        public orchCountXMLNodes(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "orchCountXMLNodes")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>e8b0d318-d73a-4616-982c-7067d783f023</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>ec23dc49-3404-4149-9c27-ecca3e754c35</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive input</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>3b71aff1-0713-4a1b-9da0-60cc9cc9d7d5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Count Records Expr</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>88f025a1-5092-44b9-b23d-400c3986a0fd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Count Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>6bf14177-a321-443f-a360-c43dc1d42ab5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Count MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>12abe017-5413-44dc-b6eb-889cc0d2b938</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>a8b5a83b-bd46-417b-bb5b-d6f6abb5bef5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'orchCountXMLNodes'</ActionName><IsAtomic>0</IsAtomic><Line>198</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>213</Line><Position>22</Position><ShapeID>'ec23dc49-3404-4149-9c27-ecca3e754c35'</ShapeID>
<Messages>
	<MsgInfo><name>msgInput</name><part>part</part><schema>POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>216</Line><Position>27</Position><ShapeID>'3b71aff1-0713-4a1b-9da0-60cc9cc9d7d5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>221</Line><Position>13</Position><ShapeID>'88f025a1-5092-44b9-b23d-400c3986a0fd'</ShapeID>
<Messages>
	<MsgInfo><name>msgCountOutput</name><part>part</part><schema>POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>231</Line><Position>13</Position><ShapeID>'a8b5a83b-bd46-417b-bb5b-d6f6abb5bef5'</ShapeID>
<Messages>
	<MsgInfo><name>msgCountOutput</name><part>part</part><schema>POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='8aa0b847-77cf-478a-bdce-253aad35dd87' LowerBound='1.1' HigherBound='56.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.BizTalk.CountXMLNodesInsideOrchestrations' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='127ee4c0-9ebe-49d0-bb1f-6566e745d071' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvInputPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ea050753-d422-476a-b146-e36641e9d017' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvSampleOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='521c3d09-7b4c-45be-a44e-e23f51cc2957' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.22'>
                    <om:Property Name='Ref' Value='POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='fff501b2-cbaf-4aac-8a30-f0a9c0e7c05a' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SndCountPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8ef9cbdf-4457-4fa5-b9b1-77743220d086' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CountOutputOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='fdf9e7b8-8e06-48b8-9c97-82712471728c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.24'>
                    <om:Property Name='Ref' Value='POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='472f7d22-fee4-420b-9d2b-e2521b887f4f' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='55.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='orchCountXMLNodes' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='b69d0fc4-9f5b-43b0-8c3e-4af08dc55e7d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varFilterCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ec76b6b8-45f0-441d-a77c-4b8d8dcd1d2d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='vatTotalCountSecAppr' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7d70ace3-5ea1-46a1-8f5e-490e16a034a2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varTotalCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f11aabbf-7eaf-4e99-a5b5-bd922ef7d674' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='71e978b9-4425-4166-8593-861548bb85c1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgInput' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='08067826-b6b8-48f8-93ad-972cda203802' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCountOutput' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='e8b0d318-d73a-4616-982c-7067d783f023' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='ec23dc49-3404-4149-9c27-ecca3e754c35' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='36.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvInputPort' />
                    <om:Property Name='MessageName' Value='msgInput' />
                    <om:Property Name='OperationName' Value='RcvSampleOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive input' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='3b71aff1-0713-4a1b-9da0-60cc9cc9d7d5' ParentLink='ServiceBody_Statement' LowerBound='36.1' HigherBound='41.1'>
                    <om:Property Name='Expression' Value='varTotalCount = System.Convert.ToInt32(xpath(msgInput,&quot;count(//*[local-name()=&apos;XMLSample&apos; and namespace-uri()=&apos;http://POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample&apos;]/*[local-name()=&apos;Object&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;vatTotalCountSecAppr = System.Convert.ToInt32(xpath(msgInput,&quot;count(//*[local-name()=&apos;XMLSample&apos;]/*[local-name()=&apos;Object&apos;])&quot;));&#xD;&#xA;&#xD;&#xA;varFilterCount = System.Convert.ToInt32(xpath(msgInput,&quot;count(//*[local-name()=&apos;XMLSample&apos;]/*[local-name()=&apos;Object&apos;]/*[local-name()=&apos;Type&apos;][text()=&apos;P&apos;])&quot;));' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Count Records Expr' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='88f025a1-5092-44b9-b23d-400c3986a0fd' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='51.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Count Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='6bf14177-a321-443f-a360-c43dc1d42ab5' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='50.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:Count xmlns:ns0=&quot;&quot;http://POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount&quot;&quot;&gt;&lt;NumberObjects&gt;&quot; + varTotalCount.ToString() + &quot;&lt;/NumberObjects&gt;&lt;NumberObjectsSecondApproach&gt;&quot; + vatTotalCountSecAppr.ToString() + &quot;&lt;/NumberObjectsSecondApproach&gt;&lt;NumberFilterObjects&gt;&quot; + varFilterCount.ToString() + &quot;&lt;/NumberFilterObjects&gt;&lt;/ns0:Count&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgCountOutput = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Count MsgAssign' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='12abe017-5413-44dc-b6eb-889cc0d2b938' ParentLink='Construct_MessageRef' LowerBound='42.23' HigherBound='42.37'>
                        <om:Property Name='Ref' Value='msgCountOutput' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='a8b5a83b-bd46-417b-bb5b-d6f6abb5bef5' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='53.1'>
                    <om:Property Name='PortName' Value='SndCountPort' />
                    <om:Property Name='MessageName' Value='msgCountOutput' />
                    <om:Property Name='OperationName' Value='CountOutputOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Count' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f5871755-20ea-42aa-9c64-67238625319f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.BizTalk.CountXMLNodesInsideOrchestrations.RcvInputPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvInputPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='43cfb3fa-5fac-46ca-b1bb-d66d51e3bc2a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='485cd361-71f0-4d7a-bc1e-88e5b3958719' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='20' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.BizTalk.CountXMLNodesInsideOrchestrations.SndCountPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SndCountPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='edfdc7f9-f628-4dff-9fd9-a98420ec481b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __orchCountXMLNodes_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __orchCountXMLNodes_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orchCountXMLNodes")
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
                orchCountXMLNodes __svc__ = (orchCountXMLNodes)_service;
                __orchCountXMLNodes_root_0 __ctx0__ = (__orchCountXMLNodes_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RcvInputPort != null)
                {
                    __svc__.RcvInputPort.Close(this, null);
                    __svc__.RcvInputPort = null;
                }
                if (__svc__.SndCountPort != null)
                {
                    __svc__.SndCountPort.Close(this, null);
                    __svc__.SndCountPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __orchCountXMLNodes_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __orchCountXMLNodes_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orchCountXMLNodes")
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
                orchCountXMLNodes __svc__ = (orchCountXMLNodes)_service;
                __orchCountXMLNodes_1 __ctx1__ = (__orchCountXMLNodes_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgCountOutput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCountOutput);
                    __ctx1__.__msgCountOutput = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                if (__ctx1__ != null && __ctx1__.__msgInput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInput);
                    __ctx1__.__msgInput = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgInput")]
            public __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample __msgInput;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCountOutput")]
            public __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount __msgCountOutput;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varFilterCount")]
            internal System.Int32 __varFilterCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("vatTotalCountSecAppr")]
            internal System.Int32 __vatTotalCountSecAppr;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varTotalCount")]
            internal System.Int32 __varTotalCount;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvInputPort")]
        internal RcvInputPortType RcvInputPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SndCountPort")]
        internal SndCountPortType SndCountPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RcvInputPortType.RcvSampleOp},
                                               typeof(orchCountXMLNodes).GetField("RcvInputPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(orchCountXMLNodes), "RcvInputPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SndCountPortType.CountOutputOp},
                                               typeof(orchCountXMLNodes).GetField("SndCountPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(orchCountXMLNodes), "SndCountPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "ec23dc49-3404-4149-9c27-ecca3e754c35", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "ec23dc49-3404-4149-9c27-ecca3e754c35", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "3b71aff1-0713-4a1b-9da0-60cc9cc9d7d5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "3b71aff1-0713-4a1b-9da0-60cc9cc9d7d5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "88f025a1-5092-44b9-b23d-400c3986a0fd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "88f025a1-5092-44b9-b23d-400c3986a0fd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "a8b5a83b-bd46-417b-bb5b-d6f6abb5bef5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "a8b5a83b-bd46-417b-bb5b-d6f6abb5bef5", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,5,5,6,6,7,8,8,8,9,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __orchCountXMLNodes_root_0 __ctx0__ = (__orchCountXMLNodes_root_0)_stateMgrs[0];
            __orchCountXMLNodes_1 __ctx1__ = (__orchCountXMLNodes_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                RcvInputPort = new RcvInputPortType(0, this);
                SndCountPort = new SndCountPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvInputPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __orchCountXMLNodes_1(this);
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
            __orchCountXMLNodes_root_0 __ctx0__ = (__orchCountXMLNodes_root_0)_stateMgrs[0];
            __orchCountXMLNodes_1 __ctx1__ = (__orchCountXMLNodes_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varFilterCount = default(System.Int32);
                __ctx1__.__vatTotalCountSecAppr = default(System.Int32);
                __ctx1__.__varTotalCount = default(System.Int32);
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
                if (!RcvInputPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgInput != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgInput);
                __ctx1__.__msgInput = new __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample("msgInput", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgInput);
                RcvInputPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgInput, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvInputPort != null)
                {
                    RcvInputPort.Close(__ctx1__, __seg__);
                    RcvInputPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgInput);
                    __edata.PortName = @"RcvInputPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
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
                __ctx1__.__varTotalCount = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgInput.part, "count(//*[local-name()='XMLSample' and namespace-uri()='http://POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample']/*[local-name()='Object' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __ctx1__.__vatTotalCountSecAppr = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgInput.part, "count(//*[local-name()='XMLSample']/*[local-name()='Object'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__varFilterCount = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgInput.part, "count(//*[local-name()='XMLSample']/*[local-name()='Object']/*[local-name()='Type'][text()='P'])", typeof(System.Object)));
                if (__ctx1__ != null && __ctx1__.__msgInput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInput);
                    __ctx1__.__msgInput = null;
                }
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
                    __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount __msgCountOutput = new __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount("msgCountOutput", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:Count xmlns:ns0=""http://POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount""><NumberObjects>" + __ctx1__.__varTotalCount.ToString() + "</NumberObjects><NumberObjectsSecondApproach>" + __ctx1__.__vatTotalCountSecAppr.ToString() + "</NumberObjectsSecondApproach><NumberFilterObjects>" + __ctx1__.__varFilterCount.ToString() + "</NumberFilterObjects></ns0:Count>");
                    __msgCountOutput.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgCountOutput != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgCountOutput);
                    __ctx1__.__msgCountOutput = __msgCountOutput;
                    __ctx1__.RefMessage(__ctx1__.__msgCountOutput);
                }
                __ctx1__.__msgCountOutput.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgCountOutput);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
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
                SndCountPort.SendMessage(0, __ctx1__.__msgCountOutput, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SndCountPort != null)
                {
                    SndCountPort.Close(__ctx1__, __seg__);
                    SndCountPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgCountOutput);
                    __edata.PortName = @"SndCountPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCountOutput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCountOutput);
                    __ctx1__.__msgCountOutput = null;
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

    [System.SerializableAttribute]
    sealed public class __POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample _schema = new POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample();

        public __POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample",
        new System.Type[]{
            typeof(POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample__)
        },
        0,
        @"http://POC.BizTalk.CountXMLNodesInsideOrchestrations.XMLSample#XMLSample"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_XMLSample(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount _schema = new POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount();

        public __POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount",
        new System.Type[]{
            typeof(POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount__)
        },
        0,
        @"http://POC.BizTalk.CountXMLNodesInsideOrchestrations.OutputCount#Count"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_BizTalk_CountXMLNodesInsideOrchestrations_OutputCount(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
