namespace SelectDistinctValues.Sample3 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SelectDistinctValues.Sample3.InputPersons", typeof(global::SelectDistinctValues.Sample3.InputPersons))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SelectDistinctValues.Sample3.OutputPersons", typeof(global::SelectDistinctValues.Sample3.OutputPersons))]
    public sealed class MapPerson : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://SelectDistinctValues.InputPersons"" xmlns:ns0=""http://SelectDistinctValues.OutputPersons"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Persons"" />
  </xsl:template>
  <xsl:template match=""/s0:Persons"">
    <ns0:Persons>
      <xsl:for-each select=""//Person[not(Name=preceding-sibling::Person/Name)]"">
<xsl:element name=""Person"">
<xsl:element name=""Name""><xsl:value-of select=""Name"" /></xsl:element>
<xsl:call-template name=""NationalityTemplate"">
  <xsl:with-param name=""param1"" select=""string(Name)"" />
</xsl:call-template>
<xsl:call-template name=""EmailTemplate"">
  <xsl:with-param name=""paramName"" select=""string(Name)"" />
</xsl:call-template>
</xsl:element>
</xsl:for-each>
    </ns0:Persons>
  </xsl:template>
  <xsl:template name=""NationalityTemplate"">
<xsl:param name=""param1"" />
<xsl:for-each select=""//Person[Name=$param1]"">
<xsl:element name=""Nationality""><xsl:value-of select=""Nationality"" /></xsl:element>
</xsl:for-each>
</xsl:template>
  <xsl:template name=""EmailTemplate"">
<xsl:param name=""paramName"" />
<xsl:for-each select=""//Person[Name=$paramName]"">
  <xsl:if test=""position()=last()"">
    <xsl:element name=""Email""><xsl:value-of select=""Email"" /></xsl:element>
  </xsl:if>
</xsl:for-each>
</xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SelectDistinctValues.Sample3.InputPersons";
        
        private const string _strTrgSchemasList0 = @"SelectDistinctValues.Sample3.OutputPersons";
        
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
                _SrcSchemas[0] = @"SelectDistinctValues.Sample3.InputPersons";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SelectDistinctValues.Sample3.OutputPersons";
                return _TrgSchemas;
            }
        }
    }
}
