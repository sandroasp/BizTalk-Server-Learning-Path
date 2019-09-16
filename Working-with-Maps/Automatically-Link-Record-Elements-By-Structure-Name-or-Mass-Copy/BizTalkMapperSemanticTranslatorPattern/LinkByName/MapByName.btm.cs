namespace BizTalkMapperSemanticTranslatorPattern.LinkByName {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder", typeof(global::BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperSemanticTranslatorPattern.LinkByName.POByName", typeof(global::BizTalkMapperSemanticTranslatorPattern.LinkByName.POByName))]
    public sealed class MapByName : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperSemanticTranslatorPattern.POByName"" xmlns:s0=""http://BizTalkMapperSemanticTranslatorPattern.PurchaseOrder"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PurchaseOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:PurchaseOrder"">
    <ns0:PO>
      <xsl:for-each select=""LineItems"">
        <LineItems>
          <xsl:for-each select=""Item"">
            <Item>
              <Product>
                <xsl:value-of select=""Product/text()"" />
              </Product>
              <Description>
                <xsl:value-of select=""Description/text()"" />
              </Description>
              <Quantity>
                <xsl:value-of select=""Quantity/text()"" />
              </Quantity>
              <Price>
                <xsl:value-of select=""Price/text()"" />
              </Price>
              <xsl:value-of select=""./text()"" />
            </Item>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </LineItems>
      </xsl:for-each>
      <To>
        <xsl:value-of select=""To/text()"" />
      </To>
      <From>
        <xsl:value-of select=""From/text()"" />
      </From>
    </ns0:PO>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder";
        
        private const global::BizTalkMapperSemanticTranslatorPattern.MassCopy.PurchaseOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkMapperSemanticTranslatorPattern.LinkByName.POByName";
        
        private const global::BizTalkMapperSemanticTranslatorPattern.LinkByName.POByName _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"BizTalkMapperSemanticTranslatorPattern.LinkByName.POByName";
                return _TrgSchemas;
            }
        }
    }
}
