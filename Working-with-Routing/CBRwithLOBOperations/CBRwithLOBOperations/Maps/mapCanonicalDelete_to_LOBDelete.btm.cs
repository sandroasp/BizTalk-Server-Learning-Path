namespace CBRwithLOBOperations.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CBRwithLOBOperations.DeletePerson", typeof(global::CBRwithLOBOperations.DeletePerson))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Delete", typeof(global::CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person.Delete))]
    public sealed class mapCanonicalDelete_to_LOBDelete : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://CBRwithLOBOperations.DeletePerson"" xmlns:array=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/Person"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:DeletePerson"" />
  </xsl:template>
  <xsl:template match=""/s0:DeletePerson"">
    <ns0:Delete>
      <ns0:Rows>
        <ns3:Person>
          <ns3:CitizenCard>
            <xsl:value-of select=""CitizenCard/text()"" />
          </ns3:CitizenCard>
        </ns3:Person>
      </ns0:Rows>
    </ns0:Delete>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CBRwithLOBOperations.DeletePerson";
        
        private const global::CBRwithLOBOperations.DeletePerson _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Delete";
        
        private const global::CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person.Delete _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"CBRwithLOBOperations.DeletePerson";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CBRwithLOBOperations.SQL_OP_TableOperation_dbo_Person+Delete";
                return _TrgSchemas;
            }
        }
    }
}
