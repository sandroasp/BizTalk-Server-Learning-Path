namespace LoopingPattern._01_LoppingTypes._04_ManyToMany {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LoopingPattern.ProjectParticipant2",@"ProjectParticipantDiv")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ProjectParticipantDiv"})]
    public sealed class ProjectParticipant2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LoopingPattern.ProjectParticipant2"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://LoopingPattern.ProjectParticipant2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ProjectParticipantDiv"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ProjectName"" type=""xs:string"" />
        <xs:element name=""ProjectReference"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""ExternalParticipant"">
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
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""InternalParticipant"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Company"" type=""xs:string"" />
              <xs:element name=""ContactName"" type=""xs:string"" />
              <xs:element name=""ContactRole"" type=""xs:string"" />
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
              <xs:element name=""Type"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ProjectParticipant2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ProjectParticipantDiv";
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
