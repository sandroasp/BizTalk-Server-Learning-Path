namespace CBRwithLOBOperations.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+SelectResponse", typeof(global::CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person.SelectResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CBRwithLOBOperations.Response", typeof(global::CBRwithLOBOperations.Response))]
    public sealed class mapLOBSelect_to_CanonicalResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 s2 userCSharp"" version=""1.0"" xmlns:ns0=""http://CBRwithLOBOperations.Response"" xmlns:s0=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:s2=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/Person"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:SelectResponse"" />
  </xsl:template>
  <xsl:template match=""/s2:SelectResponse"">
    <xsl:variable name=""var:v1"" select=""userCSharp:SetConstantValue(&quot;Operation completed&quot;)"" />
    <ns0:Response>
      <Status>
        <Status>
          <xsl:value-of select=""$var:v1"" />
        </Status>
      </Status>
      <xsl:for-each select=""s2:SelectResult"">
        <xsl:for-each select=""s1:Person"">
          <Person>
            <xsl:if test=""s1:CitizenCard"">
              <CitizenCard>
                <xsl:value-of select=""s1:CitizenCard/text()"" />
              </CitizenCard>
            </xsl:if>
            <xsl:if test=""s1:FullName"">
              <FullName>
                <xsl:value-of select=""s1:FullName/text()"" />
              </FullName>
            </xsl:if>
            <xsl:if test=""s1:Address"">
              <Address>
                <xsl:value-of select=""s1:Address/text()"" />
              </Address>
            </xsl:if>
            <xsl:if test=""s1:ZipCode"">
              <ZipCode>
                <xsl:value-of select=""s1:ZipCode/text()"" />
              </ZipCode>
            </xsl:if>
            <xsl:if test=""s1:PhoneNumber"">
              <PhoneNumber>
                <xsl:value-of select=""s1:PhoneNumber/text()"" />
              </PhoneNumber>
            </xsl:if>
            <xsl:if test=""s1:Email"">
              <Email>
                <xsl:value-of select=""s1:Email/text()"" />
              </Email>
            </xsl:if>
          </Person>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:Response>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string SetConstantValue(string value)
{
	return value;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+SelectResponse";
        
        private const global::CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person.SelectResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CBRwithLOBOperations.Response";
        
        private const global::CBRwithLOBOperations.Response _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
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
                _SrcSchemas[0] = @"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+SelectResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CBRwithLOBOperations.Response";
                return _TrgSchemas;
            }
        }
    }
}
