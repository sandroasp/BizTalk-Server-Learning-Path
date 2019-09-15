namespace WorkingWithNillableValues {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithNillableValues.InputSchema", typeof(global::WorkingWithNillableValues.InputSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithNillableValues.OutputSchema", typeof(global::WorkingWithNillableValues.OutputSchema))]
    public sealed class MapNillValuesWithCustomXSLT : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://WorkingWithNillableValues.InputSchema"" xmlns:ns0=""http://WorkingWithNillableValues.OutputSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""no"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:InputSchema"" />
  </xsl:template>
  <xsl:template match=""/s0:InputSchema"">
    <ns0:OutputSchema>
      <NillValueOutput>
          <xsl:attribute name=""xsi:nil"">
            <xsl:value-of select=""'true'"" />
          </xsl:attribute>
</NillValueOutput>
    </ns0:OutputSchema>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"WorkingWithNillableValues.InputSchema";
        
        private const global::WorkingWithNillableValues.InputSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithNillableValues.OutputSchema";
        
        private const global::WorkingWithNillableValues.OutputSchema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"WorkingWithNillableValues.InputSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithNillableValues.OutputSchema";
                return _TrgSchemas;
            }
        }
    }
}
