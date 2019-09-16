namespace BizTalkMapperIFinLoppingRecord {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SQLPollingLearnings.SCMReq",@"Req")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Req"})]
    public sealed class output : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://SQLPollingLearnings.SCMReq"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SQLPollingLearnings.SCMReq"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Req"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Quantity"" type=""xs:string"" />
        <xs:element name=""NRJQuantity"" type=""xs:string"" />
        <xs:element name=""AvgCal"" type=""xs:string"" />
        <xs:element name=""AvgDens"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public output() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Req";
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
