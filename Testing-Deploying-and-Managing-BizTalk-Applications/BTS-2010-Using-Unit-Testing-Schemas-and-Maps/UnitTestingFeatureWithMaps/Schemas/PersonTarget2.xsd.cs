namespace UnitTestingFeatureWithMaps.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://HowMapsWorks.PersonTarget2",@"PersonTarget2")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PersonTarget2"})]
    public sealed class PersonTarget2 : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://HowMapsWorks.PersonTarget2"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://HowMapsWorks.PersonTarget2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PersonTarget2"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Address"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ZipCode"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CivilStatus"" type=""xs:string"" />
        <xs:element name=""FullName"" type=""xs:string"" />
        <xs:element name=""Age"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PhoneBilling"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""TotalInternational"" type=""xs:double"" />
              <xs:element name=""TotalNational"" type=""xs:double"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PersonTarget2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PersonTarget2";
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
