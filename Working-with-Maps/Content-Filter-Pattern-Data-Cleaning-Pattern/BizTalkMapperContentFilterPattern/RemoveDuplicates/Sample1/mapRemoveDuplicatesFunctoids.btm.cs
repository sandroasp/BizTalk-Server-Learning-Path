namespace BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList", typeof(global::BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList", typeof(global::BizTalkMapperContentFilterPattern.RemoveDuplicates.Sample1.OrderList))]
    public sealed class mapRemoveDuplicatesFunctoids : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperContentFilterPattern.OrderList"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:OrderList"" />
  </xsl:template>
  <xsl:template match=""/ns0:OrderList"">
    <ns0:OrderList>
      <xsl:for-each select=""Order"">
        <xsl:variable name=""var:v1"" select=""userCSharp:IsDuplicate(string(OrderNumber/text()))"" />
        <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string($var:v1) , &quot;false&quot;)"" />
        <xsl:if test=""$var:v2"">
          <Order>
            <OrderNumber>
              <xsl:value-of select=""OrderNumber/text()"" />
            </OrderNumber>
            <OrderDate>
              <xsl:value-of select=""OrderDate/text()"" />
            </OrderDate>
            <CustomerName>
              <xsl:value-of select=""CustomerName/text()"" />
            </CustomerName>
            <CustomerAddress>
              <xsl:value-of select=""CustomerAddress/text()"" />
            </CustomerAddress>
            <Status>
              <xsl:value-of select=""Status/text()"" />
            </Status>
            <TotalAmount>
              <xsl:value-of select=""TotalAmount/text()"" />
            </TotalAmount>
            <Type>
              <xsl:value-of select=""Type/text()"" />
            </Type>
          </Order>
        </xsl:if>
      </xsl:for-each>
    </ns0:OrderList>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public System.Collections.Generic.List<string> duplicateList = new System.Collections.Generic.List<string>();
    
public bool IsDuplicate( string OrderNumber )
{
         if( duplicateList.Contains( OrderNumber ) )
            return true;

         duplicateList.Add( OrderNumber );
         return false;
}



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
