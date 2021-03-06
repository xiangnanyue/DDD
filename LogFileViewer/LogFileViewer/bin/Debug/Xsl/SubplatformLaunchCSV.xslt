<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="text" />
<xsl:template match="/">
	<xsl:choose>
		<xsl:when test="/Scenario/SubplatformLaunch">
			<xsl:for-each select="/Scenario/SubplatformLaunch">
				<xsl:value-of select="Parameter[4]/Value"/>
				<xsl:text>,</xsl:text>
				<xsl:value-of select="Parameter[1]/Value"/>
				<xsl:text>,</xsl:text>
				<xsl:value-of select="Parameter[2]/Value"/>
				<xsl:text>,</xsl:text>
				<xsl:value-of select="Parameter[3]/Value/LocationType/X"/>
				<xsl:text>,</xsl:text>
				<xsl:value-of select="Parameter[3]/Value/LocationType/Y"/>
				<xsl:text>,</xsl:text>
				<xsl:value-of select="Parameter[3]/Value/LocationType/Z"/>
				<xsl:text>&#10;</xsl:text>
			</xsl:for-each>
		</xsl:when>
		<xsl:otherwise>
			<xsl:text>0 records.</xsl:text>
		</xsl:otherwise>
	</xsl:choose>
</xsl:template>
</xsl:stylesheet>





