namespace POC.BizTalk.PropertyDemotion {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"POC.BizTalk.PropertyDemotion.Person", typeof(global::POC.BizTalk.PropertyDemotion.Person))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"POC.BizTalk.PropertyDemotion.Registration", typeof(global::POC.BizTalk.PropertyDemotion.Registration))]
    public sealed class mapPersonToRegistration : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://POC.BizTalk.PropertyDemotion.Person"" xmlns:ns0=""http://POC.BizTalk.PropertyDemotion.Registration"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Person"" />
  </xsl:template>
  <xsl:template match=""/s0:Person"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FirstName/text()) , &quot; &quot; , string(LastName/text()))"" />
    <ns0:Registration>
      <FullName>
        <xsl:value-of select=""$var:v1"" />
      </FullName>
      <Nacionality>
        <xsl:value-of select=""Nacionality/text()"" />
      </Nacionality>
      <Sex>
        <xsl:value-of select=""Sex/text()"" />
      </Sex>
      <Age>
        <xsl:value-of select=""Age/text()"" />
      </Age>
      <SubmissionDate>
        <xsl:text />
      </SubmissionDate>
      <MessageType>
        <xsl:text />
      </MessageType>
    </ns0:Registration>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"POC.BizTalk.PropertyDemotion.Person";
        
        private const global::POC.BizTalk.PropertyDemotion.Person _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"POC.BizTalk.PropertyDemotion.Registration";
        
        private const global::POC.BizTalk.PropertyDemotion.Registration _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltEngine {
            get {
                return _xsltEngine;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
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
                _SrcSchemas[0] = @"POC.BizTalk.PropertyDemotion.Person";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"POC.BizTalk.PropertyDemotion.Registration";
                return _TrgSchemas;
            }
        }
    }
}
