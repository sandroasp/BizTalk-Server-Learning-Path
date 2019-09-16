namespace HowToSendOrchestrationVariablesIntoMaps {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport",@"Support")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "HasDiscount", XPath = @"/*[local-name()='Support' and namespace-uri()='http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport']/*[local-name()='HasDiscount' and namespace-uri()='']", XsdType = @"boolean")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DiscountType", XPath = @"/*[local-name()='Support' and namespace-uri()='http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport']/*[local-name()='DiscountType' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Support"})]
    public sealed class OrchestrationSupport : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Support"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Support' and namespace-uri()='http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport']/*[local-name()='HasDiscount' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Support' and namespace-uri()='http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport']/*[local-name()='DiscountType' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""HasDiscount"" type=""xs:boolean"" />
        <xs:element name=""DiscountType"" type=""xs:string"" />
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
                _RootElements[0] = "Support";
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
