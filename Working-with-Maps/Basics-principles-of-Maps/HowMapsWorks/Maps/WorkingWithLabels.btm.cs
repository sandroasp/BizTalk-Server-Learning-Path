namespace HowMapsWorks.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowMapsWorks.Schemas.PersonOrigin", typeof(global::HowMapsWorks.Schemas.PersonOrigin))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowMapsWorks.Schemas.PersonTarget", typeof(global::HowMapsWorks.Schemas.PersonTarget))]
    public sealed class WorkingWithLabels : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://HowMapsWorks.PersonOrigin"" xmlns:ns0=""http://HowMapsWorks.PersonTarget"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PersonOrigin"" />
  </xsl:template>
  <xsl:template match=""/s0:PersonOrigin"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringLeft(string(FirstName/text()) , &quot;4&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringUpperCase(string($var:v1))"" />
    <ns0:PersonTarget>
      <FullName>
        <xsl:value-of select=""$var:v2"" />
      </FullName>
    </ns0:PersonTarget>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
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
        
        private const string _strSrcSchemasList0 = @"HowMapsWorks.Schemas.PersonOrigin";
        
        private const global::HowMapsWorks.Schemas.PersonOrigin _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"HowMapsWorks.Schemas.PersonTarget";
        
        private const global::HowMapsWorks.Schemas.PersonTarget _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"HowMapsWorks.Schemas.PersonOrigin";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"HowMapsWorks.Schemas.PersonTarget";
                return _TrgSchemas;
            }
        }
    }
}
