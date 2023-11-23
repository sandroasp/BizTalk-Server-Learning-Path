namespace CBRwithLOBOperations {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://EAISQLDemo.Person",@"AddPersons")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddPersons"})]
    public sealed class Person : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://EAISQLDemo.Person"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://EAISQLDemo.Person"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AddPersons"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Person"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FirstName"" type=""xs:string"" />
              <xs:element name=""LastName"" type=""xs:string"" />
              <xs:element name=""CitizenCard"" type=""xs:integer"" />
              <xs:element minOccurs=""0"" name=""AddressLine1"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""AddressLine2"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZipCode"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Phone"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""CountryCode"" type=""xs:string"" />
                    <xs:element name=""Prefix"" type=""xs:string"" />
                    <xs:element name=""Number"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""Email"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Person() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AddPersons";
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
