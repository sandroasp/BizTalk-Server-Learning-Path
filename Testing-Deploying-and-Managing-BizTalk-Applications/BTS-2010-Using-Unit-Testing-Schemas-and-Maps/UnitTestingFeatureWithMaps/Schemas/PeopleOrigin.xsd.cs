namespace UnitTestingFeatureWithMaps.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://HowMapsWorks.PeopleOrigin",@"PeopleOrigin")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PeopleOrigin"})]
    public sealed class PeopleOrigin : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://HowMapsWorks.PeopleOrigin"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://HowMapsWorks.PeopleOrigin"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PeopleOrigin"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Client"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Age"" type=""xs:int"" />
              <xs:element name=""Sex"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:enumeration value=""M"" />
                    <xs:enumeration value=""F"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Employee"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Age"" type=""xs:int"" />
              <xs:element name=""Sex"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:enumeration value=""M"" />
                    <xs:enumeration value=""F"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PeopleOrigin() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PeopleOrigin";
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
