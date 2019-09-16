namespace MappingWorkingWithMultipleOutputMessages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MappingWorkingWithMultipleOutputMessages.CRMOrder",@"CRMOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CRMOrder"})]
    public sealed class CRMOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MappingWorkingWithMultipleOutputMessages.CRMOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MappingWorkingWithMultipleOutputMessages.CRMOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CRMOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderId"" type=""xs:string"" />
        <xs:element name=""GeneralInformation"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ClientName"" type=""xs:string"" />
              <xs:element name=""ClientId"" type=""xs:string"" />
              <xs:element name=""Currency"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Totals"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Amount"" type=""xs:string"" />
              <xs:element name=""DiscountPercent"" type=""xs:string"" />
              <xs:element name=""DiscountAmount"" type=""xs:string"" />
              <xs:element name=""TransportationCosts"" type=""xs:string"" />
              <xs:element name=""TotalTax"" type=""xs:string"" />
              <xs:element name=""TotalAmount"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Addresses"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""InvoicingAddress"" type=""xs:string"" />
              <xs:element name=""ShippingAddress"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CRMOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CRMOrder";
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
