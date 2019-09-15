namespace SelectDistinctValues {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SelectDistinctValues.Input", typeof(global::SelectDistinctValues.Input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SelectDistinctValues.Output1", typeof(global::SelectDistinctValues.Output1))]
    public sealed class MapListParteners : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://SelectDistinctValues.Input"" xmlns:ns0=""http://SelectDistinctValues.Output1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ExternalEmployees"" />
  </xsl:template>
  <xsl:template match=""/s0:ExternalEmployees"">
    <ns0:ListPartners>
      <xsl:variable name=""unique-companies"" select=""//Employee[not(Company=preceding-sibling::Employee/Company)]/Company"" />
      <xsl:for-each select=""$unique-companies"">
    <PartnerName><xsl:value-of select=""."" /></PartnerName>
</xsl:for-each>
    </ns0:ListPartners>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SelectDistinctValues.Input";
        
        private const string _strTrgSchemasList0 = @"SelectDistinctValues.Output1";
        
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
                _SrcSchemas[0] = @"SelectDistinctValues.Input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SelectDistinctValues.Output1";
                return _TrgSchemas;
            }
        }
    }
}
