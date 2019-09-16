namespace BizTalkMapperSemanticTranslatorPattern.MassCopy {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkMapperSemanticTranslatorPattern.CanonicalPurchaseOrder",@"CanonicalPurchaseOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CanonicalPurchaseOrder"})]
    public sealed class CanonicalPurchaseOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkMapperSemanticTranslatorPattern.CanonicalPurchaseOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalkMapperSemanticTranslatorPattern.CanonicalPurchaseOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CanonicalPurchaseOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:any />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CanonicalPurchaseOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CanonicalPurchaseOrder";
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
