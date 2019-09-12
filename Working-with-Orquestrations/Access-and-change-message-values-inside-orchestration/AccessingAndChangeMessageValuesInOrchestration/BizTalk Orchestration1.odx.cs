
#pragma warning disable 162

namespace AccessingAndChangeMessageValuesInOrchestration
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(AccessingAndChangeMessageValuesInOrchestration.__messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1),
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
            typeof(AccessingAndChangeMessageValuesInOrchestration.__messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_2(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_2(PortType_2 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_2 p = new PortType_2(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_2),
            typeof(__messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1),
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
    //#line 264 "C:\Development\Testes\AccessingAndChangeMessageValuesInOrchestration\AccessingAndChangeMessageValuesInOrchestration\BizTalk Orchestration1.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(AccessingAndChangeMessageValuesInOrchestration.PortType_1),
            typeof(AccessingAndChangeMessageValuesInOrchestration.PortType_2)
        },
        new System.String[] {
            "Port_1",
            "Port_2"
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
    sealed internal class BizTalk_Orchestration1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(BizTalk_Orchestration1));
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

        static BizTalk_Orchestration1()
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
            _rootContext = new __BizTalk_Orchestration1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public BizTalk_Orchestration1(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "BizTalk_Orchestration1", tracker)
        {
            ConstructorHelper();
        }

        public BizTalk_Orchestration1(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "BizTalk_Orchestration1")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>2f024f83-9754-4896-b6a5-8408df8971a3</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>3c00d6e2-6546-4eb7-81bc-3aa4dcc05875</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>f4e20156-b9bd-46c8-8163-7324f85a8591</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Using Promoted Properties Read/Write</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>61c5336e-2ca5-4420-82de-47820606a3e4</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>07230e03-9a26-4381-b5be-4e3e4aeab661</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6bbffd91-547d-43bb-be76-a5132637d9c4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>fbd38c44-1fa1-4dbc-a2db-8dc898a257a0</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Using Distinguished Fields Read/Write</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a793ade0-c427-4e84-bb5d-0a7ee60926b9</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>a76ddd18-57f7-4589-871f-63e7639ee8c6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>a8345a42-7215-4c32-adfb-b655e161785d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8e4ed35d-7b97-486f-9120-d8f8f7d787d5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Using XPath Read/Write</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>7e363773-8473-477f-b5fa-e68b732c5ed3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>b01d6bb4-7f0c-454c-aaee-64afa8cf7827</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9670f6bb-965b-46b3-ac57-09fbf5ef4e5e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>843e8827-cd88-4ba7-b3ab-2b0af56687ea</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Using C# Object Read/Write</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>23e59885-b6f9-42b7-80e3-2b30ee0d8f46</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>9422d376-004a-416d-b68d-7ee8f8b0ade0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>fa538d73-95f7-4741-ab54-24ac9b1c5952</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'BizTalk_Orchestration1'</ActionName><IsAtomic>0</IsAtomic><Line>264</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>279</Line><Position>22</Position><ShapeID>'3c00d6e2-6546-4eb7-81bc-3aa4dcc05875'</ShapeID>
<Messages>
	<MsgInfo><name>msgInput</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>282</Line><Position>13</Position><ShapeID>'f4e20156-b9bd-46c8-8163-7324f85a8591'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput1</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>297</Line><Position>13</Position><ShapeID>'6bbffd91-547d-43bb-be76-a5132637d9c4'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput1</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>299</Line><Position>13</Position><ShapeID>'fbd38c44-1fa1-4dbc-a2db-8dc898a257a0'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput2</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>314</Line><Position>13</Position><ShapeID>'a8345a42-7215-4c32-adfb-b655e161785d'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput2</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>316</Line><Position>13</Position><ShapeID>'8e4ed35d-7b97-486f-9120-d8f8f7d787d5'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput3</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>331</Line><Position>13</Position><ShapeID>'9670f6bb-965b-46b3-ac57-09fbf5ef4e5e'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput3</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>333</Line><Position>13</Position><ShapeID>'843e8827-cd88-4ba7-b3ab-2b0af56687ea'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput4</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>354</Line><Position>13</Position><ShapeID>'fa538d73-95f7-4741-ab54-24ac9b1c5952'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput4</name><part>part</part><schema>AccessingAndChangeMessageValuesInOrchestration.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='cbba58be-9a5d-42c5-90f0-40b644c5c365' LowerBound='1.1' HigherBound='113.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='AccessingAndChangeMessageValuesInOrchestration' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5fb17ae4-c8e8-463e-aac2-c97227952071' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e7cd39ad-3ad5-4c5b-b532-7a83688b8391' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9e409137-96c2-4585-80f9-8161f0b5a796' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.20'>
                    <om:Property Name='Ref' Value='AccessingAndChangeMessageValuesInOrchestration.Schema1' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='8dc53375-5461-4602-8fb1-8022dd2cda9b' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='fedec118-5c36-4430-ac95-1aae87151e11' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='74d0d826-60ca-4948-9cf4-a5c9f7bd17ef' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.20'>
                    <om:Property Name='Ref' Value='AccessingAndChangeMessageValuesInOrchestration.Schema1' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='141f06e3-7092-457f-8dc8-fb29eab62891' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='112.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalk_Orchestration1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='8eae43cf-d952-493e-8c2c-3f3fc7e414c8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='HelperClassLibrary.Person' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varPersonMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7893ee21-7e0b-4a19-8859-b97d5ecf0d15' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='AccessingAndChangeMessageValuesInOrchestration.Schema1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOutput4' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='9a738aaf-5505-4c12-af55-ad6885bd467a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='AccessingAndChangeMessageValuesInOrchestration.Schema1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOutput3' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='94304fc7-3b2f-41b5-9d76-ebacb822fe1c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='AccessingAndChangeMessageValuesInOrchestration.Schema1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOutput2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='38a17e85-5764-4d83-b1cf-e9487ed4dc2a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='AccessingAndChangeMessageValuesInOrchestration.Schema1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgInput' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='12b22ae6-270a-45e2-9e8c-a167c534c618' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='Type' Value='AccessingAndChangeMessageValuesInOrchestration.Schema1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOutput1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='2f024f83-9754-4896-b6a5-8408df8971a3' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='3c00d6e2-6546-4eb7-81bc-3aa4dcc05875' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='36.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='msgInput' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='f4e20156-b9bd-46c8-8163-7324f85a8591' ParentLink='ServiceBody_Statement' LowerBound='36.1' HigherBound='51.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Using Promoted Properties Read/Write' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='61c5336e-2ca5-4420-82de-47820606a3e4' ParentLink='Construct_MessageRef' LowerBound='37.23' HigherBound='37.33'>
                        <om:Property Name='Ref' Value='msgOutput1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='07230e03-9a26-4381-b5be-4e3e4aeab661' ParentLink='ComplexStatement_Statement' LowerBound='39.1' HigherBound='50.1'>
                        <om:Property Name='Expression' Value='msgOutput1 = msgInput;&#xD;&#xA;&#xD;&#xA;//Read &#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&#xD;&#xA;    &quot;Orchestration&quot;, &#xD;&#xA;    System.Convert.ToString(msgOutput1(AccessingAndChangeMessageValuesInOrchestration.PropertySchema.FirstName)), &#xD;&#xA;    System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;&#xD;&#xA;//SET (Write)&#xD;&#xA;msgOutput1(AccessingAndChangeMessageValuesInOrchestration.PropertySchema.FirstName) = &quot;Sandro&quot;;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='6bbffd91-547d-43bb-be76-a5132637d9c4' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='53.1'>
                    <om:Property Name='PortName' Value='Port_2' />
                    <om:Property Name='MessageName' Value='msgOutput1' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='fbd38c44-1fa1-4dbc-a2db-8dc898a257a0' ParentLink='ServiceBody_Statement' LowerBound='53.1' HigherBound='68.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Using Distinguished Fields Read/Write' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='a793ade0-c427-4e84-bb5d-0a7ee60926b9' ParentLink='Construct_MessageRef' LowerBound='54.23' HigherBound='54.33'>
                        <om:Property Name='Ref' Value='msgOutput2' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='a76ddd18-57f7-4589-871f-63e7639ee8c6' ParentLink='ComplexStatement_Statement' LowerBound='56.1' HigherBound='67.1'>
                        <om:Property Name='Expression' Value='msgOutput2 = msgInput;&#xD;&#xA;&#xD;&#xA;//Read &#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&#xD;&#xA;    &quot;Orchestration&quot;, &#xD;&#xA;    System.Convert.ToString(msgOutput2.LastName), &#xD;&#xA;    System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;&#xD;&#xA;//SET (Write)&#xD;&#xA;msgOutput2.LastName = &quot;Pereira&quot;;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='a8345a42-7215-4c32-adfb-b655e161785d' ParentLink='ServiceBody_Statement' LowerBound='68.1' HigherBound='70.1'>
                    <om:Property Name='PortName' Value='Port_2' />
                    <om:Property Name='MessageName' Value='msgOutput2' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='8e4ed35d-7b97-486f-9120-d8f8f7d787d5' ParentLink='ServiceBody_Statement' LowerBound='70.1' HigherBound='85.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Using XPath Read/Write' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='7e363773-8473-477f-b5fa-e68b732c5ed3' ParentLink='Construct_MessageRef' LowerBound='71.23' HigherBound='71.33'>
                        <om:Property Name='Ref' Value='msgOutput3' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='b01d6bb4-7f0c-454c-aaee-64afa8cf7827' ParentLink='ComplexStatement_Statement' LowerBound='73.1' HigherBound='84.1'>
                        <om:Property Name='Expression' Value='msgOutput3 = msgInput;&#xD;&#xA;&#xD;&#xA;//Read&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&#xD;&#xA;    &quot;Orchestration&quot;, &#xD;&#xA;    System.Convert.ToString(xpath(msgOutput3,&quot;string(/*[local-name()=&apos;Person&apos; and namespace-uri()=&apos;http://AccessingAndChangeMessageValuesInOrchestration.Schema1&apos;]/*[local-name()=&apos;Age&apos; and namespace-uri()=&apos;&apos;])&quot;)), &#xD;&#xA;    System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;&#xD;&#xA;//SET (Write)&#xD;&#xA;xpath(msgOutput3,&quot;/*[local-name()=&apos;Person&apos; and namespace-uri()=&apos;http://AccessingAndChangeMessageValuesInOrchestration.Schema1&apos;]/*[local-name()=&apos;Age&apos; and namespace-uri()=&apos;&apos;]&quot;) = &quot;00&quot;;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='9670f6bb-965b-46b3-ac57-09fbf5ef4e5e' ParentLink='ServiceBody_Statement' LowerBound='85.1' HigherBound='87.1'>
                    <om:Property Name='PortName' Value='Port_2' />
                    <om:Property Name='MessageName' Value='msgOutput3' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_3' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='843e8827-cd88-4ba7-b3ab-2b0af56687ea' ParentLink='ServiceBody_Statement' LowerBound='87.1' HigherBound='108.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Using C# Object Read/Write' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='23e59885-b6f9-42b7-80e3-2b30ee0d8f46' ParentLink='Construct_MessageRef' LowerBound='88.23' HigherBound='88.33'>
                        <om:Property Name='Ref' Value='msgOutput4' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='9422d376-004a-416d-b68d-7ee8f8b0ade0' ParentLink='ComplexStatement_Statement' LowerBound='90.1' HigherBound='107.1'>
                        <om:Property Name='Expression' Value='//CONVERT MESSAGE INTO C# OBJECT&#xD;&#xA;varPersonMsg = msgInput;&#xD;&#xA;&#xD;&#xA;//Read&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&#xD;&#xA;    &quot;Orchestration&quot;, &#xD;&#xA;    varPersonMsg.FirstName + &quot; &quot; + varPersonMsg.LastName, &#xD;&#xA;    System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;&#xD;&#xA;//SET (Write)&#xD;&#xA;varPersonMsg.FirstName = &quot;Sandro&quot;;&#xD;&#xA;varPersonMsg.LastName = &quot;Pereira&quot;;&#xD;&#xA;varPersonMsg.Age = &quot;00&quot;;&#xD;&#xA;&#xD;&#xA;//CONVERT C# OBJECT INTO BIZTALK MESSAGE&#xD;&#xA;msgOutput4 = varPersonMsg;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='fa538d73-95f7-4741-ab54-24ac9b1c5952' ParentLink='ServiceBody_Statement' LowerBound='108.1' HigherBound='110.1'>
                    <om:Property Name='PortName' Value='Port_2' />
                    <om:Property Name='MessageName' Value='msgOutput4' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_4' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='2a6d6f56-cbd9-4f32-b060-793c958c280c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AccessingAndChangeMessageValuesInOrchestration.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='f8ef110d-1030-459f-b6da-c1f6d6a2fbc2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='540219c8-b0f1-49bc-a2ec-77ec0873c9fb' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='28' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AccessingAndChangeMessageValuesInOrchestration.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_2' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8682d503-ec2e-4fe9-9840-e42fdabd082a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __BizTalk_Orchestration1_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __BizTalk_Orchestration1_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration1")
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_2 != null)
                {
                    __svc__.Port_2.Close(this, null);
                    __svc__.Port_2 = null;
                }
                if (__svc__.Port_1 != null)
                {
                    __svc__.Port_1.Close(this, null);
                    __svc__.Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __BizTalk_Orchestration1_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __BizTalk_Orchestration1_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration1")
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgOutput4 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput4);
                    __ctx1__.__msgOutput4 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varPersonMsg = null;
                if (__ctx1__ != null && __ctx1__.__msgInput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInput);
                    __ctx1__.__msgInput = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput2);
                    __ctx1__.__msgOutput2 = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput1);
                    __ctx1__.__msgOutput1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput3 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput3);
                    __ctx1__.__msgOutput3 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOutput4")]
            public __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgOutput4;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOutput3")]
            public __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgOutput3;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOutput2")]
            public __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgOutput2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgInput")]
            public __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgInput;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOutput1")]
            public __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgOutput1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varPersonMsg")]
            internal HelperClassLibrary.Person __varPersonMsg;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal PortType_1 Port_1;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_2")]
        internal PortType_2 Port_2;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Port_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Port_2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Port_2"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "3c00d6e2-6546-4eb7-81bc-3aa4dcc05875", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "3c00d6e2-6546-4eb7-81bc-3aa4dcc05875", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "f4e20156-b9bd-46c8-8163-7324f85a8591", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "f4e20156-b9bd-46c8-8163-7324f85a8591", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "6bbffd91-547d-43bb-be76-a5132637d9c4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "6bbffd91-547d-43bb-be76-a5132637d9c4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "fbd38c44-1fa1-4dbc-a2db-8dc898a257a0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "fbd38c44-1fa1-4dbc-a2db-8dc898a257a0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "a8345a42-7215-4c32-adfb-b655e161785d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "a8345a42-7215-4c32-adfb-b655e161785d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "8e4ed35d-7b97-486f-9120-d8f8f7d787d5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "8e4ed35d-7b97-486f-9120-d8f8f7d787d5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "9670f6bb-965b-46b3-ac57-09fbf5ef4e5e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "9670f6bb-965b-46b3-ac57-09fbf5ef4e5e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "843e8827-cd88-4ba7-b3ab-2b0af56687ea", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "843e8827-cd88-4ba7-b3ab-2b0af56687ea", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "fa538d73-95f7-4741-ab54-24ac9b1c5952", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "fa538d73-95f7-4741-ab54-24ac9b1c5952", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,6,7,8,8,9,10,10,10,11,12,12,13,14,14,14,15,16,16,17,18,18,18,19,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Port_1 = new PortType_1(0, this);
                Port_2 = new PortType_2(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __BizTalk_Orchestration1_1(this);
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
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varPersonMsg = null;
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
                if (!Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgInput != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgInput);
                __ctx1__.__msgInput = new __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1("msgInput", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgInput);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgInput, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx1__, __seg__);
                    Port_1 = null;
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
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__varPersonMsg = new HelperClassLibrary.Person();
                RootService.CommitStateManager.UserCodeCalled = true;
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
                    __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgOutput1 = new __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1("msgOutput1", __ctx1__);

                    __msgOutput1.CopyFrom(__ctx1__.__msgInput);
                    RootService.CommitStateManager.UserCodeCalled = true;
                    System.Diagnostics.EventLog.WriteEntry("Orchestration", System.Convert.ToString((System.String)__msgOutput1.GetPropertyValueThrows(typeof(AccessingAndChangeMessageValuesInOrchestration.PropertySchema.FirstName))), System.Diagnostics.EventLogEntryType.Error);
                    RootService.CommitStateManager.UserCodeCalled = true;
                    __msgOutput1.SetPropertyValue(typeof(AccessingAndChangeMessageValuesInOrchestration.PropertySchema.FirstName), "Sandro");
                    RootService.CommitStateManager.UserCodeCalled = true;

                    if (__ctx1__.__msgOutput1 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOutput1);
                    __ctx1__.__msgOutput1 = __msgOutput1;
                    __ctx1__.RefMessage(__ctx1__.__msgOutput1);
                }
                __ctx1__.__msgOutput1.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOutput1);
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
                Port_2.SendMessage(0, __ctx1__.__msgOutput1, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgOutput1);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput1);
                    __ctx1__.__msgOutput1 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgOutput2 = new __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1("msgOutput2", __ctx1__);

                    __msgOutput2.CopyFrom(__ctx1__.__msgInput);
                    RootService.CommitStateManager.UserCodeCalled = true;
                    System.Diagnostics.EventLog.WriteEntry("Orchestration", System.Convert.ToString((System.String)__msgOutput2.part.GetDistinguishedField("LastName")), System.Diagnostics.EventLogEntryType.Error);
                    RootService.CommitStateManager.UserCodeCalled = true;
                    __msgOutput2.part.SetDistinguishedField("LastName", "Pereira");
                    RootService.CommitStateManager.UserCodeCalled = true;

                    if (__ctx1__.__msgOutput2 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOutput2);
                    __ctx1__.__msgOutput2 = __msgOutput2;
                    __ctx1__.RefMessage(__ctx1__.__msgOutput2);
                }
                __ctx1__.__msgOutput2.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOutput2);
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
                Port_2.SendMessage(0, __ctx1__.__msgOutput2, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgOutput2);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput2);
                    __ctx1__.__msgOutput2 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                {
                    __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgOutput3 = new __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1("msgOutput3", __ctx1__);

                    __msgOutput3.CopyFrom(__ctx1__.__msgInput);
                    RootService.CommitStateManager.UserCodeCalled = true;
                    System.Diagnostics.EventLog.WriteEntry("Orchestration", System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__msgOutput3.part, "string(/*[local-name()='Person' and namespace-uri()='http://AccessingAndChangeMessageValuesInOrchestration.Schema1']/*[local-name()='Age' and namespace-uri()=''])", typeof(System.Object))), System.Diagnostics.EventLogEntryType.Error);
                    RootService.CommitStateManager.UserCodeCalled = true;
                    __msgOutput3.part.XPathStore("00", "/*[local-name()='Person' and namespace-uri()='http://AccessingAndChangeMessageValuesInOrchestration.Schema1']/*[local-name()='Age' and namespace-uri()='']");
                    RootService.CommitStateManager.UserCodeCalled = true;

                    if (__ctx1__.__msgOutput3 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOutput3);
                    __ctx1__.__msgOutput3 = __msgOutput3;
                    __ctx1__.RefMessage(__ctx1__.__msgOutput3);
                }
                __ctx1__.__msgOutput3.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOutput3);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_2.SendMessage(0, __ctx1__.__msgOutput3, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgOutput3);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput3 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput3);
                    __ctx1__.__msgOutput3 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                {
                    __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 __msgOutput4 = new __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1("msgOutput4", __ctx1__);

                    __ctx1__.__varPersonMsg = (HelperClassLibrary.Person)__ctx1__.__msgInput.part.RetrieveAs(typeof(HelperClassLibrary.Person));
                    RootService.CommitStateManager.UserCodeCalled = true;
                    if (__ctx1__ != null && __ctx1__.__msgInput != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__msgInput);
                        __ctx1__.__msgInput = null;
                    }
                    System.Diagnostics.EventLog.WriteEntry("Orchestration", __ctx1__.__varPersonMsg.FirstName + " " + __ctx1__.__varPersonMsg.LastName, System.Diagnostics.EventLogEntryType.Error);
                    RootService.CommitStateManager.UserCodeCalled = true;
                    __ctx1__.__varPersonMsg.FirstName = "Sandro";
                    __ctx1__.__varPersonMsg.LastName = "Pereira";
                    __ctx1__.__varPersonMsg.Age = "00";
                    __msgOutput4.part.LoadFrom(__ctx1__.__varPersonMsg);
                    RootService.CommitStateManager.UserCodeCalled = true;
                    if (__ctx1__ != null)
                        __ctx1__.__varPersonMsg = null;

                    if (__ctx1__.__msgOutput4 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOutput4);
                    __ctx1__.__msgOutput4 = __msgOutput4;
                    __ctx1__.RefMessage(__ctx1__.__msgOutput4);
                }
                __ctx1__.__msgOutput4.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOutput4);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_2.SendMessage(0, __ctx1__.__msgOutput4, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Port_2 != null)
                {
                    Port_2.Close(__ctx1__, __seg__);
                    Port_2 = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgOutput4);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput4 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput4);
                    __ctx1__.__msgOutput4 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 37;
            case 37:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __AccessingAndChangeMessageValuesInOrchestration_Schema1__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static AccessingAndChangeMessageValuesInOrchestration.Schema1 _schema = new AccessingAndChangeMessageValuesInOrchestration.Schema1();

        public __AccessingAndChangeMessageValuesInOrchestration_Schema1__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "AccessingAndChangeMessageValuesInOrchestration.Schema1",
        new System.Type[]{
            typeof(AccessingAndChangeMessageValuesInOrchestration.Schema1)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__AccessingAndChangeMessageValuesInOrchestration_Schema1__)
        },
        0,
        @"http://AccessingAndChangeMessageValuesInOrchestration.Schema1#Person"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __AccessingAndChangeMessageValuesInOrchestration_Schema1__ part;

        private void __CreatePartWrappers()
        {
            part = new __AccessingAndChangeMessageValuesInOrchestration_Schema1__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_AccessingAndChangeMessageValuesInOrchestration_Schema1(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
