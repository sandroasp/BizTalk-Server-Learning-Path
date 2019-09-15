namespace LoopingPattern._01_LoppingTypes._01_OneToOne {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._01_OneToOne.Survays", typeof(global::LoopingPattern._01_LoppingTypes._01_OneToOne.Survays))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._01_OneToOne.MasterAddresses", typeof(global::LoopingPattern._01_LoppingTypes._01_OneToOne.MasterAddresses))]
    public sealed class OneToOneMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://LoopingPattern.Survays"" xmlns:ns0=""http://LoopingPattern.MasterAddresses"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Surveys"" />
  </xsl:template>
  <xsl:template match=""/s0:Surveys"">
    <ns0:MasterAddresses>
      <xsl:for-each select=""GeneralSurvey"">
        <Address>
          <xsl:attribute name=""Name"">
            <xsl:value-of select=""Name/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""Street"">
            <xsl:value-of select=""Address/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""City"">
            <xsl:value-of select=""City/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""State"">
            <xsl:value-of select=""State/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""PostalCode"">
            <xsl:value-of select=""PostalCode/text()"" />
          </xsl:attribute>
        </Address>
      </xsl:for-each>
    </ns0:MasterAddresses>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"LoopingPattern._01_LoppingTypes._01_OneToOne.Survays";
        
        private const global::LoopingPattern._01_LoppingTypes._01_OneToOne.Survays _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern._01_LoppingTypes._01_OneToOne.MasterAddresses";
        
        private const global::LoopingPattern._01_LoppingTypes._01_OneToOne.MasterAddresses _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern._01_LoppingTypes._01_OneToOne.Survays";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern._01_LoppingTypes._01_OneToOne.MasterAddresses";
                return _TrgSchemas;
            }
        }
    }
}
