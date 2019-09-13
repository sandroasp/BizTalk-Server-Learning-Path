namespace HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon", typeof(global::HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo+usp_GetCodesWithDummyInput", typeof(global::HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInput))]
    public sealed class mapTriggerToSQLGetCodes : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/usp_GetCodesWithDummyInput"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TriggerCommon"" />
  </xsl:template>
  <xsl:template match=""/s0:TriggerCommon"">
    <ns0:usp_GetCodesWithDummyInput>
      <ns0:Dummy>
        <xsl:value-of select=""Start/text()"" />
      </ns0:Dummy>
    </ns0:usp_GetCodesWithDummyInput>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon";
        
        private const global::HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo+usp_GetCodesWithDummyInput";
        
        private const global::HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo.usp_GetCodesWithDummyInput _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"HowToCallSQLStoredProcedureWithoutInputs._01_MostCommonSituation.TriggerCommon";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"HowToCallSQLStoredProcedureWithoutInputs.SQL_COMMON_TypedProcedure_dbo+usp_GetCodesWithDummyInput";
                return _TrgSchemas;
            }
        }
    }
}
