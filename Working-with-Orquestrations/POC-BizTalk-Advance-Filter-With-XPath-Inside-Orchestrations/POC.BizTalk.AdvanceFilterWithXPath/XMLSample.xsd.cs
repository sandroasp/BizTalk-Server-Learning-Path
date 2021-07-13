namespace POC.BizTalk.AdvanceFilterWithXSLT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://POC.BizTalk.AdvanceFilterWithXSLT.XMLSample",@"XMLSample")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"XMLSample"})]
    public sealed class XMLSample : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://POC.BizTalk.AdvanceFilterWithXSLT.XMLSample"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://POC.BizTalk.AdvanceFilterWithXSLT.XMLSample"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""XMLSample"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Id"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Object"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Type"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public XMLSample() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "XMLSample";
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
