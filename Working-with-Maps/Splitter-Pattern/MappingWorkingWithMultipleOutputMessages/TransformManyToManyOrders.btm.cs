namespace MappingWorkingWithMultipleOutputMessages {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MappingWorkingWithMultipleOutputMessages.CustomerOrder", typeof(global::MappingWorkingWithMultipleOutputMessages.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MappingWorkingWithMultipleOutputMessages.OrchestrationSupport", typeof(global::MappingWorkingWithMultipleOutputMessages.OrchestrationSupport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MappingWorkingWithMultipleOutputMessages.SAPOrder", typeof(global::MappingWorkingWithMultipleOutputMessages.SAPOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MappingWorkingWithMultipleOutputMessages.CRMOrder", typeof(global::MappingWorkingWithMultipleOutputMessages.CRMOrder))]
    public sealed class TransformManyToManyOrders : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s1=""http://MappingWorkingWithMultipleOutputMessages.OrchestrationSupport"" xmlns:ns0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns2=""http://MappingWorkingWithMultipleOutputMessages.CRMOrder"" xmlns:s0=""http://MappingWorkingWithMultipleOutputMessages.CustomerOrder"" xmlns:ns1=""http://MappingWorkingWithMultipleOutputMessages.SAPOrder"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Root"" />
  </xsl:template>
  <xsl:template match=""/ns0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v16"" select=""string(InputMessagePart_1/s1:OrchestrationSupport/DiscountType/text())"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:SetConstantValue(&quot;0.00&quot;)"" />
    <ns0:Root>
      <OutputMessagePart_0>
        <ns1:SAPOrder>
          <OrderId>
            <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/OrderHeader/OrderNumber/text()"" />
          </OrderId>
          <ClientId>
            <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/CustomerDetails/Id/text()"" />
          </ClientId>
          <Dates>
            <ProcessDate>
              <xsl:value-of select=""$var:v1"" />
            </ProcessDate>
            <OrderDate>
              <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/OrderHeader/OrderDate/text()"" />
            </OrderDate>
            <EstimatedDeliveryDate>
              <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/OrderHeader/EstimatedDeliveryDate/text()"" />
            </EstimatedDeliveryDate>
          </Dates>
          <xsl:for-each select=""InputMessagePart_0/s0:CustomerOrder/OrderDetails"">
            <Details>
              <ItemId>
                <xsl:value-of select=""ItemCustomerCode/text()"" />
              </ItemId>
              <Units>
                <xsl:value-of select=""TotalAmount/text()"" />
              </Units>
              <UnitType>
                <xsl:value-of select=""UnitType/text()"" />
              </UnitType>
            </Details>
          </xsl:for-each>
        </ns1:SAPOrder>
      </OutputMessagePart_0>
      <OutputMessagePart_1>
        <ns2:CRMOrder>
          <OrderId>
            <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/OrderHeader/OrderNumber/text()"" />
          </OrderId>
          <GeneralInformation>
            <ClientName>
              <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/CustomerDetails/Name/text()"" />
            </ClientName>
            <ClientId>
              <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/CustomerDetails/Id/text()"" />
            </ClientId>
            <xsl:variable name=""var:v2"" select=""userCSharp:GetClientCurrency(string(InputMessagePart_0/s0:CustomerOrder/CustomerDetails/Id/text()))"" />
            <Currency>
              <xsl:value-of select=""$var:v2"" />
            </Currency>
          </GeneralInformation>
          <Totals>
            <xsl:variable name=""var:v3"" select=""userCSharp:InitCumulativeSum(0)"" />
            <xsl:for-each select=""/ns0:Root/InputMessagePart_0/s0:CustomerOrder/OrderDetails"">
              <xsl:variable name=""var:v4"" select=""userCSharp:GetItemPrice(string(ItemCustomerCode/text()))"" />
              <xsl:variable name=""var:v5"" select=""userCSharp:MathMultiply(string($var:v4) , string(TotalAmount/text()))"" />
              <xsl:variable name=""var:v6"" select=""userCSharp:AddToCumulativeSum(0,string($var:v5),&quot;1000&quot;)"" />
            </xsl:for-each>
            <xsl:variable name=""var:v7"" select=""userCSharp:GetCumulativeSum(0)"" />
            <Amount>
              <xsl:value-of select=""$var:v7"" />
            </Amount>
            <xsl:variable name=""var:v8"" select=""userCSharp:MyConcat(string(InputMessagePart_1/s1:OrchestrationSupport/HasDiscount/text()) , string(InputMessagePart_1/s1:OrchestrationSupport/DiscountType/text()))"" />
            <DiscountPercent>
              <xsl:value-of select=""$var:v8"" />
            </DiscountPercent>
            <xsl:variable name=""var:v9"" select=""userCSharp:InitCumulativeSum(0)"" />
            <xsl:for-each select=""/ns0:Root/InputMessagePart_0/s0:CustomerOrder/OrderDetails"">
              <xsl:variable name=""var:v10"" select=""string(ItemCustomerCode/text())"" />
              <xsl:variable name=""var:v11"" select=""userCSharp:GetItemPrice($var:v10)"" />
              <xsl:variable name=""var:v12"" select=""string(TotalAmount/text())"" />
              <xsl:variable name=""var:v13"" select=""userCSharp:MathMultiply(string($var:v11) , $var:v12)"" />
              <xsl:variable name=""var:v14"" select=""userCSharp:AddToCumulativeSum(0,string($var:v13),&quot;1000&quot;)"" />
            </xsl:for-each>
            <xsl:variable name=""var:v15"" select=""userCSharp:GetCumulativeSum(0)"" />
            <xsl:variable name=""var:v17"" select=""userCSharp:GetTotalDiscount(string($var:v15) , $var:v16)"" />
            <DiscountAmount>
              <xsl:value-of select=""$var:v17"" />
            </DiscountAmount>
            <TransportationCosts>
              <xsl:value-of select=""$var:v18"" />
            </TransportationCosts>
            <TotalTax>
              <xsl:value-of select=""$var:v18"" />
            </TotalTax>
            <xsl:variable name=""var:v19"" select=""userCSharp:InitCumulativeSum(0)"" />
            <xsl:for-each select=""/ns0:Root/InputMessagePart_0/s0:CustomerOrder/OrderDetails"">
              <xsl:variable name=""var:v20"" select=""string(ItemCustomerCode/text())"" />
              <xsl:variable name=""var:v21"" select=""userCSharp:GetItemPrice($var:v20)"" />
              <xsl:variable name=""var:v22"" select=""string(TotalAmount/text())"" />
              <xsl:variable name=""var:v23"" select=""userCSharp:MathMultiply(string($var:v21) , $var:v22)"" />
              <xsl:variable name=""var:v24"" select=""userCSharp:AddToCumulativeSum(0,string($var:v23),&quot;1000&quot;)"" />
            </xsl:for-each>
            <xsl:variable name=""var:v25"" select=""userCSharp:GetCumulativeSum(0)"" />
            <xsl:variable name=""var:v26"" select=""userCSharp:GetTotalAmount(string($var:v25) , $var:v16)"" />
            <TotalAmount>
              <xsl:value-of select=""$var:v26"" />
            </TotalAmount>
          </Totals>
          <Addresses>
            <InvoicingAddress>
              <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/CustomerDetails/Address/text()"" />
            </InvoicingAddress>
            <ShippingAddress>
              <xsl:value-of select=""InputMessagePart_0/s0:CustomerOrder/CustomerDetails/Address/text()"" />
            </ShippingAddress>
          </Addresses>
        </ns2:CRMOrder>
      </OutputMessagePart_1>
    </ns0:Root>
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


public string GetClientCurrency(int clientId)
{
     //put the logic here, this is a sample
     if(clientId > 10000)
          return ""Dolar"";
     return ""Euro"";
}


public int GetItemPrice(string itemCode)
{
      //this is a demo
      return 2;
}


public string MathMultiply(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 1;
	bool first = true;
	foreach (string obj in listValues)
	{
		double d = 0;
		if (IsNumeric(obj, ref d))
		{
			if (first)
			{
				first = false;
				ret = d;
			}
			else
			{
				ret *= d;
			}
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetTotalDiscount(int total, int discountPercent)
{
     if(discountPercent == 0)
        return ""0"";
     double totalDiscount = 0;
     totalDiscount = total * (double)discountPercent / 100;
     return totalDiscount.ToString();
}


public string GetTotalAmount(int total, int discountPercent)
{
     double totalWithDiscount = 0;
     totalWithDiscount = total * (1 - ((double)discountPercent / 100));
     return totalWithDiscount.ToString();
}


public string MyConcat(bool hasDiscount, int discountPercent)
{
      if (hasDiscount == false)
          return ""0%"";
      return discountPercent.ToString() + ""%"";
}


public string SetConstantValue(string value)
{
	return value;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MappingWorkingWithMultipleOutputMessages.CustomerOrder";
        
        private const global::MappingWorkingWithMultipleOutputMessages.CustomerOrder _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MappingWorkingWithMultipleOutputMessages.OrchestrationSupport";
        
        private const global::MappingWorkingWithMultipleOutputMessages.OrchestrationSupport _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MappingWorkingWithMultipleOutputMessages.SAPOrder";
        
        private const global::MappingWorkingWithMultipleOutputMessages.SAPOrder _trgSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList1 = @"MappingWorkingWithMultipleOutputMessages.CRMOrder";
        
        private const global::MappingWorkingWithMultipleOutputMessages.CRMOrder _trgSchemaTypeReference1 = null;
        
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
                _SrcSchemas[0] = @"MappingWorkingWithMultipleOutputMessages.CustomerOrder";
                _SrcSchemas[1] = @"MappingWorkingWithMultipleOutputMessages.OrchestrationSupport";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [2];
                _TrgSchemas[0] = @"MappingWorkingWithMultipleOutputMessages.SAPOrder";
                _TrgSchemas[1] = @"MappingWorkingWithMultipleOutputMessages.CRMOrder";
                return _TrgSchemas;
            }
        }
    }
}
