namespace CBRwithLOBOperations {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CBRwithLOBOperations.Response",@"Response")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Response"})]
    public sealed class Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CBRwithLOBOperations.Response"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CBRwithLOBOperations.Response"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Response"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Status"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Status"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Person"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""CitizenCard"" type=""xs:string"" />
              <xs:element name=""FullName"" type=""xs:string"" />
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ZipCode"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PhoneNumber"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Email"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Response() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Response";
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
