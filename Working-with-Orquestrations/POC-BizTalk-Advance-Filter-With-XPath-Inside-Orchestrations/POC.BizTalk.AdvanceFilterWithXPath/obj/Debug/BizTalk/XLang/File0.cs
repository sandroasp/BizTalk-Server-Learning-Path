
#pragma warning disable 162

namespace POC.BizTalk.AdvanceFilterWithXSLT
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "RcvSampleOp",
        new System.Type[]{
            typeof(POC.BizTalk.AdvanceFilterWithXSLT.__messagetype_POC_BizTalk_AdvanceFilterWithXSLT_XMLSample)
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
            typeof(__messagetype_POC_BizTalk_AdvanceFilterWithXSLT_XMLSample),
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
            typeof(POC.BizTalk.AdvanceFilterWithXSLT.__messagetype_POC_BizTalk_AdvanceFilterWithXSLT_OutputCount)
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
            typeof(__messagetype_POC_BizTalk_AdvanceFilterWithXSLT_OutputCount),
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
    //#line 206 "C:\DEV\POC\POC.BizTalk.AdvanceFilterWithXPath\POC.BizTalk.AdvanceFilterWithXPath\orchAdvFilterXPath.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvInputPort", "RcvSampleOp", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.BizTalk.AdvanceFilterWithXSLT.RcvInputPortType),
            typeof(POC.BizTalk.AdvanceFilterWithXSLT.SndCountPortType)
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
    sealed internal class orchAdvFilterXSLT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(orchAdvFilterXSLT));
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

        static orchAdvFilterXSLT()
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
            _rootContext = new __orchAdvFilterXSLT_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public orchAdvFilterXSLT(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "orchAdvFilterXSLT", tracker)
        {
            ConstructorHelper();
        }

        public orchAdvFilterXSLT(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "orchAdvFilterXSLT")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>56fc407f-b17e-4a1f-87cd-0194287189ec</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>13b54db2-80dd-437f-8db2-22c5d3baf74d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Sample Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>dd517e13-6364-4953-b3f4-7d89447d2ce4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Count Records Expr</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>edbeb44b-eddc-481e-8514-17e4a379db8c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Output Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>4ee7a465-cfaf-4e86-a7e3-b694c3522765</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Output MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>75c843c2-c5e5-4dca-aedd-73805610ad98</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>ed8c4e93-5494-462f-9d70-b013c6b11d5d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Output</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'orchAdvFilterXSLT'</ActionName><IsAtomic>0</IsAtomic><Line>206</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>222</Line><Position>22</Position><ShapeID>'13b54db2-80dd-437f-8db2-22c5d3baf74d'</ShapeID>
<Messages>
	<MsgInfo><name>msgInput</name><part>part</part><schema>POC.BizTalk.AdvanceFilterWithXSLT.XMLSample</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>225</Line><Position>24</Position><ShapeID>'dd517e13-6364-4953-b3f4-7d89447d2ce4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>233</Line><Position>13</Position><ShapeID>'edbeb44b-eddc-481e-8514-17e4a379db8c'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput</name><part>part</part><schema>POC.BizTalk.AdvanceFilterWithXSLT.OutputCount</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>243</Line><Position>13</Position><ShapeID>'ed8c4e93-5494-462f-9d70-b013c6b11d5d'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput</name><part>part</part><schema>POC.BizTalk.AdvanceFilterWithXSLT.OutputCount</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='72b29f79-5720-4dc0-a21c-b61541fe70a4' LowerBound='1.1' HigherBound='60.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.BizTalk.AdvanceFilterWithXSLT' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='87020686-b02d-4fe0-9dcf-820360d3fac7' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='59.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='orchAdvFilterXSLT' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='973728d3-a970-403b-b38e-2eaa11e241e4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varCountDistinct' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='22724942-32b9-4909-8818-42f5acb5a41f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varCountOr' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e61fc071-542a-4001-8a40-c15d9fb79744' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varCountSF' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='148977b7-efe5-4b80-a2b0-83b716431164' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9809becd-f076-4577-bc22-4cf37c298b8a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varCountMF' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='5d85e12a-7b8a-4702-8bc8-6cebdbf673f8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='POC.BizTalk.AdvanceFilterWithXSLT.XMLSample' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgInput' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ef28790d-5236-4a3b-9fc9-3ed60be1d1a5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='POC.BizTalk.AdvanceFilterWithXSLT.OutputCount' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOutput' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='56fc407f-b17e-4a1f-87cd-0194287189ec' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='13b54db2-80dd-437f-8db2-22c5d3baf74d' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='37.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvInputPort' />
                    <om:Property Name='MessageName' Value='msgInput' />
                    <om:Property Name='OperationName' Value='RcvSampleOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Sample Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='dd517e13-6364-4953-b3f4-7d89447d2ce4' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='45.1'>
                    <om:Property Name='Expression' Value='varCountSF = System.Convert.ToInt32(xpath(msgInput,&quot;count(//*[local-name()=&apos;XMLSample&apos;]/*[local-name()=&apos;Object&apos;]/*[local-name()=&apos;Type&apos;][text()=&apos;P&apos;])&quot;));&#xD;&#xA;&#xD;&#xA;varCountOr = System.Convert.ToInt32(xpath(msgInput,&quot;count(//*[local-name()=&apos;XMLSample&apos;]/*[local-name()=&apos;Object&apos;]/*[local-name()=&apos;Type&apos;][text()=&apos;P&apos; or text()=&apos;A&apos;])&quot;));&#xD;&#xA;&#xD;&#xA;varCountMF = System.Convert.ToInt32(xpath(msgInput,&quot;count(//*[local-name()=&apos;XMLSample&apos;]/*[local-name()=&apos;Object&apos;][*[local-name()=&apos;Type&apos;][text()=&apos;P&apos;]][*[local-name()=&apos;Name&apos;][text()=&apos;Sandro&apos;]])&quot;));&#xD;&#xA;&#xD;&#xA;varCountDistinct = System.Convert.ToInt32(xpath(msgInput,&quot;count(//*[local-name()=&apos;XMLSample&apos;]/*[local-name()=&apos;Object&apos;][not(*[local-name()=&apos;Name&apos;]/text()=preceding-sibling::*[local-name()=&apos;Object&apos;]/*[local-name()=&apos;Name&apos;]/text())]/*[local-name()=&apos;Name&apos;])&quot;));' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Count Records Expr' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='edbeb44b-eddc-481e-8514-17e4a379db8c' ParentLink='ServiceBody_Statement' LowerBound='45.1' HigherBound='55.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Output Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='4ee7a465-cfaf-4e86-a7e3-b694c3522765' ParentLink='ComplexStatement_Statement' LowerBound='48.1' HigherBound='54.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:Count xmlns:ns0=&quot;&quot;http://POC.BizTalk.AdvanceFilterWithXSLT.OutputCount&quot;&quot;&gt;&lt;NumberObjMultipleFilterElement&gt;&quot; + varCountMF.ToString() + &quot;&lt;/NumberObjMultipleFilterElement&gt;&lt;NumberObjSingleFilterElement&gt;&quot; + varCountSF.ToString() + &quot;&lt;/NumberObjSingleFilterElement&gt;&lt;NumberObjsOrClause&gt;&quot; + varCountOr.ToString() + &quot;&lt;/NumberObjsOrClause&gt;&lt;NumberObjsDistinct&gt;&quot; + varCountDistinct.ToString() + &quot;&lt;/NumberObjsDistinct&gt;&lt;/ns0:Count&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgOutput = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Output MsgAssign' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='75c843c2-c5e5-4dca-aedd-73805610ad98' ParentLink='Construct_MessageRef' LowerBound='46.23' HigherBound='46.32'>
                        <om:Property Name='Ref' Value='msgOutput' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='ed8c4e93-5494-462f-9d70-b013c6b11d5d' ParentLink='ServiceBody_Statement' LowerBound='55.1' HigherBound='57.1'>
                    <om:Property Name='PortName' Value='SndCountPort' />
                    <om:Property Name='MessageName' Value='msgOutput' />
                    <om:Property Name='OperationName' Value='CountOutputOp' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Output' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='09828c58-c271-4279-83a2-c0c701e9b058' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.BizTalk.AdvanceFilterWithXSLT.RcvInputPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvInputPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e892f54e-af01-4fec-a3d2-62f5401b3937' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3bbffcf5-062d-4ebd-aa71-1a69335fccbf' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='15' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.BizTalk.AdvanceFilterWithXSLT.SndCountPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SndCountPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='fc0f4a98-2b7c-4a9e-8c36-2ca3a869144e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='99276538-b3bf-45e8-892d-56f7f937c5bc' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvInputPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='fce2fbd7-000c-4e7c-a5d4-7f7525dd7524' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvSampleOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='fd1caa6c-7a40-42f4-95fc-3ea256a6e591' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.22'>
                    <om:Property Name='Ref' Value='POC.BizTalk.AdvanceFilterWithXSLT.XMLSample' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='f03d7137-4e64-41d0-a2ff-1c435ddb17b6' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SndCountPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='db9cc2d6-531b-4c56-9feb-756b7d4d5a98' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CountOutputOp' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='4a8dd0c3-e553-4389-8a1e-b21f706fcb01' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.24'>
                    <om:Property Name='Ref' Value='POC.BizTalk.AdvanceFilterWithXSLT.OutputCount' />
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
        public class __orchAdvFilterXSLT_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __orchAdvFilterXSLT_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orchAdvFilterXSLT")
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
                orchAdvFilterXSLT __svc__ = (orchAdvFilterXSLT)_service;
                __orchAdvFilterXSLT_root_0 __ctx0__ = (__orchAdvFilterXSLT_root_0)(__svc__._stateMgrs[0]);

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
        public class __orchAdvFilterXSLT_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __orchAdvFilterXSLT_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orchAdvFilterXSLT")
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
                orchAdvFilterXSLT __svc__ = (orchAdvFilterXSLT)_service;
                __orchAdvFilterXSLT_1 __ctx1__ = (__orchAdvFilterXSLT_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgInput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInput);
                    __ctx1__.__msgInput = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput);
                    __ctx1__.__msgOutput = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgInput")]
            public __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_XMLSample __msgInput;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOutput")]
            public __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_OutputCount __msgOutput;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varCountDistinct")]
            internal System.Int32 __varCountDistinct;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varCountOr")]
            internal System.Int32 __varCountOr;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varCountSF")]
            internal System.Int32 __varCountSF;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varXML")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __varXML;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varCountMF")]
            internal System.Int32 __varCountMF;
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
                                               typeof(orchAdvFilterXSLT).GetField("RcvInputPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(orchAdvFilterXSLT), "RcvInputPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SndCountPortType.CountOutputOp},
                                               typeof(orchAdvFilterXSLT).GetField("SndCountPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(orchAdvFilterXSLT), "SndCountPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "13b54db2-80dd-437f-8db2-22c5d3baf74d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "13b54db2-80dd-437f-8db2-22c5d3baf74d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "dd517e13-6364-4953-b3f4-7d89447d2ce4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "dd517e13-6364-4953-b3f4-7d89447d2ce4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "edbeb44b-eddc-481e-8514-17e4a379db8c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "edbeb44b-eddc-481e-8514-17e4a379db8c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "ed8c4e93-5494-462f-9d70-b013c6b11d5d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "ed8c4e93-5494-462f-9d70-b013c6b11d5d", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,5,5,5,6,6,7,8,8,8,9,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __orchAdvFilterXSLT_root_0 __ctx0__ = (__orchAdvFilterXSLT_root_0)_stateMgrs[0];
            __orchAdvFilterXSLT_1 __ctx1__ = (__orchAdvFilterXSLT_1)_stateMgrs[1];

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
                __ctx1__ = new __orchAdvFilterXSLT_1(this);
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
            __orchAdvFilterXSLT_root_0 __ctx0__ = (__orchAdvFilterXSLT_root_0)_stateMgrs[0];
            __orchAdvFilterXSLT_1 __ctx1__ = (__orchAdvFilterXSLT_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varCountDistinct = default(System.Int32);
                __ctx1__.__varCountOr = default(System.Int32);
                __ctx1__.__varCountSF = default(System.Int32);
                __ctx1__.__varXML = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__varCountMF = default(System.Int32);
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
                __ctx1__.__msgInput = new __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_XMLSample("msgInput", __ctx1__);
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
                __ctx1__.__varCountSF = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgInput.part, "count(//*[local-name()='XMLSample']/*[local-name()='Object']/*[local-name()='Type'][text()='P'])", typeof(System.Object)));
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
                __ctx1__.__varCountOr = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgInput.part, "count(//*[local-name()='XMLSample']/*[local-name()='Object']/*[local-name()='Type'][text()='P' or text()='A'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__varCountMF = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgInput.part, "count(//*[local-name()='XMLSample']/*[local-name()='Object'][*[local-name()='Type'][text()='P']][*[local-name()='Name'][text()='Sandro']])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__varCountDistinct = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgInput.part, "count(//*[local-name()='XMLSample']/*[local-name()='Object'][not(*[local-name()='Name']/text()=preceding-sibling::*[local-name()='Object']/*[local-name()='Name']/text())]/*[local-name()='Name'])", typeof(System.Object)));
                if (__ctx1__ != null && __ctx1__.__msgInput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInput);
                    __ctx1__.__msgInput = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_OutputCount __msgOutput = new __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_OutputCount("msgOutput", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:Count xmlns:ns0=""http://POC.BizTalk.AdvanceFilterWithXSLT.OutputCount""><NumberObjMultipleFilterElement>" + __ctx1__.__varCountMF.ToString() + "</NumberObjMultipleFilterElement><NumberObjSingleFilterElement>" + __ctx1__.__varCountSF.ToString() + "</NumberObjSingleFilterElement><NumberObjsOrClause>" + __ctx1__.__varCountOr.ToString() + "</NumberObjsOrClause><NumberObjsDistinct>" + __ctx1__.__varCountDistinct.ToString() + "</NumberObjsDistinct></ns0:Count>");
                    __msgOutput.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgOutput != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOutput);
                    __ctx1__.__msgOutput = __msgOutput;
                    __ctx1__.RefMessage(__ctx1__.__msgOutput);
                }
                __ctx1__.__msgOutput.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOutput);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
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
                SndCountPort.SendMessage(0, __ctx1__.__msgOutput, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SndCountPort != null)
                {
                    SndCountPort.Close(__ctx1__, __seg__);
                    SndCountPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgOutput);
                    __edata.PortName = @"SndCountPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput);
                    __ctx1__.__msgOutput = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
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
    }

    [System.SerializableAttribute]
    sealed public class __POC_BizTalk_AdvanceFilterWithXSLT_XMLSample__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.BizTalk.AdvanceFilterWithXSLT.XMLSample _schema = new POC.BizTalk.AdvanceFilterWithXSLT.XMLSample();

        public __POC_BizTalk_AdvanceFilterWithXSLT_XMLSample__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.BizTalk.AdvanceFilterWithXSLT.XMLSample",
        new System.Type[]{
            typeof(POC.BizTalk.AdvanceFilterWithXSLT.XMLSample)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_BizTalk_AdvanceFilterWithXSLT_XMLSample__)
        },
        0,
        @"http://POC.BizTalk.AdvanceFilterWithXSLT.XMLSample#XMLSample"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_XMLSample : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_BizTalk_AdvanceFilterWithXSLT_XMLSample__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_BizTalk_AdvanceFilterWithXSLT_XMLSample__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_XMLSample(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_BizTalk_AdvanceFilterWithXSLT_OutputCount__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.BizTalk.AdvanceFilterWithXSLT.OutputCount _schema = new POC.BizTalk.AdvanceFilterWithXSLT.OutputCount();

        public __POC_BizTalk_AdvanceFilterWithXSLT_OutputCount__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.BizTalk.AdvanceFilterWithXSLT.OutputCount",
        new System.Type[]{
            typeof(POC.BizTalk.AdvanceFilterWithXSLT.OutputCount)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_BizTalk_AdvanceFilterWithXSLT_OutputCount__)
        },
        0,
        @"http://POC.BizTalk.AdvanceFilterWithXSLT.OutputCount#Count"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_OutputCount : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_BizTalk_AdvanceFilterWithXSLT_OutputCount__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_BizTalk_AdvanceFilterWithXSLT_OutputCount__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_BizTalk_AdvanceFilterWithXSLT_OutputCount(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
