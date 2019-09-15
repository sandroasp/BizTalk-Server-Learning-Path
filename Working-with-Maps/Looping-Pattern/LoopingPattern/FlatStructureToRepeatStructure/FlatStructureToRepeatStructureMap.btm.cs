namespace LoopingPattern.FlatStructureToRepeatStructure {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.FlatStructureToRepeatStructure.Lines", typeof(global::LoopingPattern.FlatStructureToRepeatStructure.Lines))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.FlatStructureToRepeatStructure.LinesOutput", typeof(global::LoopingPattern.FlatStructureToRepeatStructure.LinesOutput))]
    public sealed class FlatStructureToRepeatStructureMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://LoopingPattern.LinesOutput"" xmlns:s0=""http://LoopingPattern.Lines"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Lines"" />
  </xsl:template>
  <xsl:template match=""/s0:Lines"">
    <ns0:LinesOutput>
      <xsl:for-each select=""Line"">
        <xsl:variable name=""var:v1"" select=""PropertyName1"" />
        <xsl:variable name=""var:v2"" select=""PropertyValue1"" />
        <xsl:variable name=""var:v3"" select=""PropertyName2"" />
        <xsl:variable name=""var:v4"" select=""PropertyValue2"" />
        <xsl:variable name=""var:v5"" select=""PropertyName3"" />
        <xsl:variable name=""var:v6"" select=""PropertyValue3"" />
        <Line>
          <xsl:attribute name=""Item"">
            <xsl:value-of select=""Item/text()"" />
          </xsl:attribute>
          <Service>
            <xsl:value-of select=""Service/text()"" />
          </Service>
          <Properties>
            <Name>
              <xsl:value-of select=""$var:v1"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v2"" />
            </Value>
          </Properties>
          <Properties>
            <Name>
              <xsl:value-of select=""$var:v3"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v4"" />
            </Value>
          </Properties>
          <Properties>
            <Name>
              <xsl:value-of select=""$var:v5"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v6"" />
            </Value>
          </Properties>
        </Line>
      </xsl:for-each>
    </ns0:LinesOutput>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"LoopingPattern.FlatStructureToRepeatStructure.Lines";
        
        private const global::LoopingPattern.FlatStructureToRepeatStructure.Lines _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern.FlatStructureToRepeatStructure.LinesOutput";
        
        private const global::LoopingPattern.FlatStructureToRepeatStructure.LinesOutput _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern.FlatStructureToRepeatStructure.Lines";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern.FlatStructureToRepeatStructure.LinesOutput";
                return _TrgSchemas;
            }
        }
    }
}
