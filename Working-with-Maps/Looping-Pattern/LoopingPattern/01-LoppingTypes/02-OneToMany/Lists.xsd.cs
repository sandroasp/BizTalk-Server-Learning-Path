namespace LoopingPattern._01_LoppingTypes._02_OneToMany {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LoopingPattern.Lists",@"Lists")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Lists"})]
    public sealed class Lists : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LoopingPattern.Lists"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://LoopingPattern.Lists"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Lists"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Address"">
          <xs:complexType>
            <xs:attribute name=""Street"" type=""xs:string"" />
            <xs:attribute name=""City"" type=""xs:string"" />
            <xs:attribute name=""State"" type=""xs:string"" />
            <xs:attribute name=""PostalCode"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Person"">
          <xs:complexType>
            <xs:attribute name=""Name"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Lists() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Lists";
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
