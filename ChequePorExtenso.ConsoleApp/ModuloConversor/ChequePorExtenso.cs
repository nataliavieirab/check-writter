namespace ModuloConversor;

public static class ChequePorExtenso
{
  public static string Converter(decimal valor)
  {
    // Transforma valor em inteiro (2.25 | valorReais = 2)
    int valorReais = (int)valor;

    // Pega somente os decimais (2.25 | valorCentavos: 0.25) e
    // Transforma em inteiro (valorCentavos: 25)
    int valorCentavos = (int)Math.Round((valor - valorReais) * 100);

    string resultado = "";

    // REAIS
    if (valorReais > 0)
    {
      string reaisPorExtenso = NumeroPorExtenso.Converter(valorReais);

      string palavraReal = valorReais == 1
        ? "real"
        : "reais";

      resultado += $"{reaisPorExtenso} {palavraReal}";
    }

    // CENTAVOS
    if (valorCentavos > 0)
    {
      string centavosPorExtenso = NumeroPorExtenso.Converter(valorCentavos);

      string palavraCentavo = valorCentavos == 1
        ? "centavo"
        : "centavos";

      if (resultado != "")
        resultado += " e ";

      resultado += $"{centavosPorExtenso} {palavraCentavo}";
    }

    return resultado;
  }
}