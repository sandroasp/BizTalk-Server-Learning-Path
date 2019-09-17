namespace JoinMultipleMessages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk_Server_GenerationFichiersReleve.Test3",@"Informations")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Informations"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"JoinMultipleMessages.OutputMessage1", typeof(global::JoinMultipleMessages.OutputMessage1))]
    public sealed class OutputMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://BizTalk_Server_GenerationFichiersReleve.Test3"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk_Server_GenerationFichiersReleve.Test3"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""JoinMultipleMessages.OutputMessage1"" />
  <xs:element name=""Informations"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Users"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OutputMessage() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Informations";
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
