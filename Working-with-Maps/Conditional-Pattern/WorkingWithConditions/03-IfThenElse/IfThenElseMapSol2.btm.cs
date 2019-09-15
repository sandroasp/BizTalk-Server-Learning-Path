namespace WorkingWithConditions._03_IfThenElse {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._03_IfThenElse.IfThenElseSource", typeof(global::WorkingWithConditions._03_IfThenElse.IfThenElseSource))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._03_IfThenElse.IfThenElseDestination", typeof(global::WorkingWithConditions._03_IfThenElse.IfThenElseDestination))]
    public sealed class IfThenElseMapSol2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://WorkingWithConditions.IfThenElseSource"" xmlns:ns0=""http://WorkingWithConditions.IfThenElseDestination"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:IfThenElseSource"" />
  </xsl:template>
  <xsl:template match=""/s0:IfThenElseSource"">
    <xsl:variable name=""var:v1"" select=""userCSharp:ReturnValueFromOptionalField(string(Person/Sex/text()) , &quot;N/D&quot;)"" />
    <ns0:IfThenElseDestination>
      <Name>
        <xsl:value-of select=""Person/Name/text()"" />
      </Name>
      <Sex>
        <xsl:value-of select=""$var:v1"" />
      </Sex>
      <xsl:variable name=""var:v2"" select=""userCSharp:ValidateIfIsInteger(string(Person/Age/text()))"" />
      <Age>
        <xsl:value-of select=""$var:v2"" />
      </Age>
    </ns0:IfThenElseDestination>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string ReturnValueFromOptionalField(string input, string defaultValue)
{
	if (System.String.IsNullOrEmpty(input))
		return defaultValue;
	return input;
}


public string ValidateIfIsInteger(string param)
{
    if (param == null)
        return ""0"";
    int number;

    bool isNumber = int.TryParse(param, out number);
    if (isNumber)
        return number.ToString();
    return ""0"";
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
