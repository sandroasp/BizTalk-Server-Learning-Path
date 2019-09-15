namespace BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList", typeof(global::BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList", typeof(global::BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList))]
    public sealed class mapRemoveDuplicatesMuenchianMethod : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperContentFilterPattern.OrderList"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:OrderList"" />
  </xsl:template>
  <xsl:template match=""/ns0:OrderList"">
    <ns0:OrderList>
      <xsl:for-each select=""Order[generate-id(.)=generate-id(key('UniqueOrders',OrderNumber))]"">
        <Order>
          <xsl:copy-of select=""./@*"" />
          <xsl:copy-of select=""./*"" />
        </Order>
</xsl:for-each>
    </ns0:OrderList>
  </xsl:template>
  <xsl:key name=""UniqueOrders"" match=""Order"" use=""OrderNumber"" />
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList";
        
        private const global::BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList";
        
        private const global::BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList";
                return _TrgSchemas;
            }
        }
    }
}
