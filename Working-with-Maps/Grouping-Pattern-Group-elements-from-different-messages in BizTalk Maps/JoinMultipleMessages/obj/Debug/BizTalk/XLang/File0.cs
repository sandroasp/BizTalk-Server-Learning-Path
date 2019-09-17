
#pragma warning disable 162

namespace JoinMultipleMessages
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ReceiveUsers",
        new System.Type[]{
            typeof(JoinMultipleMessages.__messagetype_JoinMultipleMessages_InuputUsers)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class ReceiveUsersType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceiveUsersType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceiveUsersType(ReceiveUsersType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceiveUsersType p = new ReceiveUsersType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ReceiveUsers = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ReceiveUsers",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceiveUsersType),
            typeof(__messagetype_JoinMultipleMessages_InuputUsers),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ReceiveUsers" ] = ReceiveUsers;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendResult",
        new System.Type[]{
            typeof(JoinMultipleMessages.__messagetype_JoinMultipleMessages_OutputMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class OutputType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public OutputType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public OutputType(OutputType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            OutputType p = new OutputType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendResult = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendResult",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(OutputType),
            typeof(__messagetype_JoinMultipleMessages_OutputMessage),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendResult" ] = SendResult;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 209 "c:\development\JoinMultipleMessages\JoinMultipleMessages\JoinMultipleMessagesDemoOrchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "InputPort", "ReceiveUsers", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(JoinMultipleMessages.ReceiveUsersType),
            typeof(JoinMultipleMessages.OutputType)
        },
        new System.String[] {
            "InputPort",
            "OutputPort"
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
    sealed internal class JoinMultipleMessagesDemoOrchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(JoinMultipleMessagesDemoOrchestration));
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

        static JoinMultipleMessagesDemoOrchestration()
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
            _rootContext = new __JoinMultipleMessagesDemoOrchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public JoinMultipleMessagesDemoOrchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "JoinMultipleMessagesDemoOrchestration", tracker)
        {
            ConstructorHelper();
        }

        public JoinMultipleMessagesDemoOrchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "JoinMultipleMessagesDemoOrchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>3470bf7b-d732-41de-8c09-26b8c44e6beb</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>3295feb6-d212-4ac4-bdee-d10294289bf5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Users Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>2431e406-c008-4098-8448-7bb4b1d064d6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Addresses Message Demo Logic</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c002ee22-899e-4d4a-9f1b-6264bed2f84f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Addresses MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a9a3f239-20d6-4923-a8d8-e394284b6a1d</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>85029459-3327-4416-8e4b-041a6bab1634</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Output Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>f4a785ac-ffc7-474c-bf25-2f56c646783d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform User and Addresses In Output</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9874f092-2efc-47ac-861b-64377ba0ccec</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5e6e4c92-af81-48b5-bb5c-d3e9bd39ed8a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1242d8e0-3b0a-4761-9b1d-0884431bc6c5</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c9837a89-70df-4da7-bdf3-731e6b38137c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7276260b-b9a4-4eff-8dac-77ea2dea82f6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Output Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'JoinMultipleMessagesDemoOrchestration'</ActionName><IsAtomic>0</IsAtomic><Line>209</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>222</Line><Position>22</Position><ShapeID>'3295feb6-d212-4ac4-bdee-d10294289bf5'</ShapeID>
<Messages>
	<MsgInfo><name>msgUsers</name><part>part</part><schema>JoinMultipleMessages.InuputUsers</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>225</Line><Position>13</Position><ShapeID>'2431e406-c008-4098-8448-7bb4b1d064d6'</ShapeID>
<Messages>
	<MsgInfo><name>msgAddresses</name><part>part</part><schema>JoinMultipleMessages.InputAddresses</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>254</Line><Position>13</Position><ShapeID>'85029459-3327-4416-8e4b-041a6bab1634'</ShapeID>
<Messages>
	<MsgInfo><name>msgResult</name><part>part</part><schema>JoinMultipleMessages.OutputMessage</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgUsers</name><part>part</part><schema>JoinMultipleMessages.InuputUsers</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>msgAddresses</name><part>part</part><schema>JoinMultipleMessages.InputAddresses</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>260</Line><Position>13</Position><ShapeID>'7276260b-b9a4-4eff-8dac-77ea2dea82f6'</ShapeID>
<Messages>
	<MsgInfo><name>msgResult</name><part>part</part><schema>JoinMultipleMessages.OutputMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='6029d5d4-9ed0-4415-967d-c051de401c7f' LowerBound='1.1' HigherBound='74.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='JoinMultipleMessages' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='9c6730bc-8181-479b-b08f-d9b4be1b7fad' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='73.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='JoinMultipleMessagesDemoOrchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='cb322fef-5384-4a49-84d7-a47602800f39' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f0addf32-9191-4d92-9090-3d8731af3f4a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='JoinMultipleMessages.InuputUsers' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgUsers' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='37206bb3-a1ac-437f-82be-8d5024738e49' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='JoinMultipleMessages.InputAddresses' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgAddresses' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='a00a0a46-9a79-41df-bd8f-741c1741d64e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='JoinMultipleMessages.OutputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgResult' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='3470bf7b-d732-41de-8c09-26b8c44e6beb' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='3295feb6-d212-4ac4-bdee-d10294289bf5' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='34.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='InputPort' />
                    <om:Property Name='MessageName' Value='msgUsers' />
                    <om:Property Name='OperationName' Value='ReceiveUsers' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Users Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='2431e406-c008-4098-8448-7bb4b1d064d6' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='63.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Addresses Message Demo Logic' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='c002ee22-899e-4d4a-9f1b-6264bed2f84f' ParentLink='ComplexStatement_Statement' LowerBound='37.1' HigherBound='62.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:Addresses xmlns:ns0=&quot;&quot;http://BizTalk_Server_GenerationFichiersReleve.Test2&quot;&quot;&gt;&#xD;&#xA;                &lt;Address&gt;&#xD;&#xA;                    &lt;UserID&gt;1&lt;/UserID&gt;&#xD;&#xA;                    &lt;AddressLine1&gt;245 rue françois 1er &lt;/AddressLine1&gt;&#xD;&#xA;                    &lt;PostCode&gt;69001&lt;/PostCode&gt;&#xD;&#xA;                    &lt;Town&gt;Lyon&lt;/Town&gt;&#xD;&#xA;                &lt;/Address&gt; &#xD;&#xA;                &lt;Address&gt;&#xD;&#xA;                    &lt;UserID&gt;2&lt;/UserID&gt;&#xD;&#xA;                    &lt;AddressLine1&gt;18 avenue Gerard Majax&lt;/AddressLine1&gt;&#xD;&#xA;                    &lt;PostCode&gt;75001&lt;/PostCode&gt;&#xD;&#xA;                    &lt;Town&gt;Paris&lt;/Town&gt; &#xD;&#xA;                &lt;/Address&gt;&#xD;&#xA;                &lt;Address&gt;&#xD;&#xA;                    &lt;UserID&gt;2&lt;/UserID&gt;&#xD;&#xA;                    &lt;AddressLine1&gt;450 rue Michou&lt;/AddressLine1&gt;&#xD;&#xA;                    &lt;PostCode&gt;75005&lt;/PostCode&gt;&#xD;&#xA;                    &lt;Town&gt;Paris&lt;/Town&gt;&#xD;&#xA;                &lt;/Address&gt;&#xD;&#xA;                &lt;/ns0:Addresses&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgAddresses = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Addresses MsgAssign' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='a9a3f239-20d6-4923-a8d8-e394284b6a1d' ParentLink='Construct_MessageRef' LowerBound='35.23' HigherBound='35.35'>
                        <om:Property Name='Ref' Value='msgAddresses' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='85029459-3327-4416-8e4b-041a6bab1634' ParentLink='ServiceBody_Statement' LowerBound='63.1' HigherBound='69.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Output Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='f4a785ac-ffc7-474c-bf25-2f56c646783d' ParentLink='ComplexStatement_Statement' LowerBound='66.1' HigherBound='68.1'>
                        <om:Property Name='ClassName' Value='JoinMultipleMessages.Transform_User_and_Addresses_In_Output' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform User and Addresses In Output' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='9874f092-2efc-47ac-861b-64377ba0ccec' ParentLink='Transform_InputMessagePartRef' LowerBound='67.102' HigherBound='67.110'>
                            <om:Property Name='MessageRef' Value='msgUsers' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='5e6e4c92-af81-48b5-bb5c-d3e9bd39ed8a' ParentLink='Transform_InputMessagePartRef' LowerBound='67.112' HigherBound='67.124'>
                            <om:Property Name='MessageRef' Value='msgAddresses' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='1242d8e0-3b0a-4761-9b1d-0884431bc6c5' ParentLink='Transform_OutputMessagePartRef' LowerBound='67.28' HigherBound='67.37'>
                            <om:Property Name='MessageRef' Value='msgResult' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='c9837a89-70df-4da7-bdf3-731e6b38137c' ParentLink='Construct_MessageRef' LowerBound='64.23' HigherBound='64.32'>
                        <om:Property Name='Ref' Value='msgResult' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='7276260b-b9a4-4eff-8dac-77ea2dea82f6' ParentLink='ServiceBody_Statement' LowerBound='69.1' HigherBound='71.1'>
                    <om:Property Name='PortName' Value='OutputPort' />
                    <om:Property Name='MessageName' Value='msgResult' />
                    <om:Property Name='OperationName' Value='SendResult' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Output Result' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='78b0238b-5547-42a6-b365-8b841f8fb5ca' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='JoinMultipleMessages.ReceiveUsersType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InputPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='19d55f59-a9a5-4770-a33c-3ca5cfe11f56' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e3512621-1dbb-4770-9d0c-b26a6c23ce5b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='26' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='JoinMultipleMessages.OutputType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OutputPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='4fd08654-eda5-443f-aed5-1e962974bacc' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='d95e654e-54ca-4f68-98f4-074f034cbbbe' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiveUsersType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='21c53b53-be9f-4e83-9fa9-1e70838574a5' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveUsers' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='e136b058-7c02-4de7-8325-7bed02ded791' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.24'>
                    <om:Property Name='Ref' Value='JoinMultipleMessages.InuputUsers' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='4b9d807f-7dee-4c24-bdad-04c0c41b244c' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OutputType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='3c59bb21-cfcb-402a-a94b-dbfbd039801d' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendResult' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='152b97da-d152-4b09-8427-1a0c49032adc' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.26'>
                    <om:Property Name='Ref' Value='JoinMultipleMessages.OutputMessage' />
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
        public class __JoinMultipleMessagesDemoOrchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __JoinMultipleMessagesDemoOrchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "JoinMultipleMessagesDemoOrchestration")
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
                JoinMultipleMessagesDemoOrchestration __svc__ = (JoinMultipleMessagesDemoOrchestration)_service;
                __JoinMultipleMessagesDemoOrchestration_root_0 __ctx0__ = (__JoinMultipleMessagesDemoOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.InputPort != null)
                {
                    __svc__.InputPort.Close(this, null);
                    __svc__.InputPort = null;
                }
                if (__svc__.OutputPort != null)
                {
                    __svc__.OutputPort.Close(this, null);
                    __svc__.OutputPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __JoinMultipleMessagesDemoOrchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __JoinMultipleMessagesDemoOrchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "JoinMultipleMessagesDemoOrchestration")
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
                JoinMultipleMessagesDemoOrchestration __svc__ = (JoinMultipleMessagesDemoOrchestration)_service;
                __JoinMultipleMessagesDemoOrchestration_1 __ctx1__ = (__JoinMultipleMessagesDemoOrchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgUsers != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgUsers);
                    __ctx1__.__msgUsers = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgAddresses != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgAddresses);
                    __ctx1__.__msgAddresses = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgResult != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgResult);
                    __ctx1__.__msgResult = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgUsers")]
            public __messagetype_JoinMultipleMessages_InuputUsers __msgUsers;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgAddresses")]
            public __messagetype_JoinMultipleMessages_InputAddresses __msgAddresses;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgResult")]
            public __messagetype_JoinMultipleMessages_OutputMessage __msgResult;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("InputPort")]
        internal ReceiveUsersType InputPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("OutputPort")]
        internal OutputType OutputPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceiveUsersType.ReceiveUsers},
                                               typeof(JoinMultipleMessagesDemoOrchestration).GetField("InputPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(JoinMultipleMessagesDemoOrchestration), "InputPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OutputType.SendResult},
                                               typeof(JoinMultipleMessagesDemoOrchestration).GetField("OutputPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(JoinMultipleMessagesDemoOrchestration), "OutputPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "3295feb6-d212-4ac4-bdee-d10294289bf5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "3295feb6-d212-4ac4-bdee-d10294289bf5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "2431e406-c008-4098-8448-7bb4b1d064d6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "2431e406-c008-4098-8448-7bb4b1d064d6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "85029459-3327-4416-8e4b-041a6bab1634", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "85029459-3327-4416-8e4b-041a6bab1634", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "7276260b-b9a4-4eff-8dac-77ea2dea82f6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "7276260b-b9a4-4eff-8dac-77ea2dea82f6", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,7,8,8,8,9,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __JoinMultipleMessagesDemoOrchestration_root_0 __ctx0__ = (__JoinMultipleMessagesDemoOrchestration_root_0)_stateMgrs[0];
            __JoinMultipleMessagesDemoOrchestration_1 __ctx1__ = (__JoinMultipleMessagesDemoOrchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                InputPort = new ReceiveUsersType(0, this);
                OutputPort = new OutputType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], InputPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __JoinMultipleMessagesDemoOrchestration_1(this);
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
            __JoinMultipleMessagesDemoOrchestration_root_0 __ctx0__ = (__JoinMultipleMessagesDemoOrchestration_root_0)_stateMgrs[0];
            __JoinMultipleMessagesDemoOrchestration_1 __ctx1__ = (__JoinMultipleMessagesDemoOrchestration_1)_stateMgrs[1];

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
                if (!InputPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgUsers != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgUsers);
                __ctx1__.__msgUsers = new __messagetype_JoinMultipleMessages_InuputUsers("msgUsers", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgUsers);
                InputPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgUsers, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (InputPort != null)
                {
                    InputPort.Close(__ctx1__, __seg__);
                    InputPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgUsers);
                    __edata.PortName = @"InputPort";
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
                {
                    __messagetype_JoinMultipleMessages_InputAddresses __msgAddresses = new __messagetype_JoinMultipleMessages_InputAddresses("msgAddresses", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:Addresses xmlns:ns0=""http://BizTalk_Server_GenerationFichiersReleve.Test2"">
                                <Address>
                                    <UserID>1</UserID>
                                    <AddressLine1>245 rue françois 1er </AddressLine1>
                                    <PostCode>69001</PostCode>
                                    <Town>Lyon</Town>
                                </Address> 
                                <Address>
                                    <UserID>2</UserID>
                                    <AddressLine1>18 avenue Gerard Majax</AddressLine1>
                                    <PostCode>75001</PostCode>
                                    <Town>Paris</Town> 
                                </Address>
                                <Address>
                                    <UserID>2</UserID>
                                    <AddressLine1>450 rue Michou</AddressLine1>
                                    <PostCode>75005</PostCode>
                                    <Town>Paris</Town>
                                </Address>
                                </ns0:Addresses>");
                    __msgAddresses.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgAddresses != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgAddresses);
                    __ctx1__.__msgAddresses = __msgAddresses;
                    __ctx1__.RefMessage(__ctx1__.__msgAddresses);
                }
                __ctx1__.__msgAddresses.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgAddresses);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_JoinMultipleMessages_OutputMessage __msgResult = new __messagetype_JoinMultipleMessages_OutputMessage("msgResult", __ctx1__);

                    ApplyTransform(typeof(JoinMultipleMessages.Transform_User_and_Addresses_In_Output), new object[] {__msgResult.part}, new object[] {__ctx1__.__msgUsers.part, __ctx1__.__msgAddresses.part});

                    if (__ctx1__.__msgResult != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgResult);
                    __ctx1__.__msgResult = __msgResult;
                    __ctx1__.RefMessage(__ctx1__.__msgResult);
                }
                __ctx1__.__msgResult.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgResult);
                    __edata.Messages.Add(__ctx1__.__msgUsers);
                    __edata.Messages.Add(__ctx1__.__msgAddresses);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgAddresses != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgAddresses);
                    __ctx1__.__msgAddresses = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgUsers != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgUsers);
                    __ctx1__.__msgUsers = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[1].TrackDataStream );
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
                OutputPort.SendMessage(0, __ctx1__.__msgResult, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (OutputPort != null)
                {
                    OutputPort.Close(__ctx1__, __seg__);
                    OutputPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgResult);
                    __edata.PortName = @"OutputPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgResult != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgResult);
                    __ctx1__.__msgResult = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[4],_stateMgrs[1].TrackDataStream );
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
    }

    [System.SerializableAttribute]
    sealed public class __JoinMultipleMessages_InuputUsers__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static JoinMultipleMessages.InuputUsers _schema = new JoinMultipleMessages.InuputUsers();

        public __JoinMultipleMessages_InuputUsers__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "JoinMultipleMessages.InuputUsers",
        new System.Type[]{
            typeof(JoinMultipleMessages.InuputUsers)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__JoinMultipleMessages_InuputUsers__)
        },
        0,
        @"http://BizTalk_Server_GenerationFichiersReleve.test#Users"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_JoinMultipleMessages_InuputUsers : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __JoinMultipleMessages_InuputUsers__ part;

        private void __CreatePartWrappers()
        {
            part = new __JoinMultipleMessages_InuputUsers__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_JoinMultipleMessages_InuputUsers(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __JoinMultipleMessages_OutputMessage__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static JoinMultipleMessages.OutputMessage _schema = new JoinMultipleMessages.OutputMessage();

        public __JoinMultipleMessages_OutputMessage__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "JoinMultipleMessages.OutputMessage",
        new System.Type[]{
            typeof(JoinMultipleMessages.OutputMessage)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__JoinMultipleMessages_OutputMessage__)
        },
        0,
        @"http://BizTalk_Server_GenerationFichiersReleve.Test3#Informations"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_JoinMultipleMessages_OutputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __JoinMultipleMessages_OutputMessage__ part;

        private void __CreatePartWrappers()
        {
            part = new __JoinMultipleMessages_OutputMessage__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_JoinMultipleMessages_OutputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __JoinMultipleMessages_InputAddresses__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static JoinMultipleMessages.InputAddresses _schema = new JoinMultipleMessages.InputAddresses();

        public __JoinMultipleMessages_InputAddresses__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "JoinMultipleMessages.InputAddresses",
        new System.Type[]{
            typeof(JoinMultipleMessages.InputAddresses)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__JoinMultipleMessages_InputAddresses__)
        },
        0,
        @"http://BizTalk_Server_GenerationFichiersReleve.Test2#Addresses"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_JoinMultipleMessages_InputAddresses : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __JoinMultipleMessages_InputAddresses__ part;

        private void __CreatePartWrappers()
        {
            part = new __JoinMultipleMessages_InputAddresses__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_JoinMultipleMessages_InputAddresses(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
