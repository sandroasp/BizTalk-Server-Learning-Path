namespace WorkingWithConditions._04_IfThenElseRecursiveRecords {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance", typeof(global::WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq", typeof(global::WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq))]
    public sealed class MapIfInsideLoop5 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperIFinLoppingRecord.OutputReq"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/GetPIArchiveDataResult"" />
  </xsl:template>
  <xsl:template match=""/GetPIArchiveDataResult"">
    <ns0:Req>
      <xsl:for-each select=""TimeSeries"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(@Path) , &quot;1&quot;)"" />
        <xsl:if test=""$var:v1"">
          <Quantity>
            <xsl:value-of select=""TimedValues/TimedValue/text()"" />
          </Quantity>
        </xsl:if>
      </xsl:for-each>
      <xsl:for-each select=""TimeSeries"">
        <xsl:variable name=""var:v2"" select=""string(@Path)"" />
        <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq($var:v2 , &quot;2&quot;)"" />
        <xsl:if test=""$var:v3"">
          <NRJQuantity>
            <xsl:value-of select=""TimedValues/TimedValue/text()"" />
          </NRJQuantity>
        </xsl:if>
      </xsl:for-each>
      <xsl:for-each select=""TimeSeries"">
        <xsl:variable name=""var:v4"" select=""string(@Path)"" />
        <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq($var:v4 , &quot;3&quot;)"" />
        <xsl:if test=""$var:v5"">
          <AvgCal>
            <xsl:value-of select=""TimedValues/TimedValue/text()"" />
          </AvgCal>
        </xsl:if>
      </xsl:for-each>
      <xsl:for-each select=""TimeSeries"">
        <xsl:variable name=""var:v6"" select=""string(@Path)"" />
        <xsl:variable name=""var:v7"" select=""userCSharp:LogicalEq($var:v6 , &quot;4&quot;)"" />
        <xsl:if test=""$var:v7"">
          <AvgDens>
            <xsl:value-of select=""TimedValues/TimedValue/text()"" />
          </AvgDens>
        </xsl:if>
      </xsl:for-each>
    </ns0:Req>
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
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance";
        
        private const global::WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq";
        
        private const global::WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq";
                return _TrgSchemas;
            }
        }
    }
}
