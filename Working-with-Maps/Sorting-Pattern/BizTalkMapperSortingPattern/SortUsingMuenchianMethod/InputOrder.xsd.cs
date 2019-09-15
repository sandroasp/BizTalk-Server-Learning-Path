namespace MuenchianGrouping {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MuenchianGrouping.InputOrder",@"InputOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InputOrder"})]
    public sealed class InputOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MuenchianGrouping.InputOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MuenchianGrouping.InputOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""InputOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Order"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderId"" type=""xs:string"" />
              <xs:element name=""ItemId"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InputOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "InputOrder";
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
