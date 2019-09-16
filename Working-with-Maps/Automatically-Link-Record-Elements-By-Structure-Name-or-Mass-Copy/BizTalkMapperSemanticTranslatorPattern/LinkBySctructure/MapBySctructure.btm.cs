namespace BizTalkMapperSemanticTranslatorPattern.LinkBySctructure {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder", typeof(global::BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperSemanticTranslatorPattern.LinkBySctructure.POBySctructure", typeof(global::BizTalkMapperSemanticTranslatorPattern.LinkBySctructure.POBySctructure))]
    public sealed class MapBySctructure : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BizTalkMapperSemanticTranslatorPattern.PurchaseOrder"" xmlns:ns0=""http://BizTalkMapperSemanticTranslatorPattern.POBySctructure"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PurchaseOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:PurchaseOrder"">
    <ns0:ExternalPO>
      <FromAddress>
        <xsl:value-of select=""From/text()"" />
      </FromAddress>
      <ToAddress>
        <xsl:value-of select=""To/text()"" />
      </ToAddress>
      <xsl:for-each select=""LineItems"">
        <LineOfItems>
          <xsl:for-each select=""Item"">
            <Item>
              <ProductName>
                <xsl:value-of select=""Product/text()"" />
              </ProductName>
              <ProductDescription>
                <xsl:value-of select=""Description/text()"" />
              </ProductDescription>
              <ProductPrice>
                <xsl:value-of select=""Price/text()"" />
              </ProductPrice>
              <productQuantity>
                <xsl:value-of select=""Quantity/text()"" />
              </productQuantity>
              <xsl:value-of select=""./text()"" />
            </Item>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </LineOfItems>
      </xsl:for-each>
    </ns0:ExternalPO>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder";
        
        private const global::BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkMapperSemanticTranslatorPattern.LinkBySctructure.POBySctructure";
        
        private const global::BizTalkMapperSemanticTranslatorPattern.LinkBySctructure.POBySctructure _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"BizTalkMapperSemanticTranslatorPattern.LinkBySctructure.POBySctructure";
                return _TrgSchemas;
            }
        }
    }
}
