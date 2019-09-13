namespace UnitTestingFeatureWithMaps.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"UnitTestingFeatureWithMaps.Schemas.PeopleOrigin", typeof(global::UnitTestingFeatureWithMaps.Schemas.PeopleOrigin))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"UnitTestingFeatureWithMaps.Schemas.PeopleTarget", typeof(global::UnitTestingFeatureWithMaps.Schemas.PeopleTarget))]
    public sealed class LinksPerOrder : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://HowMapsWorks.PeopleOrigin"" xmlns:ns0=""http://HowMapsWorks.PeopleTarget"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PeopleOrigin"" />
  </xsl:template>
  <xsl:template match=""/s0:PeopleOrigin"">
    <ns0:PeopleTarget>
      <xsl:for-each select=""Client"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(Sex/text()) , &quot;F&quot;)"" />
        <xsl:if test=""$var:v1"">
          <Person>
            <Name>
              <xsl:value-of select=""Name/text()"" />
            </Name>
            <Sex>
              <xsl:value-of select=""Sex/text()"" />
            </Sex>
          </Person>
        </xsl:if>
      </xsl:for-each>
    </ns0:PeopleTarget>
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
        
        private const string _strSrcSchemasList0 = @"UnitTestingFeatureWithMaps.Schemas.PeopleOrigin";
        
        private const global::UnitTestingFeatureWithMaps.Schemas.PeopleOrigin _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"UnitTestingFeatureWithMaps.Schemas.PeopleTarget";
        
        private const global::UnitTestingFeatureWithMaps.Schemas.PeopleTarget _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"UnitTestingFeatureWithMaps.Schemas.PeopleOrigin";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"UnitTestingFeatureWithMaps.Schemas.PeopleTarget";
                return _TrgSchemas;
            }
        }
    }
}
