namespace HowToSendOrchestrationVariablesIntoMaps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToSendOrchestrationVariablesIntoMaps.Order", typeof(global::HowToSendOrchestrationVariablesIntoMaps.Order))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"HowToSendOrchestrationVariablesIntoMaps.SAPOrder", typeof(global::HowToSendOrchestrationVariablesIntoMaps.SAPOrder))]
    public sealed class OrderToSAPOrder : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://HowToSendOrchestrationVariablesIntoMaps.SAPOrder"" xmlns:s0=""http://HowToSendOrchestrationVariablesIntoMaps.Order"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Order"" />
  </xsl:template>
  <xsl:template match=""/s0:Order"">
    <Record field=""value"">
</Record>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"HowToSendOrchestrationVariablesIntoMaps.Order";
        
        private const global::HowToSendOrchestrationVariablesIntoMaps.Order _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"HowToSendOrchestrationVariablesIntoMaps.SAPOrder";
        
        private const global::HowToSendOrchestrationVariablesIntoMaps.SAPOrder _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"HowToSendOrchestrationVariablesIntoMaps.Order";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"HowToSendOrchestrationVariablesIntoMaps.SAPOrder";
                return _TrgSchemas;
            }
        }
    }
}
