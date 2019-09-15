namespace WorkingWithConditions._02_CommonConditions {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._02_CommonConditions.CommonConditionsSource", typeof(global::WorkingWithConditions._02_CommonConditions.CommonConditionsSource))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._02_CommonConditions.CommonConditionsDestination", typeof(global::WorkingWithConditions._02_CommonConditions.CommonConditionsDestination))]
    public sealed class CommonConditionsMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
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
      <xsl:variable name=""var:v4"" select=""userCSharp:InitCumulativeSum(0)"" />
      <xsl:for-each select=""/s0:CommonConditionsSource/MapRecordBaseCondition"">
        <xsl:variable name=""var:v5"" select=""string(Number/text())"" />
        <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq($var:v5 , &quot;10&quot;)"" />
        <xsl:variable name=""var:v7"" select=""userCSharp:MyConcat(string($var:v6))"" />
        <xsl:variable name=""var:v8"" select=""userCSharp:AddToCumulativeSum(0,string($var:v7),string(./text()))"" />
      </xsl:for-each>
      <xsl:variable name=""var:v9"" select=""userCSharp:GetCumulativeSum(0)"" />
      <xsl:variable name=""var:v10"" select=""userCSharp:LogicalGt(string($var:v9) , &quot;0&quot;)"" />
      <xsl:if test=""$var:v10"">
        <ListOfNames>
          <xsl:for-each select=""MapRecordBaseCondition"">
            <xsl:variable name=""var:v11"" select=""string(Number/text())"" />
            <xsl:variable name=""var:v12"" select=""userCSharp:LogicalEq($var:v11 , &quot;10&quot;)"" />
            <xsl:if test=""$var:v12"">
              <Name>
                <xsl:value-of select=""Name/text()"" />
              </Name>
            </xsl:if>
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


public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public int MyConcat(bool param1)
{
  if(param1)
      return 1;
 return 0;
}


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
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
