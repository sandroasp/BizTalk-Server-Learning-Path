namespace SandroPereira.NameValueToHierarchical {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SandroPereira.NameValueToHierarchical.Request",@"Request")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request"})]
    public sealed class NameValueSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SandroPereira.NameValueToHierarchical.Request"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://SandroPereira.NameValueToHierarchical.Request"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Header"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Nprocesso"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Body"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ServiceName"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Type"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Protocol"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Pool"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""VPNName"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IPAddress"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IPNetmask"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LAN"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IPRoute"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Profile"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""VirtualRouter"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IdleTimeout"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SessionTimeout"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TunnelType"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public NameValueSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Request";
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
