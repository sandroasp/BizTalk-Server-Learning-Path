namespace SandroPereira.NameValueToHierarchical.Solution1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.NameValueToHierarchical.Provisioning", typeof(global::SandroPereira.NameValueToHierarchical.Provisioning))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SandroPereira.NameValueToHierarchical.NameValueSchema", typeof(global::SandroPereira.NameValueToHierarchical.NameValueSchema))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://SandroPereira.NameValueToHierarchical.Request"" xmlns:s0=""http://SandroPereira.NameValueToHierarchical.Provisioning"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Provisioning"" />
  </xsl:template>
  <xsl:template match=""/s0:Provisioning"">
    <ns0:Request>
      <Header>
        <Nprocesso>
          <xsl:value-of select=""Id/text()"" />
        </Nprocesso>
      </Header>
      <Body>
        <ServiceName>
          <xsl:value-of select=""ServiceName/text()"" />
        </ServiceName>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(Name/text()) , &quot;Type&quot;)"" />
          <xsl:if test=""string($var:v1)='true'"">
            <xsl:variable name=""var:v2"" select=""Value/text()"" />
            <Type>
              <xsl:value-of select=""$var:v2"" />
            </Type>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v3"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;Protocol&quot;)"" />
          <xsl:if test=""string($var:v4)='true'"">
            <xsl:variable name=""var:v5"" select=""Value/text()"" />
            <Protocol>
              <xsl:value-of select=""$var:v5"" />
            </Protocol>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v6"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:LogicalEq($var:v6 , &quot;Pool&quot;)"" />
          <xsl:if test=""string($var:v7)='true'"">
            <xsl:variable name=""var:v8"" select=""Value/text()"" />
            <Pool>
              <xsl:value-of select=""$var:v8"" />
            </Pool>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v9"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v10"" select=""userCSharp:LogicalEq($var:v9 , &quot;VPNName&quot;)"" />
          <xsl:if test=""string($var:v10)='true'"">
            <xsl:variable name=""var:v11"" select=""Value/text()"" />
            <VPNName>
              <xsl:value-of select=""$var:v11"" />
            </VPNName>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v12"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v13"" select=""userCSharp:LogicalEq($var:v12 , &quot;IPAddress&quot;)"" />
          <xsl:if test=""string($var:v13)='true'"">
            <xsl:variable name=""var:v14"" select=""Value/text()"" />
            <IPAddress>
              <xsl:value-of select=""$var:v14"" />
            </IPAddress>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v15"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v16"" select=""userCSharp:LogicalEq($var:v15 , &quot;IPNetmask&quot;)"" />
          <xsl:if test=""string($var:v16)='true'"">
            <xsl:variable name=""var:v17"" select=""Value/text()"" />
            <IPNetmask>
              <xsl:value-of select=""$var:v17"" />
            </IPNetmask>
          </xsl:if>
        </xsl:for-each>
        <LAN>
          <xsl:for-each select=""Properties/Property"">
            <xsl:variable name=""var:v18"" select=""string(Name/text())"" />
            <xsl:variable name=""var:v19"" select=""userCSharp:LogicalEq($var:v18 , &quot;IPRoute&quot;)"" />
            <xsl:if test=""$var:v19"">
              <xsl:if test=""string($var:v19)='true'"">
                <xsl:variable name=""var:v20"" select=""Value/text()"" />
                <IPRoute>
                  <xsl:value-of select=""$var:v20"" />
                </IPRoute>
              </xsl:if>
            </xsl:if>
          </xsl:for-each>
        </LAN>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v21"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v22"" select=""userCSharp:LogicalEq($var:v21 , &quot;Profile&quot;)"" />
          <xsl:if test=""string($var:v22)='true'"">
            <xsl:variable name=""var:v23"" select=""Value/text()"" />
            <Profile>
              <xsl:value-of select=""$var:v23"" />
            </Profile>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v24"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v25"" select=""userCSharp:LogicalEq($var:v24 , &quot;VirtualRouter&quot;)"" />
          <xsl:if test=""string($var:v25)='true'"">
            <xsl:variable name=""var:v26"" select=""Value/text()"" />
            <VirtualRouter>
              <xsl:value-of select=""$var:v26"" />
            </VirtualRouter>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v27"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v28"" select=""userCSharp:LogicalEq($var:v27 , &quot;IdleTimeout&quot;)"" />
          <xsl:if test=""string($var:v28)='true'"">
            <xsl:variable name=""var:v29"" select=""Value/text()"" />
            <IdleTimeout>
              <xsl:value-of select=""$var:v29"" />
            </IdleTimeout>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v30"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v31"" select=""userCSharp:LogicalEq($var:v30 , &quot;SessionTimeout&quot;)"" />
          <xsl:if test=""string($var:v31)='true'"">
            <xsl:variable name=""var:v32"" select=""Value/text()"" />
            <SessionTimeout>
              <xsl:value-of select=""$var:v32"" />
            </SessionTimeout>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Properties/Property"">
          <xsl:variable name=""var:v33"" select=""string(Name/text())"" />
          <xsl:variable name=""var:v34"" select=""userCSharp:LogicalEq($var:v33 , &quot;TunnelType&quot;)"" />
          <xsl:if test=""string($var:v34)='true'"">
            <xsl:variable name=""var:v35"" select=""Value/text()"" />
            <TunnelType>
              <xsl:value-of select=""$var:v35"" />
            </TunnelType>
          </xsl:if>
        </xsl:for-each>
      </Body>
    </ns0:Request>
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
        
        private const string _strSrcSchemasList0 = @"SandroPereira.NameValueToHierarchical.Provisioning";
        
        private const global::SandroPereira.NameValueToHierarchical.Provisioning _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SandroPereira.NameValueToHierarchical.NameValueSchema";
        
        private const global::SandroPereira.NameValueToHierarchical.NameValueSchema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SandroPereira.NameValueToHierarchical.Provisioning";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SandroPereira.NameValueToHierarchical.NameValueSchema";
                return _TrgSchemas;
            }
        }
    }
}
