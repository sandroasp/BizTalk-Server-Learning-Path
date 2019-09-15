namespace CanonicalDataModelPattern._01_Solution.ServiceSchemasToCanonical {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CanonicalDataModelPattern.ChangeUserInfo", typeof(global::CanonicalDataModelPattern.ChangeUserInfo))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CanonicalDataModelPattern.CanonicalRequest", typeof(global::CanonicalDataModelPattern.CanonicalRequest))]
    public sealed class ChangeUserInfoToCanonicalMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://CanonicalDataModelPattern.ChangeUserInfo"" xmlns:ns0=""http://CanonicalDataModelPattern.CanonicalRequest"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ChangeOrAddUserInfo"" />
  </xsl:template>
  <xsl:template match=""/s0:ChangeOrAddUserInfo"">
    <xsl:variable name=""var:v1"" select=""userCSharp:SetConstantValue(&quot;P019&quot;)"" />
    <ns0:CanonicalRequest>
      <Header>
        <ProcessId>
          <xsl:value-of select=""RequestId/text()"" />
        </ProcessId>
        <OperationType>
          <xsl:value-of select=""$var:v1"" />
        </OperationType>
      </Header>
      <Body>
        <Username>
          <xsl:value-of select=""Username/text()"" />
        </Username>
        <Framed-Protocol>
          <xsl:value-of select=""Framed/Protocol/text()"" />
        </Framed-Protocol>
        <Framed-Pool>
          <xsl:value-of select=""Framed/Pool/text()"" />
        </Framed-Pool>
        <Framed-IP-Address>
          <xsl:value-of select=""Framed/IPAddress/text()"" />
        </Framed-IP-Address>
        <Framed-IP-Netmask>
          <xsl:value-of select=""Framed/IPNetmask/text()"" />
        </Framed-IP-Netmask>
        <IPLAN>
          <xsl:for-each select=""Framed"">
            <Framed-Route>
              <xsl:value-of select=""Route/text()"" />
            </Framed-Route>
          </xsl:for-each>
        </IPLAN>
        <Unisphere-Virtual-Router>
          <xsl:value-of select=""Unisphere/VirtualRouter/text()"" />
        </Unisphere-Virtual-Router>
        <Unisphere-Ingress-Policy-Name>
          <xsl:value-of select=""Unisphere/IngressPolicyName/text()"" />
        </Unisphere-Ingress-Policy-Name>
        <Unisphere-Init-CLI-Access-Level>
          <xsl:value-of select=""Unisphere/InitCLIAccessLevel/text()"" />
        </Unisphere-Init-CLI-Access-Level>
        <Unisphere-Local-Address-Pool>
          <xsl:value-of select=""Unisphere/LocalAddressPool/text()"" />
        </Unisphere-Local-Address-Pool>
        <Unisphere-Ingress-Statistics>
          <xsl:value-of select=""Unisphere/IngressStatistics/text()"" />
        </Unisphere-Ingress-Statistics>
        <Unisphere-Primary-Dns>
          <xsl:value-of select=""Unisphere/PrimaryDns/text()"" />
        </Unisphere-Primary-Dns>
      </Body>
    </ns0:CanonicalRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string SetConstantValue(string value)
{
	return value;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CanonicalDataModelPattern.ChangeUserInfo";
        
        private const global::CanonicalDataModelPattern.ChangeUserInfo _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CanonicalDataModelPattern.CanonicalRequest";
        
        private const global::CanonicalDataModelPattern.CanonicalRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"CanonicalDataModelPattern.ChangeUserInfo";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CanonicalDataModelPattern.CanonicalRequest";
                return _TrgSchemas;
            }
        }
    }
}
