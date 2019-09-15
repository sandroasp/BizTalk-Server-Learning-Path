namespace LoopingPattern.ConditionalLooping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.ConditionalLooping.Surveys", typeof(global::LoopingPattern.ConditionalLooping.Surveys))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern.ConditionalLooping.MasterAddress", typeof(global::LoopingPattern.ConditionalLooping.MasterAddress))]
    public sealed class ConditionalLoopingMapReadable : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://LoopingPattern.MasterAddress"" xmlns:s0=""http://LoopingPattern.Surveys"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Surveys"" />
  </xsl:template>
  <xsl:template match=""/s0:Surveys"">
    <ns0:MasterAddresses>
      <xsl:for-each select=""FoodSurvey"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(State/text()) , &quot;FL&quot;)"" />
        <xsl:if test=""$var:v1"">
          <Address>
            <xsl:attribute name=""Name"">
              <xsl:value-of select=""Name/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Name"">
              <xsl:value-of select=""../FlowerDurvey/Name/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Street"">
              <xsl:value-of select=""Address/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""Street"">
              <xsl:value-of select=""../FlowerDurvey/Address/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""City"">
              <xsl:value-of select=""City/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""City"">
              <xsl:value-of select=""../FlowerDurvey/City/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""State"">
              <xsl:value-of select=""State/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""State"">
              <xsl:value-of select=""../FlowerDurvey/State/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""PostalCode"">
              <xsl:value-of select=""PostalCode/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""PostalCode"">
              <xsl:value-of select=""../FlowerDurvey/PostalCode/text()"" />
            </xsl:attribute>
          </Address>
        </xsl:if>
      </xsl:for-each>
    </ns0:MasterAddresses>
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
        
        private const string _strSrcSchemasList0 = @"LoopingPattern.ConditionalLooping.Surveys";
        
        private const global::LoopingPattern.ConditionalLooping.Surveys _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern.ConditionalLooping.MasterAddress";
        
        private const global::LoopingPattern.ConditionalLooping.MasterAddress _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern.ConditionalLooping.Surveys";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern.ConditionalLooping.MasterAddress";
                return _TrgSchemas;
            }
        }
    }
}
