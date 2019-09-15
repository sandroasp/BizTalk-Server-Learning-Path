namespace WorkingWithConditions {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions.Conditions", typeof(global::WorkingWithConditions.Conditions))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions.ConditionsResult2", typeof(global::WorkingWithConditions.ConditionsResult2))]
    public sealed class MapConditionsSplitting : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://WorkingWithConditions.ConditionsResult2"" xmlns:s0=""http://WorkingWithConditions.Conditions"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Conditions"" />
  </xsl:template>
  <xsl:template match=""/s0:Conditions"">
    <ns0:ConditionsResultTwo>
      <xsl:for-each select=""Person"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(Role/text()) , &quot;CEO&quot;)"" />
        <xsl:variable name=""var:v2"" select=""string(Role/text())"" />
        <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq($var:v2 , &quot;Director&quot;)"" />
        <xsl:variable name=""var:v4"" select=""userCSharp:LogicalOr(string($var:v1) , string($var:v3))"" />
        <xsl:if test=""$var:v4"">
          <BusinessManagers>
            <Name>
              <xsl:value-of select=""Name/text()"" />
            </Name>
            <Role>
              <xsl:value-of select=""Role/text()"" />
            </Role>
          </BusinessManagers>
        </xsl:if>
      </xsl:for-each>
      <xsl:for-each select=""Person"">
        <xsl:variable name=""var:v5"" select=""string(Role/text())"" />
        <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq($var:v5 , &quot;Business Assistant&quot;)"" />
        <xsl:variable name=""var:v7"" select=""userCSharp:LogicalEq($var:v5 , &quot;Assistant&quot;)"" />
        <xsl:variable name=""var:v8"" select=""userCSharp:LogicalOr(string($var:v6) , string($var:v7))"" />
        <xsl:if test=""$var:v8"">
          <BusinessAssistant>
            <Name>
              <xsl:value-of select=""Name/text()"" />
            </Name>
            <Role>
              <xsl:value-of select=""Role/text()"" />
            </Role>
          </BusinessAssistant>
        </xsl:if>
      </xsl:for-each>
      <xsl:for-each select=""Person"">
        <xsl:variable name=""var:v9"" select=""string(Role/text())"" />
        <xsl:variable name=""var:v10"" select=""userCSharp:LogicalEq($var:v9 , &quot;CEO&quot;)"" />
        <xsl:variable name=""var:v11"" select=""userCSharp:LogicalNot(string($var:v10))"" />
        <xsl:variable name=""var:v12"" select=""userCSharp:LogicalEq($var:v9 , &quot;Director&quot;)"" />
        <xsl:variable name=""var:v13"" select=""userCSharp:LogicalNot(string($var:v12))"" />
        <xsl:variable name=""var:v14"" select=""userCSharp:LogicalEq($var:v9 , &quot;Business Assistant&quot;)"" />
        <xsl:variable name=""var:v15"" select=""userCSharp:LogicalNot(string($var:v14))"" />
        <xsl:variable name=""var:v16"" select=""userCSharp:LogicalEq($var:v9 , &quot;Assistant&quot;)"" />
        <xsl:variable name=""var:v17"" select=""userCSharp:LogicalNot(string($var:v16))"" />
        <xsl:variable name=""var:v18"" select=""userCSharp:LogicalAnd(string($var:v11) , string($var:v13) , string($var:v15) , string($var:v17))"" />
        <xsl:if test=""$var:v18"">
          <xsl:variable name=""var:v19"" select=""userCSharp:LogicalEq(string(AdditionalInfo/CivilStatus/text()) , &quot;M&quot;)"" />
          <xsl:variable name=""var:v21"" select=""userCSharp:LogicalNot(string($var:v19))"" />
          <Employee>
            <Name>
              <xsl:value-of select=""Name/text()"" />
            </Name>
            <Role>
              <xsl:value-of select=""Role/text()"" />
            </Role>
            <xsl:if test=""string($var:v19)='true'"">
              <xsl:variable name=""var:v20"" select=""&quot;Married&quot;"" />
              <CivilStatusDescription>
                <xsl:value-of select=""$var:v20"" />
              </CivilStatusDescription>
            </xsl:if>
            <xsl:if test=""string($var:v21)='true'"">
              <xsl:variable name=""var:v22"" select=""&quot;Single&quot;"" />
              <CivilStatusDescription>
                <xsl:value-of select=""$var:v22"" />
              </CivilStatusDescription>
            </xsl:if>
          </Employee>
        </xsl:if>
      </xsl:for-each>
    </ns0:ConditionsResultTwo>
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


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool LogicalAnd(string param0, string param1, string param2, string param3)
{
	return ValToBool(param0) && ValToBool(param1) && ValToBool(param2) && ValToBool(param3);
	return false;
}


public bool LogicalOr(string param0, string param1)
{
	return ValToBool(param0) || ValToBool(param1);
	return false;
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

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions.Conditions";
        
        private const global::WorkingWithConditions.Conditions _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions.ConditionsResult2";
        
        private const global::WorkingWithConditions.ConditionsResult2 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConditions.Conditions";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConditions.ConditionsResult2";
                return _TrgSchemas;
            }
        }
    }
}
