namespace LoopingPattern.LoopValueMappingFlatteningFunctoid {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.input", typeof(global::LoopingPattern.input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat", typeof(global::LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat))]
    public sealed class LoppingFlatMapSol2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://LoopingPattern.InputSchema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Root"" />
  </xsl:template>
  <xsl:template match=""/ns0:Root"">
    <ns0:Root>
      <xsl:for-each select=""Record"">
  <Record>
    <xsl:for-each select=""Field"">
      <xsl:if test=""string(@Name)='Param1'"">
        <xsl:attribute name=""Param1"">
          <xsl:value-of select=""@Value"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:if test=""string(@Name)='Param2'"">
        <xsl:attribute name=""Param2"">
          <xsl:value-of select=""@Value"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:if test=""string(@Name)='Param3'"">
        <xsl:attribute name=""Param3"">
          <xsl:value-of select=""@Value"" />
        </xsl:attribute>
      </xsl:if>
    </xsl:for-each>
  </Record>
</xsl:for-each>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"LoopingPattern.input";
        
        private const global::LoopingPattern.input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat";
        
        private const global::LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern.input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat";
                return _TrgSchemas;
            }
        }
    }
}
