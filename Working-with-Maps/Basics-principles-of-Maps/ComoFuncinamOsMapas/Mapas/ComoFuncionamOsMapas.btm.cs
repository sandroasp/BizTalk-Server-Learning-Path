namespace ComoFuncinamOsMapas.Mapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.PessoaOrigem", typeof(global::ComoFuncinamOsMapas.Schemas.PessoaOrigem))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.PessoaDestino2", typeof(global::ComoFuncinamOsMapas.Schemas.PessoaDestino2))]
    public sealed class ComoFuncionamOsMapas : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://ComoFuncinamOsMapas.PessoaOrigem"" xmlns:ns0=""http://ComoFuncinamOsMapas.PessoaDestino2"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PessoaOrigem"" />
  </xsl:template>
  <xsl:template match=""/s0:PessoaOrigem"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalIsString(string(CodigoPostal/text()))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string(Nome/text()) , &quot; &quot; , string(Apelido/text()))"" />
    <ns0:PessoaDestino2>
      <Morada>
        <xsl:value-of select=""Morada/text()"" />
      </Morada>
      <xsl:if test=""string($var:v1)='true'"">
        <xsl:variable name=""var:v2"" select=""CodigoPostal/text()"" />
        <CodigoPostal>
          <xsl:value-of select=""$var:v2"" />
        </CodigoPostal>
      </xsl:if>
      <NomeCompleto>
        <xsl:value-of select=""$var:v3"" />
      </NomeCompleto>
      <xsl:variable name=""var:v4"" select=""userCSharp:CalcularIdade(string(DataNascimento/text()))"" />
      <Idade>
        <xsl:value-of select=""$var:v4"" />
      </Idade>
      <Facturacao>
        <xsl:variable name=""var:v5"" select=""userCSharp:InitCumulativeSum(0)"" />
        <xsl:for-each select=""/s0:PessoaOrigem/Chamada"">
          <xsl:variable name=""var:v6"" select=""userCSharp:StringLeft(string(@Destino) , &quot;4&quot;)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:LogicalEq(string($var:v6) , &quot;+351&quot;)"" />
          <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNot(string($var:v7))"" />
          <xsl:if test=""string($var:v8)='true'"">
            <xsl:variable name=""var:v9"" select=""@Custo"" />
            <xsl:variable name=""var:v10"" select=""userCSharp:AddToCumulativeSum(0,string($var:v9),&quot;1000&quot;)"" />
          </xsl:if>
        </xsl:for-each>
        <xsl:variable name=""var:v11"" select=""userCSharp:GetCumulativeSum(0)"" />
        <TotalInternacional>
          <xsl:value-of select=""$var:v11"" />
        </TotalInternacional>
        <xsl:variable name=""var:v12"" select=""userCSharp:InitCumulativeSum(1)"" />
        <xsl:for-each select=""/s0:PessoaOrigem/Chamada"">
          <xsl:variable name=""var:v13"" select=""string(@Destino)"" />
          <xsl:variable name=""var:v14"" select=""userCSharp:StringLeft($var:v13 , &quot;4&quot;)"" />
          <xsl:variable name=""var:v15"" select=""userCSharp:LogicalEq(string($var:v14) , &quot;+351&quot;)"" />
          <xsl:if test=""string($var:v15)='true'"">
            <xsl:variable name=""var:v16"" select=""@Custo"" />
            <xsl:variable name=""var:v17"" select=""userCSharp:AddToCumulativeSum(1,string($var:v16),&quot;1000&quot;)"" />
          </xsl:if>
        </xsl:for-each>
        <xsl:variable name=""var:v18"" select=""userCSharp:GetCumulativeSum(1)"" />
        <TotalNacional>
          <xsl:value-of select=""$var:v18"" />
        </TotalNacional>
      </Facturacao>
    </ns0:PessoaDestino2>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public bool LogicalIsString(string val)
{
	return (val != null && val !="""");
}


public int CalcularIdade(string dataNascimento)
{
   return (int)(DateTime.Now.Subtract(DateTime.Parse(dataNascimento)).TotalDays / 365.25);          
}

public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ComoFuncinamOsMapas.Schemas.PessoaOrigem";
        
        private const global::ComoFuncinamOsMapas.Schemas.PessoaOrigem _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ComoFuncinamOsMapas.Schemas.PessoaDestino2";
        
        private const global::ComoFuncinamOsMapas.Schemas.PessoaDestino2 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"ComoFuncinamOsMapas.Schemas.PessoaOrigem";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ComoFuncinamOsMapas.Schemas.PessoaDestino2";
                return _TrgSchemas;
            }
        }
    }
}
