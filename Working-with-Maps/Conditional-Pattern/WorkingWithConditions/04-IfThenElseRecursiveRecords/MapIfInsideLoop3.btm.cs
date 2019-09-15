namespace WorkingWithConditions._04_IfThenElseRecursiveRecords {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance", typeof(global::WorkingWithConditions._04_IfThenElseRecursiveRecords.Instance))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq", typeof(global::WorkingWithConditions._04_IfThenElseRecursiveRecords.OutputReq))]
    public sealed class MapIfInsideLoop2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://BizTalkMapperIFinLoppingRecord.OutputReq"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/GetPIArchiveDataResult"" />
  </xsl:template>
  <xsl:template match=""/GetPIArchiveDataResult"">
    <ns0:Req>
      <xsl:for-each select=""TimeSeries"">
         <xsl:if test=""string(@Path) = '1' "">
            <Quantity>
              <xsl:value-of select=""TimedValues/TimedValue/text()"" />
            </Quantity>
        </xsl:if>
        <xsl:if test=""string(@Path) = '2' "">
            <NRJQuantity>
              <xsl:value-of select=""TimedValues/TimedValue/text()"" />
            </NRJQuantity>
        </xsl:if>
        <xsl:if test=""string(@Path) = '3' "">
            <AvgCal>
              <xsl:value-of select=""TimedValues/TimedValue/text()"" />
            </AvgCal>
        </xsl:if>
        <xsl:if test=""string(@Path) = '4' "">
            <AvgDens>
              <xsl:value-of select=""TimedValues/TimedValue/text()"" />
            </AvgDens>
        </xsl:if>
      </xsl:for-each>
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
