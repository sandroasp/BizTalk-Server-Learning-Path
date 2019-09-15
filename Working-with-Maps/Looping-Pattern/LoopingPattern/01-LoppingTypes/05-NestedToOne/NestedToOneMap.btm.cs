namespace LoopingPattern._01_LoppingTypes._05_NestedToOne {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._05_NestedToOne.NestedPurchaseOrder", typeof(global::LoopingPattern._01_LoppingTypes._05_NestedToOne.NestedPurchaseOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._05_NestedToOne.OrderSimple", typeof(global::LoopingPattern._01_LoppingTypes._05_NestedToOne.OrderSimple))]
    public sealed class NestedToOnemap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://LoopingPattern.OrderSimple"" xmlns:s0=""http://LoopingPattern.NestedPurchaseOrder"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PurchaseOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:PurchaseOrder"">
    <xsl:variable name=""var:v7"" select=""count(/s0:PurchaseOrder/Items/Item)"" />
    <ns0:Order>
      <xsl:if test=""@OrderDate"">
        <OrderDate>
          <xsl:value-of select=""@OrderDate"" />
        </OrderDate>
      </xsl:if>
      <xsl:for-each select=""NAD"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(PartyIdentifier/text()) , &quot;buyer&quot;)"" />
        <xsl:if test=""$var:v1"">
          <Client>
            <xsl:value-of select=""Name/text()"" />
          </Client>
        </xsl:if>
      </xsl:for-each>
      <xsl:for-each select=""NAD"">
        <xsl:for-each select=""Address"">
          <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(Type/text()) , &quot;VA&quot;)"" />
          <xsl:if test=""$var:v2"">
            <ShipTo>
              <xsl:if test=""Contact"">
                <Contact>
                  <xsl:value-of select=""Contact/text()"" />
                </Contact>
              </xsl:if>
              <Country>
                <xsl:value-of select=""Country/text()"" />
              </Country>
              <Street>
                <xsl:value-of select=""Street/text()"" />
              </Street>
              <City>
                <xsl:value-of select=""City/text()"" />
              </City>
              <Zip>
                <xsl:value-of select=""Zip/text()"" />
              </Zip>
            </ShipTo>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""NAD"">
        <xsl:for-each select=""Address"">
          <xsl:variable name=""var:v3"" select=""string(Type/text())"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;BY&quot;)"" />
          <xsl:if test=""$var:v4"">
            <BillTo>
              <xsl:if test=""Contact"">
                <Contact>
                  <xsl:value-of select=""Contact/text()"" />
                </Contact>
              </xsl:if>
              <Country>
                <xsl:value-of select=""Country/text()"" />
              </Country>
              <Street>
                <xsl:value-of select=""Street/text()"" />
              </Street>
              <City>
                <xsl:value-of select=""City/text()"" />
              </City>
              <Zip>
                <xsl:value-of select=""Zip/text()"" />
              </Zip>
            </BillTo>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""NAD"">
        <xsl:for-each select=""Address"">
          <xsl:variable name=""var:v5"" select=""string(Type/text())"" />
          <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq($var:v5 , &quot;SU&quot;)"" />
          <xsl:if test=""$var:v6"">
            <ShipFrom>
              <Country>
                <xsl:value-of select=""Country/text()"" />
              </Country>
              <Street>
                <xsl:value-of select=""Street/text()"" />
              </Street>
              <City>
                <xsl:value-of select=""City/text()"" />
              </City>
              <Zip>
                <xsl:value-of select=""Zip/text()"" />
              </Zip>
            </ShipFrom>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
      <Items>
        <ItemLines>
          <xsl:value-of select=""$var:v7"" />
        </ItemLines>
        <xsl:for-each select=""Items/Item"">
          <Item>
            <PartNum>
              <xsl:value-of select=""PartNum/text()"" />
            </PartNum>
            <ProductName>
              <xsl:value-of select=""ProductName/text()"" />
            </ProductName>
            <Quantity>
              <xsl:value-of select=""Quantity/text()"" />
            </Quantity>
          </Item>
        </xsl:for-each>
      </Items>
    </ns0:Order>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
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
        
        private const string _strSrcSchemasList0 = @"LoopingPattern._01_LoppingTypes._05_NestedToOne.NestedPurchaseOrder";
        
        private const global::LoopingPattern._01_LoppingTypes._05_NestedToOne.NestedPurchaseOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern._01_LoppingTypes._05_NestedToOne.OrderSimple";
        
        private const global::LoopingPattern._01_LoppingTypes._05_NestedToOne.OrderSimple _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern._01_LoppingTypes._05_NestedToOne.NestedPurchaseOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern._01_LoppingTypes._05_NestedToOne.OrderSimple";
                return _TrgSchemas;
            }
        }
    }
}
