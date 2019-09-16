namespace WorkingWithConstantValues {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://WorkingWithConstantValues.TargetSchema",@"Target")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Target"})]
    public sealed class TargetSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://WorkingWithConstantValues.TargetSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://WorkingWithConstantValues.TargetSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Target"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Title"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""OpcionalField"" type=""xs:string"" />
        <xs:element name=""StaticConstants"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ConstValueInSchema"" type=""xs:string"" />
              <xs:element name=""ConstValueUsingScriptingFunctoid"" type=""xs:string"" />
              <xs:element name=""ConstValueUsingScriptingFunctoid2"" type=""xs:string"" />
              <xs:element name=""ConstValueUsingStringFunctoids"" type=""xs:string"" />
              <xs:element name=""ConstValueUsingConstantFunctoid"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DynamicConstants"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""GetConstValueFromSSO"" type=""xs:string"" />
              <xs:element name=""GetConstValueFromBTSNTSvsConfig"" type=""xs:string"" />
              <xs:element name=""GetConstValueFromConfigFile"" type=""xs:string"" />
              <xs:element name=""GetConstValueFromRegistry"" type=""xs:string"" />
              <xs:element name=""GetConstValueFromSysEnvrm"" type=""xs:string"" />
              <xs:element name=""GetConstValueFromCustomDB"" type=""xs:string"" />
              <xs:element name=""GetConstValueFromBusinessRule"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TargetSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Target";
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
