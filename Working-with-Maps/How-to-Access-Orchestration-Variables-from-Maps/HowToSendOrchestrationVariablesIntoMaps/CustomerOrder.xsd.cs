namespace HowToSendOrchestrationVariablesIntoMaps {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://HowToSendOrchestrationVariablesIntoMaps.Order",@"Order")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    public sealed class Order : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://HowToSendOrchestrationVariablesIntoMaps.Order"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://HowToSendOrchestrationVariablesIntoMaps.Order"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Order"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Orderheader"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderDate"" type=""xs:string"" />
              <xs:element name=""EstimatedDeliveryDate"" type=""xs:string"" />
              <xs:element name=""OrderNumber"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""CustomerDetails"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element name=""Id"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""OrderDetails"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ItemDescription"" type=""xs:string"" />
              <xs:element name=""ItemCustomerCode"" type=""xs:string"" />
              <xs:element name=""TotalAmount"" type=""xs:int"" />
              <xs:element name=""UnitType"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Order() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
