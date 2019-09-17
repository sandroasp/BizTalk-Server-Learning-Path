namespace JoinMultipleMessages {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"JoinMultipleMessages.InuputUsers", typeof(global::JoinMultipleMessages.InuputUsers))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"JoinMultipleMessages.InputAddresses", typeof(global::JoinMultipleMessages.InputAddresses))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"JoinMultipleMessages.OutputMessage", typeof(global::JoinMultipleMessages.OutputMessage))]
    public sealed class Transform_User_and_Addresses_In_Output : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s1 s0"" version=""1.0"" xmlns:ns0=""http://BizTalk_Server_GenerationFichiersReleve.Test3"" xmlns:s1=""http://BizTalk_Server_GenerationFichiersReleve.test"" xmlns:s0=""http://BizTalk_Server_GenerationFichiersReleve.Test2"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <ns0:Informations>
      <Users>
        <xsl:for-each select=""InputMessagePart_0/s1:Users/User"">
          <User>
            <UserID>
              <xsl:value-of select=""UserID/text()"" />
            </UserID>
            <LastName>
              <xsl:value-of select=""LastName/text()"" />
            </LastName>
            <FirstName>
              <xsl:value-of select=""FirstName/text()"" />
            </FirstName>
            <xsl:call-template name=""AddressTemplate"">
              <xsl:with-param name=""id"" select=""string(UserID/text())"" />
            </xsl:call-template>
          </User>
        </xsl:for-each>
      </Users>
    </ns0:Informations>
  </xsl:template>
  <xsl:template name=""AddressTemplate"">
<xsl:param name=""id"" select=""UserID"" />

<Addresses>
<xsl:for-each select=""../../../InputMessagePart_1/s0:Addresses/Address[UserID=$id]"">

   <Address>
     <UserID>
     	<xsl:value-of select=""UserID/text()"" />
     </UserID>
     <AddressLine1>
     	<xsl:value-of select=""AddressLine1/text()"" />
     </AddressLine1>
     <PostCode>
     	<xsl:value-of select=""PostCode/text()"" />
     </PostCode>
     <Town>
     	<xsl:value-of select=""Town/text()"" />
     </Town>
  </Address>

  </xsl:for-each>
</Addresses>

</xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"JoinMultipleMessages.InuputUsers";
        
        private const global::JoinMultipleMessages.InuputUsers _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"JoinMultipleMessages.InputAddresses";
        
        private const global::JoinMultipleMessages.InputAddresses _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"JoinMultipleMessages.OutputMessage";
        
        private const global::JoinMultipleMessages.OutputMessage _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"JoinMultipleMessages.InuputUsers";
                _SrcSchemas[1] = @"JoinMultipleMessages.InputAddresses";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"JoinMultipleMessages.OutputMessage";
                return _TrgSchemas;
            }
        }
    }
}
