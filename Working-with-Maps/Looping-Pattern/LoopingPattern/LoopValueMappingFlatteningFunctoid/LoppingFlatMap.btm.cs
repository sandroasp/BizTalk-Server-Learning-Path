namespace LoopingPattern.LoopValueMappingFlatteningFunctoid {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.input", typeof(global::LoopingPattern.input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat", typeof(global::LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat))]
    public sealed class LoppingFlatMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://LoopingPattern.InputSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Root"" />
  </xsl:template>
  <xsl:template match=""/ns0:Root"">
    <ns0:Root>
      <xsl:for-each select=""Record"">
        <Record>
          <xsl:for-each select=""Field"">
            <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(@Name) , &quot;Param1&quot;)"" />
            <xsl:if test=""string($var:v1)='true'"">
              <xsl:variable name=""var:v2"" select=""@Value"" />
              <xsl:attribute name=""Param1"">
                <xsl:value-of select=""$var:v2"" />
              </xsl:attribute>
            </xsl:if>
          </xsl:for-each>
          <xsl:for-each select=""Field"">
            <xsl:variable name=""var:v3"" select=""string(@Name)"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;Param2&quot;)"" />
            <xsl:if test=""string($var:v4)='true'"">
              <xsl:variable name=""var:v5"" select=""@Value"" />
              <xsl:attribute name=""Param2"">
                <xsl:value-of select=""$var:v5"" />
              </xsl:attribute>
            </xsl:if>
          </xsl:for-each>
          <xsl:for-each select=""Field"">
            <xsl:variable name=""var:v6"" select=""string(@Name)"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:LogicalEq($var:v6 , &quot;Param3&quot;)"" />
            <xsl:if test=""string($var:v7)='true'"">
              <xsl:variable name=""var:v8"" select=""@Value"" />
              <xsl:attribute name=""Param3"">
                <xsl:value-of select=""$var:v8"" />
              </xsl:attribute>
            </xsl:if>
          </xsl:for-each>
        </Record>
      </xsl:for-each>
    </ns0:Root>
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
        
        private const string _strSrcSchemasList0 = @"LoopingPattern.input";
        
        private const global::LoopingPattern.input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat";
        
        private const global::LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern.input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern.LoopValueMappingFlatteningFunctoid.OutputFlat";
                return _TrgSchemas;
            }
        }
    }
}
