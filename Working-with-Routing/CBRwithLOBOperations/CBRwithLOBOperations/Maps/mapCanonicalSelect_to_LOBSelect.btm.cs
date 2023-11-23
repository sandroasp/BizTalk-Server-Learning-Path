namespace CBRwithLOBOperations.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CBRwithLOBOperations.SelectPersons", typeof(global::CBRwithLOBOperations.SelectPersons))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Select", typeof(global::CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person.Select))]
    public sealed class mapCanonicalSelect_to_LOBSelect : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://CBRwithLOBOperations.SelectPersons"" xmlns:array=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/Person"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:SelectPersons"" />
  </xsl:template>
  <xsl:template match=""/s0:SelectPersons"">
    <xsl:variable name=""var:v1"" select=""userCSharp:SetConstantValue(&quot;CitizenCard,FullName,Address,ZipCode,PhoneNumber,Email&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;WHERE FullName like '%&quot; , string(Name/text()) , &quot;%'&quot;)"" />
    <ns0:Select>
      <ns0:Columns>
        <xsl:value-of select=""$var:v1"" />
      </ns0:Columns>
      <ns0:Query>
        <xsl:value-of select=""$var:v2"" />
      </ns0:Query>
    </ns0:Select>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string SetConstantValue(string value)
{
	return value;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CBRwithLOBOperations.SelectPersons";
        
        private const global::CBRwithLOBOperations.SelectPersons _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Select";
        
        private const global::CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person.Select _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"CBRwithLOBOperations.SelectPersons";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Select";
                return _TrgSchemas;
            }
        }
    }
}
