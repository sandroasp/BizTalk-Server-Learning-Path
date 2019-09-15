namespace WorkingWithConditions {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions.Conditions", typeof(global::WorkingWithConditions.Conditions))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions.ConditionsResult", typeof(global::WorkingWithConditions.ConditionsResult))]
    public sealed class MapConditions : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://WorkingWithConditions.ConditionsResult"" xmlns:s0=""http://WorkingWithConditions.Conditions"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Conditions"" />
  </xsl:template>
  <xsl:template match=""/s0:Conditions"">
    <ns0:ConditionsResult>
      <xsl:for-each select=""Person"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(Role/text()) , &quot;CEO&quot;)"" />
        <xsl:if test=""$var:v1"">
          <xsl:variable name=""var:v2"" select=""string(Role/text())"" />
          <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq($var:v2 , &quot;CEO&quot;)"" />
          <CEO>
            <xsl:if test=""string($var:v3)='true'"">
              <xsl:variable name=""var:v4"" select=""Name/text()"" />
              <Name>
                <xsl:value-of select=""$var:v4"" />
              </Name>
            </xsl:if>
          </CEO>
        </xsl:if>
      </xsl:for-each>
      <CEOList>
        <xsl:variable name=""var:vCEOCount"" select=""count(//Person[Role='CEO'])"" />
        <xsl:if test=""$var:vCEOCount &gt; 0"">
  <CEOList> 
    <xsl:for-each select=""//Person[Role='CEO']"">
      <Name>
        <xsl:value-of select=""Name/text()"" /> 
      </Name>
    </xsl:for-each>
  </CEOList>
</xsl:if>
      </CEOList>
      <xsl:for-each select=""Person"">
        <xsl:variable name=""var:v5"" select=""string(Role/text())"" />
        <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq($var:v5 , &quot;Employee&quot;)"" />
        <xsl:if test=""$var:v6"">
          <xsl:variable name=""var:v8"" select=""userCSharp:LogicalExistence(boolean(AdditionalInfo/Age))"" />
          <Employee>
            <xsl:if test=""string($var:v6)='true'"">
              <xsl:variable name=""var:v7"" select=""Name/text()"" />
              <Name>
                <xsl:value-of select=""$var:v7"" />
              </Name>
            </xsl:if>
            <Company>
              <xsl:value-of select=""Company/text()"" />
            </Company>
            <PersonalData>
              <xsl:if test=""string($var:v8)='true'"">
                <xsl:variable name=""var:v9"" select=""AdditionalInfo/Age/text()"" />
                <Age>
                  <xsl:value-of select=""$var:v9"" />
                </Age>
              </xsl:if>
              <xsl:variable name=""var:vStatus"" select=""AdditionalInfo/CivilStatus/text()"" />
              <xsl:if test=""$var:vStatus != ''"">
   <CivilStatus>
      <xsl:value-of select=""$var:vStatus"" /> 
   </CivilStatus>
</xsl:if>
            </PersonalData>
          </Employee>
        </xsl:if>
      </xsl:for-each>
    </ns0:ConditionsResult>
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


public bool LogicalExistence(bool val)
{
	return val;
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
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions.Conditions";
        
        private const global::WorkingWithConditions.Conditions _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions.ConditionsResult";
        
        private const global::WorkingWithConditions.ConditionsResult _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"WorkingWithConditions.ConditionsResult";
                return _TrgSchemas;
            }
        }
    }
}
