namespace ExternalCustomXSLTvsBizTalkMapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ExternalCustomXSLTvsBizTalkMapper.Order", typeof(global::ExternalCustomXSLTvsBizTalkMapper.Order))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ExternalCustomXSLTvsBizTalkMapper.SAPOrder", typeof(global::ExternalCustomXSLTvsBizTalkMapper.SAPOrder))]
    public sealed class OrderToSAPOrder : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://ExternalCustomXSLTvsBizTalkMapper.SAPOrder"" xmlns:s0=""http://ExternalCustomXSLTvsBizTalkMapper.Order"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Order"" />
  </xsl:template>
  <xsl:template match=""/s0:Order"">
    <xsl:variable name=""var:v1"" select=""userCSharp:GetCurrentDateTime()"" />
    <SAPOrder>
      <OrderId>
        <xsl:value-of select=""Orderheader/OrderNumber/text()"" />
      </OrderId>
      <ClientId>
        <xsl:text>1</xsl:text>
      </ClientId>
      <Dates>
        <ProcessDate>
         2013-09-23T15:06:54
        </ProcessDate>
        <OrderDate>
          <xsl:value-of select=""Orderheader/OrderDate/text()"" />
        </OrderDate>
        <EstimatedDeliveryDate>
          <xsl:value-of select=""Orderheader/EstimatedDeliveryDate/text()"" />
        </EstimatedDeliveryDate>
      </Dates>
      <Details>
        <ItemId>
          <xsl:value-of select=""OrderDetails/ItemCustomerCode/text()"" />
        </ItemId>
        <Units>
          <xsl:value-of select=""OrderDetails/TotalAmount/text()"" />
        </Units>
        <UnitType>
          <xsl:value-of select=""OrderDetails/UnitType/text()"" />
        </UnitType>
      </Details>
</SAPOrder>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string GetCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ExternalCustomXSLTvsBizTalkMapper.Order";
        
        private const global::ExternalCustomXSLTvsBizTalkMapper.Order _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ExternalCustomXSLTvsBizTalkMapper.SAPOrder";
        
        private const global::ExternalCustomXSLTvsBizTalkMapper.SAPOrder _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"ExternalCustomXSLTvsBizTalkMapper.Order";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ExternalCustomXSLTvsBizTalkMapper.SAPOrder";
                return _TrgSchemas;
            }
        }
    }
}
