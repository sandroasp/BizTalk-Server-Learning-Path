namespace WorkingWithConditions._01_CommonConditions {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._01_CommonConditions.CommonConditionsSource", typeof(global::WorkingWithConditions._01_CommonConditions.CommonConditionsSource))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._01_CommonConditions.CommonConditionsDestination", typeof(global::WorkingWithConditions._01_CommonConditions.CommonConditionsDestination))]
    public sealed class CommonConditionsMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://WorkingWithConditions.CommonConditionsSource"" xmlns:ns0=""http://WorkingWithConditions.CommonConditionsDestination"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CommonConditionsSource"" />
  </xsl:template>
  <xsl:template match=""/s0:CommonConditionsSource"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(CheckElementExistence/ElementExist))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalExistence(boolean(CheckElementExistence/ElementExist2))"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalIsString(string(CheckDataExistence/DataExist/text()))"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalIsNumeric(string(CheckDataExistence/IntExist/text()))"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalIsDate(string(CheckDataExistence/DateExist/text()))"" />
    <ns0:CommonConditionsDestination>
      <CheckElementExistence>
        <xsl:if test=""string($var:v1)='true'"">
          <xsl:variable name=""var:v2"" select=""CheckElementExistence/ElementExist/text()"" />
          <ElementExistOutput>
            <xsl:value-of select=""$var:v2"" />
          </ElementExistOutput>
        </xsl:if>
        <xsl:if test=""$var:v3"">
          <xsl:if test=""CheckElementExistence/ElementExist2"">
            <ElementExistOutput2>
              <xsl:value-of select=""CheckElementExistence/ElementExist2/text()"" />
            </ElementExistOutput2>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""CheckElementExistence/ElementExist3"">
          <ElementExistOutput3>
            <xsl:value-of select=""CheckElementExistence/ElementExist3/text()"" />
          </ElementExistOutput3>
        </xsl:if>
      </CheckElementExistence>
      <CheckDataExistence>
        <xsl:if test=""string($var:v4)='true'"">
          <xsl:variable name=""var:v5"" select=""CheckDataExistence/DataExist/text()"" />
          <DataExistOutput>
            <xsl:value-of select=""$var:v5"" />
          </DataExistOutput>
        </xsl:if>
        <xsl:if test=""string($var:v6)='true'"">
          <xsl:variable name=""var:v7"" select=""CheckDataExistence/IntExist/text()"" />
          <IntExistOutput>
            <xsl:value-of select=""$var:v7"" />
          </IntExistOutput>
        </xsl:if>
        <xsl:if test=""string($var:v8)='true'"">
          <xsl:variable name=""var:v9"" select=""CheckDataExistence/DateExist/text()"" />
          <DateExistOutput>
            <xsl:value-of select=""$var:v9"" />
          </DateExistOutput>
        </xsl:if>
      </CheckDataExistence>
    </ns0:CommonConditionsDestination>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalIsString(string val)
{
	return (val != null && val !="""");
}


public bool LogicalIsNumeric(string val)
{
	return IsNumeric(val);
}


public bool LogicalIsDate(string val)
{
	return IsDate(val);
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

public bool IsDate(string val)
{
	bool retval = true;
	try
	{
		DateTime dt = Convert.ToDateTime(val, System.Globalization.CultureInfo.InvariantCulture);
	}
	catch (Exception)
	{
		retval = false;
	}
	return retval;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions._01_CommonConditions.CommonConditionsSource";
        
        private const global::WorkingWithConditions._01_CommonConditions.CommonConditionsSource _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions._01_CommonConditions.CommonConditionsDestination";
        
        private const global::WorkingWithConditions._01_CommonConditions.CommonConditionsDestination _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConditions._01_CommonConditions.CommonConditionsSource";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConditions._01_CommonConditions.CommonConditionsDestination";
                return _TrgSchemas;
            }
        }
    }
}
