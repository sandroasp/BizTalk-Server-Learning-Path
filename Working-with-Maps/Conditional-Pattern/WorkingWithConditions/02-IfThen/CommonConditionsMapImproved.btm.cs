namespace WorkingWithConditions._02_CommonConditions {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._02_CommonConditions.CommonConditionsSource", typeof(global::WorkingWithConditions._02_CommonConditions.CommonConditionsSource))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._02_CommonConditions.CommonConditionsDestination", typeof(global::WorkingWithConditions._02_CommonConditions.CommonConditionsDestination))]
    public sealed class CommonConditionsMapImproved : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://WorkingWithConditions.CommonConditionsSource"" xmlns:ns0=""http://WorkingWithConditions.CommonConditionsDestination"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CommonConditionsSource"" />
  </xsl:template>
  <xsl:template match=""/s0:CommonConditionsSource"">
    <xsl:variable name=""var:v1"" select=""userCSharp:SetConstantValue(&quot;Equal to 10&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(MapElemBaseCondition/Number/text()) , &quot;10&quot;)"" />
    <ns0:CommonConditionsDestination>
      <Description>
        <xsl:value-of select=""$var:v1"" />
      </Description>
      <xsl:if test=""$var:v2"">
        <Number>
          <xsl:value-of select=""MapElemBaseCondition/Number/text()"" />
        </Number>
      </xsl:if>
      <xsl:for-each select=""MapRecordBaseCondition"">
        <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq(string(Number/text()) , &quot;10&quot;)"" />
        <xsl:if test=""$var:v3"">
          <RecordThatMachCondition>
            <Number>
              <xsl:value-of select=""Number/text()"" />
            </Number>
            <Name>
              <xsl:value-of select=""Name/text()"" />
            </Name>
          </RecordThatMachCondition>
        </xsl:if>
      </xsl:for-each>
      <xsl:if test=""count(//MapRecordBaseCondition[Number = 10]) &gt; 0"">
<ListOfNames>
  <xsl:for-each select=""MapRecordBaseCondition[Number = 10]"">
    <Name>
      <xsl:value-of select=""Name/text()"" />
    </Name>
  </xsl:for-each>
</ListOfNames>
</xsl:if>
    </ns0:CommonConditionsDestination>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string SetConstantValue(string value)
{
	return value;
}


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
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions._02_CommonConditions.CommonConditionsSource";
        
        private const global::WorkingWithConditions._02_CommonConditions.CommonConditionsSource _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions._02_CommonConditions.CommonConditionsDestination";
        
        private const global::WorkingWithConditions._02_CommonConditions.CommonConditionsDestination _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConditions._02_CommonConditions.CommonConditionsSource";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConditions._02_CommonConditions.CommonConditionsDestination";
                return _TrgSchemas;
            }
        }
    }
}
