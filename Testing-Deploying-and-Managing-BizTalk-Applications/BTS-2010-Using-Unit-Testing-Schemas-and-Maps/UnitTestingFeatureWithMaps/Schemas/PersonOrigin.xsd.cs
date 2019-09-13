namespace UnitTestingFeatureWithMaps.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://HowMapsWorks.PersonOrigin",@"PersonOrigin")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PersonOrigin"})]
    public sealed class PersonOrigin : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://HowMapsWorks.PersonOrigin"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://HowMapsWorks.PersonOrigin"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PersonOrigin"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""DateOfBirth"" type=""xs:date"" />
        <xs:element name=""Address"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ZipCode"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PhoneCalls"">
          <xs:complexType>
            <xs:attribute name=""PhoneNumber"" type=""xs:string"" />
            <xs:attribute name=""Cost"" type=""xs:double"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PersonOrigin() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PersonOrigin";
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
