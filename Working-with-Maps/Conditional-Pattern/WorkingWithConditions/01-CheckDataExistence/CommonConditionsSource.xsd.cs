namespace WorkingWithConditions._01_CommonConditions {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://WorkingWithConditions.CommonConditionsSource",@"CommonConditionsSource")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CommonConditionsSource"})]
    public sealed class CommonConditionsSource : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://WorkingWithConditions.CommonConditionsSource"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://WorkingWithConditions.CommonConditionsSource"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CommonConditionsSource"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CheckElementExistence"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ElementExist"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ElementExist2"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ElementExist3"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""CheckDataExistence"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""DataExist"" nillable=""true"" type=""xs:string"" />
              <xs:element name=""IntExist"" nillable=""true"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DateExist"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CommonConditionsSource() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CommonConditionsSource";
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
