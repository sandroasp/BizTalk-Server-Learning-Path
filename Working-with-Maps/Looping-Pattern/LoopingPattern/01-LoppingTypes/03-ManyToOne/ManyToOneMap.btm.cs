namespace LoopingPattern._01_LoppingTypes._03_ManyToOne {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender", typeof(global::LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectParticipant", typeof(global::LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectParticipant))]
    public sealed class ManyToOneMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://LoopingPattern.ProjectTender"" xmlns:ns0=""http://LoopingPattern.ProjectParticipant"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ProjectTender"" />
  </xsl:template>
  <xsl:template match=""/s0:ProjectTender"">
    <ns0:ProjectParticipant>
      <ProjectName>
        <xsl:value-of select=""ProjectName/text()"" />
      </ProjectName>
      <ProjectReference>
        <xsl:value-of select=""ProjectReference/text()"" />
      </ProjectReference>
      <xsl:for-each select=""Vendor"">
        <Participant>
          <Company>
            <xsl:value-of select=""Company/text()"" />
          </Company>
          <ContactName>
            <xsl:value-of select=""ContactName/text()"" />
          </ContactName>
          <ContactRole>
            <xsl:value-of select=""ContactRole/text()"" />
          </ContactRole>
          <Address>
            <xsl:value-of select=""Address/text()"" />
          </Address>
          <City>
            <xsl:value-of select=""City/text()"" />
          </City>
          <Type>Vendor</Type>
        </Participant>
      </xsl:for-each>
      <Participant>
        <Company>
          <xsl:value-of select=""Client/Company/text()"" />
        </Company>
        <ContactName>
          <xsl:value-of select=""Client/ContactName/text()"" />
        </ContactName>
        <ContactRole>
          <xsl:value-of select=""Client/ContactRole/text()"" />
        </ContactRole>
        <Address>
          <xsl:value-of select=""Client/Address/text()"" />
        </Address>
        <City>
          <xsl:value-of select=""Client/City/text()"" />
        </City>
        <Type>Client</Type>
      </Participant>
      <xsl:for-each select=""DecisionMakers"">
        <Participant>
          <Company>
            <xsl:value-of select=""Company/text()"" />
          </Company>
          <ContactName>
            <xsl:value-of select=""ContactName/text()"" />
          </ContactName>
          <ContactRole>
            <xsl:value-of select=""ContactRole/text()"" />
          </ContactRole>
          <Address>
            <xsl:value-of select=""Address/text()"" />
          </Address>
          <City>
            <xsl:value-of select=""City/text()"" />
          </City>
          <Type>DecisionMakers</Type>
        </Participant>
      </xsl:for-each>
    </ns0:ProjectParticipant>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender";
        
        private const global::LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectParticipant";
        
        private const global::LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectParticipant _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectParticipant";
                return _TrgSchemas;
            }
        }
    }
}
