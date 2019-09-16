
#pragma warning disable 162

namespace CallExternalOrchestrationCommonSolution
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendOutput",
        new System.Type[]{
            typeof(CallExternalOrchestrationCommonSolution.__messagetype_CallExternalOrchestrationCommonSolution_OutputSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class SendType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendType(SendType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendType p = new SendType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendOutput = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendOutput",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendType),
            typeof(__messagetype_CallExternalOrchestrationCommonSolution_OutputSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendOutput" ] = SendOutput;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 139 "C:\Development\AzureSDKOctober\CallExternalOrchestrationCommonSolution\CallExternalOrchestrationCommonSolution\OrchestrationToBeCalled.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(CallExternalOrchestrationCommonSolution.SendType)
        },
        new System.String[] {
            "SendPort"
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
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class OrchestrationToBeCalled : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String varInputParm1,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String varInputParm2)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(OrchestrationToBeCalled));
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

        static OrchestrationToBeCalled()
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
            _rootContext = new __OrchestrationToBeCalled_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public OrchestrationToBeCalled(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "OrchestrationToBeCalled", tracker)
        {
            ConstructorHelper();
        }

        public OrchestrationToBeCalled(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "OrchestrationToBeCalled")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>ebe6bb9a-2912-442c-a7be-15f82e878cef</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>93430cd6-baa6-4b5f-9e9b-bbe73146bfa3</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>varInputParm1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>98889517-3bad-410f-9a03-513616a7de3e</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>varInputParm2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>faf78ecf-ec8d-421d-af63-9a846cd45ede</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>DoSomething Expr</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c2dfdb99-5db6-43b7-957a-d9cad16d9121</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Output Message</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>479ea07f-3758-4321-a7d0-2dabbc7cf42d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Output MsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2a179730-6743-467e-a5c5-13d3da2163c8</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c36b9ad4-9ea8-4b94-a593-004c95bbdf72</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SendOutput</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'OrchestrationToBeCalled'</ActionName><IsAtomic>0</IsAtomic><Line>139</Line><Position>12</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>151</Line><Position>21</Position><ShapeID>'faf78ecf-ec8d-421d-af63-9a846cd45ede'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>153</Line><Position>13</Position><ShapeID>'c2dfdb99-5db6-43b7-957a-d9cad16d9121'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput</name><part>part</part><schema>CallExternalOrchestrationCommonSolution.OutputSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>162</Line><Position>13</Position><ShapeID>'c36b9ad4-9ea8-4b94-a593-004c95bbdf72'</ShapeID>
<Messages>
	<MsgInfo><name>msgOutput</name><part>part</part><schema>CallExternalOrchestrationCommonSolution.OutputSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='bcb061f3-d815-44c5-acfd-d709698ca721' LowerBound='1.1' HigherBound='39.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='CallExternalOrchestrationCommonSolution' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='01469578-bddc-46a4-b0a5-2c92d059fa57' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7178d803-7da0-4672-ac0b-40f6dabb849f' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendOutput' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='0303e4ca-1d16-478e-b7e3-4b81207f69ab' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.25'>
                    <om:Property Name='Ref' Value='CallExternalOrchestrationCommonSolution.OutputSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='e90b03f8-fe3d-45da-b83a-c2fc4008be60' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='38.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrchestrationToBeCalled' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='a9636b73-f22c-4e9d-8344-9a939a4084e3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varNote' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='30f386ca-d35c-458f-b48d-98e8a0f7afe9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='32a6900d-e175-40ad-8780-f3b24bea42f0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='CallExternalOrchestrationCommonSolution.OutputSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOutput' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='ebe6bb9a-2912-442c-a7be-15f82e878cef' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='93430cd6-baa6-4b5f-9e9b-bbe73146bfa3' ParentLink='ServiceBody_Declaration' LowerBound='19.15' HigherBound='19.42'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='varInputParm1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='98889517-3bad-410f-9a03-513616a7de3e' ParentLink='ServiceBody_Declaration' LowerBound='19.44' HigherBound='19.71'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='varInputParm2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='faf78ecf-ec8d-421d-af63-9a846cd45ede' ParentLink='ServiceBody_Statement' LowerBound='23.1' HigherBound='25.1'>
                    <om:Property Name='Expression' Value='varNote = &quot;do something&quot;;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='DoSomething Expr' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='c2dfdb99-5db6-43b7-957a-d9cad16d9121' ParentLink='ServiceBody_Statement' LowerBound='25.1' HigherBound='34.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Output Message' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='479ea07f-3758-4321-a7d0-2dabbc7cf42d' ParentLink='ComplexStatement_Statement' LowerBound='28.1' HigherBound='33.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:OutputSchema xmlns:ns0=&quot;&quot;http://CallExternalOrchestrationCommonSolution.OutputSchema&quot;&quot;&gt;&lt;Param1&gt;&quot; + varInputParm1 + &quot;&lt;/Param1&gt;&lt;Param2&gt;&quot; + varInputParm2 + &quot;&lt;/Param2&gt;&lt;Note&gt;&quot; + varNote + &quot;&lt;/Note&gt;&lt;ProcessDate&gt;&quot; + System.DateTime.Now.ToString() + &quot;&lt;/ProcessDate&gt;&lt;/ns0:OutputSchema&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgOutput = varXML;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Output MsgAssign' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='2a179730-6743-467e-a5c5-13d3da2163c8' ParentLink='Construct_MessageRef' LowerBound='26.23' HigherBound='26.32'>
                        <om:Property Name='Ref' Value='msgOutput' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='c36b9ad4-9ea8-4b94-a593-004c95bbdf72' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='36.1'>
                    <om:Property Name='PortName' Value='SendPort' />
                    <om:Property Name='MessageName' Value='msgOutput' />
                    <om:Property Name='OperationName' Value='SendOutput' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SendOutput' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='6db3cfe5-6a5b-468c-8fd4-61514fea1386' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='16' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='CallExternalOrchestrationCommonSolution.SendType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='f41bd115-f6f5-4d42-bd09-652f3784af94' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __OrchestrationToBeCalled_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __OrchestrationToBeCalled_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchestrationToBeCalled")
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
                OrchestrationToBeCalled __svc__ = (OrchestrationToBeCalled)_service;
                __OrchestrationToBeCalled_root_0 __ctx0__ = (__OrchestrationToBeCalled_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendPort != null)
                {
                    __svc__.SendPort.Close(this, null);
                    __svc__.SendPort = null;
                }
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __OrchestrationToBeCalled_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __OrchestrationToBeCalled_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchestrationToBeCalled")
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
                OrchestrationToBeCalled __svc__ = (OrchestrationToBeCalled)_service;
                __OrchestrationToBeCalled_1 __ctx1__ = (__OrchestrationToBeCalled_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgOutput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput);
                    __ctx1__.__msgOutput = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varNote = null;
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                if (__ctx1__ != null)
                    __ctx1__.__varInputParm1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__varInputParm2 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOutput")]
            public __messagetype_CallExternalOrchestrationCommonSolution_OutputSchema __msgOutput;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varNote")]
            internal System.String __varNote;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varXML")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __varXML;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varInputParm1")]
            internal System.String __varInputParm1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varInputParm2")]
            internal System.String __varInputParm2;
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
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendPort")]
        internal SendType SendPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendType.SendOutput},
                                               typeof(OrchestrationToBeCalled).GetField("SendPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchestrationToBeCalled), "SendPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "faf78ecf-ec8d-421d-af63-9a846cd45ede", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "faf78ecf-ec8d-421d-af63-9a846cd45ede", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "c2dfdb99-5db6-43b7-957a-d9cad16d9121", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "c2dfdb99-5db6-43b7-957a-d9cad16d9121", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "c36b9ad4-9ea8-4b94-a593-004c95bbdf72", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "c36b9ad4-9ea8-4b94-a593-004c95bbdf72", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,2,2,3,4,4,5,6,6,6,7,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __OrchestrationToBeCalled_1 __ctx1__ = (__OrchestrationToBeCalled_1)_stateMgrs[1];
            __OrchestrationToBeCalled_root_0 __ctx0__ = (__OrchestrationToBeCalled_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                SendPort = new SendType(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __OrchestrationToBeCalled_1(this);
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
            __OrchestrationToBeCalled_1 __ctx1__ = (__OrchestrationToBeCalled_1)_stateMgrs[1];
            __OrchestrationToBeCalled_root_0 __ctx0__ = (__OrchestrationToBeCalled_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varInputParm1 = (System.String)Args[0];
                __ctx1__.__varInputParm2 = (System.String)Args[1];
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__varNote = default(System.String);
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
                __ctx1__.__varNote = "";
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx1__.__varNote = "do something";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    __messagetype_CallExternalOrchestrationCommonSolution_OutputSchema __msgOutput = new __messagetype_CallExternalOrchestrationCommonSolution_OutputSchema("msgOutput", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:OutputSchema xmlns:ns0=""http://CallExternalOrchestrationCommonSolution.OutputSchema""><Param1>" + __ctx1__.__varInputParm1 + "</Param1><Param2>" + __ctx1__.__varInputParm2 + "</Param2><Note>" + __ctx1__.__varNote + "</Note><ProcessDate>" + System.DateTime.Now.ToString() + "</ProcessDate></ns0:OutputSchema>");
                    if (__ctx1__ != null)
                        __ctx1__.__varInputParm2 = null;
                    if (__ctx1__ != null)
                        __ctx1__.__varInputParm1 = null;
                    if (__ctx1__ != null)
                        __ctx1__.__varNote = null;
                    __msgOutput.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;

                    if (__ctx1__.__msgOutput != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOutput);
                    __ctx1__.__msgOutput = __msgOutput;
                    __ctx1__.RefMessage(__ctx1__.__msgOutput);
                }
                __ctx1__.__msgOutput.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOutput);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendPort.SendMessage(0, __ctx1__.__msgOutput, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendPort != null)
                {
                    SendPort.Close(__ctx1__, __seg__);
                    SendPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgOutput);
                    __edata.PortName = @"SendPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOutput != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOutput);
                    __ctx1__.__msgOutput = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 18;
            case 18:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __CallExternalOrchestrationCommonSolution_OutputSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static CallExternalOrchestrationCommonSolution.OutputSchema _schema = new CallExternalOrchestrationCommonSolution.OutputSchema();

        public __CallExternalOrchestrationCommonSolution_OutputSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "CallExternalOrchestrationCommonSolution.OutputSchema",
        new System.Type[]{
            typeof(CallExternalOrchestrationCommonSolution.OutputSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__CallExternalOrchestrationCommonSolution_OutputSchema__)
        },
        0,
        @"http://CallExternalOrchestrationCommonSolution.OutputSchema#OutputSchema"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_CallExternalOrchestrationCommonSolution_OutputSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __CallExternalOrchestrationCommonSolution_OutputSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __CallExternalOrchestrationCommonSolution_OutputSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_CallExternalOrchestrationCommonSolution_OutputSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
