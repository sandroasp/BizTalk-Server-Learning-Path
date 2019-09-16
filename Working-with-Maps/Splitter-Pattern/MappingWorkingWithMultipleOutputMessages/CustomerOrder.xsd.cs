namespace MappingWorkingWithMultipleOutputMessages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MappingWorkingWithMultipleOutputMessages.CustomerOrder",@"CustomerOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerOrder"})]
    public sealed class CustomerOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MappingWorkingWithMultipleOutputMessages.CustomerOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MappingWorkingWithMultipleOutputMessages.CustomerOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""OrderHeader"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderDate"" type=""xs:string"" />
              <xs:element name=""EstimatedDeliveryDate"" type=""xs:string"" />
              <xs:element name=""OrderNumber"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""CustomerDetails"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element name=""Id"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""OrderDetails"">
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
        
        public CustomerOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerOrder";
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
