namespace ComoFuncinamOsMapas.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ComoFuncinamOsMapas.PessoaDestino2",@"PessoaDestino2")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PessoaDestino2"})]
    public sealed class PessoaDestino2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://ComoFuncinamOsMapas.PessoaDestino2"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://ComoFuncinamOsMapas.PessoaDestino2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PessoaDestino2"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Morada"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CodigoPostal"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EstadoCivil"" type=""xs:string"" />
        <xs:element name=""NomeCompleto"" type=""xs:string"" />
        <xs:element name=""Idade"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Facturacao"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""TotalInternacional"" type=""xs:double"" />
              <xs:element name=""TotalNacional"" type=""xs:double"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PessoaDestino2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PessoaDestino2";
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
