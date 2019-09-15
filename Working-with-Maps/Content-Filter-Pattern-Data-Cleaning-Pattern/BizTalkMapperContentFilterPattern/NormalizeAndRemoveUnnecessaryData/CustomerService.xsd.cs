namespace BizTalkMapperContentFilterPattern.RemoveUnnecessaryData {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkMapperContentFilterPattern.CustomerService",@"CustomerService")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerService"})]
    public sealed class CustomerService : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkMapperContentFilterPattern.CustomerService"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalkMapperContentFilterPattern.CustomerService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerService"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RequestDate"" type=""xs:dateTime"" />
        <xs:element name=""Name"" type=""xs:string"" />
        <xs:element name=""TaxId"" type=""xs:string"" />
        <xs:element name=""ContactPhone"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ContactName"" type=""xs:string"" />
              <xs:element name=""Phone"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Email"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Address"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element name=""PostalCode"" type=""xs:string"" />
              <xs:element name=""Region"" type=""xs:string"" />
              <xs:element name=""Locality"" type=""xs:string"" />
              <xs:element name=""Country"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Organization"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Description"" type=""xs:string"" />
              <xs:element name=""SiteURL"" type=""xs:string"" />
              <xs:element name=""Logo"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Person"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Gender"" type=""xs:string"" />
              <xs:element name=""BirthDate"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CustomerService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerService";
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
