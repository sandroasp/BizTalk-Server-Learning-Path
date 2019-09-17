
#pragma warning disable 162

namespace ComoFuncinamOsMapas
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(ComoFuncinamOsMapas.__messagetype_ComoFuncinamOsMapas_Schemas_PessoaOrigem)
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
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceivePortType),
            typeof(__messagetype_ComoFuncinamOsMapas_Schemas_PessoaOrigem),
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
            typeof(ComoFuncinamOsMapas.__messagetype_ComoFuncinamOsMapas_Schemas_PessoaDestino)
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
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendPortType),
            typeof(__messagetype_ComoFuncinamOsMapas_Schemas_PessoaDestino),
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
    //#line 172 "C:\Development\ComoFuncinamOsMapas\ComoFuncinamOsMapas\Orchestrations\MapTestOrchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceivePort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(ComoFuncinamOsMapas.ReceivePortType),
            typeof(ComoFuncinamOsMapas.SendPortType)
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
    sealed internal class MapTestOrchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(MapTestOrchestration));
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

        static MapTestOrchestration()
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
            _rootContext = new __MapTestOrchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public MapTestOrchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "MapTestOrchestration", tracker)
        {
            ConstructorHelper();
        }

        public MapTestOrchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "MapTestOrchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>4d64520c-8cd6-4f64-838e-258ca26abedc</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>9c81338b-1460-477c-8516-b541af2f69c7</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Pessoa Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>bfb5ad1e-777a-4c96-b111-dbec5e936b74</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>DemoNetPonto ConstructMsg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>6cc248ca-8b00-414a-a7ad-12e751433926</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>DemoNetPonto Transf</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>c3aafd5d-7b51-485f-99a2-49f08aee1d4c</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7fdbe7ff-3c5e-4297-b714-dc8d85bdb6e1</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>44f63298-e598-4531-ba56-0a54be8e26ba</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>073f4e77-aa26-4701-895c-55a1f45a84d6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Pessoa2 Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'MapTestOrchestration'</ActionName><IsAtomic>0</IsAtomic><Line>172</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>183</Line><Position>22</Position><ShapeID>'9c81338b-1460-477c-8516-b541af2f69c7'</ShapeID>
<Messages>
	<MsgInfo><name>msgPessoa</name><part>part</part><schema>ComoFuncinamOsMapas.Schemas.PessoaOrigem</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>185</Line><Position>13</Position><ShapeID>'bfb5ad1e-777a-4c96-b111-dbec5e936b74'</ShapeID>
<Messages>
	<MsgInfo><name>msgPessoaFinal</name><part>part</part><schema>ComoFuncinamOsMapas.Schemas.PessoaDestino</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgPessoa</name><part>part</part><schema>ComoFuncinamOsMapas.Schemas.PessoaOrigem</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>191</Line><Position>13</Position><ShapeID>'073f4e77-aa26-4701-895c-55a1f45a84d6'</ShapeID>
<Messages>
	<MsgInfo><name>msgPessoaFinal</name><part>part</part><schema>ComoFuncinamOsMapas.Schemas.PessoaDestino</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='64255384-e48d-4be7-b63d-e2d79feb159a' LowerBound='1.1' HigherBound='42.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='ComoFuncinamOsMapas' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='4a551c86-054e-40a8-8bbf-21ebef46f307' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceivePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e2b97e25-de5c-4b15-8ff2-f52ef80f27e0' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='4c025237-c915-430f-979d-824330567cd0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.33'>
                    <om:Property Name='Ref' Value='ComoFuncinamOsMapas.Schemas.PessoaOrigem' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='86c44fe5-485b-4048-aef8-e11a988387ed' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b0be6eac-51cb-441b-87a9-59ab10077150' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='1cb4049d-3776-4670-895c-fa6bea30b8a2' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.34'>
                    <om:Property Name='Ref' Value='ComoFuncinamOsMapas.Schemas.PessoaDestino' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='2ba8c0a4-a29a-44f6-843d-4a331438fa52' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='41.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MapTestOrchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='4d64520c-8cd6-4f64-838e-258ca26abedc' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='9c81338b-1460-477c-8516-b541af2f69c7' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceivePort' />
                    <om:Property Name='MessageName' Value='msgPessoa' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Pessoa Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='bfb5ad1e-777a-4c96-b111-dbec5e936b74' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='37.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='DemoNetPonto ConstructMsg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='6cc248ca-8b00-414a-a7ad-12e751433926' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='36.1'>
                        <om:Property Name='ClassName' Value='ComoFuncinamOsMapas.MapasNetPonto.DemoNetPonto' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='DemoNetPonto Transf' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='c3aafd5d-7b51-485f-99a2-49f08aee1d4c' ParentLink='Transform_InputMessagePartRef' LowerBound='35.94' HigherBound='35.103'>
                            <om:Property Name='MessageRef' Value='msgPessoa' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='7fdbe7ff-3c5e-4297-b714-dc8d85bdb6e1' ParentLink='Transform_OutputMessagePartRef' LowerBound='35.28' HigherBound='35.42'>
                            <om:Property Name='MessageRef' Value='msgPessoaFinal' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='44f63298-e598-4531-ba56-0a54be8e26ba' ParentLink='Construct_MessageRef' LowerBound='32.23' HigherBound='32.37'>
                        <om:Property Name='Ref' Value='msgPessoaFinal' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='073f4e77-aa26-4701-895c-55a1f45a84d6' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='39.1'>
                    <om:Property Name='PortName' Value='SendPort' />
                    <om:Property Name='MessageName' Value='msgPessoaFinal' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Pessoa2 Msg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b764657d-7ef9-4a0e-9810-31a00e2572aa' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ComoFuncinamOsMapas.ReceivePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceivePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='077a6e16-6a65-41e2-a4d1-ebfcbb48d544' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8812441c-e09c-4c48-a3d1-cc4355b13509' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='17' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ComoFuncinamOsMapas.SendPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='49a76eb3-fef9-455f-8054-e5561e954c20' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ad6dfe00-3d80-4d89-a7b2-73482d379eb5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='ComoFuncinamOsMapas.Schemas.PessoaOrigem' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgPessoa' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='eca90f80-ac92-4f03-893d-eef0b2637f18' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='ComoFuncinamOsMapas.Schemas.PessoaDestino' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgPessoaFinal' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __MapTestOrchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __MapTestOrchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MapTestOrchestration")
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
                MapTestOrchestration __svc__ = (MapTestOrchestration)_service;
                __MapTestOrchestration_root_0 __ctx0__ = (__MapTestOrchestration_root_0)(__svc__._stateMgrs[0]);

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
        public class __MapTestOrchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __MapTestOrchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MapTestOrchestration")
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
                MapTestOrchestration __svc__ = (MapTestOrchestration)_service;
                __MapTestOrchestration_1 __ctx1__ = (__MapTestOrchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgPessoa != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgPessoa);
                    __ctx1__.__msgPessoa = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgPessoaFinal != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgPessoaFinal);
                    __ctx1__.__msgPessoaFinal = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgPessoa")]
            public __messagetype_ComoFuncinamOsMapas_Schemas_PessoaOrigem __msgPessoa;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgPessoaFinal")]
            public __messagetype_ComoFuncinamOsMapas_Schemas_PessoaDestino __msgPessoaFinal;
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
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceivePortType.Operation_1},
                                               typeof(MapTestOrchestration).GetField("ReceivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MapTestOrchestration), "ReceivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendPortType.Operation_1},
                                               typeof(MapTestOrchestration).GetField("SendPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MapTestOrchestration), "SendPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "9c81338b-1460-477c-8516-b541af2f69c7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "9c81338b-1460-477c-8516-b541af2f69c7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "bfb5ad1e-777a-4c96-b111-dbec5e936b74", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "bfb5ad1e-777a-4c96-b111-dbec5e936b74", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "073f4e77-aa26-4701-895c-55a1f45a84d6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "073f4e77-aa26-4701-895c-55a1f45a84d6", 1, false),
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
            __MapTestOrchestration_1 __ctx1__ = (__MapTestOrchestration_1)_stateMgrs[1];
            __MapTestOrchestration_root_0 __ctx0__ = (__MapTestOrchestration_root_0)_stateMgrs[0];

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
                __ctx1__ = new __MapTestOrchestration_1(this);
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
            __MapTestOrchestration_1 __ctx1__ = (__MapTestOrchestration_1)_stateMgrs[1];
            __MapTestOrchestration_root_0 __ctx0__ = (__MapTestOrchestration_root_0)_stateMgrs[0];

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
                if (__ctx1__.__msgPessoa != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgPessoa);
                __ctx1__.__msgPessoa = new __messagetype_ComoFuncinamOsMapas_Schemas_PessoaOrigem("msgPessoa", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgPessoa);
                ReceivePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgPessoa, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
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
                    __edata.Messages.Add(__ctx1__.__msgPessoa);
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
                    __messagetype_ComoFuncinamOsMapas_Schemas_PessoaDestino __msgPessoaFinal = new __messagetype_ComoFuncinamOsMapas_Schemas_PessoaDestino("msgPessoaFinal", __ctx1__);

                    ApplyTransform(typeof(ComoFuncinamOsMapas.MapasNetPonto.DemoNetPonto), new object[] {__msgPessoaFinal.part}, new object[] {__ctx1__.__msgPessoa.part});

                    if (__ctx1__.__msgPessoaFinal != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgPessoaFinal);
                    __ctx1__.__msgPessoaFinal = __msgPessoaFinal;
                    __ctx1__.RefMessage(__ctx1__.__msgPessoaFinal);
                }
                __ctx1__.__msgPessoaFinal.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgPessoaFinal);
                    __edata.Messages.Add(__ctx1__.__msgPessoa);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgPessoa != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgPessoa);
                    __ctx1__.__msgPessoa = null;
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
                SendPort.SendMessage(0, __ctx1__.__msgPessoaFinal, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
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
                    __edata.Messages.Add(__ctx1__.__msgPessoaFinal);
                    __edata.PortName = @"SendPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgPessoaFinal != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgPessoaFinal);
                    __ctx1__.__msgPessoaFinal = null;
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
    sealed public class __ComoFuncinamOsMapas_Schemas_PessoaOrigem__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ComoFuncinamOsMapas.Schemas.PessoaOrigem _schema = new ComoFuncinamOsMapas.Schemas.PessoaOrigem();

        public __ComoFuncinamOsMapas_Schemas_PessoaOrigem__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ComoFuncinamOsMapas.Schemas.PessoaOrigem",
        new System.Type[]{
            typeof(ComoFuncinamOsMapas.Schemas.PessoaOrigem)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ComoFuncinamOsMapas_Schemas_PessoaOrigem__)
        },
        0,
        @"http://ComoFuncinamOsMapas.PessoaOrigem#PessoaOrigem"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ComoFuncinamOsMapas_Schemas_PessoaOrigem : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ComoFuncinamOsMapas_Schemas_PessoaOrigem__ part;

        private void __CreatePartWrappers()
        {
            part = new __ComoFuncinamOsMapas_Schemas_PessoaOrigem__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ComoFuncinamOsMapas_Schemas_PessoaOrigem(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __ComoFuncinamOsMapas_Schemas_PessoaDestino__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ComoFuncinamOsMapas.Schemas.PessoaDestino _schema = new ComoFuncinamOsMapas.Schemas.PessoaDestino();

        public __ComoFuncinamOsMapas_Schemas_PessoaDestino__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ComoFuncinamOsMapas.Schemas.PessoaDestino",
        new System.Type[]{
            typeof(ComoFuncinamOsMapas.Schemas.PessoaDestino)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ComoFuncinamOsMapas_Schemas_PessoaDestino__)
        },
        0,
        @"http://ComoFuncinamOsMapas.PessoaDestino#PessoaDestino"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ComoFuncinamOsMapas_Schemas_PessoaDestino : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ComoFuncinamOsMapas_Schemas_PessoaDestino__ part;

        private void __CreatePartWrappers()
        {
            part = new __ComoFuncinamOsMapas_Schemas_PessoaDestino__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ComoFuncinamOsMapas_Schemas_PessoaDestino(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
