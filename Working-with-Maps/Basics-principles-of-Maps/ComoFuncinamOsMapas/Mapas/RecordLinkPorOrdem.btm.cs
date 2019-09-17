namespace ComoFuncinamOsMapas.Mapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.Schema1", typeof(global::ComoFuncinamOsMapas.Schemas.Schema1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.Schema2", typeof(global::ComoFuncinamOsMapas.Schemas.Schema2))]
    public sealed class RecordLinkPorOrdem : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://ComoFuncinamOsMapas.Schema2"" xmlns:s0=""http://ComoFuncinamOsMapas.Schema1"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Origem"" />
  </xsl:template>
  <xsl:template match=""/s0:Origem"">
    <ns0:Destino>
      <xsl:for-each select=""Cliente"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(Sexo/text()) , &quot;F&quot;)"" />
        <xsl:if test=""$var:v1"">
          <Pessoa>
            <Nome>
              <xsl:value-of select=""Nome/text()"" />
            </Nome>
          </Pessoa>
        </xsl:if>
      </xsl:for-each>
    </ns0:Destino>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
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
