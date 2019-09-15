namespace CanonicalDataModelPattern {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CanonicalDataModelPattern.ChangeUserInfo",@"ChangeOrAddUserInfo")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ChangeOrAddUserInfo"})]
    public sealed class ChangeUserInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CanonicalDataModelPattern.ChangeUserInfo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CanonicalDataModelPattern.ChangeUserInfo"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ChangeOrAddUserInfo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RequestId"" type=""xs:string"" />
        <xs:element name=""Username"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Protocol"" type=""xs:string"" />
              <xs:element name=""Pool"" type=""xs:string"" />
              <xs:element name=""Route"" type=""xs:string"" />
              <xs:element name=""IPAddress"" type=""xs:string"" />
              <xs:element name=""IPNetmask"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Unisphere"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""VirtualRouter"" type=""xs:string"" />
              <xs:element name=""IngressPolicyName"" type=""xs:string"" />
              <xs:element name=""InitCLIAccessLevel"" type=""xs:string"" />
              <xs:element name=""LocalAddressPool"" type=""xs:string"" />
              <xs:element name=""IngressStatistics"" type=""xs:string"" />
              <xs:element name=""PrimaryDns"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ChangeUserInfo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ChangeOrAddUserInfo";
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
