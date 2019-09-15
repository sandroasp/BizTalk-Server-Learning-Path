namespace WorkingWithConditions._01_CheckDataExistence {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://WorkingWithConditions.CheckDataExistenceSource",@"CheckExistenceSource")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CheckExistenceSource"})]
    public sealed class CheckDataExistenceSource : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://WorkingWithConditions.CheckDataExistenceSource"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://WorkingWithConditions.CheckDataExistenceSource"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CheckExistenceSource"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OptionalElementExistence"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OptionalElement"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OptionalElement2"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OptionalElement3"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""MandatoryElementExistence"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""StringExist"" nillable=""true"" type=""xs:string"" />
              <xs:element name=""IntExist"" nillable=""true"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DateExist"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""MoreAdvanceValidation"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""DateExist"" nillable=""true"" type=""xs:dateTime"" />
              <xs:element minOccurs=""0"" name=""OptionalElement"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""OptionalElement2"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RepetingElements"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OptionElement"" type=""xs:string"" />
              <xs:element name=""MandatoryElement"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CheckDataExistenceSource() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CheckExistenceSource";
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
