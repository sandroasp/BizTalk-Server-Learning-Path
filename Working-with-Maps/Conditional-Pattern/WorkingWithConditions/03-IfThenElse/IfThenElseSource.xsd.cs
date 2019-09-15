namespace WorkingWithConditions._03_IfThenElse {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://WorkingWithConditions.IfThenElseSource",@"IfThenElseSource")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"IfThenElseSource"})]
    public sealed class IfThenElseSource : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://WorkingWithConditions.IfThenElseSource"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://WorkingWithConditions.IfThenElseSource"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""IfThenElseSource"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Person"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Sex"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:enumeration value=""M"" />
                    <xs:enumeration value=""F"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""Age"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public IfThenElseSource() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "IfThenElseSource";
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
