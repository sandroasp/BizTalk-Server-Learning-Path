namespace MuenchianGrouping.Sample1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MuenchianGrouping.InputOrder", typeof(global::MuenchianGrouping.InputOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MuenchianGrouping.OutputOrder", typeof(global::MuenchianGrouping.OutputOrder))]
    public sealed class MapOrderUsingCount : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://MuenchianGrouping.InputOrder"" xmlns:ns0=""http://MuenchianGrouping.OutputOrder"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:InputOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:InputOrder"">
    <ns0:OutputOrder>
      <xsl:for-each select=""Order[count(. | key('groups',OrderId)[1]) = 1]"">
			
			<!-- And let's do some sorting for good measure... -->
			<xsl:sort select=""OrderId"" order=""ascending"" />
			<Order>
				<OrderId>
				  <xsl:value-of select=""OrderId/text()"" />
			  </OrderId>
				<Items>
					<!-- Another loop... -->
					<xsl:for-each select=""key('groups',OrderId)"">
						<ItemId>
						  <xsl:value-of select=""ItemId"" />
						</ItemId>
					</xsl:for-each>
					
				</Items>
			</Order>
		  
	  </xsl:for-each>
    </ns0:OutputOrder>
  </xsl:template>
  <xsl:key name=""groups"" match=""Order"" use=""OrderId"" />
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MuenchianGrouping.InputOrder";
        
        private const global::MuenchianGrouping.InputOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MuenchianGrouping.OutputOrder";
        
        private const global::MuenchianGrouping.OutputOrder _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MuenchianGrouping.InputOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MuenchianGrouping.OutputOrder";
                return _TrgSchemas;
            }
        }
    }
}
