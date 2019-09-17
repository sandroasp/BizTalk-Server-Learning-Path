namespace BizTalk.CallingExternalAssemblyFromInlineXSLT {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo", typeof(global::BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale", typeof(global::BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale))]
    public sealed class CarInfo_to_CarsOnSale : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo"" xmlns:ns0=""http://BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CarProperty"" />
  </xsl:template>
  <xsl:template match=""/s0:CarProperty"">
    <ns0:CarsOnSale>
      <xsl:for-each select=""Car"">
        <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FuelType/text()) , &quot;,&quot; , string(HP/text()) , &quot;,&quot; , string(Color/text()) , &quot;,&quot; , string(Observations/text()))"" />
        <Car>
          <Brand>
            <xsl:value-of select=""Brand/text()"" />
          </Brand>
          <Model>
            <xsl:value-of select=""Model/text()"" />
          </Model>
          <Year>
            <xsl:value-of select=""Year/text()"" />
          </Year>
          <TechnicalInfo>
            <xsl:value-of select=""$var:v1"" />
          </TechnicalInfo>
          <xsl:call-template name=""PriceTemplate"">
            <xsl:with-param name=""market"" select=""string(MarketPrice/text())"" />
            <xsl:with-param name=""owner"" select=""string(OwnerPrice/text())"" />
          </xsl:call-template>
          <OwnerInfo>
            <Name>
              <xsl:value-of select=""../OwnerName/text()"" />
            </Name>
            <Address>
              <xsl:value-of select=""../OwnerAddress/text()"" />
            </Address>
          </OwnerInfo>
        </Car>
      </xsl:for-each>
    </ns0:CarsOnSale>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6;
}



]]></msxsl:script>
  <xsl:template name=""PriceTemplate"">
  <xsl:param name=""market"" />
  <xsl:param name=""owner"" />
  <xsl:element name=""Price"">
    <xsl:variable name=""pmarket"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" select=""ScriptNS0:ToDecimalPoint($market)"" />
    <xsl:variable name=""powner"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" select=""ScriptNS0:ToDecimalPoint($owner)"" />
    <PriceMarket>
      <xsl:value-of select=""$pmarket"" />
    </PriceMarket>
    <PriceOwner>
      <xsl:value-of select=""$powner"" />
    </PriceOwner>
  </xsl:element>
</xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<?xml version=""1.0"" encoding=""utf-16""?>
<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MapperExtensionsFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cdbffba4cc751306"" ClassName=""MapperExtensionsFunctions.MappingFunctions"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo";
        
        private const global::BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale";
        
        private const global::BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalk.CallingExternalAssemblyFromInlineXSLT.CarInfo";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale";
                return _TrgSchemas;
            }
        }
    }
}
