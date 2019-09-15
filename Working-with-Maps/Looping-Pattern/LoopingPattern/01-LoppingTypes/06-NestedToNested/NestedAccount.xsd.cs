namespace LoopingPattern._01_LoppingTypes._06_NestedToNested {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LoopingPattern.NestedAccount",@"NestedAccount")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"NestedAccount"})]
    public sealed class NestedAccount : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LoopingPattern.NestedAccount"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://LoopingPattern.NestedAccount"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""NestedAccount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Account"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""AccountName"" type=""xs:string"" />
              <xs:element name=""AccountId"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""AccountBuild"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""AccountProduct"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""AccountProductId"" type=""xs:string"" />
                          <xs:element name=""ProductId"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""AccountBuildId"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public NestedAccount() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "NestedAccount";
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
