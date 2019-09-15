namespace BizTalkMapperContentFilterPattern.Example2 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkMapperContentFilterPattern.ApplicationForms",@"ApplicationForms")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ApplicationForms"})]
    public sealed class ApplicationForms : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkMapperContentFilterPattern.ApplicationForms"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalkMapperContentFilterPattern.ApplicationForms"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ApplicationForms"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Form"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FullName"" type=""xs:string"" />
              <xs:element name=""RequestDate"" type=""xs:date"" />
              <xs:element name=""Nationality"" type=""xs:string"" />
              <xs:element name=""Address"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""AddressLine1"" type=""xs:string"" />
                    <xs:element name=""AddressLine2"" type=""xs:string"" />
                    <xs:element name=""PostalCode"" type=""xs:string"" />
                    <xs:element name=""Location"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contacts"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Email"" type=""xs:string"" />
                    <xs:element name=""Phone"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""QualificationsAndSkills"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""AcademicLevel"" type=""xs:string"" />
                    <xs:element name=""TechnicalKnowledge"" type=""xs:string"" />
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
        
        public ApplicationForms() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ApplicationForms";
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
