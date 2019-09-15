namespace LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.Families", typeof(global::LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.Families))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.SchoolApplicationForm", typeof(global::LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.SchoolApplicationForm))]
    public sealed class NestedFamiliesMapOptimized : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://LoopingPattern.SchoolApplicationForm"" xmlns:s0=""http://LoopingPattern.Families"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Families"" />
  </xsl:template>
  <xsl:template match=""/s0:Families"">
    <ns0:ApplicationForm>
      <xsl:for-each select=""Family"">
        <xsl:variable name=""var:v1"" select=""position()"" />
        <Form>
          <LineId>
            <xsl:value-of select=""$var:v1"" />
          </LineId>
          <TotalOfChildren>
  <xsl:value-of select=""count(Parents/Child)"" />
</TotalOfChildren>
          <Parents>
            <xsl:for-each select=""Parents/Name"">
              <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(@Sex) , &quot;M&quot;)"" />
              <xsl:variable name=""var:v4"" select=""userCSharp:LogicalNot(string($var:v2))"" />
              <Parent>
                <Name>
                  <xsl:value-of select=""./text()"" />
                </Name>
                <xsl:if test=""string($var:v2)='true'"">
                  <xsl:variable name=""var:v3"" select=""&quot;Father&quot;"" />
                  <Type>
                    <xsl:value-of select=""$var:v3"" />
                  </Type>
                </xsl:if>
                <xsl:if test=""string($var:v4)='true'"">
                  <xsl:variable name=""var:v5"" select=""&quot;Mother&quot;"" />
                  <Type>
                    <xsl:value-of select=""$var:v5"" />
                  </Type>
                </xsl:if>
              </Parent>
            </xsl:for-each>
          </Parents>
          <Children>
            <xsl:for-each select=""Parents/Child"">
              <Child>
                <Name>
                  <xsl:value-of select=""Name/text()"" />
                </Name>
                <Age>
                  <xsl:value-of select=""Age/text()"" />
                </Age>
                <Sex>
                  <xsl:value-of select=""Sex/text()"" />
                </Sex>
              </Child>
            </xsl:for-each>
          </Children>
        </Form>
      </xsl:for-each>
    </ns0:ApplicationForm>
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
        
        private const string _strSrcSchemasList0 = @"LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.Families";
        
        private const global::LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.Families _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.SchoolApplicationForm";
        
        private const global::LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.SchoolApplicationForm _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.Families";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern._01_LoppingTypes._06_NestedToNested.OtherExample.SchoolApplicationForm";
                return _TrgSchemas;
            }
        }
    }
}
