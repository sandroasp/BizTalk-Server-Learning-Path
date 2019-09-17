namespace SandroPereira.MappingToNameValueRecord.Solution1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.MappingToNameValueRecord.Request", typeof(global::SandroPereira.MappingToNameValueRecord.Request))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.MappingToNameValueRecord.Provisioning", typeof(global::SandroPereira.MappingToNameValueRecord.Provisioning))]
    public sealed class NameValueSolution1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://SandroPereira.MappingToNameValueRecord.Provisioning"" xmlns:s0=""http://SandroPereira.MappingToNameValueRecord.Request"">
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
        <xsl:for-each select=""Body/LAN"">
          <xsl:for-each select=""IPRoute"">
            <Property>
              <Name>IPRoute</Name>
              <Value>
                <xsl:value-of select=""./text()"" />
              </Value>
            </Property>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""Body/Type"">
          <Property>
            <Name>Type</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/Protocol"">
          <Property>
            <Name>Protocol</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/Pool"">
          <Property>
            <Name>Pool</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/VPNName"">
          <Property>
            <Name>VPNName</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/IPAddress"">
          <Property>
            <Name>IPAddress</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/IPNetmask"">
          <Property>
            <Name>IPNetmask</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/Profile"">
          <Property>
            <Name>Profile</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/VirtualRouter"">
          <Property>
            <Name>VirtualRouter</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/IdleTimeout"">
          <Property>
            <Name>IdleTimeout</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/SessionTimeout"">
          <Property>
            <Name>SessionTimeout</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
        <xsl:for-each select=""Body/TunnelType"">
          <Property>
            <Name>TunnelType</Name>
            <Value>
              <xsl:value-of select=""./text()"" />
            </Value>
          </Property>
        </xsl:for-each>
      </Properties>
      <ServiceName>
        <xsl:value-of select=""Body/ServiceName/text()"" />
      </ServiceName>
    </ns0:Provisioning>
  </xsl:template>
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
