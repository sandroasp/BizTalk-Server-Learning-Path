namespace BizTalkMapperSemanticTranslatorPattern.MassCopy {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder", typeof(global::BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperSemanticTranslatorPattern.MassCopy.CanonicalPurchaseOrder", typeof(global::BizTalkMapperSemanticTranslatorPattern.MassCopy.CanonicalPurchaseOrder))]
    public sealed class MapUsingCustomMassCopy : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperSemanticTranslatorPattern.CanonicalPurchaseOrder"" xmlns:s0=""http://BizTalkMapperSemanticTranslatorPattern.PurchaseOrder"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PurchaseOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:PurchaseOrder"">
    <CanonicalPurchaseOrder>
      <xsl:for-each select=""/s0:PurchaseOrder/*"">
	<xsl:if test=""local-name()!='LineItems'"">
          <xsl:element name=""{local-name(.)}"">
            <xsl:value-of select=""."" />
          </xsl:element>
	</xsl:if>
      </xsl:for-each>

      <xsl:choose>
        <xsl:when test=""count(/s0:PurchaseOrder/LineItems) &gt; 0"">
          <LineItems>
            <xsl:for-each select=""/s0:PurchaseOrder/LineItems/*"">
	      <Items>
                <xsl:for-each select=""./*"">
                  <xsl:element name=""{local-name(.)}"">
                    <xsl:value-of select=""."" />
                  </xsl:element>
                </xsl:for-each>
	      </Items>
            </xsl:for-each>
          </LineItems>
        </xsl:when>
      </xsl:choose>
</CanonicalPurchaseOrder>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder";
        
        private const global::BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkMapperSemanticTranslatorPattern.MassCopy.CanonicalPurchaseOrder";
        
        private const global::BizTalkMapperSemanticTranslatorPattern.MassCopy.CanonicalPurchaseOrder _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkMapperSemanticTranslatorPattern.MassCopy.CanonicalPurchaseOrder";
                return _TrgSchemas;
            }
        }
    }
}
