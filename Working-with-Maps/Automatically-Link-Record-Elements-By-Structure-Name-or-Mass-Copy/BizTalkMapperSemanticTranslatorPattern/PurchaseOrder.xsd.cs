namespace BizTalkMapperSemanticTranslatorPattern.MassCopy {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkMapperSemanticTranslatorPattern.PurchaseOrder",@"PurchaseOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PurchaseOrder"})]
    public sealed class PurchaseOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkMapperSemanticTranslatorPattern.PurchaseOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalkMapperSemanticTranslatorPattern.PurchaseOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PurchaseOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""From"" type=""xs:string"" />
        <xs:element name=""To"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineItems"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Item"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Product"" type=""xs:string"" />
                    <xs:element name=""Description"" type=""xs:string"" />
                    <xs:element name=""Price"" type=""xs:double"" />
                    <xs:element name=""Quantity"" type=""xs:int"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PurchaseOrder() {
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
