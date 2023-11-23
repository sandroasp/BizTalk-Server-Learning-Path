namespace CBRwithLOBOperations.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CBRwithLOBOperations.Person", typeof(global::CBRwithLOBOperations.Person))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Insert", typeof(global::CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person.Insert))]
    public sealed class mapCanonicalAdd_to_LOBInsert : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://EAISQLDemo.Person"" xmlns:array=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/Person"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddPersons"" />
  </xsl:template>
  <xsl:template match=""/s0:AddPersons"">
    <ns0:Insert>
      <ns0:Rows>
        <xsl:for-each select=""Person"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(AddressLine1/text()) , &quot;, &quot; , string(AddressLine2/text()))"" />
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string(Phone/CountryCode/text()) , string(Phone/Prefix/text()) , string(Phone/Number/text()))"" />
          <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string(FirstName/text()) , &quot; &quot; , string(LastName/text()))"" />
          <ns3:Person>
            <xsl:if test=""Email"">
              <ns3:Email>
                <xsl:value-of select=""Email/text()"" />
              </ns3:Email>
            </xsl:if>
            <ns3:Address>
              <xsl:value-of select=""$var:v1"" />
            </ns3:Address>
            <ns3:CitizenCard>
              <xsl:value-of select=""CitizenCard/text()"" />
            </ns3:CitizenCard>
            <xsl:if test=""ZipCode"">
              <ns3:ZipCode>
                <xsl:value-of select=""ZipCode/text()"" />
              </ns3:ZipCode>
            </xsl:if>
            <ns3:PhoneNumber>
              <xsl:value-of select=""$var:v2"" />
            </ns3:PhoneNumber>
            <ns3:FullName>
              <xsl:value-of select=""$var:v3"" />
            </ns3:FullName>
          </ns3:Person>
        </xsl:for-each>
      </ns0:Rows>
    </ns0:Insert>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CBRwithLOBOperations.Person";
        
        private const global::CBRwithLOBOperations.Person _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Insert";
        
        private const global::CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person.Insert _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"CBRwithLOBOperations.Person";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Insert";
                return _TrgSchemas;
            }
        }
    }
}
