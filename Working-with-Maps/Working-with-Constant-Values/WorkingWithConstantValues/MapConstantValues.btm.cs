namespace WorkingWithConstantValues {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConstantValues.SourceSchema", typeof(global::WorkingWithConstantValues.SourceSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConstantValues.TargetSchema", typeof(global::WorkingWithConstantValues.TargetSchema))]
    public sealed class MapConstantValues : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://WorkingWithConstantValues.SourceSchema"" xmlns:ns0=""http://WorkingWithConstantValues.TargetSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" encoding=""windows-1250"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Source"" />
  </xsl:template>
  <xsl:template match=""/s0:Source"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(OptionalField))"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;Set static constant using String Concatenate Functoid&quot;)"" />
    <ns0:Target>
      <Title>
        <xsl:value-of select=""Title/text()"" />
      </Title>
      <xsl:if test=""string($var:v1)='true'"">
        <xsl:variable name=""var:v2"" select=""OptionalField/text()"" />
        <OpcionalField>
          <xsl:value-of select=""$var:v2"" />
        </OpcionalField>
      </xsl:if>
      <StaticConstants>
        <ConstValueInSchema>
          <xsl:text>Set static constant using schema properties</xsl:text>
        </ConstValueInSchema>
        <xsl:variable name=""var:v3"" select=""userCSharp:SetCustomValue(&quot;Set static constant using Inline C#&quot;)"" />
        <ConstValueUsingScriptingFunctoid>
          <xsl:value-of select=""$var:v3"" />
        </ConstValueUsingScriptingFunctoid>
        <ConstValueUsingScriptingFunctoid2>Set static constant using custom XSLT</ConstValueUsingScriptingFunctoid2>
        <ConstValueUsingStringFunctoids>
          <xsl:value-of select=""$var:v4"" />
        </ConstValueUsingStringFunctoids>
      </StaticConstants>
    </ns0:Target>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public string SetCustomValue(string param1)
{
    return param1;
}


public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"WorkingWithConstantValues.SourceSchema";
        
        private const global::WorkingWithConstantValues.SourceSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConstantValues.TargetSchema";
        
        private const global::WorkingWithConstantValues.TargetSchema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConstantValues.SourceSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConstantValues.TargetSchema";
                return _TrgSchemas;
            }
        }
    }
}
