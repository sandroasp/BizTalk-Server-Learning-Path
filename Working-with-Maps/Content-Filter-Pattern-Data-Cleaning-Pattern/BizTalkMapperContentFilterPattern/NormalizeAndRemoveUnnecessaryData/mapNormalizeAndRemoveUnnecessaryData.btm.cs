namespace BizTalkMapperContentFilterPattern.NormalizeAndRemoveUnnecessaryData {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.CustomerService", typeof(global::BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.CustomerService))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.Client", typeof(global::BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.Client))]
    public sealed class mapNormalizeAndRemoveUnnecessaryData : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperContentFilterPattern.Client"" xmlns:s0=""http://BizTalkMapperContentFilterPattern.CustomerService"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerService"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerService"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(Address/Address/text()) , &quot;, &quot; , string(Address/PostalCode/text()) , &quot;, &quot; , string(Address/Country/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalExistence(boolean(ContactPhone/Email))"" />
    <ns0:Client>
      <Name>
        <xsl:value-of select=""Name/text()"" />
      </Name>
      <Address>
        <xsl:value-of select=""$var:v1"" />
      </Address>
      <Phone>
        <xsl:value-of select=""ContactPhone/Phone/text()"" />
      </Phone>
      <xsl:if test=""string($var:v2)='true'"">
        <xsl:variable name=""var:v3"" select=""ContactPhone/Email/text()"" />
        <Email>
          <xsl:value-of select=""$var:v3"" />
        </Email>
      </xsl:if>
      <TaxId>
        <xsl:value-of select=""TaxId/text()"" />
      </TaxId>
    </ns0:Client>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2, string param3, string param4)
{
   return param0 + param1 + param2 + param3 + param4;
}


public bool LogicalExistence(bool val)
{
	return val;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.CustomerService";
        
        private const global::BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.CustomerService _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.Client";
        
        private const global::BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.Client _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.CustomerService";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkMapperContentFilterPattern.RemoveUnnecessaryData.Client";
                return _TrgSchemas;
            }
        }
    }
}
