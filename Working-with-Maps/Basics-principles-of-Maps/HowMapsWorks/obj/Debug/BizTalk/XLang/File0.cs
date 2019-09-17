
#pragma warning disable 162

namespace HowMapsWorks
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "PersonOperation",
        new System.Type[]{
            typeof(HowMapsWorks.__messagetype_HowMapsWorks_Schemas_PersonOrigin)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class ReceivePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceivePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceivePortType(ReceivePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceivePortType p = new ReceivePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo PersonOperation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "PersonOperation",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceivePortType),
            typeof(__messagetype_HowMapsWorks_Schemas_PersonOrigin),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "PersonOperation" ] = PersonOperation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendTargetOperation",
        new System.Type[]{
            typeof(HowMapsWorks.__messagetype_HowMapsWorks_Schemas_PersonTarget)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class SendPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendPortType(SendPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendPortType p = new SendPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendTargetOperation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendTargetOperation",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendPortType),
            typeof(__messagetype_HowMapsWorks_Schemas_PersonTarget),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendTargetOperation" ] = SendTargetOperation;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 172 "C:\Development\ComoFuncinamOsMapas\HowMapsWorks\Orchestrations\TestMapInOrchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceivePort", "PersonOperation", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(HowMapsWorks.ReceivePortType),
            typeof(HowMapsWorks.SendPortType)
        },
        new System.String[] {
            "ReceivePort",
            "SendPort"
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
    sealed internal class TestMapInOrchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(TestMapInOrchestration));
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

        static TestMapInOrchestration()
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
            _rootContext = new __TestMapInOrchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public TestMapInOrchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "TestMapInOrchestration", tracker)
        {
            ConstructorHelper();
        }

        public TestMapInOrchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "TestMapInOrchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>994fdaeb-26b6-421b-967c-e1e0ea335e01</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>db5de239-5d13-40a8-bff8-01a0a4e3d6a3</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive PersonOrigin</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>534e1eca-2e0c-4b76-bacc-911805086c7a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct PersonTarget Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>cadf57d3-fa8a-4aa6-8ff8-2a6417bfcfd0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform Origin to Target</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d47fb527-2621-4cda-abab-d09ea91a9b8f</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b021e967-494c-4000-afff-3fe16e59022e</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>8baf5ed7-0514-48d7-8466-b54110c551dc</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>63120a3b-c4fe-4060-9b33-ac3498ed42d5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send PersonTarget</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'TestMapInOrchestration'</ActionName><IsAtomic>0</IsAtomic><Line>172</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>183</Line><Position>22</Position><ShapeID>'db5de239-5d13-40a8-bff8-01a0a4e3d6a3'</ShapeID>
<Messages>
	<MsgInfo><name>msgIn</name><part>part</part><schema>HowMapsWorks.Schemas.PersonOrigin</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>185</Line><Position>13</Position><ShapeID>'534e1eca-2e0c-4b76-bacc-911805086c7a'</ShapeID>
<Messages>
	<MsgInfo><name>msgOut</name><part>part</part><schema>HowMapsWorks.Schemas.PersonTarget</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgIn</name><part>part</part><schema>HowMapsWorks.Schemas.PersonOrigin</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>191</Line><Position>13</Position><ShapeID>'63120a3b-c4fe-4060-9b33-ac3498ed42d5'</ShapeID>
<Messages>
	<MsgInfo><name>msgOut</name><part>part</part><schema>HowMapsWorks.Schemas.PersonTarget</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='a45200b9-6f5f-42f7-9ad5-cb3da026d1af' LowerBound='1.1' HigherBound='42.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='HowMapsWorks' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='e1895df6-4399-4f80-8aba-e746935a974d' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceivePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d17bfdbd-4f2d-451b-8182-09c64bec2e26' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PersonOperation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='a1f17ae0-4dbf-4935-aa0b-b8a4991eede6' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.33'>
                    <om:Property Name='Ref' Value='HowMapsWorks.Schemas.PersonOrigin' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='22ad2426-79dd-47d8-aa66-40938880a8a8' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='70748076-5d88-4992-a137-2072a766da0f' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendTargetOperation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='88253d4f-fba7-4a2b-be3a-409ff8d65c78' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.33'>
                    <om:Property Name='Ref' Value='HowMapsWorks.Schemas.PersonTarget' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='e458c8a1-9407-4f19-9d23-4c64a2b31935' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='41.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='TestMapInOrchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='994fdaeb-26b6-421b-967c-e1e0ea335e01' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='db5de239-5d13-40a8-bff8-01a0a4e3d6a3' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceivePort' />
                    <om:Property Name='MessageName' Value='msgIn' />
                    <om:Property Name='OperationName' Value='PersonOperation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive PersonOrigin' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='534e1eca-2e0c-4b76-bacc-911805086c7a' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='37.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct PersonTarget Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='cadf57d3-fa8a-4aa6-8ff8-2a6417bfcfd0' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='36.1'>
                        <om:Property Name='ClassName' Value='HowMapsWorks.Maps.BasicsOfMaps' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform Origin to Target' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='d47fb527-2621-4cda-abab-d09ea91a9b8f' ParentLink='Transform_InputMessagePartRef' LowerBound='35.70' HigherBound='35.75'>
                            <om:Property Name='MessageRef' Value='msgIn' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='b021e967-494c-4000-afff-3fe16e59022e' ParentLink='Transform_OutputMessagePartRef' LowerBound='35.28' HigherBound='35.34'>
                            <om:Property Name='MessageRef' Value='msgOut' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='8baf5ed7-0514-48d7-8466-b54110c551dc' ParentLink='Construct_MessageRef' LowerBound='32.23' HigherBound='32.29'>
                        <om:Property Name='Ref' Value='msgOut' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='63120a3b-c4fe-4060-9b33-ac3498ed42d5' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='39.1'>
                    <om:Property Name='PortName' Value='SendPort' />
                    <om:Property Name='MessageName' Value='msgOut' />
                    <om:Property Name='OperationName' Value='SendTargetOperation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send PersonTarget' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e0b5e749-6d6f-4409-8f35-9cc907619b9c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowMapsWorks.ReceivePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceivePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='309203fa-10a4-4e34-938c-1dd2fc6096eb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1f113745-0366-4b9e-9569-8cbfffc929c2' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='HowMapsWorks.SendPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2476278f-03b3-43d4-8c76-767cfeba9e6c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7ae56e95-eb8a-4c32-b3ce-7bf654584e9f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='HowMapsWorks.Schemas.PersonOrigin' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='84f5edb3-4129-42d7-85c1-d0486e711a37' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='HowMapsWorks.Schemas.PersonTarget' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOut' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __TestMapInOrchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __TestMapInOrchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "TestMapInOrchestration")
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
                TestMapInOrchestration __svc__ = (TestMapInOrchestration)_service;
                __TestMapInOrchestration_root_0 __ctx0__ = (__TestMapInOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceivePort != null)
                {
                    __svc__.ReceivePort.Close(this, null);
                    __svc__.ReceivePort = null;
                }
                if (__svc__.SendPort != null)
                {
                    __svc__.SendPort.Close(this, null);
                    __svc__.SendPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __TestMapInOrchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __TestMapInOrchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "TestMapInOrchestration")
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
                TestMapInOrchestration __svc__ = (TestMapInOrchestration)_service;
                __TestMapInOrchestration_1 __ctx1__ = (__TestMapInOrchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                    __ctx1__.__msgIn = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOut);
                    __ctx1__.__msgOut = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgIn")]
            public __messagetype_HowMapsWorks_Schemas_PersonOrigin __msgIn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOut")]
            public __messagetype_HowMapsWorks_Schemas_PersonTarget __msgOut;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceivePort")]
        internal ReceivePortType ReceivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendPort")]
        internal SendPortType SendPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceivePortType.PersonOperation},
                                               typeof(TestMapInOrchestration).GetField("ReceivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(TestMapInOrchestration), "ReceivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendPortType.SendTargetOperation},
                                               typeof(TestMapInOrchestration).GetField("SendPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(TestMapInOrchestration), "SendPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "db5de239-5d13-40a8-bff8-01a0a4e3d6a3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "db5de239-5d13-40a8-bff8-01a0a4e3d6a3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "534e1eca-2e0c-4b76-bacc-911805086c7a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "534e1eca-2e0c-4b76-bacc-911805086c7a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "63120a3b-c4fe-4060-9b33-ac3498ed42d5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "63120a3b-c4fe-4060-9b33-ac3498ed42d5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 1, false)
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

        public static int[] __progressLocation0 = new int[] { 0,0,0,7,7,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,7,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __TestMapInOrchestration_root_0 __ctx0__ = (__TestMapInOrchestration_root_0)_stateMgrs[0];
            __TestMapInOrchestration_1 __ctx1__ = (__TestMapInOrchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceivePort = new ReceivePortType(0, this);
                SendPort = new SendPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceivePort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __TestMapInOrchestration_1(this);
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
            __TestMapInOrchestration_root_0 __ctx0__ = (__TestMapInOrchestration_root_0)_stateMgrs[0];
            __TestMapInOrchestration_1 __ctx1__ = (__TestMapInOrchestration_1)_stateMgrs[1];

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
                if (!ReceivePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                __ctx1__.__msgIn = new __messagetype_HowMapsWorks_Schemas_PersonOrigin("msgIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgIn);
                ReceivePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceivePort != null)
                {
                    ReceivePort.Close(__ctx1__, __seg__);
                    ReceivePort = null;
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
                    __edata.PortName = @"ReceivePort";
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
                    __messagetype_HowMapsWorks_Schemas_PersonTarget __msgOut = new __messagetype_HowMapsWorks_Schemas_PersonTarget("msgOut", __ctx1__);

                    ApplyTransform(typeof(HowMapsWorks.Maps.BasicsOfMaps), new object[] {__msgOut.part}, new object[] {__ctx1__.__msgIn.part});

                    if (__ctx1__.__msgOut != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOut);
                    __ctx1__.__msgOut = __msgOut;
                    __ctx1__.RefMessage(__ctx1__.__msgOut);
                }
                __ctx1__.__msgOut.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOut);
                    __edata.Messages.Add(__ctx1__.__msgIn);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgIn);
                    __ctx1__.__msgIn = null;
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
                SendPort.SendMessage(0, __ctx1__.__msgOut, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendPort != null)
                {
                    SendPort.Close(__ctx1__, __seg__);
                    SendPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgOut);
                    __edata.PortName = @"SendPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOut);
                    __ctx1__.__msgOut = null;
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
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowMapsWorks_Schemas_PersonOrigin__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowMapsWorks.Schemas.PersonOrigin _schema = new HowMapsWorks.Schemas.PersonOrigin();

        public __HowMapsWorks_Schemas_PersonOrigin__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowMapsWorks.Schemas.PersonOrigin",
        new System.Type[]{
            typeof(HowMapsWorks.Schemas.PersonOrigin)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowMapsWorks_Schemas_PersonOrigin__)
        },
        0,
        @"http://HowMapsWorks.PersonOrigin#PersonOrigin"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowMapsWorks_Schemas_PersonOrigin : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowMapsWorks_Schemas_PersonOrigin__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowMapsWorks_Schemas_PersonOrigin__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowMapsWorks_Schemas_PersonOrigin(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __HowMapsWorks_Schemas_PersonTarget__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static HowMapsWorks.Schemas.PersonTarget _schema = new HowMapsWorks.Schemas.PersonTarget();

        public __HowMapsWorks_Schemas_PersonTarget__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "HowMapsWorks.Schemas.PersonTarget",
        new System.Type[]{
            typeof(HowMapsWorks.Schemas.PersonTarget)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__HowMapsWorks_Schemas_PersonTarget__)
        },
        0,
        @"http://HowMapsWorks.PersonTarget#PersonTarget"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_HowMapsWorks_Schemas_PersonTarget : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __HowMapsWorks_Schemas_PersonTarget__ part;

        private void __CreatePartWrappers()
        {
            part = new __HowMapsWorks_Schemas_PersonTarget__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_HowMapsWorks_Schemas_PersonTarget(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
