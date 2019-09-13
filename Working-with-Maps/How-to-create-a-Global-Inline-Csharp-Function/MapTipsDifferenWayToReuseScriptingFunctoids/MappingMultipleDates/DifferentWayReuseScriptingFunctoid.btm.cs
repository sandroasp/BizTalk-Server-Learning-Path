namespace MapTipsDifferenWayToReuseScriptingFunctoids.MappingMultipleDates {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.Order", typeof(global::MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.Order))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.SAPOrder", typeof(global::MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.SAPOrder))]
    public sealed class DifferentWayReuseScriptingFunctoid : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://MapTipsDifferenWayToReuseScriptingFunctoids.SAPOrder"" xmlns:s0=""http://MapTipsDifferenWayToReuseScriptingFunctoids.Order"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Order"" />
  </xsl:template>
  <xsl:template match=""/s0:Order"">
    <ns0:SAPOrder>
      <OrderID>
        <xsl:value-of select=""OrderHeader/OrderNumber/text()"" />
      </OrderID>
      <ClientId>
        <xsl:value-of select=""CustomDetails/Name/text()"" />
      </ClientId>
      <Dates>
        <xsl:variable name=""var:v1"" select=""userCSharp:FormatDate(string(OrderHeader/OrderDate/text()) , &quot;yyyyMMdd&quot; , &quot;dd/MM/yyyy&quot;)"" />
        <OrderDate>
          <xsl:value-of select=""$var:v1"" />
        </OrderDate>
        <xsl:variable name=""var:v2"" select=""userCSharp:FormatDate(string(OrderHeader/EstimatedDeliveryDate/text()) , &quot;yyyyMMdd&quot; , &quot;dd/MM/yyyy&quot;)"" />
        <EstimatedDeliveryDate>
          <xsl:value-of select=""$var:v2"" />
        </EstimatedDeliveryDate>
      </Dates>
      <Details>
        <xsl:for-each select=""OrderDetail/Item"">
          <Item>
            <ItemId>
              <xsl:value-of select=""ItemCustomerCode/text()"" />
            </ItemId>
            <xsl:variable name=""var:v3"" select=""userCSharp:ChangeDecimalSeparator(string(TotalAmount/text()))"" />
            <Total>
              <xsl:value-of select=""$var:v3"" />
            </Total>
            <UnitType>
              <xsl:value-of select=""UnitType/text()"" />
            </UnitType>
            <xsl:variable name=""var:v4"" select=""userCSharp:ChangeDecimalSeparator(string(Discount/text()))"" />
            <Discount>
              <xsl:value-of select=""$var:v4"" />
            </Discount>
            <Units>
              <xsl:value-of select=""NumberItems/text()"" />
            </Units>
          </Item>
        </xsl:for-each>
      </Details>
    </ns0:SAPOrder>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string FormatDate(string inputDate, string inputFormat, string outputFormat)
{
            System.DateTime date;
            if (System.DateTime.TryParseExact(inputDate, inputFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out date))
            {
                return date.ToString(outputFormat);
            }
            return """";
}

public string ChangeDecimalSeparator(string inputDate)
{
            return inputDate.Replace("","",""."");
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 2;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.Order";
        
        private const global::MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.Order _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.SAPOrder";
        
        private const global::MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.SAPOrder _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
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
                _SrcSchemas[0] = @"MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.Order";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MapTipsDifferenWayToReuseScriptingFunctoids.Schemas.SAPOrder";
                return _TrgSchemas;
            }
        }
    }
}
