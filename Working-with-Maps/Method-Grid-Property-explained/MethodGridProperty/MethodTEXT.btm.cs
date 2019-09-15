namespace MethodGridProperty {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MethodGridProperty.Input", typeof(global::MethodGridProperty.Input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MethodGridProperty.Output", typeof(global::MethodGridProperty.Output))]
    public sealed class MethodTEXT : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://MethodGridProperty.Input"" xmlns:ns0=""http://MethodGridProperty.Output"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""text"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Input"" />
  </xsl:template>
  <xsl:template match=""/s0:Input"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(Name/text()) , &quot; &quot; , string(LastName/text()))"" />
    <ns0:Output>
      <FullName>
        <xsl:value-of select=""$var:v1"" />
      </FullName>
      <Age>
        <xsl:value-of select=""Age/text()"" />
      </Age>
    </ns0:Output>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MethodGridProperty.Input";
        
        private const global::MethodGridProperty.Input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MethodGridProperty.Output";
        
        private const global::MethodGridProperty.Output _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MethodGridProperty.Input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MethodGridProperty.Output";
                return _TrgSchemas;
            }
        }
    }
}
