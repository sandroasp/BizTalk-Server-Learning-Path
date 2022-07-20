namespace POC.BizTalk.PropertyDemotion {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://POC.BizTalk.PropertyDemotion.Registration",@"Registration")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::POC.BizTalk.PropertyDemotion.PropertySchema.SubmissionDate), XPath = @"/*[local-name()='Registration' and namespace-uri()='http://POC.BizTalk.PropertyDemotion.Registration']/*[local-name()='SubmissionDate' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BTS.MessageType), XPath = @"/*[local-name()='Registration' and namespace-uri()='http://POC.BizTalk.PropertyDemotion.Registration']/*[local-name()='MessageType' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Registration"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"POC.BizTalk.PropertyDemotion.PropertySchema.PropertySchema", typeof(global::POC.BizTalk.PropertyDemotion.PropertySchema.PropertySchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.bts_system_properties", typeof(global::BTS.bts_system_properties))]
    public sealed class Registration : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://POC.BizTalk.PropertyDemotion.Registration"" xmlns:ns0=""https://POC.BizTalk.PropertyDemotion.PropertySchema"" xmlns:ns1=""http://schemas.microsoft.com/BizTalk/2003/system-properties"" targetNamespace=""http://POC.BizTalk.PropertyDemotion.Registration"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://POC.BizTalk.PropertyDemotion.PropertySchema"" location=""POC.BizTalk.PropertyDemotion.PropertySchema.PropertySchema"" />
        <b:namespace prefix=""ns1"" uri=""http://schemas.microsoft.com/BizTalk/2003/system-properties"" location=""BTS.bts_system_properties"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Registration"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:SubmissionDate"" xpath=""/*[local-name()='Registration' and namespace-uri()='http://POC.BizTalk.PropertyDemotion.Registration']/*[local-name()='SubmissionDate' and namespace-uri()='']"" />
          <b:property name=""ns1:MessageType"" xpath=""/*[local-name()='Registration' and namespace-uri()='http://POC.BizTalk.PropertyDemotion.Registration']/*[local-name()='MessageType' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FullName"" type=""xs:string"" />
        <xs:element name=""Nacionality"" type=""xs:string"" />
        <xs:element name=""Sex"" type=""xs:string"" />
        <xs:element name=""Age"" type=""xs:string"" />
        <xs:element name=""SubmissionDate"" type=""xs:string"" />
        <xs:element name=""MessageType"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        private const global::BTS.bts_system_properties  __DummyVar0 = null;
        
        public Registration() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Registration";
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
