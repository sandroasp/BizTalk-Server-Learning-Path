namespace MappingWorkingWithMultipleOutputMessages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport",@"OrchestrationSupport")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "HasDiscount", XPath = @"/*[local-name()='OrchestrationSupport' and namespace-uri()='http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport']/*[local-name()='HasDiscount' and namespace-uri()='']", XsdType = @"boolean")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "DiscountType", XPath = @"/*[local-name()='OrchestrationSupport' and namespace-uri()='http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport']/*[local-name()='DiscountType' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrchestrationSupport"})]
    public sealed class OrchestrationSupport : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standard=""Flat File"" root_reference=""OrchestrationSupport"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" />
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""OrchestrationSupport"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""1"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='OrchestrationSupport' and namespace-uri()='http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport']/*[local-name()='HasDiscount' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='OrchestrationSupport' and namespace-uri()='http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport']/*[local-name()='DiscountType' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <b:groupInfo sequence_number=""0"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element name=""HasDiscount"" type=""xs:boolean"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""1"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""DiscountType"" type=""xs:int"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""2"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrchestrationSupport() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrchestrationSupport";
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
