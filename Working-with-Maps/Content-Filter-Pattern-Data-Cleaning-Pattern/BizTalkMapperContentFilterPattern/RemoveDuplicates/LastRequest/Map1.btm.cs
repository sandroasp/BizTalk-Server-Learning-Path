namespace BizTalkMapperContentFilterPattern.RemoveDuplicates.LastRequest {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperContentFilterPattern.Example2.ApplicationForms", typeof(global::BizTalkMapperContentFilterPattern.Example2.ApplicationForms))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperContentFilterPattern.Example2.ApplicationForms", typeof(global::BizTalkMapperContentFilterPattern.Example2.ApplicationForms))]
    public sealed class Map1 : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperContentFilterPattern.ApplicationForms"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:ApplicationForms"" />
  </xsl:template>
  <xsl:template match=""/ns0:ApplicationForms"">
    <ns0:ApplicationForms>
      <xsl:for-each select=""Form"">
        <Form>
          <FullName>
            <xsl:value-of select=""FullName/text()"" />
          </FullName>
        </Form>
      </xsl:for-each>
    </ns0:ApplicationForms>
  </xsl:template>
  <xsl:key name=""Customer"" use=""."" match=""Form/FullName/text()"" />
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkMapperContentFilterPattern.Example2.ApplicationForms";
        
        private const global::BizTalkMapperContentFilterPattern.Example2.ApplicationForms _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkMapperContentFilterPattern.Example2.ApplicationForms";
        
        private const global::BizTalkMapperContentFilterPattern.Example2.ApplicationForms _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkMapperContentFilterPattern.Example2.ApplicationForms";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkMapperContentFilterPattern.Example2.ApplicationForms";
                return _TrgSchemas;
            }
        }
    }
}
