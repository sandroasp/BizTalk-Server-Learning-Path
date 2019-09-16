namespace SandroPereira.NameValueToHierarchical {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SandroPereira.NameValueToHierarchical.Provisioning",@"Provisioning")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Provisioning"})]
    public sealed class Provisioning : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SandroPereira.NameValueToHierarchical.Provisioning"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://SandroPereira.NameValueToHierarchical.Provisioning"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Provisioning"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Id"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Properties"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Property"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Name"" type=""xs:string"" />
                    <xs:element name=""Value"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""ServiceName"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Provisioning() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Provisioning";
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
