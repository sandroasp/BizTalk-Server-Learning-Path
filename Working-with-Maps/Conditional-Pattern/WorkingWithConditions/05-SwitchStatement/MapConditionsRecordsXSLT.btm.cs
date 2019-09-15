namespace WorkingWithConditions.IfElseCondForMappingRecords {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions.Conditions", typeof(global::WorkingWithConditions.Conditions))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WorkingWithConditions.ConditionsResult2", typeof(global::WorkingWithConditions.ConditionsResult2))]
    public sealed class MapConditionsXSLT : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://WorkingWithConditions.ConditionsResult2"" xmlns:s0=""http://WorkingWithConditions.Conditions"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Conditions"" />
  </xsl:template>
  <xsl:template match=""/s0:Conditions"">
    <ns0:ConditionsResultTwo>
      <xsl:for-each select=""key('roles','CEO') | key('roles','Director')"">
   <BusinessManagers>
      <Name>
         <xsl:value-of select=""Name/text()"" />
      </Name>
      <Role>
         <xsl:value-of select=""Role/text()"" />
      </Role>
   </BusinessManagers>
</xsl:for-each>
      <xsl:for-each select=""key('roles','Business Assistant')"">
   <BusinessAssistant>
      <Name>
         <xsl:value-of select=""Name/text()"" />
      </Name>
      <Role>
         <xsl:value-of select=""Role/text()"" />
      </Role>
   </BusinessAssistant>
</xsl:for-each>
      <xsl:for-each select=""//Person[(Role != 'CEO') and (Role != 'Director') and (Role != 'Business Assistant')]"">
   <Employee>
      <Name>
         <xsl:value-of select=""Name/text()"" />
      </Name>
      <Role>
         <xsl:value-of select=""Role/text()"" />
      </Role>
      <xsl:choose>
    <xsl:when test=""string(AdditionalInfo/CivilStatus/text())='M'"">
      <CivilStatusDescription>Married</CivilStatusDescription>
   </xsl:when>
   <xsl:when test=""string(AdditionalInfo/CivilStatus/text())='S'"">
          <CivilStatusDescription>Single</CivilStatusDescription>
   </xsl:when>
   <xsl:otherwise>
         <CivilStatusDescription>Unknown</CivilStatusDescription>
    </xsl:otherwise>
  </xsl:choose> 
   </Employee>
</xsl:for-each>
    </ns0:ConditionsResultTwo>
  </xsl:template>
  <xsl:key name=""roles"" match=""Person"" use=""Role"" />
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"WorkingWithConditions.Conditions";
        
        private const global::WorkingWithConditions.Conditions _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WorkingWithConditions.ConditionsResult2";
        
        private const global::WorkingWithConditions.ConditionsResult2 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WorkingWithConditions.Conditions";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WorkingWithConditions.ConditionsResult2";
                return _TrgSchemas;
            }
        }
    }
}
