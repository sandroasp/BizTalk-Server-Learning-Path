namespace MappingWorkingWithMultipleOutputMessages {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MappingWorkingWithMultipleOutputMessages.CustomerOrder", typeof(global::MappingWorkingWithMultipleOutputMessages.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MappingWorkingWithMultipleOutputMessages.CRMOrder", typeof(global::MappingWorkingWithMultipleOutputMessages.CRMOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MappingWorkingWithMultipleOutputMessages.SAPOrder", typeof(global::MappingWorkingWithMultipleOutputMessages.SAPOrder))]
    public sealed class TransformOneToManyOrders : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns1=""http://MappingWorkingWithMultipleOutputMessages.CRMOrder"" xmlns:s0=""http://MappingWorkingWithMultipleOutputMessages.CustomerOrder"" xmlns:ns2=""http://MappingWorkingWithMultipleOutputMessages.SAPOrder"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerOrder"">
    <xsl:variable name=""var:v7"" select=""userCSharp:SetConstantValue(&quot;0&quot;)"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:Root>
      <OutputMessagePart_0>
        <ns1:CRMOrder>
          <OrderId>
            <xsl:value-of select=""OrderHeader/OrderNumber/text()"" />
          </OrderId>
          <GeneralInformation>
            <ClientName>
              <xsl:value-of select=""CustomerDetails/Name/text()"" />
            </ClientName>
            <ClientId>
              <xsl:value-of select=""CustomerDetails/Id/text()"" />
            </ClientId>
            <xsl:variable name=""var:v1"" select=""userCSharp:GetClientCurrency(string(CustomerDetails/Id/text()))"" />
            <Currency>
              <xsl:value-of select=""$var:v1"" />
            </Currency>
          </GeneralInformation>
          <Totals>
            <xsl:variable name=""var:v2"" select=""userCSharp:InitCumulativeSum(0)"" />
            <xsl:for-each select=""/s0:CustomerOrder/OrderDetails"">
              <xsl:variable name=""var:v3"" select=""userCSharp:GetItemPrice(string(ItemCustomerCode/text()))"" />
              <xsl:variable name=""var:v4"" select=""userCSharp:MathMultiply(string($var:v3) , string(TotalAmount/text()))"" />
              <xsl:variable name=""var:v5"" select=""userCSharp:AddToCumulativeSum(0,string($var:v4),&quot;1000&quot;)"" />
            </xsl:for-each>
            <xsl:variable name=""var:v6"" select=""userCSharp:GetCumulativeSum(0)"" />
            <Amount>
              <xsl:value-of select=""$var:v6"" />
            </Amount>
            <DiscountPercent>
              <xsl:value-of select=""$var:v7"" />
            </DiscountPercent>
            <DiscountAmount>
              <xsl:value-of select=""$var:v7"" />
            </DiscountAmount>
            <TransportationCosts>
              <xsl:value-of select=""$var:v7"" />
            </TransportationCosts>
            <TotalTax>
              <xsl:value-of select=""$var:v7"" />
            </TotalTax>
            <xsl:variable name=""var:v8"" select=""userCSharp:InitCumulativeSum(0)"" />
            <xsl:for-each select=""/s0:CustomerOrder/OrderDetails"">
              <xsl:variable name=""var:v9"" select=""string(ItemCustomerCode/text())"" />
              <xsl:variable name=""var:v10"" select=""userCSharp:GetItemPrice($var:v9)"" />
              <xsl:variable name=""var:v11"" select=""string(TotalAmount/text())"" />
              <xsl:variable name=""var:v12"" select=""userCSharp:MathMultiply(string($var:v10) , $var:v11)"" />
              <xsl:variable name=""var:v13"" select=""userCSharp:AddToCumulativeSum(0,string($var:v12),&quot;1000&quot;)"" />
            </xsl:for-each>
            <xsl:variable name=""var:v14"" select=""userCSharp:GetCumulativeSum(0)"" />
            <TotalAmount>
              <xsl:value-of select=""$var:v14"" />
            </TotalAmount>
          </Totals>
          <Addresses>
            <InvoicingAddress>
              <xsl:value-of select=""CustomerDetails/Address/text()"" />
            </InvoicingAddress>
            <ShippingAddress>
              <xsl:value-of select=""CustomerDetails/Address/text()"" />
            </ShippingAddress>
          </Addresses>
        </ns1:CRMOrder>
      </OutputMessagePart_0>
      <OutputMessagePart_1>
        <ns2:SAPOrder>
          <OrderId>
            <xsl:value-of select=""OrderHeader/OrderNumber/text()"" />
          </OrderId>
          <ClientId>
            <xsl:value-of select=""CustomerDetails/Id/text()"" />
          </ClientId>
          <Dates>
            <ProcessDate>
              <xsl:value-of select=""$var:v15"" />
            </ProcessDate>
            <OrderDate>
              <xsl:value-of select=""OrderHeader/OrderDate/text()"" />
            </OrderDate>
            <EstimatedDeliveryDate>
              <xsl:value-of select=""OrderHeader/EstimatedDeliveryDate/text()"" />
            </EstimatedDeliveryDate>
          </Dates>
          <xsl:for-each select=""OrderDetails"">
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
        </ns2:SAPOrder>
      </OutputMessagePart_1>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string GetClientCurrency(int clientId)
{
     //put the logic here, this is a sample
     if(clientId > 10000)
          return ""Dolar"";
     return ""Euro"";
}


public string SetConstantValue(string value)
{
	return value;
}


public int GetItemPrice(string itemCode)
{
      //this is a demo
      return 2;
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


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
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
        
        private const string _strTrgSchemasList0 = @"MappingWorkingWithMultipleOutputMessages.CRMOrder";
        
        private const global::MappingWorkingWithMultipleOutputMessages.CRMOrder _trgSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList1 = @"MappingWorkingWithMultipleOutputMessages.SAPOrder";
        
        private const global::MappingWorkingWithMultipleOutputMessages.SAPOrder _trgSchemaTypeReference1 = null;
        
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
                _SrcSchemas[0] = @"MappingWorkingWithMultipleOutputMessages.CustomerOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [2];
                _TrgSchemas[0] = @"MappingWorkingWithMultipleOutputMessages.CRMOrder";
                _TrgSchemas[1] = @"MappingWorkingWithMultipleOutputMessages.SAPOrder";
                return _TrgSchemas;
            }
        }
    }
}
