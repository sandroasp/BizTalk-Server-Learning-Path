namespace LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LoopingPattern.Families",@"Families")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Families"})]
    public sealed class Families : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LoopingPattern.Families"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://LoopingPattern.Families"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Families"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Family"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Parents"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""1"" maxOccurs=""2"" name=""Name"">
                      <xs:complexType>
                        <xs:simpleContent>
                          <xs:extension base=""xs:string"">
                            <xs:attribute name=""Sex"" type=""xs:string"" />
                          </xs:extension>
                        </xs:simpleContent>
                      </xs:complexType>
                    </xs:element>
                    <xs:element maxOccurs=""unbounded"" name=""Child"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Name"" type=""xs:string"" />
                          <xs:element name=""Age"" type=""xs:string"" />
                          <xs:element name=""Sex"" type=""xs:string"" />
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
        
        public Families() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Families";
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
