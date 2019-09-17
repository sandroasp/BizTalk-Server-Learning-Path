namespace BizTalk.CallingExternalAssemblyFromInlineXSLT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo",@"CarProperty")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CarProperty"})]
    public sealed class CarInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CarProperty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Car"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Brand"" type=""xs:string"" />
              <xs:element name=""Model"" type=""xs:string"" />
              <xs:element name=""Year"" type=""xs:int"" />
              <xs:element name=""FuelType"" type=""xs:string"" />
              <xs:element name=""HP"" type=""xs:int"" />
              <xs:element name=""Color"" type=""xs:string"" />
              <xs:element name=""Observations"" type=""xs:string"" />
              <xs:element name=""MarketPrice"" type=""xs:double"" />
              <xs:element name=""OwnerPrice"" type=""xs:double"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""OwnerName"" type=""xs:string"" />
        <xs:element name=""OwnerAddress"" type=""xs:string"" />
        <xs:element name=""OwnerProfession"" type=""xs:string"" />
        <xs:element name=""OwnerAge"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CarInfo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CarProperty";
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
