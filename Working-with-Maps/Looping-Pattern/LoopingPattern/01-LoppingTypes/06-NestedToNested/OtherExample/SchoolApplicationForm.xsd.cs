namespace LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LoopingPattern.SchoolApplicationForm",@"ApplicationForm")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ApplicationForm"})]
    public sealed class SchoolApplicationForm : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LoopingPattern.SchoolApplicationForm"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://LoopingPattern.SchoolApplicationForm"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ApplicationForm"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Form"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""LineId"" type=""xs:string"" />
              <xs:element name=""TotalOfChildren"" type=""xs:string"" />
              <xs:element name=""Parents"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""1"" maxOccurs=""2"" name=""Parent"">
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
              <xs:element name=""Children"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element maxOccurs=""unbounded"" name=""Child"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Name"" type=""xs:string"" />
                          <xs:element name=""Age"" type=""xs:string"" />
                          <xs:element name=""Sex"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
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
        
        public SchoolApplicationForm() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ApplicationForm";
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
