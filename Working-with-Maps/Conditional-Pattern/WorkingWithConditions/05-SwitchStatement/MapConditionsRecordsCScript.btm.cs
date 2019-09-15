namespace WorkingWithConditions.IfElseCondForMappingRecords {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions.Conditions", typeof(global::WorkingWithConditions.Conditions))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions.ConditionsResult2", typeof(global::WorkingWithConditions.ConditionsResult2))]
    public sealed class MapConditionsRecordsCScript : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://WorkingWithConditions.ConditionsResult2"" xmlns:s0=""http://WorkingWithConditions.Conditions"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Conditions"" />
  </xsl:template>
  <xsl:template match=""/s0:Conditions"">
    <ns0:ConditionsResultTwo>
      <xsl:for-each select=""Person"">
        <xsl:variable name=""var:v1"" select=""userCSharp:CheckIfIsManager(string(Role/text()))"" />
        <xsl:variable name=""var:v2"" select=""userCSharp:LogicalAnd(string($var:v1) , &quot;true&quot;)"" />
        <xsl:if test=""$var:v2"">
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
        <xsl:variable name=""var:v3"" select=""string(Role/text())"" />
        <xsl:variable name=""var:v4"" select=""userCSharp:CheckIfIsAssistant($var:v3)"" />
        <xsl:variable name=""var:v5"" select=""userCSharp:LogicalAnd(string($var:v4) , &quot;true&quot;)"" />
        <xsl:if test=""$var:v5"">
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
        <xsl:variable name=""var:v6"" select=""string(Role/text())"" />
        <xsl:variable name=""var:v7"" select=""userCSharp:CheckIfIsManager($var:v6)"" />
        <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNot(string($var:v7))"" />
        <xsl:variable name=""var:v9"" select=""userCSharp:CheckIfIsAssistant($var:v6)"" />
        <xsl:variable name=""var:v10"" select=""userCSharp:LogicalNot(string($var:v9))"" />
        <xsl:variable name=""var:v11"" select=""userCSharp:LogicalAnd(string($var:v8) , string($var:v10))"" />
        <xsl:if test=""$var:v11"">
          <Employee>
            <Name>
              <xsl:value-of select=""Name/text()"" />
            </Name>
            <Role>
              <xsl:value-of select=""Role/text()"" />
            </Role>
            <xsl:variable name=""var:v12"" select=""userCSharp:GetCivilStatusDescription(string(AdditionalInfo/CivilStatus/text()))"" />
            <CivilStatusDescription>
              <xsl:value-of select=""$var:v12"" />
            </CivilStatusDescription>
          </Employee>
        </xsl:if>
      </xsl:for-each>
    </ns0:ConditionsResultTwo>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool CheckIfIsManager(string role)
{
     if(String.Compare(""CEO"", role, true) == 0 || String.Compare(""R&D Director"", role, true) == 0)
         return true;
     return false;
}

public bool CheckIfIsAssistant(string role)
{
     if(String.Compare(""Business Assistant"", role, true) == 0 || String.Compare(""Assistant"", role, true) == 0)
         return true;
     return false;
}

public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public string GetCivilStatusDescription(string status)
{
     if(String.IsNullOrEmpty(status))
         return ""unknown"";
     if(String.Compare(""M"", status, true) == 0)
         return ""Married"";
     return ""Single"";
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
