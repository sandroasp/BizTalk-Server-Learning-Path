namespace ComoFuncinamOsMapas.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ComoFuncinamOsMapas.PessoaOrigem",@"PessoaOrigem")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PessoaOrigem"})]
    public sealed class PessoaOrigem : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://ComoFuncinamOsMapas.PessoaOrigem"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://ComoFuncinamOsMapas.PessoaOrigem"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PessoaOrigem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Nome"" type=""xs:string"" />
        <xs:element name=""Apelido"" type=""xs:string"" />
        <xs:element name=""DataNascimento"" type=""xs:date"" />
        <xs:element name=""Morada"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CodigoPostal"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Chamada"">
          <xs:complexType>
            <xs:attribute name=""Destino"" type=""xs:string"" />
            <xs:attribute name=""Custo"" type=""xs:double"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PessoaOrigem() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PessoaOrigem";
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
