namespace OmitXMLDeclaration {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OmitXMLDeclaration.Input", typeof(global::OmitXMLDeclaration.Input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OmitXMLDeclaration.Output", typeof(global::OmitXMLDeclaration.Output))]
    public sealed class OmitXMLDeclaration : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://OmitXMLDeclaration.Output"" xmlns:s0=""http://OmitXMLDeclaration.Input"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Input"" />
  </xsl:template>
  <xsl:template match=""/s0:Input"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(Name/text()) , &quot; &quot; , string(LastName/text()))"" />
    <ns0:Output>
      <Fullname>
        <xsl:value-of select=""$var:v1"" />
      </Fullname>
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
        
        private const string _strSrcSchemasList0 = @"OmitXMLDeclaration.Input";
        
        private const global::OmitXMLDeclaration.Input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"OmitXMLDeclaration.Output";
        
        private const global::OmitXMLDeclaration.Output _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"OmitXMLDeclaration.Input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"OmitXMLDeclaration.Output";
                return _TrgSchemas;
            }
        }
    }
}
