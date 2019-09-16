namespace CallExternalOrchestrationCommonSolution {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CallExternalOrchestrationCommonSolution.OutputSchema",@"OutputSchema")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OutputSchema"})]
    public sealed class OutputSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CallExternalOrchestrationCommonSolution.OutputSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CallExternalOrchestrationCommonSolution.OutputSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""OutputSchema"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Param1"" type=""xs:string"" />
        <xs:element name=""Param2"" type=""xs:string"" />
        <xs:element name=""Note"" type=""xs:string"" />
        <xs:element name=""ProcessDate"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OutputSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OutputSchema";
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
