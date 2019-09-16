namespace CallExternalOrchestrationMainSolution {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CallExternalOrchestrationMainSolution.InputSchema",@"InputSchema")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Param1", XPath = @"/*[local-name()='InputSchema' and namespace-uri()='http://CallExternalOrchestrationMainSolution.InputSchema']/*[local-name()='Param1' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Param2", XPath = @"/*[local-name()='InputSchema' and namespace-uri()='http://CallExternalOrchestrationMainSolution.InputSchema']/*[local-name()='Param2' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InputSchema"})]
    public sealed class InputSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CallExternalOrchestrationMainSolution.InputSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CallExternalOrchestrationMainSolution.InputSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""InputSchema"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='InputSchema' and namespace-uri()='http://CallExternalOrchestrationMainSolution.InputSchema']/*[local-name()='Param1' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='InputSchema' and namespace-uri()='http://CallExternalOrchestrationMainSolution.InputSchema']/*[local-name()='Param2' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Param1"" type=""xs:string"" />
        <xs:element name=""Param2"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InputSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "InputSchema";
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
