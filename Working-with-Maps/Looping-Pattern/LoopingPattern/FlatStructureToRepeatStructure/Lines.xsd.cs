namespace LoopingPattern.FlatStructureToRepeatStructure {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LoopingPattern.Lines",@"Lines")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Lines"})]
    public sealed class Lines : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LoopingPattern.Lines"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://LoopingPattern.Lines"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Lines"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Line"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Item"" type=""xs:string"" />
              <xs:element name=""Service"" type=""xs:string"" />
              <xs:element name=""PropertyName1"" type=""xs:string"" />
              <xs:element name=""PropertyValue1"" type=""xs:string"" />
              <xs:element name=""PropertyName2"" type=""xs:string"" />
              <xs:element name=""PropertyValue2"" type=""xs:string"" />
              <xs:element name=""PropertyName3"" type=""xs:string"" />
              <xs:element name=""PropertyValue3"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Lines() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Lines";
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
