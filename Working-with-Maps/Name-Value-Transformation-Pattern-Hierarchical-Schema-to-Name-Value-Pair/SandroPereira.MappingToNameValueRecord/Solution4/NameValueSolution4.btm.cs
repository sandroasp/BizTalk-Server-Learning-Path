namespace SandroPereira.MappingToNameValueRecord.Solution4 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.MappingToNameValueRecord.Request", typeof(global::SandroPereira.MappingToNameValueRecord.Request))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.MappingToNameValueRecord.Provisioning", typeof(global::SandroPereira.MappingToNameValueRecord.Provisioning))]
    public sealed class NameValueSolution4 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://SandroPereira.MappingToNameValueRecord.Provisioning"" xmlns:s0=""http://SandroPereira.MappingToNameValueRecord.Request"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Request"" />
  </xsl:template>
  <xsl:template match=""/s0:Request"">
    <ns0:Provisioning>
      <Id>
        <xsl:value-of select=""Header/Nprocesso/text()"" />
      </Id>
      <Properties>
        <xsl:for-each select=""Body/Type"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;Type&quot;)"" />
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;Protocol&quot;)"" />
          <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;Pool&quot;)"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;VPNName&quot;)"" />
          <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;IPAddress&quot;)"" />
          <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;IPNetmask&quot;)"" />
          <xsl:variable name=""var:v7"" select=""$var:v1"" />
          <xsl:variable name=""var:v8"" select=""&quot;Type&quot;"" />
          <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat($var:v8)"" />
          <xsl:variable name=""var:v10"" select=""&quot;Protocol&quot;"" />
          <xsl:variable name=""var:v11"" select=""userCSharp:StringConcat($var:v10)"" />
          <xsl:variable name=""var:v12"" select=""&quot;Pool&quot;"" />
          <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat($var:v12)"" />
          <xsl:variable name=""var:v14"" select=""&quot;VPNName&quot;"" />
          <xsl:variable name=""var:v15"" select=""userCSharp:StringConcat($var:v14)"" />
          <xsl:variable name=""var:v16"" select=""&quot;IPAddress&quot;"" />
          <xsl:variable name=""var:v17"" select=""userCSharp:StringConcat($var:v16)"" />
          <xsl:variable name=""var:v18"" select=""&quot;IPNetmask&quot;"" />
          <xsl:variable name=""var:v19"" select=""userCSharp:StringConcat($var:v18)"" />
          <xsl:variable name=""var:v20"" select=""."" />
          <xsl:variable name=""var:v21"" select=""$var:v11"" />
          <xsl:variable name=""var:v22"" select=""../Protocol"" />
          <xsl:variable name=""var:v23"" select=""$var:v13"" />
          <xsl:variable name=""var:v24"" select=""../Pool"" />
          <xsl:variable name=""var:v25"" select=""$var:v15"" />
          <xsl:variable name=""var:v26"" select=""../VPNName"" />
          <xsl:variable name=""var:v27"" select=""$var:v17"" />
          <xsl:variable name=""var:v28"" select=""../IPAddress"" />
          <xsl:variable name=""var:v29"" select=""$var:v19"" />
          <xsl:variable name=""var:v30"" select=""../IPNetmask"" />
          <Property>
            <Name>
              <xsl:value-of select=""$var:v7"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v20"" />
            </Value>
          </Property>
          <Property>
            <Name>
              <xsl:value-of select=""$var:v21"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v22"" />
            </Value>
          </Property>
          <Property>
            <Name>
              <xsl:value-of select=""$var:v23"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v24"" />
            </Value>
          </Property>
          <Property>
            <Name>
              <xsl:value-of select=""$var:v25"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v26"" />
            </Value>
          </Property>
          <Property>
            <Name>
              <xsl:value-of select=""$var:v27"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v28"" />
            </Value>
          </Property>
          <Property>
            <Name>
              <xsl:value-of select=""$var:v29"" />
            </Name>
            <Value>
              <xsl:value-of select=""$var:v30"" />
            </Value>
          </Property>
        </xsl:for-each>
      </Properties>
      <ServiceName>
        <xsl:value-of select=""Body/ServiceName/text()"" />
      </ServiceName>
    </ns0:Provisioning>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SandroPereira.MappingToNameValueRecord.Request";
        
        private const global::SandroPereira.MappingToNameValueRecord.Request _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SandroPereira.MappingToNameValueRecord.Provisioning";
        
        private const global::SandroPereira.MappingToNameValueRecord.Provisioning _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SandroPereira.MappingToNameValueRecord.Request";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SandroPereira.MappingToNameValueRecord.Provisioning";
                return _TrgSchemas;
            }
        }
    }
}
