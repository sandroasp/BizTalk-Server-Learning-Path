namespace SandroPereira.MappingToNameValueRecord.Solution2 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.MappingToNameValueRecord.Request", typeof(global::SandroPereira.MappingToNameValueRecord.Request))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.MappingToNameValueRecord.Provisioning", typeof(global::SandroPereira.MappingToNameValueRecord.Provisioning))]
    public sealed class NameValueSolution2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
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
          <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(.))"" />
          <xsl:variable name=""var:v3"" select=""boolean(.)"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:LogicalExistence($var:v3)"" />
          <Property>
            <xsl:if test=""string($var:v1)='true'"">
              <xsl:variable name=""var:v2"" select=""&quot;Type&quot;"" />
              <Name>
                <xsl:value-of select=""$var:v2"" />
              </Name>
            </xsl:if>
            <xsl:if test=""string($var:v4)='true'"">
              <xsl:variable name=""var:v5"" select=""./text()"" />
              <Value>
                <xsl:value-of select=""$var:v5"" />
              </Value>
            </xsl:if>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/Protocol"">
          <xsl:variable name=""var:v6"" select=""boolean(.)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:LogicalExistence($var:v6)"" />
          <Property>
            <xsl:if test=""string($var:v7)='true'"">
              <xsl:variable name=""var:v8"" select=""&quot;Protocol&quot;"" />
              <Name>
                <xsl:value-of select=""$var:v8"" />
              </Name>
            </xsl:if>
            <xsl:if test=""string($var:v7)='true'"">
              <xsl:variable name=""var:v9"" select=""./text()"" />
              <Value>
                <xsl:value-of select=""$var:v9"" />
              </Value>
            </xsl:if>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/Pool"">
          <xsl:variable name=""var:v10"" select=""boolean(.)"" />
          <xsl:variable name=""var:v11"" select=""userCSharp:LogicalExistence($var:v10)"" />
          <Property>
            <xsl:if test=""string($var:v11)='true'"">
              <xsl:variable name=""var:v12"" select=""&quot;Pool&quot;"" />
              <Name>
                <xsl:value-of select=""$var:v12"" />
              </Name>
            </xsl:if>
            <xsl:if test=""string($var:v11)='true'"">
              <xsl:variable name=""var:v13"" select=""./text()"" />
              <Value>
                <xsl:value-of select=""$var:v13"" />
              </Value>
            </xsl:if>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/VPNName"">
          <xsl:variable name=""var:v14"" select=""boolean(.)"" />
          <xsl:variable name=""var:v15"" select=""userCSharp:LogicalExistence($var:v14)"" />
          <Property>
            <xsl:if test=""string($var:v15)='true'"">
              <xsl:variable name=""var:v16"" select=""&quot;VPNName&quot;"" />
              <Name>
                <xsl:value-of select=""$var:v16"" />
              </Name>
            </xsl:if>
            <xsl:if test=""string($var:v15)='true'"">
              <xsl:variable name=""var:v17"" select=""./text()"" />
              <Value>
                <xsl:value-of select=""$var:v17"" />
              </Value>
            </xsl:if>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/IPAddress"">
          <xsl:variable name=""var:v18"" select=""boolean(.)"" />
          <xsl:variable name=""var:v19"" select=""userCSharp:LogicalExistence($var:v18)"" />
          <Property>
            <xsl:if test=""string($var:v19)='true'"">
              <xsl:variable name=""var:v20"" select=""&quot;IPAddress&quot;"" />
              <Name>
                <xsl:value-of select=""$var:v20"" />
              </Name>
            </xsl:if>
            <xsl:if test=""string($var:v19)='true'"">
              <xsl:variable name=""var:v21"" select=""./text()"" />
              <Value>
                <xsl:value-of select=""$var:v21"" />
              </Value>
            </xsl:if>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/IPNetmask"">
          <xsl:variable name=""var:v22"" select=""boolean(.)"" />
          <xsl:variable name=""var:v23"" select=""userCSharp:LogicalExistence($var:v22)"" />
          <Property>
            <xsl:if test=""string($var:v23)='true'"">
              <xsl:variable name=""var:v24"" select=""&quot;IPNetmask&quot;"" />
              <Name>
                <xsl:value-of select=""$var:v24"" />
              </Name>
            </xsl:if>
            <xsl:if test=""string($var:v23)='true'"">
              <xsl:variable name=""var:v25"" select=""./text()"" />
              <Value>
                <xsl:value-of select=""$var:v25"" />
              </Value>
            </xsl:if>
          </Property>
        </xsl:for-each>
      </Properties>
      <ServiceName>
        <xsl:value-of select=""Body/ServiceName/text()"" />
      </ServiceName>
    </ns0:Provisioning>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
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
