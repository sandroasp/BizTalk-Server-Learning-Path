namespace HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary", typeof(global::HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes", typeof(global::HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes))]
    public sealed class mapTriggerUnnecessaryToSQLGetCodes : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/usp_GetCodes"" xmlns:s0=""http://HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TriggerUnnecessary"" />
  </xsl:template>
  <xsl:template match=""/s0:TriggerUnnecessary"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:usp_GetCodes>
      <xsl:value-of select=""$var:v1"" />
    </ns0:usp_GetCodes>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary";
        
        private const global::HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes";
        
        private const global::HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo.usp_GetCodes _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"HowToCallSQLStoredProcedureWithoutInputs._03_UnnecessaryApproach.TriggerUnnecessary";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"HowToCallSQLStoredProcedureWithoutInputs.SQL_TypedProcedure_dbo+usp_GetCodes";
                return _TrgSchemas;
            }
        }
    }
}
