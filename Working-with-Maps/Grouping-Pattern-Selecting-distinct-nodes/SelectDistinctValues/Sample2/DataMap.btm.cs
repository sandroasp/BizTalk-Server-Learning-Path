namespace SelectDistinctValues {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SelectDistinctValues.DataInput", typeof(global::SelectDistinctValues.DataInput))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SelectDistinctValues.DataOutput", typeof(global::SelectDistinctValues.DataOutput))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/In"" />
  </xsl:template>
  <xsl:template match=""/In"">
    <xsl:element name=""Data"">
<xsl:for-each select=""Data[not(@Header=preceding-sibling::Data/@Header)]"">
<xsl:element name=""Header""><xsl:value-of select=""@Header"" /></xsl:element>
<xsl:element name=""date""><xsl:value-of select=""@date"" /></xsl:element>
<xsl:element name=""Record"">
  <xsl:call-template name=""NameValueTemplate"">
    <xsl:with-param name=""param1"" select=""string(@Header)"" />
  </xsl:call-template>
</xsl:element>

</xsl:for-each>
</xsl:element>
  </xsl:template>
  <xsl:template name=""NameValueTemplate"">
<xsl:param name=""param1"" />
<xsl:for-each select=""//Data[@Header=$param1]"">
<xsl:element name=""Name""><xsl:value-of select=""@Name"" /></xsl:element>
<xsl:element name=""Value""><xsl:value-of select=""@Value"" /></xsl:element>
</xsl:for-each>
</xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SelectDistinctValues.DataInput";
        
        private const string _strTrgSchemasList0 = @"SelectDistinctValues.DataOutput";
        
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
                _SrcSchemas[0] = @"SelectDistinctValues.DataInput";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SelectDistinctValues.DataOutput";
                return _TrgSchemas;
            }
        }
    }
}
