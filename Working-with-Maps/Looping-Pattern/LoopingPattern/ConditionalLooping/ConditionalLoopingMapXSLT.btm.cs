namespace LoopingPattern.ConditionalLooping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.ConditionalLooping.Surveys", typeof(global::LoopingPattern.ConditionalLooping.Surveys))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.ConditionalLooping.MasterAddress", typeof(global::LoopingPattern.ConditionalLooping.MasterAddress))]
    public sealed class ConditionalLoopingMapXSLT : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://LoopingPattern.MasterAddress"" xmlns:s0=""http://LoopingPattern.Surveys"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Surveys"" />
  </xsl:template>
  <xsl:template match=""/s0:Surveys"">
    <ns0:MasterAddresses>
      <xsl:for-each select=""FoodSurvey[State = 'FL']"">
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
      <xsl:for-each select=""FlowerDurvey[State = 'FL']"">
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
        
        private const string _strSrcSchemasList0 = @"LoopingPattern.ConditionalLooping.Surveys";
        
        private const global::LoopingPattern.ConditionalLooping.Surveys _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern.ConditionalLooping.MasterAddress";
        
        private const global::LoopingPattern.ConditionalLooping.MasterAddress _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern.ConditionalLooping.Surveys";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern.ConditionalLooping.MasterAddress";
                return _TrgSchemas;
            }
        }
    }
}
