namespace SandroPereira.MappingToNameValueRecord.Solution3 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.MappingToNameValueRecord.Request", typeof(global::SandroPereira.MappingToNameValueRecord.Request))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.MappingToNameValueRecord.Provisioning", typeof(global::SandroPereira.MappingToNameValueRecord.Provisioning))]
    public sealed class NameValueSolution3 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
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
      <xsl:element name=""Properties"">
      <xsl:for-each select=""/s0:Request/Body/*"">
              <xsl:variable name=""var:v2"">
                     <xsl:value-of select=""."" />
              </xsl:variable>
              <xsl:variable name=""var:v1"" select=""userCSharp:EmptyOrNull(string($var:v2))"" /> 
              <xsl:if test=""local-name()!='ServiceName' and local-name()!='LAN' and $var:v1='true'"">
                  <xsl:element name=""Property"">
                     <xsl:element name=""Name"">
                             <xsl:value-of select=""local-name()"" />
                      </xsl:element>
                      <xsl:element name=""Value"">
                             <xsl:value-of select=""."" />
                      </xsl:element>
                </xsl:element>
              </xsl:if>
       </xsl:for-each>
       <xsl:for-each select=""/s0:Request/Body/LAN/*"">
              <xsl:variable name=""var:v2"">
                     <xsl:value-of select=""."" />
              </xsl:variable>
              <xsl:variable name=""var:v1"" select=""userCSharp:EmptyOrNull(string($var:v2))"" />
              <xsl:if test=""$var:v1='true'"">
                     <xsl:element name=""Property"">
                     <xsl:element name=""Name"">
                            <xsl:value-of select=""local-name()"" />
                     </xsl:element>
                     <xsl:element name=""Value"">
                           <xsl:value-of select=""."" />
                     </xsl:element>
                     </xsl:element>
              </xsl:if>
       </xsl:for-each>
</xsl:element>
      <ServiceName>
        <xsl:value-of select=""Body/ServiceName/text()"" />
      </ServiceName>
    </ns0:Provisioning>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string EmptyOrNull(string param)
{
     if(string.IsNullOrEmpty(param))
	return ""false"";
     return ""true"";
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
