namespace ComoFuncinamOsMapas.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ComoFuncinamOsMapas.Schema1",@"Origem")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Origem"})]
    public sealed class Schema1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://ComoFuncinamOsMapas.Schema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://ComoFuncinamOsMapas.Schema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Origem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Cliente"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Nome"" type=""xs:string"" />
              <xs:element name=""Idade"" type=""xs:int"" />
              <xs:element name=""Sexo"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:enumeration value=""M"" />
                    <xs:enumeration value=""F"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Empregado"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Nome"" type=""xs:string"" />
              <xs:element name=""Idade"" type=""xs:int"" />
              <xs:element name=""Sexo"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:enumeration value=""M"" />
                    <xs:enumeration value=""F"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Schema1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Origem";
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
