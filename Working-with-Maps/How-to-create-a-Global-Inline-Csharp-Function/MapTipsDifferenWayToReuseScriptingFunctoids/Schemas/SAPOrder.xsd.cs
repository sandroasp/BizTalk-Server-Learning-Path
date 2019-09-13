namespace MapTipsDifferenWayToReuseScriptingFunctoids.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MapTipsDifferenWayToReuseScriptingFunctoids.SAPOrder",@"SAPOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SAPOrder"})]
    public sealed class SAPOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MapTipsDifferenWayToReuseScriptingFunctoids.SAPOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MapTipsDifferenWayToReuseScriptingFunctoids.SAPOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SAPOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderID"" type=""xs:string"" />
        <xs:element name=""ClientId"" type=""xs:string"" />
        <xs:element name=""Dates"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderDate"" type=""xs:string"" />
              <xs:element name=""EstimatedDeliveryDate"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Details"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Item"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ItemId"" type=""xs:string"" />
                    <xs:element name=""Total"" type=""xs:string"" />
                    <xs:element name=""UnitType"" type=""xs:string"" />
                    <xs:element name=""Discount"" type=""xs:string"" />
                    <xs:element name=""Units"" type=""xs:string"" />
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
        
        public SAPOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SAPOrder";
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
