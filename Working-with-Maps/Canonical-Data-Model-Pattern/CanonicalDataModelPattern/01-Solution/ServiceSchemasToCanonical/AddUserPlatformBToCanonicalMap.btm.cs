namespace CanonicalDataModelPattern._01_Solution.ServiceSchemasToCanonical {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CanonicalDataModelPattern.AddUserPlatformB", typeof(global::CanonicalDataModelPattern.AddUserPlatformB))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CanonicalDataModelPattern.CanonicalRequest", typeof(global::CanonicalDataModelPattern.CanonicalRequest))]
    public sealed class AddUserPlatformBToCanonicalMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://CanonicalDataModelPattern.AddUserPlatformB"" xmlns:ns0=""http://CanonicalDataModelPattern.CanonicalRequest"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddUserPlatformB"" />
  </xsl:template>
  <xsl:template match=""/s0:AddUserPlatformB"">
    <xsl:variable name=""var:v1"" select=""userCSharp:SetConstantValue(&quot;P001&quot;)"" />
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
        <Password>
          <xsl:value-of select=""Password/text()"" />
        </Password>
        <Service-Type>
          <xsl:value-of select=""ServiceType/text()"" />
        </Service-Type>
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
          <Framed-Route>
            <xsl:value-of select=""Framed/Route/text()"" />
          </Framed-Route>
        </IPLAN>
        <Framed-IPv6-Route>
          <xsl:value-of select=""Framed/IPv6Route/text()"" />
        </Framed-IPv6-Route>
        <Framed-IPv6-Pool>
          <xsl:value-of select=""Framed/IPv6Pool/text()"" />
        </Framed-IPv6-Pool>
        <Framed-IPv6-Prefix>
          <xsl:value-of select=""Framed/IPv6Prefix/text()"" />
        </Framed-IPv6-Prefix>
        <Cisco-Account-Info>
          <xsl:value-of select=""Cisco/AccountInfo/text()"" />
        </Cisco-Account-Info>
        <CiscoAvpairs>
          <xsl:for-each select=""Cisco/CiscoAvpair"">
            <Cisco-Avpair>
              <xsl:value-of select=""./text()"" />
            </Cisco-Avpair>
          </xsl:for-each>
        </CiscoAvpairs>
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
        
        private const string _strSrcSchemasList0 = @"CanonicalDataModelPattern.AddUserPlatformB";
        
        private const global::CanonicalDataModelPattern.AddUserPlatformB _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"CanonicalDataModelPattern.AddUserPlatformB";
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
