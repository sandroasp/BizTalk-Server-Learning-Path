namespace WorkingWithConditions._04_IfThenElseRecursiveRecords {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"GetPIArchiveDataResult")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GetPIArchiveDataResult"})]
    public sealed class Instance : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""GetPIArchiveDataResult"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""TimeSeries"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""TimedValues"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""TimedValue"">
                      <xs:complexType>
                        <xs:simpleContent>
                          <xs:extension base=""xs:decimal"">
                            <xs:attribute name=""Path"" type=""xs:unsignedByte"" use=""required"" />
                            <xs:attribute name=""Flags"" type=""xs:string"" use=""required"" />
                            <xs:attribute name=""Time"" type=""xs:dateTime"" use=""required"" />
                            <xs:attribute name=""UOM"" type=""xs:string"" use=""required"" />
                            <xs:attribute name=""Status"" type=""xs:string"" use=""required"" />
                            <xs:attribute name=""PctGood"" type=""xs:unsignedByte"" use=""required"" />
                            <xs:attribute name=""DataType"" type=""xs:string"" use=""required"" />
                          </xs:extension>
                        </xs:simpleContent>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Updates"" type=""xs:anyType"" />
            </xs:sequence>
            <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
            <xs:attribute name=""Path"" type=""xs:unsignedByte"" use=""required"" />
            <xs:attribute name=""ErrDesc"" type=""xs:string"" use=""required"" />
            <xs:attribute name=""Error"" type=""xs:int"" use=""required"" />
            <xs:attribute name=""SeriesID"" type=""xs:string"" use=""required"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Instance() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "GetPIArchiveDataResult";
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
