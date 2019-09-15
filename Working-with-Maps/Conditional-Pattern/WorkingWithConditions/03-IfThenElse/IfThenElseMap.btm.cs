namespace WorkingWithConditions._03_IfThenElse {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._03_IfThenElse.IfThenElseSource", typeof(global::WorkingWithConditions._03_IfThenElse.IfThenElseSource))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._03_IfThenElse.IfThenElseDestination", typeof(global::WorkingWithConditions._03_IfThenElse.IfThenElseDestination))]
    public sealed class IfThenElseMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://WorkingWithConditions.IfThenElseSource"" xmlns:ns0=""http://WorkingWithConditions.IfThenElseDestination"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:IfThenElseSource"" />
  </xsl:template>
  <xsl:template match=""/s0:IfThenElseSource"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(Person/Sex))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalNot(string($var:v1))"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalIsNumeric(string(Person/Age/text()))"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:LogicalNot(string($var:v5))"" />
    <ns0:IfThenElseDestination>
      <Name>
        <xsl:value-of select=""Person/Name/text()"" />
      </Name>
      <xsl:if test=""string($var:v1)='true'"">
        <xsl:variable name=""var:v2"" select=""Person/Sex/text()"" />
        <Sex>
          <xsl:value-of select=""$var:v2"" />
        </Sex>
      </xsl:if>
      <xsl:if test=""string($var:v3)='true'"">
        <xsl:variable name=""var:v4"" select=""&quot;N/D&quot;"" />
        <Sex>
          <xsl:value-of select=""$var:v4"" />
        </Sex>
      </xsl:if>
      <xsl:if test=""string($var:v5)='true'"">
        <xsl:variable name=""var:v6"" select=""Person/Age/text()"" />
        <Age>
          <xsl:value-of select=""$var:v6"" />
        </Age>
      </xsl:if>
      <xsl:if test=""string($var:v7)='true'"">
        <xsl:variable name=""var:v8"" select=""&quot;0&quot;"" />
        <Age>
          <xsl:value-of select=""$var:v8"" />
        </Age>
      </xsl:if>
    </ns0:IfThenElseDestination>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool LogicalIsNumeric(string val)
{
	return IsNumeric(val);
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
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions._03_IfThenElse.IfThenElseSource";
        
        private const global::WorkingWithConditions._03_IfThenElse.IfThenElseSource _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions._03_IfThenElse.IfThenElseDestination";
        
        private const global::WorkingWithConditions._03_IfThenElse.IfThenElseDestination _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConditions._03_IfThenElse.IfThenElseSource";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConditions._03_IfThenElse.IfThenElseDestination";
                return _TrgSchemas;
            }
        }
    }
}
