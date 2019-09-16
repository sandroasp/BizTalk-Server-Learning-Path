namespace SandroPereira.NameValueToHierarchical.Solution3 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.NameValueToHierarchical.Provisioning", typeof(global::SandroPereira.NameValueToHierarchical.Provisioning))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.NameValueToHierarchical.NameValueSchema", typeof(global::SandroPereira.NameValueToHierarchical.NameValueSchema))]
    public sealed class Map3 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://SandroPereira.NameValueToHierarchical.Request"" xmlns:s0=""http://SandroPereira.NameValueToHierarchical.Provisioning"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Provisioning"" />
  </xsl:template>
  <xsl:template match=""/s0:Provisioning"">
    <ns0:Request>
      <Header>
        <Nprocesso>
          <xsl:value-of select=""Id/text()"" />
        </Nprocesso>
      </Header>
      <Body>
        <ServiceName>
          <xsl:value-of select=""ServiceName/text()"" />
        </ServiceName>
        <Type>
  <xsl:value-of select=""//Properties/Property[Name='Type']/Value/text()"" />
</Type>
        <Protocol>
  <xsl:value-of select=""//Properties/Property[Name='Protocol']/Value/text()"" />
</Protocol>
        <Pool>
  <xsl:value-of select=""//Properties/Property[Name='Pool']/Value/text()"" />
</Pool>
        <VPNName>
  <xsl:value-of select=""//Properties/Property[Name='VPNName']/Value/text()"" />
</VPNName>
        <IPAddress>
  <xsl:value-of select=""//Properties/Property[Name='IPAddress']/Value/text()"" />
</IPAddress>
        <IPNetmask>
  <xsl:value-of select=""//Properties/Property[Name='IPNetmask']/Value/text()"" />
</IPNetmask>
        <LAN>
  <xsl:for-each select=""Properties/Property[Name='IPRoute']"">
    <IPRoute>
      <xsl:value-of select=""./Value/text()"" />
    </IPRoute>
  </xsl:for-each>
</LAN>
        <VirtualRouter>
  <xsl:value-of select=""//Properties/Property[Name='VirtualRouter']/Value/text()"" />
</VirtualRouter>
        <IdleTimeout>
  <xsl:value-of select=""//Properties/Property[Name='IdleTimeout']/Value/text()"" />
</IdleTimeout>
        <SessionTimeout>
  <xsl:value-of select=""//Properties/Property[Name='SessionTimeout']/Value/text()"" />
</SessionTimeout>
        <TunnelType>
  <xsl:value-of select=""//Properties/Property[Name='TunnelType']/Value/text()"" />
</TunnelType>
      </Body>
    </ns0:Request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SandroPereira.NameValueToHierarchical.Provisioning";
        
        private const global::SandroPereira.NameValueToHierarchical.Provisioning _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SandroPereira.NameValueToHierarchical.NameValueSchema";
        
        private const global::SandroPereira.NameValueToHierarchical.NameValueSchema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SandroPereira.NameValueToHierarchical.Provisioning";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SandroPereira.NameValueToHierarchical.NameValueSchema";
                return _TrgSchemas;
            }
        }
    }
}
