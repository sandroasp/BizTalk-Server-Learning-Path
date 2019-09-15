namespace WorkingWithConditions._04_IfThenElseRecursiveRecords {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance", typeof(global::WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq", typeof(global::WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq))]
    public sealed class MapIfInsideLoop4 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperIFinLoppingRecord.OutputReq"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/GetPIArchiveDataResult"" />
  </xsl:template>
  <xsl:template match=""/GetPIArchiveDataResult"">
    <ns0:Req>
      <xsl:choose>
  <xsl:when test=""count(//TimeSeries[@Path='1']) &gt; 0"">
    <Quantity>
      <xsl:value-of select=""//TimeSeries[@Path='1']/TimedValues/TimedValue/text()"" />
    </Quantity>
  </xsl:when>
</xsl:choose>
      <xsl:choose>
  <xsl:when test=""count(//TimeSeries[@Path='2']) &gt; 0"">
    <NRJQuantity>
      <xsl:value-of select=""//TimeSeries[@Path='2']/TimedValues/TimedValue/text()"" />
    </NRJQuantity>
  </xsl:when>
</xsl:choose>
      <xsl:choose>
  <xsl:when test=""count(//TimeSeries[@Path='3']) &gt; 0"">
    <AvgCal>
      <xsl:value-of select=""//TimeSeries[@Path='3']/TimedValues/TimedValue/text()"" />
    </AvgCal>
  </xsl:when>
</xsl:choose>
      <xsl:choose>
  <xsl:when test=""count(//TimeSeries[@Path='4']) &gt; 0"">
    <AvgDens>
      <xsl:value-of select=""//TimeSeries[@Path='4']/TimedValues/TimedValue/text()"" />
    </AvgDens>
  </xsl:when>
</xsl:choose>
    </ns0:Req>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance";
        
        private const global::WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq";
        
        private const global::WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq";
                return _TrgSchemas;
            }
        }
    }
}
