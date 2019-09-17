namespace ComoFuncinamOsMapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.Schema1", typeof(global::ComoFuncinamOsMapas.Schemas.Schema1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.Schema2", typeof(global::ComoFuncinamOsMapas.Schemas.Schema2))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://ComoFuncinamOsMapas.Schema2"" xmlns:s0=""http://ComoFuncinamOsMapas.Schema1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Origem"" />
  </xsl:template>
  <xsl:template match=""/s0:Origem"">
    <ns0:Destino>
      <xsl:for-each select=""Empregado"">
        <Pessoa>
          <Nome>
            <xsl:value-of select=""Nome/text()"" />
          </Nome>
          <Sexo>
            <xsl:value-of select=""Sexo/text()"" />
          </Sexo>
        </Pessoa>
      </xsl:for-each>
      <xsl:for-each select=""Cliente"">
        <Pessoa>
          <Nome>
            <xsl:value-of select=""Nome/text()"" />
          </Nome>
          <Sexo>
            <xsl:value-of select=""Sexo/text()"" />
          </Sexo>
        </Pessoa>
      </xsl:for-each>
    </ns0:Destino>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ComoFuncinamOsMapas.Schemas.Schema1";
        
        private const string _strTrgSchemasList0 = @"ComoFuncinamOsMapas.Schemas.Schema2";
        
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
