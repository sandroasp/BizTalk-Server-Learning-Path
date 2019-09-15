namespace WorkingWithConditions._01_CheckDataExistence {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceSource", typeof(global::WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceSource))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceDestination", typeof(global::WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceDestination))]
    public sealed class CheckDataExistenceMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://WorkingWithConditions.CheckDataExistenceDestination"" xmlns:s0=""http://WorkingWithConditions.CheckDataExistenceSource"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CheckExistenceSource"" />
  </xsl:template>
  <xsl:template match=""/s0:CheckExistenceSource"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(OptionalElementExistence/OptionalElement))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalExistence(boolean(OptionalElementExistence/OptionalElement2))"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalIsString(string(MandatoryElementExistence/StringExist/text()))"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalIsNumeric(string(MandatoryElementExistence/IntExist/text()))"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalIsDate(string(MandatoryElementExistence/DateExist/text()))"" />
    <xsl:variable name=""var:v7"" select=""string(MoreAdvanceValidation/DateExist/@xsi:nil) = 'true'"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNot(string($var:v7))"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:LogicalExistence(boolean(MoreAdvanceValidation/OptionalElement))"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:LogicalNot(string($var:v10))"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:ReturnValueFromOptionalField(string(MoreAdvanceValidation/OptionalElement2/text()) , &quot;Default Value 2&quot;)"" />
    <ns0:CheckDataExistenceDestination>
      <OnlyIfElementExistence>
        <xsl:if test=""string($var:v1)='true'"">
          <xsl:variable name=""var:v2"" select=""OptionalElementExistence/OptionalElement/text()"" />
          <ElementExistOutput>
            <xsl:value-of select=""$var:v2"" />
          </ElementExistOutput>
        </xsl:if>
        <xsl:if test=""$var:v3"">
          <xsl:if test=""OptionalElementExistence/OptionalElement2"">
            <ElementExistOutput2>
              <xsl:value-of select=""OptionalElementExistence/OptionalElement2/text()"" />
            </ElementExistOutput2>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""OptionalElementExistence/OptionalElement3"">
          <ElementExistOutput3>
            <xsl:value-of select=""OptionalElementExistence/OptionalElement3/text()"" />
          </ElementExistOutput3>
        </xsl:if>
      </OnlyIfElementExistence>
      <OnlyIfDataExistence>
        <xsl:if test=""$var:v4"">
          <DataExistOutput>
            <xsl:value-of select=""MandatoryElementExistence/StringExist/text()"" />
          </DataExistOutput>
        </xsl:if>
        <xsl:if test=""$var:v5"">
          <IntExistOutput>
            <xsl:value-of select=""MandatoryElementExistence/IntExist/text()"" />
          </IntExistOutput>
        </xsl:if>
        <xsl:if test=""$var:v6"">
          <xsl:if test=""MandatoryElementExistence/DateExist"">
            <DateExistOutput>
              <xsl:value-of select=""MandatoryElementExistence/DateExist/text()"" />
            </DateExistOutput>
          </xsl:if>
        </xsl:if>
      </OnlyIfDataExistence>
      <MandatoryElements>
        <xsl:if test=""string($var:v7)='true'"">
          <MandatoryButCanBeNill>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </MandatoryButCanBeNill>
        </xsl:if>
        <xsl:if test=""string($var:v8)='true'"">
          <xsl:variable name=""var:v9"" select=""MoreAdvanceValidation/DateExist/text()"" />
          <MandatoryButCanBeNill>
            <xsl:value-of select=""$var:v9"" />
          </MandatoryButCanBeNill>
        </xsl:if>
        <xsl:if test=""string($var:v10)='true'"">
          <xsl:variable name=""var:v11"" select=""MoreAdvanceValidation/OptionalElement/text()"" />
          <MandatoryElementOutput>
            <xsl:value-of select=""$var:v11"" />
          </MandatoryElementOutput>
        </xsl:if>
        <xsl:if test=""string($var:v12)='true'"">
          <xsl:variable name=""var:v13"" select=""&quot;Default Value&quot;"" />
          <MandatoryElementOutput>
            <xsl:value-of select=""$var:v13"" />
          </MandatoryElementOutput>
        </xsl:if>
        <MandatoryElementOutput2>
          <xsl:value-of select=""$var:v14"" />
        </MandatoryElementOutput2>
      </MandatoryElements>
      <xsl:for-each select=""RepetingElements"">
        <xsl:variable name=""var:v15"" select=""userCSharp:LogicalIsString(string(MandatoryElement/text()))"" />
        <xsl:variable name=""var:v17"" select=""userCSharp:LogicalNot(string($var:v15))"" />
        <ExistenceInRepetingRecords>
          <xsl:if test=""OptionElement"">
            <OptionalElement>
              <xsl:value-of select=""OptionElement/text()"" />
            </OptionalElement>
          </xsl:if>
          <xsl:if test=""string($var:v15)='true'"">
            <xsl:variable name=""var:v16"" select=""MandatoryElement/text()"" />
            <MandatoryElement>
              <xsl:value-of select=""$var:v16"" />
            </MandatoryElement>
          </xsl:if>
          <xsl:if test=""string($var:v17)='true'"">
            <MandatoryElement>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </MandatoryElement>
          </xsl:if>
        </ExistenceInRepetingRecords>
      </xsl:for-each>
    </ns0:CheckDataExistenceDestination>
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


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string ReturnValueFromOptionalField(string input, string defaultValue)
{
	if (System.String.IsNullOrEmpty(input))
		return defaultValue;
	return input;
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
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceSource";
        
        private const global::WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceSource _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceDestination";
        
        private const global::WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceDestination _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceSource";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConditions._01_CheckDataExistence.CheckDataExistenceDestination";
                return _TrgSchemas;
            }
        }
    }
}
