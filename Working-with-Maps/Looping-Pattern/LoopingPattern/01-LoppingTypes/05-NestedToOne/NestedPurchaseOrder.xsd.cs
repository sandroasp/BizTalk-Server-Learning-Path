namespace LoopingPattern._01_LoppingTypes._05_NestedToOne {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LoopingPattern.NestedPurchaseOrder",@"PurchaseOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PurchaseOrder"})]
    public sealed class NestedPurchaseOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LoopingPattern.NestedPurchaseOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://LoopingPattern.NestedPurchaseOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PurchaseOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""NAD"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PartyIdentifier"" type=""xs:string"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element maxOccurs=""unbounded"" name=""Address"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Type"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Contact"" type=""xs:string"" />
                    <xs:element name=""Country"" type=""xs:string"" />
                    <xs:element name=""Street"" type=""xs:string"" />
                    <xs:element name=""City"" type=""xs:string"" />
                    <xs:element name=""Zip"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Items"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""Item"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""PartNum"" type=""xs:string"" />
                    <xs:element name=""ProductName"" type=""xs:string"" />
                    <xs:element name=""Quantity"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""OrderDate"" type=""xs:string"" />
      <xs:attribute name=""ClientOrderId"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public NestedPurchaseOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PurchaseOrder";
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
