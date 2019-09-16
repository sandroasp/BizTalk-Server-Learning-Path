namespace SandroPereira.NameValueToHierarchical.Solution3 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.NameValueToHierarchical.Provisioning", typeof(global::SandroPereira.NameValueToHierarchical.Provisioning))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.NameValueToHierarchical.NameValueSchema", typeof(global::SandroPereira.NameValueToHierarchical.NameValueSchema))]
    public sealed class Map4 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
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
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='Type']) &gt; 0"">
    <Type>
      <xsl:value-of select=""//Properties/Property[Name='Type']/Value/text()"" />
    </Type>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='Protocol']) &gt; 0"">
    <Protocol>
      <xsl:value-of select=""//Properties/Property[Name='Protocol']/Value/text()"" />
    </Protocol>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='Pool']) &gt; 0"">
    <Pool>
      <xsl:value-of select=""//Properties/Property[Name='Pool']/Value/text()"" />
    </Pool>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='VPNName']) &gt; 0"">
    <VPNName>
      <xsl:value-of select=""//Properties/Property[Name='VPNName']/Value/text()"" />
    </VPNName>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='IPAddress']) &gt; 0"">
    <IPAddress>
      <xsl:value-of select=""//Properties/Property[Name='IPAddress']/Value/text()"" />
    </IPAddress>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='IPNetmask']) &gt; 0"">
    <IPNetmask>
      <xsl:value-of select=""//Properties/Property[Name='IPNetmask']/Value/text()"" />
    </IPNetmask>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='IPRoute']) &gt; 0"">
    <LAN>
      <xsl:for-each select=""Properties/Property[Name='IPRoute']"">
        <IPRoute>
          <xsl:value-of select=""./Value/text()"" />
        </IPRoute>
      </xsl:for-each>
    </LAN>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='VirtualRouter']) &gt; 0"">
    <VirtualRouter>
      <xsl:value-of select=""//Properties/Property[Name='VirtualRouter']/Value/text()"" />
    </VirtualRouter>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='IdleTimeout']) &gt; 0"">
    <IdleTimeout>
      <xsl:value-of select=""//Properties/Property[Name='IdleTimeout']/Value/text()"" />
    </IdleTimeout>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='SessionTimeout']) &gt; 0"">
    <SessionTimeout>
      <xsl:value-of select=""//Properties/Property[Name='SessionTimeout']/Value/text()"" />
    </SessionTimeout>
  </xsl:when>
</xsl:choose>
        <xsl:choose>
  <xsl:when test=""count(//Properties/Property[Name='TunnelType']) &gt; 0"">
    <TunnelType>
      <xsl:value-of select=""//Properties/Property[Name='TunnelType']/Value/text()"" />
    </TunnelType>
  </xsl:when>
</xsl:choose>
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
