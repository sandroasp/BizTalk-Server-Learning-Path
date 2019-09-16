namespace HowToSendOrchestrationVariablesIntoMaps.UsingFunctoid {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToSendOrchestrationVariablesIntoMaps.Order", typeof(global::HowToSendOrchestrationVariablesIntoMaps.Order))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToSendOrchestrationVariablesIntoMaps.SAPOrder", typeof(global::HowToSendOrchestrationVariablesIntoMaps.SAPOrder))]
    public sealed class OrderToSAPOrderAccessOrcVarFunctoids : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""http://HowToSendOrchestrationVariablesIntoMaps.SAPOrder"" xmlns:s0=""http://HowToSendOrchestrationVariablesIntoMaps.Order"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Order"" />
  </xsl:template>
  <xsl:template match=""/s0:Order"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:SAPOrder>
      <OrderId>
        <xsl:value-of select=""Orderheader/OrderNumber/text()"" />
      </OrderId>
      <ClientId>
        <xsl:value-of select=""CustomerDetails/Id/text()"" />
      </ClientId>
      <Dates>
        <ProcessDate>
          <xsl:value-of select=""$var:v1"" />
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
      <AdditionalInfo>
        <xsl:variable name=""var:v2"" select=""ScriptNS0:RetrieveVariable(&quot;varDiscountType&quot;)"" />
        <DiscountType>
          <xsl:value-of select=""$var:v2"" />
        </DiscountType>
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
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""OrchVarRetrieverFunctoid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=ac2986086295abc5"" ClassName=""OrchVarRetrieverFunctoid.OrchVarRetriever"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"HowToSendOrchestrationVariablesIntoMaps.Order";
        
        private const global::HowToSendOrchestrationVariablesIntoMaps.Order _srcSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"HowToSendOrchestrationVariablesIntoMaps.Order";
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
