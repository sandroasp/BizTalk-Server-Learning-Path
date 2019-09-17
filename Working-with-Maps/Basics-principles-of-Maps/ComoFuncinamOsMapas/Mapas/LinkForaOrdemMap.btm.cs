namespace ComoFuncinamOsMapas.Mapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.Schema1", typeof(global::ComoFuncinamOsMapas.Schemas.Schema1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.Schema2", typeof(global::ComoFuncinamOsMapas.Schemas.Schema2))]
    public sealed class LinkForaOrdemMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://ComoFuncinamOsMapas.Schema2"" xmlns:s0=""http://ComoFuncinamOsMapas.Schema1"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Origem"" />
  </xsl:template>
  <xsl:template match=""/s0:Origem"">
    <ns0:Destino>
      <xsl:for-each select=""Cliente"">
        <Pessoa>
          <xsl:variable name=""var:v1"" select=""userCSharp:RetornarContador()"" />
          <Linha>
            <xsl:value-of select=""$var:v1"" />
          </Linha>
          <xsl:variable name=""var:v2"" select=""userCSharp:IncrementarContador()"" />
          <xsl:value-of select=""$var:v2"" />
        </Pessoa>
      </xsl:for-each>
    </ns0:Destino>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
int contador = 0;

public void IncrementarContador()
{
    contador += 1;
}


public int RetornarContador()
{
   return contador;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ComoFuncinamOsMapas.Schemas.Schema1";
        
        private const global::ComoFuncinamOsMapas.Schemas.Schema1 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ComoFuncinamOsMapas.Schemas.Schema2";
        
        private const global::ComoFuncinamOsMapas.Schemas.Schema2 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"ComoFuncinamOsMapas.Schemas.Schema1";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ComoFuncinamOsMapas.Schemas.Schema2";
                return _TrgSchemas;
            }
        }
    }
}
