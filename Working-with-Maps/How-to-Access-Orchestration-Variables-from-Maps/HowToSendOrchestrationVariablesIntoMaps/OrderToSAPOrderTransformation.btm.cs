namespace HowToSendOrchestrationVariablesIntoMaps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToSendOrchestrationVariablesIntoMaps.Order", typeof(global::HowToSendOrchestrationVariablesIntoMaps.Order))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport", typeof(global::HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToSendOrchestrationVariablesIntoMaps.SAPOrder", typeof(global::HowToSendOrchestrationVariablesIntoMaps.SAPOrder))]
    public sealed class OrderToSAPOrderTransformation : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s1 userCSharp"" version=""1.0"" xmlns:ns0=""http://HowToSendOrchestrationVariablesIntoMaps.SAPOrder"" xmlns:s0=""http://HowToSendOrchestrationVariablesIntoMaps.Order"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s1=""http://HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:SAPOrder>
      <OrderId>
        <xsl:value-of select=""InputMessagePart_0/s0:Order/Orderheader/OrderNumber/text()"" />
      </OrderId>
      <ClientId>
        <xsl:value-of select=""InputMessagePart_0/s0:Order/CustomerDetails/Id/text()"" />
      </ClientId>
      <Dates>
        <ProcessDate>
          <xsl:value-of select=""$var:v1"" />
        </ProcessDate>
        <OrderDate>
          <xsl:value-of select=""InputMessagePart_0/s0:Order/Orderheader/OrderDate/text()"" />
        </OrderDate>
        <EstimatedDeliveryDate>
          <xsl:value-of select=""InputMessagePart_0/s0:Order/Orderheader/EstimatedDeliveryDate/text()"" />
        </EstimatedDeliveryDate>
      </Dates>
      <Details>
        <ItemId>
          <xsl:value-of select=""InputMessagePart_0/s0:Order/OrderDetails/ItemCustomerCode/text()"" />
        </ItemId>
        <Units>
          <xsl:value-of select=""InputMessagePart_0/s0:Order/OrderDetails/TotalAmount/text()"" />
        </Units>
        <UnitType>
          <xsl:value-of select=""InputMessagePart_0/s0:Order/OrderDetails/UnitType/text()"" />
        </UnitType>
      </Details>
      <AdditionalInfo>
        <xsl:if test=""InputMessagePart_1/s1:Support/HasDiscount/text()='true'"">
          <xsl:variable name=""var:v2"" select=""InputMessagePart_1/s1:Support/DiscountType/text()"" />
          <DiscountType>
            <xsl:value-of select=""$var:v2"" />
          </DiscountType>
        </xsl:if>
      </AdditionalInfo>
    </ns0:SAPOrder>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
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
        
        private const string _strSrcSchemasList0 = @"HowToSendOrchestrationVariablesIntoMaps.Order";
        
        private const global::HowToSendOrchestrationVariablesIntoMaps.Order _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport";
        
        private const global::HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"HowToSendOrchestrationVariablesIntoMaps.SAPOrder";
        
        private const global::HowToSendOrchestrationVariablesIntoMaps.SAPOrder _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"HowToSendOrchestrationVariablesIntoMaps.Order";
                _SrcSchemas[1] = @"HowToSendOrchestrationVariablesIntoMaps.OrchestrationSupport";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"HowToSendOrchestrationVariablesIntoMaps.SAPOrder";
                return _TrgSchemas;
            }
        }
    }
}
