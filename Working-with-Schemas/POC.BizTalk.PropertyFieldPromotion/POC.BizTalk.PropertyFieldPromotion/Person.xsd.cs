namespace POC.BizTalk.PropertyFieldPromotion {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://POC.BizTalk.PropertyFieldPromotion.Person",@"Person")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::POC.BizTalk.PropertyFieldPromotion.Nationality), XPath = @"/*[local-name()='Person' and namespace-uri()='http://POC.BizTalk.PropertyFieldPromotion.Person']/*[local-name()='Nationality' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::POC.BizTalk.PropertyFieldPromotion.Sex), XPath = @"/*[local-name()='Person' and namespace-uri()='http://POC.BizTalk.PropertyFieldPromotion.Person']/*[local-name()='Sex' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Person"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"POC.BizTalk.PropertyFieldPromotion.POCPropertySchema", typeof(global::POC.BizTalk.PropertyFieldPromotion.POCPropertySchema))]
    public sealed class Person : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://POC.BizTalk.PropertyFieldPromotion.Person"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://POC.BizTalk.PropertyFieldPromotion.POCPropertySchema"" targetNamespace=""http://POC.BizTalk.PropertyFieldPromotion.Person"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://POC.BizTalk.PropertyFieldPromotion.POCPropertySchema"" location=""POC.BizTalk.PropertyFieldPromotion.POCPropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Person"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Nationality"" xpath=""/*[local-name()='Person' and namespace-uri()='http://POC.BizTalk.PropertyFieldPromotion.Person']/*[local-name()='Nationality' and namespace-uri()='']"" />
          <b:property name=""ns0:Sex"" xpath=""/*[local-name()='Person' and namespace-uri()='http://POC.BizTalk.PropertyFieldPromotion.Person']/*[local-name()='Sex' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""Age"" type=""xs:string"" />
        <xs:element name=""Nationality"" type=""xs:string"" />
        <xs:element name=""Sex"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Person() {
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
