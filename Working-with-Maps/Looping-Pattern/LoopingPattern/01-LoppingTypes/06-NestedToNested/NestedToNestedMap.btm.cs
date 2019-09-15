namespace LoopingPattern._01_LoppingTypes._06_NestedToNested {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._06_NestedToNested.NestedAccount", typeof(global::LoopingPattern._01_LoppingTypes._06_NestedToNested.NestedAccount))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._06_NestedToNested.CreateAccount", typeof(global::LoopingPattern._01_LoppingTypes._06_NestedToNested.CreateAccount))]
    public sealed class NestedToNestedMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://LoopingPattern.CreateAccount"" xmlns:s0=""http://LoopingPattern.NestedAccount"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:NestedAccount"" />
  </xsl:template>
  <xsl:template match=""/s0:NestedAccount"">
    <ns0:CreateAccount>
      <xsl:for-each select=""Account"">
        <NewAccount>
          <AccountName>
            <xsl:value-of select=""AccountName/text()"" />
          </AccountName>
          <AccountId>
            <xsl:value-of select=""AccountId/text()"" />
          </AccountId>
          <xsl:if test=""AccountBuild/@AccountBuildId"">
            <AccountBuildId>
              <xsl:value-of select=""AccountBuild/@AccountBuildId"" />
            </AccountBuildId>
          </xsl:if>
          <xsl:for-each select=""AccountBuild/AccountProduct"">
            <AssociatedProduct>
              <AccountProductId>
                <xsl:value-of select=""AccountProductId/text()"" />
              </AccountProductId>
              <ProductId>
                <xsl:value-of select=""ProductId/text()"" />
              </ProductId>
            </AssociatedProduct>
          </xsl:for-each>
        </NewAccount>
      </xsl:for-each>
    </ns0:CreateAccount>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"LoopingPattern._01_LoppingTypes._06_NestedToNested.NestedAccount";
        
        private const global::LoopingPattern._01_LoppingTypes._06_NestedToNested.NestedAccount _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern._01_LoppingTypes._06_NestedToNested.CreateAccount";
        
        private const global::LoopingPattern._01_LoppingTypes._06_NestedToNested.CreateAccount _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern._01_LoppingTypes._06_NestedToNested.NestedAccount";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern._01_LoppingTypes._06_NestedToNested.CreateAccount";
                return _TrgSchemas;
            }
        }
    }
}
