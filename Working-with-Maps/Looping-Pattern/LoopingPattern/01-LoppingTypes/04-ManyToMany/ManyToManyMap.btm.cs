namespace LoopingPattern._01_LoppingTypes._04_ManyToMany {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender", typeof(global::LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LoopingPattern._01_LoppingTypes._04_ManyToMany.ProjectParticipant2", typeof(global::LoopingPattern._01_LoppingTypes._04_ManyToMany.ProjectParticipant2))]
    public sealed class ManyToManyMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://LoopingPattern.ProjectTender"" xmlns:ns0=""http://LoopingPattern.ProjectParticipant2"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ProjectTender"" />
  </xsl:template>
  <xsl:template match=""/s0:ProjectTender"">
    <ns0:ProjectParticipantDiv>
      <ProjectName>
        <xsl:value-of select=""ProjectName/text()"" />
      </ProjectName>
      <ProjectReference>
        <xsl:value-of select=""ProjectReference/text()"" />
      </ProjectReference>
      <xsl:for-each select=""Vendor"">
        <ExternalParticipant>
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
        </ExternalParticipant>
      </xsl:for-each>
      <InternalParticipant>
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
      </InternalParticipant>
      <xsl:for-each select=""DecisionMakers"">
        <InternalParticipant>
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
        </InternalParticipant>
      </xsl:for-each>
    </ns0:ProjectParticipantDiv>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender";
        
        private const global::LoopingPattern._01_LoppingTypes._03_ManyToOne.ProjectTender _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LoopingPattern._01_LoppingTypes._04_ManyToMany.ProjectParticipant2";
        
        private const global::LoopingPattern._01_LoppingTypes._04_ManyToMany.ProjectParticipant2 _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"LoopingPattern._01_LoppingTypes._04_ManyToMany.ProjectParticipant2";
                return _TrgSchemas;
            }
        }
    }
}
