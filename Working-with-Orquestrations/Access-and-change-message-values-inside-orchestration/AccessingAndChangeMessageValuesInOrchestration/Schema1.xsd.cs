namespace AccessingAndChangeMessageValuesInOrchestration {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://AccessingAndChangeMessageValuesInOrchestration.Schema1",@"Person")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::AccessingAndChangeMessageValuesInOrchestration.PropertySchema.FirstName), XPath = @"/*[local-name()='Person' and namespace-uri()='http://AccessingAndChangeMessageValuesInOrchestration.Schema1']/*[local-name()='FirstName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LastName", XPath = @"/*[local-name()='Person' and namespace-uri()='http://AccessingAndChangeMessageValuesInOrchestration.Schema1']/*[local-name()='LastName' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Person"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AccessingAndChangeMessageValuesInOrchestration.PropertySchema.PropertySchema", typeof(global::AccessingAndChangeMessageValuesInOrchestration.PropertySchema.PropertySchema))]
    public sealed class Schema1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://AccessingAndChangeMessageValuesInOrchestration.Schema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://AccessingAndChangeMessageValuesInOrchestration.PropertySchema.PropertySchema"" targetNamespace=""http://AccessingAndChangeMessageValuesInOrchestration.Schema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://AccessingAndChangeMessageValuesInOrchestration.PropertySchema.PropertySchema"" location=""AccessingAndChangeMessageValuesInOrchestration.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Person"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:FirstName"" xpath=""/*[local-name()='Person' and namespace-uri()='http://AccessingAndChangeMessageValuesInOrchestration.Schema1']/*[local-name()='FirstName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Person' and namespace-uri()='http://AccessingAndChangeMessageValuesInOrchestration.Schema1']/*[local-name()='LastName' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""Age"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Schema1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Person";
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
