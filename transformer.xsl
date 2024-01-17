<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html"/>

    <xsl:template match="/">
        <html>
            <body>
                <h2>Scientist Data</h2>
                <table border="1">
                    <tr>
                        <th>PIP</th>
                        <th>Name</th>
                        <th>Department</th>
                        <th>Branch</th>
                        <th>Scientific Degree</th>
                        <th>Academic Title</th>
                        <th>Title From Date</th>
                    </tr>
                    <xsl:for-each select="scientists/scientist">
                        <tr>
                            <td><xsl:value-of select="pip"/></td>
                            <td><xsl:value-of select="name"/></td>
                            <td><xsl:value-of select="faculty/department"/></td>
                            <td><xsl:value-of select="faculty/branch"/></td>
                            <td><xsl:value-of select="scientificDegree"/></td>
                            <td><xsl:value-of select="academicTitle/title"/></td>
                            <td><xsl:value-of select="academicTitle/fromDate"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
