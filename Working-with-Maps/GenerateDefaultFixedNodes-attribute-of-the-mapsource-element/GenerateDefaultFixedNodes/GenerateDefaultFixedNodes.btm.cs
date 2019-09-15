namespace GenerateDefaultFixedNodes {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GenerateDefaultFixedNodes.Input", typeof(global::GenerateDefaultFixedNodes.Input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GenerateDefaultFixedNodes.Output", typeof(global::GenerateDefaultFixedNodes.Output))]
    public sealed class GenerateDefaultFixedNodes : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://GenerateDefaultFixedNodes.Output"" xmlns:s0=""http://GenerateDefaultFixedNodes.Input"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Input"" />
  </xsl:template>
  <xsl:template match=""/s0:Input"">
    <ns0:Output>
      <Name>
        <xsl:value-of select=""Name/text()"" />
      </Name>
      <Address>
        <xsl:value-of select=""Address/text()"" />
      </Address>
    </ns0:Output>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GenerateDefaultFixedNodes.Input";
        
        private const global::GenerateDefaultFixedNodes.Input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GenerateDefaultFixedNodes.Output";
        
        private const global::GenerateDefaultFixedNodes.Output _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"GenerateDefaultFixedNodes.Input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GenerateDefaultFixedNodes.Output";
                return _TrgSchemas;
            }
        }
    }
}
