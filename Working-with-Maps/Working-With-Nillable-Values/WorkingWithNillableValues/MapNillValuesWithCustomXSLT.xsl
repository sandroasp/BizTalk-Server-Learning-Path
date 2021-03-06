<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0 userCSharp" version="1.0" xmlns:s0="http://WorkingWithNillableValues.InputSchema" xmlns:ns0="http://WorkingWithNillableValues.OutputSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s0:InputSchema" />
  </xsl:template>
  <xsl:template match="/s0:InputSchema">
    <ns0:OutputSchema>
      <xsl:choose>
        <xsl:when test="NillValue/@xsi:nil">
          <NillValueOutput>
            <xsl:attribute name="xsi:nil">
              <xsl:value-of select="'true'" />
            </xsl:attribute>
          </NillValueOutput>
        </xsl:when>
        <xsl:otherwise>
          <NillValueOutput>
            <xsl:value-of select="NillValue/text()" />
          </NillValueOutput>
        </xsl:otherwise>
      </xsl:choose>
      <xsl:choose>
        <xsl:when test="AnotherNilValue/@xsi:nil">
          <AnotherNilValueOutput>
            <xsl:attribute name="xsi:nil">
              <xsl:value-of select="'true'" />
            </xsl:attribute>
          </AnotherNilValueOutput>
        </xsl:when>
        <xsl:otherwise>
          <AnotherNilValueOutput>
            <xsl:value-of select="AnotherNilValue/text()" />
          </AnotherNilValueOutput>
        </xsl:otherwise>
      </xsl:choose>
    </ns0:OutputSchema>
  </xsl:template>
</xsl:stylesheet>