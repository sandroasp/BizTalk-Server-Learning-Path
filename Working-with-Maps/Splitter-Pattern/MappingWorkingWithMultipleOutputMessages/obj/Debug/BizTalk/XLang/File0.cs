
#pragma warning disable 162

namespace MappingWorkingWithMultipleOutputMessages
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ReceiveOrder",
        new System.Type[]{
            typeof(MappingWorkingWithMultipleOutputMessages.__messagetype_MappingWorkingWithMultipleOutputMessages_CustomerOrder)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class CustomerOrderType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public CustomerOrderType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public CustomerOrderType(CustomerOrderType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            CustomerOrderType p = new CustomerOrderType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ReceiveOrder = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ReceiveOrder",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(CustomerOrderType),
            typeof(__messagetype_MappingWorkingWithMultipleOutputMessages_CustomerOrder),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ReceiveOrder" ] = ReceiveOrder;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendSAPOrder",
        new System.Type[]{
            typeof(MappingWorkingWithMultipleOutputMessages.__messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class SendSAPOrderType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendSAPOrderType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendSAPOrderType(SendSAPOrderType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendSAPOrderType p = new SendSAPOrderType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendSAPOrder = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendSAPOrder",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendSAPOrderType),
            typeof(__messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendCRMOrder",
        new System.Type[]{
            typeof(MappingWorkingWithMultipleOutputMessages.__messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class SendCRMOrderType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendCRMOrderType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendCRMOrderType(SendCRMOrderType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendCRMOrderType p = new SendCRMOrderType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendCRMOrder = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendCRMOrder",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendCRMOrderType),
            typeof(__messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendCRMOrder" ] = SendCRMOrder;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 241 "C:\Development\05- MappingWorkingWithMultipleOutputMessages\MappingWorkingWithMultipleOutputMessages\MappingOneToMany.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "CustomerOrderPort", "ReceiveOrder", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MappingWorkingWithMultipleOutputMessages.CustomerOrderType),
            typeof(MappingWorkingWithMultipleOutputMessages.SendSAPOrderType),
            typeof(MappingWorkingWithMultipleOutputMessages.SendCRMOrderType)
        },
        new System.String[] {
            "CustomerOrderPort",
            "SendSAPOrderPort",
            "SendCRMOrderPort"
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
    sealed internal class MappingOneToMany : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(MappingOneToMany));
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

        static MappingOneToMany()
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
            _rootContext = new __MappingOneToMany_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public MappingOneToMany(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "MappingOneToMany", tracker)
        {
            ConstructorHelper();
        }

        public MappingOneToMany(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "MappingOneToMany")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>cd49f509-c651-42cf-bc23-17b0a5c5cae2</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>41c9b19c-b54d-41e0-8495-bb5f967b5172</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Customer Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a2a91609-c0b3-455b-a36b-d4332cae9f8c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SAP and Order Msg Const</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>6129ce9b-3ee1-4af8-a1ae-8b73d0eb13e8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>TransformCustomOrderToSAPAndCRMOrder</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>79bbfa6a-ef10-4889-a88c-cfe39a76a8fb</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>e07a5292-ee59-4074-99ca-ffe7ef9b95ab</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>af51f39a-c104-4367-bcca-ed3b53366ca0</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>45dfb17c-a7da-4e81-a065-b7fe8a2ccd77</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>73b4c98b-7104-4c71-90b4-cd757e11611e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f581cb38-1c31-4b76-a8d7-600c00c6ae8f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SAP Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>451b940a-5744-4b83-a08c-c5bede67e11c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send CRM Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'MappingOneToMany'</ActionName><IsAtomic>0</IsAtomic><Line>241</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>255</Line><Position>22</Position><ShapeID>'41c9b19c-b54d-41e0-8495-bb5f967b5172'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomerOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.CustomerOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>257</Line><Position>13</Position><ShapeID>'a2a91609-c0b3-455b-a36b-d4332cae9f8c'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.SAPOrder</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgCRMOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.CRMOrder</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgCustomerOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.CustomerOrder</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>263</Line><Position>13</Position><ShapeID>'f581cb38-1c31-4b76-a8d7-600c00c6ae8f'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.SAPOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>265</Line><Position>13</Position><ShapeID>'451b940a-5744-4b83-a08c-c5bede67e11c'</ShapeID>
<Messages>
	<MsgInfo><name>msgCRMOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.CRMOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='155acaee-25ae-4b5a-94a4-b3a28abf55a9' LowerBound='1.1' HigherBound='54.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MappingWorkingWithMultipleOutputMessages' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8aa2cd84-4923-44a0-b87f-f11c9b0d9cc6' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CustomerOrderType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cc3d6d8f-d571-4097-bae9-d676ad72a39d' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveOrder' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='cf030515-fe14-45c2-a7cd-290e75702059' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.26'>
                    <om:Property Name='Ref' Value='MappingWorkingWithMultipleOutputMessages.CustomerOrder' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='73485af2-ebb3-4a8b-a52f-fed47fecac3f' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendSAPOrderType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e0daf957-7ee7-4f9b-b286-551e57a4bbf0' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSAPOrder' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='dea5867f-d7b2-4502-975f-cbd708bf1b1f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.21'>
                    <om:Property Name='Ref' Value='MappingWorkingWithMultipleOutputMessages.SAPOrder' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='ad685aa5-1965-45ce-b43c-303ca31cd92f' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendCRMOrderType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2f1fab9e-b794-4db6-b4be-ece08da94a2d' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendCRMOrder' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='6112d7d1-9aab-495f-8eeb-e2be82e59083' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.21'>
                    <om:Property Name='Ref' Value='MappingWorkingWithMultipleOutputMessages.CRMOrder' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='f39d1c5e-9a67-40a1-9863-89db182b3374' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='53.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MappingOneToMany' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='cd49f509-c651-42cf-bc23-17b0a5c5cae2' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='41c9b19c-b54d-41e0-8495-bb5f967b5172' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='41.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='CustomerOrderPort' />
                    <om:Property Name='MessageName' Value='msgCustomerOrder' />
                    <om:Property Name='OperationName' Value='ReceiveOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Customer Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='a2a91609-c0b3-455b-a36b-d4332cae9f8c' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='47.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SAP and Order Msg Const' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='6129ce9b-3ee1-4af8-a1ae-8b73d0eb13e8' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='46.1'>
                        <om:Property Name='ClassName' Value='MappingWorkingWithMultipleOutputMessages.TransformOneToManyOrders' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='TransformCustomOrderToSAPAndCRMOrder' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='79bbfa6a-ef10-4889-a88c-cfe39a76a8fb' ParentLink='Transform_InputMessagePartRef' LowerBound='45.123' HigherBound='45.139'>
                            <om:Property Name='MessageRef' Value='msgCustomerOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='e07a5292-ee59-4074-99ca-ffe7ef9b95ab' ParentLink='Transform_OutputMessagePartRef' LowerBound='45.28' HigherBound='45.39'>
                            <om:Property Name='MessageRef' Value='msgCRMOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='af51f39a-c104-4367-bcca-ed3b53366ca0' ParentLink='Transform_OutputMessagePartRef' LowerBound='45.41' HigherBound='45.52'>
                            <om:Property Name='MessageRef' Value='msgSAPOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='45dfb17c-a7da-4e81-a065-b7fe8a2ccd77' ParentLink='Construct_MessageRef' LowerBound='42.23' HigherBound='42.34'>
                        <om:Property Name='Ref' Value='msgSAPOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='73b4c98b-7104-4c71-90b4-cd757e11611e' ParentLink='Construct_MessageRef' LowerBound='42.36' HigherBound='42.47'>
                        <om:Property Name='Ref' Value='msgCRMOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='f581cb38-1c31-4b76-a8d7-600c00c6ae8f' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='49.1'>
                    <om:Property Name='PortName' Value='SendSAPOrderPort' />
                    <om:Property Name='MessageName' Value='msgSAPOrder' />
                    <om:Property Name='OperationName' Value='SendSAPOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SAP Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='451b940a-5744-4b83-a08c-c5bede67e11c' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='51.1'>
                    <om:Property Name='PortName' Value='SendCRMOrderPort' />
                    <om:Property Name='MessageName' Value='msgCRMOrder' />
                    <om:Property Name='OperationName' Value='SendCRMOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send CRM Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3767581a-5ca3-46f9-b7a0-d0dc7f3f5f9c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.CustomerOrderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustomerOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c53bb1e7-03c7-49ec-8d2c-be6209d9dfe9' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='7b938161-b5fd-4a1b-8487-a762cc885161' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='16' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.SendSAPOrderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSAPOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='524bc62a-ca74-4552-b0eb-1022cc6b7260' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0d6889ab-29d5-4643-a9e0-583cbe972438' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='18' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.SendCRMOrderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendCRMOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6d9c2b7b-5746-408c-80bc-cfcba605c47a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='1c42afe7-31bc-4830-8ead-d3080262c76b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.CustomerOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCustomerOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e169c936-b363-45b8-8de1-343d86b4eefd' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.CRMOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCRMOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0c1f5f1f-5215-4241-aed5-b80abd241c5b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.SAPOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSAPOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __MappingOneToMany_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __MappingOneToMany_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MappingOneToMany")
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
                MappingOneToMany __svc__ = (MappingOneToMany)_service;
                __MappingOneToMany_root_0 __ctx0__ = (__MappingOneToMany_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.CustomerOrderPort != null)
                {
                    __svc__.CustomerOrderPort.Close(this, null);
                    __svc__.CustomerOrderPort = null;
                }
                if (__svc__.SendCRMOrderPort != null)
                {
                    __svc__.SendCRMOrderPort.Close(this, null);
                    __svc__.SendCRMOrderPort = null;
                }
                if (__svc__.SendSAPOrderPort != null)
                {
                    __svc__.SendSAPOrderPort.Close(this, null);
                    __svc__.SendSAPOrderPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __MappingOneToMany_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __MappingOneToMany_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MappingOneToMany")
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
                MappingOneToMany __svc__ = (MappingOneToMany)_service;
                __MappingOneToMany_1 __ctx1__ = (__MappingOneToMany_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                    __ctx1__.__msgCustomerOrder = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCRMOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCRMOrder);
                    __ctx1__.__msgCRMOrder = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCustomerOrder")]
            public __messagetype_MappingWorkingWithMultipleOutputMessages_CustomerOrder __msgCustomerOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCRMOrder")]
            public __messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder __msgCRMOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSAPOrder")]
            public __messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder __msgSAPOrder;
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
        internal CustomerOrderType CustomerOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendSAPOrderPort")]
        internal SendSAPOrderType SendSAPOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendCRMOrderPort")]
        internal SendCRMOrderType SendCRMOrderPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CustomerOrderType.ReceiveOrder},
                                               typeof(MappingOneToMany).GetField("CustomerOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MappingOneToMany), "CustomerOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendSAPOrderType.SendSAPOrder},
                                               typeof(MappingOneToMany).GetField("SendSAPOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MappingOneToMany), "SendSAPOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendCRMOrderType.SendCRMOrder},
                                               typeof(MappingOneToMany).GetField("SendCRMOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MappingOneToMany), "SendCRMOrderPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "41c9b19c-b54d-41e0-8495-bb5f967b5172", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "41c9b19c-b54d-41e0-8495-bb5f967b5172", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "a2a91609-c0b3-455b-a36b-d4332cae9f8c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "a2a91609-c0b3-455b-a36b-d4332cae9f8c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "f581cb38-1c31-4b76-a8d7-600c00c6ae8f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f581cb38-1c31-4b76-a8d7-600c00c6ae8f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "451b940a-5744-4b83-a08c-c5bede67e11c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "451b940a-5744-4b83-a08c-c5bede67e11c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 1, false)
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

        public static int[] __progressLocation0 = new int[] { 0,0,0,9,9,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,8,9,9,9,9,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __MappingOneToMany_1 __ctx1__ = (__MappingOneToMany_1)_stateMgrs[1];
            __MappingOneToMany_root_0 __ctx0__ = (__MappingOneToMany_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                CustomerOrderPort = new CustomerOrderType(0, this);
                SendSAPOrderPort = new SendSAPOrderType(1, this);
                SendCRMOrderPort = new SendCRMOrderType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], CustomerOrderPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __MappingOneToMany_1(this);
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
            __MappingOneToMany_1 __ctx1__ = (__MappingOneToMany_1)_stateMgrs[1];
            __MappingOneToMany_root_0 __ctx0__ = (__MappingOneToMany_root_0)_stateMgrs[0];

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
                if (!CustomerOrderPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgCustomerOrder != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                __ctx1__.__msgCustomerOrder = new __messagetype_MappingWorkingWithMultipleOutputMessages_CustomerOrder("msgCustomerOrder", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgCustomerOrder);
                CustomerOrderPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgCustomerOrder, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
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
                    __edata.Messages.Add(__ctx1__.__msgCustomerOrder);
                    __edata.PortName = @"CustomerOrderPort";
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
                    __messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder __msgSAPOrder = new __messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder("msgSAPOrder", __ctx1__);
                    __messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder __msgCRMOrder = new __messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder("msgCRMOrder", __ctx1__);

                    ApplyTransform(typeof(MappingWorkingWithMultipleOutputMessages.TransformOneToManyOrders), new object[] {__msgCRMOrder.part, __msgSAPOrder.part}, new object[] {__ctx1__.__msgCustomerOrder.part});

                    if (__ctx1__.__msgSAPOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = __msgSAPOrder;
                    __ctx1__.RefMessage(__ctx1__.__msgSAPOrder);
                    if (__ctx1__.__msgCRMOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgCRMOrder);
                    __ctx1__.__msgCRMOrder = __msgCRMOrder;
                    __ctx1__.RefMessage(__ctx1__.__msgCRMOrder);
                }
                __ctx1__.__msgSAPOrder.ConstructionCompleteEvent(true);
                __ctx1__.__msgCRMOrder.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.Messages.Add(__ctx1__.__msgCRMOrder);
                    __edata.Messages.Add(__ctx1__.__msgCustomerOrder);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                    __ctx1__.__msgCustomerOrder = null;
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
                SendSAPOrderPort.SendMessage(0, __ctx1__.__msgSAPOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (SendSAPOrderPort != null)
                {
                    SendSAPOrderPort.Close(__ctx1__, __seg__);
                    SendSAPOrderPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.PortName = @"SendSAPOrderPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
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
                SendCRMOrderPort.SendMessage(0, __ctx1__.__msgCRMOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendCRMOrderPort != null)
                {
                    SendCRMOrderPort.Close(__ctx1__, __seg__);
                    SendCRMOrderPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgCRMOrder);
                    __edata.PortName = @"SendCRMOrderPort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCRMOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCRMOrder);
                    __ctx1__.__msgCRMOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[4],_stateMgrs[1].TrackDataStream );
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
    //#line 223 "C:\Development\05- MappingWorkingWithMultipleOutputMessages\MappingWorkingWithMultipleOutputMessages\MappingManyToMany.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "CustomOrderPort", "ReceiveOrder", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(MappingWorkingWithMultipleOutputMessages.CustomerOrderType),
            typeof(MappingWorkingWithMultipleOutputMessages.SendSAPOrderType),
            typeof(MappingWorkingWithMultipleOutputMessages.SendCRMOrderType)
        },
        new System.String[] {
            "CustomOrderPort",
            "SendSAPOrderPort",
            "SendCRMOrderPort"
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
    sealed internal class MappingManyToMany : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(MappingManyToMany));
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

        static MappingManyToMany()
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
            _rootContext = new __MappingManyToMany_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public MappingManyToMany(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "MappingManyToMany", tracker)
        {
            ConstructorHelper();
        }

        public MappingManyToMany(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "MappingManyToMany")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>4145c889-2257-4264-8781-d6b3948919fa</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>29f2d9df-ef8e-40c0-9966-c9f3d508fea1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Customer Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e1866887-c556-42be-bb6f-9c1334dbd427</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Set Variables Expr</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>d3c39638-4cf2-4410-af15-efaef4789912</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Orchestration Support Msg Const</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>6c24471a-2561-489c-818d-e2f31a9561f4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>OrchestrationSupportMsgAssign</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f6715baa-cc32-4d1c-bae5-d28856aeaed4</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a068526c-82ee-47ad-a10e-1411d1ab661d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SAP and Order Msg Const</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>76931972-78c9-47a4-a950-f42155418dd5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>TransformCustomOrderToSAPAndCRMOrder</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>c9708331-7d8f-4e48-8aaa-7e38a1a8308e</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>733ea0dd-07f5-48f2-8a83-1bfe313deaaf</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>592d7764-da5b-43f5-84ca-dac66149559f</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7352433d-e87e-4b39-8e3d-3387dd188443</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>d1d35589-d4fb-4c3e-8f82-d2b97085f2a2</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c6e2fcba-9d82-416b-aa9b-69164e9bf6c5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f4dbff3b-ee4e-4b0d-8bff-88e7c493593b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send SAP Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>049852fe-19b7-4e44-bff7-521d7b73a805</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send CRM Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'MappingManyToMany'</ActionName><IsAtomic>0</IsAtomic><Line>223</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>241</Line><Position>22</Position><ShapeID>'29f2d9df-ef8e-40c0-9966-c9f3d508fea1'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomerOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.CustomerOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>245</Line><Position>28</Position><ShapeID>'e1866887-c556-42be-bb6f-9c1334dbd427'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>248</Line><Position>13</Position><ShapeID>'d3c39638-4cf2-4410-af15-efaef4789912'</ShapeID>
<Messages>
	<MsgInfo><name>msgOrchestrationSupport</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.OrchestrationSupport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>261</Line><Position>13</Position><ShapeID>'a068526c-82ee-47ad-a10e-1411d1ab661d'</ShapeID>
<Messages>
	<MsgInfo><name>msgCRMOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.CRMOrder</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.SAPOrder</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgCustomerOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.CustomerOrder</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>msgOrchestrationSupport</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.OrchestrationSupport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>267</Line><Position>13</Position><ShapeID>'f4dbff3b-ee4e-4b0d-8bff-88e7c493593b'</ShapeID>
<Messages>
	<MsgInfo><name>msgSAPOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.SAPOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>269</Line><Position>13</Position><ShapeID>'049852fe-19b7-4e44-bff7-521d7b73a805'</ShapeID>
<Messages>
	<MsgInfo><name>msgCRMOrder</name><part>part</part><schema>MappingWorkingWithMultipleOutputMessages.CRMOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='0c0c8693-6398-4691-a29d-61eb396d9add' LowerBound='1.1' HigherBound='55.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MappingWorkingWithMultipleOutputMessages' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='bb30eaa5-8c82-45a0-a162-93eef379934b' ParentLink='Module_ServiceDeclaration' LowerBound='4.1' HigherBound='54.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MappingManyToMany' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='235721c6-d826-4745-ba27-7927504ddc72' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a4954103-e10b-4e2b-9747-931c3e53fbaf' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varHasDiscount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fafaa936-e775-4a2d-be95-14c76daf65b7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varDiscountType' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='2706c6b0-d554-482e-89e9-97db1e69be26' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='13.1' HigherBound='14.1'>
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.SAPOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSAPOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7c0ef23d-f1c9-4a2e-9baf-3fbdc0b403e2' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.CustomerOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCustomerOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ce266c2e-7540-4e14-b5b2-1c8e4b20c07a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='15.1' HigherBound='16.1'>
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.CRMOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCRMOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7f5dc449-bff4-4e57-a03e-83102599ac13' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.OrchestrationSupport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOrchestrationSupport' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='4145c889-2257-4264-8781-d6b3948919fa' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='29f2d9df-ef8e-40c0-9966-c9f3d508fea1' ParentLink='ServiceBody_Statement' LowerBound='22.1' HigherBound='26.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='CustomOrderPort' />
                    <om:Property Name='MessageName' Value='msgCustomerOrder' />
                    <om:Property Name='OperationName' Value='ReceiveOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Customer Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='e1866887-c556-42be-bb6f-9c1334dbd427' ParentLink='ServiceBody_Statement' LowerBound='26.1' HigherBound='29.1'>
                    <om:Property Name='Expression' Value='varHasDiscount = true;&#xD;&#xA;varDiscountType = 10;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Set Variables Expr' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='d3c39638-4cf2-4410-af15-efaef4789912' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='42.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Orchestration Support Msg Const' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='6c24471a-2561-489c-818d-e2f31a9561f4' ParentLink='ComplexStatement_Statement' LowerBound='32.1' HigherBound='41.1'>
                        <om:Property Name='Expression' Value='varXML = new System.Xml.XmlDocument();&#xD;&#xA;varXML.LoadXml(@&quot;&lt;ns0:OrchestrationSupport xmlns:ns0=&quot;&quot;http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport&quot;&quot;&gt;&#xD;&#xA;                        &lt;HasDiscount&gt;true&lt;/HasDiscount&gt;&lt;DiscountType&gt;0&lt;/DiscountType&gt;&lt;/ns0:OrchestrationSupport&gt;&quot;);&#xD;&#xA;&#xD;&#xA;msgOrchestrationSupport = varXML;&#xD;&#xA;&#xD;&#xA;msgOrchestrationSupport.HasDiscount = varHasDiscount;&#xD;&#xA;msgOrchestrationSupport.DiscountType = varDiscountType;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='OrchestrationSupportMsgAssign' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='f6715baa-cc32-4d1c-bae5-d28856aeaed4' ParentLink='Construct_MessageRef' LowerBound='30.23' HigherBound='30.46'>
                        <om:Property Name='Ref' Value='msgOrchestrationSupport' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='a068526c-82ee-47ad-a10e-1411d1ab661d' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='48.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SAP and Order Msg Const' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='76931972-78c9-47a4-a950-f42155418dd5' ParentLink='ComplexStatement_Statement' LowerBound='45.1' HigherBound='47.1'>
                        <om:Property Name='ClassName' Value='MappingWorkingWithMultipleOutputMessages.TransformManyToManyOrders' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='TransformCustomOrderToSAPAndCRMOrder' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='c9708331-7d8f-4e48-8aaa-7e38a1a8308e' ParentLink='Transform_InputMessagePartRef' LowerBound='46.124' HigherBound='46.140'>
                            <om:Property Name='MessageRef' Value='msgCustomerOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='733ea0dd-07f5-48f2-8a83-1bfe313deaaf' ParentLink='Transform_InputMessagePartRef' LowerBound='46.142' HigherBound='46.165'>
                            <om:Property Name='MessageRef' Value='msgOrchestrationSupport' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='592d7764-da5b-43f5-84ca-dac66149559f' ParentLink='Transform_OutputMessagePartRef' LowerBound='46.28' HigherBound='46.39'>
                            <om:Property Name='MessageRef' Value='msgSAPOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='7352433d-e87e-4b39-8e3d-3387dd188443' ParentLink='Transform_OutputMessagePartRef' LowerBound='46.41' HigherBound='46.52'>
                            <om:Property Name='MessageRef' Value='msgCRMOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_4' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='d1d35589-d4fb-4c3e-8f82-d2b97085f2a2' ParentLink='Construct_MessageRef' LowerBound='43.23' HigherBound='43.34'>
                        <om:Property Name='Ref' Value='msgCRMOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='c6e2fcba-9d82-416b-aa9b-69164e9bf6c5' ParentLink='Construct_MessageRef' LowerBound='43.36' HigherBound='43.47'>
                        <om:Property Name='Ref' Value='msgSAPOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='f4dbff3b-ee4e-4b0d-8bff-88e7c493593b' ParentLink='ServiceBody_Statement' LowerBound='48.1' HigherBound='50.1'>
                    <om:Property Name='PortName' Value='SendSAPOrderPort' />
                    <om:Property Name='MessageName' Value='msgSAPOrder' />
                    <om:Property Name='OperationName' Value='SendSAPOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send SAP Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='049852fe-19b7-4e44-bff7-521d7b73a805' ParentLink='ServiceBody_Statement' LowerBound='50.1' HigherBound='52.1'>
                    <om:Property Name='PortName' Value='SendCRMOrderPort' />
                    <om:Property Name='MessageName' Value='msgCRMOrder' />
                    <om:Property Name='OperationName' Value='SendCRMOrder' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send CRM Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='bf41d9e7-ec75-4767-bcde-9e91fa45da63' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='7.1' HigherBound='9.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.CustomerOrderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustomOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='bae461b5-377b-43b5-8915-bb8b5d768014' ParentLink='PortDeclaration_CLRAttribute' LowerBound='7.1' HigherBound='8.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a8cbf731-9aa7-4113-b7d4-4b57e789b68d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='9.1' HigherBound='11.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='33' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.SendSAPOrderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendSAPOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a53c84c1-fb7f-4a72-aba3-de326bcc3c15' ParentLink='PortDeclaration_CLRAttribute' LowerBound='9.1' HigherBound='10.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0d28b1a9-fc78-4d25-a597-04c272f47b4f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='11.1' HigherBound='13.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='MappingWorkingWithMultipleOutputMessages.SendCRMOrderType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendCRMOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='47112108-1df1-426f-bcde-9fd9683be5c6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='11.1' HigherBound='12.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __MappingManyToMany_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __MappingManyToMany_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MappingManyToMany")
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
                MappingManyToMany __svc__ = (MappingManyToMany)_service;
                __MappingManyToMany_root_0 __ctx0__ = (__MappingManyToMany_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.CustomOrderPort != null)
                {
                    __svc__.CustomOrderPort.Close(this, null);
                    __svc__.CustomOrderPort = null;
                }
                if (__svc__.SendSAPOrderPort != null)
                {
                    __svc__.SendSAPOrderPort.Close(this, null);
                    __svc__.SendSAPOrderPort = null;
                }
                if (__svc__.SendCRMOrderPort != null)
                {
                    __svc__.SendCRMOrderPort.Close(this, null);
                    __svc__.SendCRMOrderPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __MappingManyToMany_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __MappingManyToMany_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MappingManyToMany")
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
                MappingManyToMany __svc__ = (MappingManyToMany)_service;
                __MappingManyToMany_1 __ctx1__ = (__MappingManyToMany_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgCustomerOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                    __ctx1__.__msgCustomerOrder = null;
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
                if (__ctx1__ != null && __ctx1__.__msgCRMOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCRMOrder);
                    __ctx1__.__msgCRMOrder = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXML = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSAPOrder")]
            public __messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder __msgSAPOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCustomerOrder")]
            public __messagetype_MappingWorkingWithMultipleOutputMessages_CustomerOrder __msgCustomerOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCRMOrder")]
            public __messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder __msgCRMOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOrchestrationSupport")]
            public __messagetype_MappingWorkingWithMultipleOutputMessages_OrchestrationSupport __msgOrchestrationSupport;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varXML")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __varXML;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varHasDiscount")]
            internal System.Boolean __varHasDiscount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varDiscountType")]
            internal System.Int32 __varDiscountType;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("CustomOrderPort")]
        internal CustomerOrderType CustomOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendSAPOrderPort")]
        internal SendSAPOrderType SendSAPOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendCRMOrderPort")]
        internal SendCRMOrderType SendCRMOrderPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CustomerOrderType.ReceiveOrder},
                                               typeof(MappingManyToMany).GetField("CustomOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MappingManyToMany), "CustomOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendSAPOrderType.SendSAPOrder},
                                               typeof(MappingManyToMany).GetField("SendSAPOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MappingManyToMany), "SendSAPOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendCRMOrderType.SendCRMOrder},
                                               typeof(MappingManyToMany).GetField("SendCRMOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(MappingManyToMany), "SendCRMOrderPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "29f2d9df-ef8e-40c0-9966-c9f3d508fea1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "29f2d9df-ef8e-40c0-9966-c9f3d508fea1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "e1866887-c556-42be-bb6f-9c1334dbd427", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "e1866887-c556-42be-bb6f-9c1334dbd427", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "d3c39638-4cf2-4410-af15-efaef4789912", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "d3c39638-4cf2-4410-af15-efaef4789912", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "a068526c-82ee-47ad-a10e-1411d1ab661d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "a068526c-82ee-47ad-a10e-1411d1ab661d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "f4dbff3b-ee4e-4b0d-8bff-88e7c493593b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "f4dbff3b-ee4e-4b0d-8bff-88e7c493593b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "049852fe-19b7-4e44-bff7-521d7b73a805", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "049852fe-19b7-4e44-bff7-521d7b73a805", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,4,4,5,5,6,6,7,8,8,9,10,10,10,11,12,12,12,13,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __MappingManyToMany_root_0 __ctx0__ = (__MappingManyToMany_root_0)_stateMgrs[0];
            __MappingManyToMany_1 __ctx1__ = (__MappingManyToMany_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                CustomOrderPort = new CustomerOrderType(0, this);
                SendSAPOrderPort = new SendSAPOrderType(1, this);
                SendCRMOrderPort = new SendCRMOrderType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], CustomOrderPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __MappingManyToMany_1(this);
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
            __MappingManyToMany_root_0 __ctx0__ = (__MappingManyToMany_root_0)_stateMgrs[0];
            __MappingManyToMany_1 __ctx1__ = (__MappingManyToMany_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varXML = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__varHasDiscount = default(System.Boolean);
                __ctx1__.__varDiscountType = default(System.Int32);
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
                if (!CustomOrderPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgCustomerOrder != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                __ctx1__.__msgCustomerOrder = new __messagetype_MappingWorkingWithMultipleOutputMessages_CustomerOrder("msgCustomerOrder", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgCustomerOrder);
                CustomOrderPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgCustomerOrder, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (CustomOrderPort != null)
                {
                    CustomOrderPort.Close(__ctx1__, __seg__);
                    CustomOrderPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgCustomerOrder);
                    __edata.PortName = @"CustomOrderPort";
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
                __ctx1__.__varHasDiscount = true;
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
                __ctx1__.__varDiscountType = 10;
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
                    __messagetype_MappingWorkingWithMultipleOutputMessages_OrchestrationSupport __msgOrchestrationSupport = new __messagetype_MappingWorkingWithMultipleOutputMessages_OrchestrationSupport("msgOrchestrationSupport", __ctx1__);

                    __ctx1__.__varXML.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__varXML.UnderlyingXmlDocument.LoadXml(@"<ns0:OrchestrationSupport xmlns:ns0=""http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport"">
                                        <HasDiscount>true</HasDiscount><DiscountType>0</DiscountType></ns0:OrchestrationSupport>");
                    __msgOrchestrationSupport.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXML.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__varXML = null;
                    __msgOrchestrationSupport.part.SetDistinguishedField("HasDiscount", __ctx1__.__varHasDiscount);
                    __msgOrchestrationSupport.part.SetDistinguishedField("DiscountType", __ctx1__.__varDiscountType);

                    if (__ctx1__.__msgOrchestrationSupport != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOrchestrationSupport);
                    __ctx1__.__msgOrchestrationSupport = __msgOrchestrationSupport;
                    __ctx1__.RefMessage(__ctx1__.__msgOrchestrationSupport);
                }
                __ctx1__.__msgOrchestrationSupport.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOrchestrationSupport);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                {
                    __messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder __msgCRMOrder = new __messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder("msgCRMOrder", __ctx1__);
                    __messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder __msgSAPOrder = new __messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder("msgSAPOrder", __ctx1__);

                    ApplyTransform(typeof(MappingWorkingWithMultipleOutputMessages.TransformManyToManyOrders), new object[] {__msgSAPOrder.part, __msgCRMOrder.part}, new object[] {__ctx1__.__msgCustomerOrder.part, __ctx1__.__msgOrchestrationSupport.part});

                    if (__ctx1__.__msgCRMOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgCRMOrder);
                    __ctx1__.__msgCRMOrder = __msgCRMOrder;
                    __ctx1__.RefMessage(__ctx1__.__msgCRMOrder);
                    if (__ctx1__.__msgSAPOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = __msgSAPOrder;
                    __ctx1__.RefMessage(__ctx1__.__msgSAPOrder);
                }
                __ctx1__.__msgCRMOrder.ConstructionCompleteEvent(true);
                __ctx1__.__msgSAPOrder.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgCRMOrder);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.Messages.Add(__ctx1__.__msgCustomerOrder);
                    __edata.Messages.Add(__ctx1__.__msgOrchestrationSupport);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOrchestrationSupport != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrchestrationSupport);
                    __ctx1__.__msgOrchestrationSupport = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                    __ctx1__.__msgCustomerOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendSAPOrderPort.SendMessage(0, __ctx1__.__msgSAPOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (SendSAPOrderPort != null)
                {
                    SendSAPOrderPort.Close(__ctx1__, __seg__);
                    SendSAPOrderPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSAPOrder);
                    __edata.PortName = @"SendSAPOrderPort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSAPOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSAPOrder);
                    __ctx1__.__msgSAPOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendCRMOrderPort.SendMessage(0, __ctx1__.__msgCRMOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendCRMOrderPort != null)
                {
                    SendCRMOrderPort.Close(__ctx1__, __seg__);
                    SendCRMOrderPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgCRMOrder);
                    __edata.PortName = @"SendCRMOrderPort";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCRMOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCRMOrder);
                    __ctx1__.__msgCRMOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 28;
            case 28:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __MappingWorkingWithMultipleOutputMessages_CustomerOrder__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MappingWorkingWithMultipleOutputMessages.CustomerOrder _schema = new MappingWorkingWithMultipleOutputMessages.CustomerOrder();

        public __MappingWorkingWithMultipleOutputMessages_CustomerOrder__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MappingWorkingWithMultipleOutputMessages.CustomerOrder",
        new System.Type[]{
            typeof(MappingWorkingWithMultipleOutputMessages.CustomerOrder)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MappingWorkingWithMultipleOutputMessages_CustomerOrder__)
        },
        0,
        @"http://MappingWorkingWithMultipleOutputMessages.CustomerOrder#CustomerOrder"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MappingWorkingWithMultipleOutputMessages_CustomerOrder : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MappingWorkingWithMultipleOutputMessages_CustomerOrder__ part;

        private void __CreatePartWrappers()
        {
            part = new __MappingWorkingWithMultipleOutputMessages_CustomerOrder__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MappingWorkingWithMultipleOutputMessages_CustomerOrder(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MappingWorkingWithMultipleOutputMessages_SAPOrder__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MappingWorkingWithMultipleOutputMessages.SAPOrder _schema = new MappingWorkingWithMultipleOutputMessages.SAPOrder();

        public __MappingWorkingWithMultipleOutputMessages_SAPOrder__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MappingWorkingWithMultipleOutputMessages.SAPOrder",
        new System.Type[]{
            typeof(MappingWorkingWithMultipleOutputMessages.SAPOrder)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MappingWorkingWithMultipleOutputMessages_SAPOrder__)
        },
        0,
        @"http://MappingWorkingWithMultipleOutputMessages.SAPOrder#SAPOrder"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MappingWorkingWithMultipleOutputMessages_SAPOrder__ part;

        private void __CreatePartWrappers()
        {
            part = new __MappingWorkingWithMultipleOutputMessages_SAPOrder__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MappingWorkingWithMultipleOutputMessages_SAPOrder(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MappingWorkingWithMultipleOutputMessages_CRMOrder__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MappingWorkingWithMultipleOutputMessages.CRMOrder _schema = new MappingWorkingWithMultipleOutputMessages.CRMOrder();

        public __MappingWorkingWithMultipleOutputMessages_CRMOrder__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MappingWorkingWithMultipleOutputMessages.CRMOrder",
        new System.Type[]{
            typeof(MappingWorkingWithMultipleOutputMessages.CRMOrder)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MappingWorkingWithMultipleOutputMessages_CRMOrder__)
        },
        0,
        @"http://MappingWorkingWithMultipleOutputMessages.CRMOrder#CRMOrder"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MappingWorkingWithMultipleOutputMessages_CRMOrder__ part;

        private void __CreatePartWrappers()
        {
            part = new __MappingWorkingWithMultipleOutputMessages_CRMOrder__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MappingWorkingWithMultipleOutputMessages_CRMOrder(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MappingWorkingWithMultipleOutputMessages_OrchestrationSupport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MappingWorkingWithMultipleOutputMessages.OrchestrationSupport _schema = new MappingWorkingWithMultipleOutputMessages.OrchestrationSupport();

        public __MappingWorkingWithMultipleOutputMessages_OrchestrationSupport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "MappingWorkingWithMultipleOutputMessages.OrchestrationSupport",
        new System.Type[]{
            typeof(MappingWorkingWithMultipleOutputMessages.OrchestrationSupport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__MappingWorkingWithMultipleOutputMessages_OrchestrationSupport__)
        },
        0,
        @"http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport#OrchestrationSupport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_MappingWorkingWithMultipleOutputMessages_OrchestrationSupport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MappingWorkingWithMultipleOutputMessages_OrchestrationSupport__ part;

        private void __CreatePartWrappers()
        {
            part = new __MappingWorkingWithMultipleOutputMessages_OrchestrationSupport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_MappingWorkingWithMultipleOutputMessages_OrchestrationSupport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
