namespace LoopingPattern._01_LoppingTypes._03_ManyToOne {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LoopingPattern.ProjectTender",@"ProjectTender")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ProjectTender"})]
    public sealed class ProjectTender : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LoopingPattern.ProjectTender"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://LoopingPattern.ProjectTender"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ProjectTender"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ProjectName"" type=""xs:string"" />
        <xs:element name=""ProjectReference"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Vendor"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Company"" type=""xs:string"" />
              <xs:element name=""ContactName"" type=""xs:string"" />
              <xs:element name=""ContactRole"" type=""xs:string"" />
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Client"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Company"" type=""xs:string"" />
              <xs:element name=""ContactName"" type=""xs:string"" />
              <xs:element name=""ContactRole"" type=""xs:string"" />
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""DecisionMakers"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Company"" type=""xs:string"" />
              <xs:element name=""ContactName"" type=""xs:string"" />
              <xs:element name=""ContactRole"" type=""xs:string"" />
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ProjectTender() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ProjectTender";
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
