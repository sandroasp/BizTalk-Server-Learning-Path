namespace WorkingWithConditions._01_CheckDataExistence {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://WorkingWithConditions.CheckDataExistenceDestination",@"CheckDataExistenceDestination")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CheckDataExistenceDestination"})]
    public sealed class CheckDataExistenceDestination : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://WorkingWithConditions.CheckDataExistenceDestination"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://WorkingWithConditions.CheckDataExistenceDestination"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CheckDataExistenceDestination"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""OnlyIfElementExistence"" nillable=""true"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ElementExistOutput"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ElementExistOutput2"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ElementExistOutput3"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""OnlyIfDataExistence"" nillable=""true"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""DataExistOutput"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""IntExistOutput"" type=""xs:int"" />
              <xs:element minOccurs=""0"" name=""DateExistOutput"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""MandatoryElements"" nillable=""true"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""MandatoryButCanBeNill"" nillable=""true"" type=""xs:string"" />
              <xs:element name=""MandatoryElementOutput"" type=""xs:string"" />
              <xs:element name=""MandatoryElementOutput2"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" name=""ExistenceInRepetingRecords"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OptionalElement"" type=""xs:string"" />
              <xs:element name=""MandatoryElement"" nillable=""true"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CheckDataExistenceDestination() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CheckDataExistenceDestination";
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
