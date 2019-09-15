namespace CanonicalDataModelPattern {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CanonicalDataModelPattern.CanonicalRequest",@"CanonicalRequest")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CanonicalRequest"})]
    public sealed class CanonicalRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CanonicalDataModelPattern.CanonicalRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CanonicalDataModelPattern.CanonicalRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CanonicalRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Header"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ProcessId"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""OperationType"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Body"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Username"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Password"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Service-Type"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-Protocol"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-Pool"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Shasta-VPN-Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-IP-Address"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-IP-Netmask"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IPLAN"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Framed-Route"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Shasta-Service-Profile"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Virtual-Router"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Ingress-Policy-Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Init-CLI-Access-Level"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Local-Address-Pool"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Ingress-Statistics"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Primary-Dns"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Secondary-Dns"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Qos-Profile-Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Egress-Policy-Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Egress-Statistics"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-IpV6-Virtual-Router"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Shasta-IPSec-Split-Tunnel"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Idle-Timeout"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Session-Timeout"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Tunnel-Type"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Tunnel-Medium-Type"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Tunnel-Server-Endpoint"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Called-Station-Id"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-MTU"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-IPv6-Route"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-IPv6-Pool"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-IPv6-Prefix"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Ascend-Client-Primary-DNS"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Ascend-Client-Secondary-DNS"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Cisco-Account-Info"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CiscoAvpairs"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Cisco-Avpair"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Simultaneous-Use"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Port-Limit"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Access-Type"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Fortinet-Vdom-Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Tunnel-Assignment-ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Tunnel-Password"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Tunnel-Preference"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Framed-Netmask"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Unisphere-Policy-Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Calling-Station-Id"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""User-Wifi"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Acct-Interim-Interval"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Properties"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""RadiusProperties"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""FieldName"" type=""xs:string"" />
                          <xs:element name=""FieldValue"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CanonicalRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CanonicalRequest";
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
