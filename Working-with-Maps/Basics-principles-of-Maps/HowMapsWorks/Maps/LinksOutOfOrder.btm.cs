namespace HowMapsWorks.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowMapsWorks.Schemas.PeopleOrigin", typeof(global::HowMapsWorks.Schemas.PeopleOrigin))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowMapsWorks.Schemas.PeopleTarget", typeof(global::HowMapsWorks.Schemas.PeopleTarget))]
    public sealed class LinksOutOfOrder : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://HowMapsWorks.PeopleOrigin"" xmlns:ns0=""http://HowMapsWorks.PeopleTarget"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PeopleOrigin"" />
  </xsl:template>
  <xsl:template match=""/s0:PeopleOrigin"">
    <ns0:PeopleTarget>
      <xsl:for-each select=""Client"">
        <Person>
          <xsl:variable name=""var:v1"" select=""userCSharp:ReturnCounter()"" />
          <LineNumber>
            <xsl:value-of select=""$var:v1"" />
          </LineNumber>
          <xsl:variable name=""var:v2"" select=""userCSharp:IncrementCounter()"" />
          <xsl:value-of select=""$var:v2"" />
        </Person>
      </xsl:for-each>
    </ns0:PeopleTarget>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
int myCounter = 0;

public void IncrementCounter()
{
    myCounter += 1;
}


public int ReturnCounter()
{
   return myCounter;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"HowMapsWorks.Schemas.PeopleOrigin";
        
        private const global::HowMapsWorks.Schemas.PeopleOrigin _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"HowMapsWorks.Schemas.PeopleTarget";
        
        private const global::HowMapsWorks.Schemas.PeopleTarget _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"HowMapsWorks.Schemas.PeopleOrigin";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"HowMapsWorks.Schemas.PeopleTarget";
                return _TrgSchemas;
            }
        }
    }
}
