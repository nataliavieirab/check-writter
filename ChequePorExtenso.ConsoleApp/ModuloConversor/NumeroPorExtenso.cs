using Compartilhado;

namespace ModuloConversor;

public static class NumeroPorExtenso
{
  public static string Converter(int numero)
  {
    // Trata números de 0-9
    if (numero < 10)
      return Dicionarios.UnidadesPorExtenso[numero];

    // Trata números de 10-19
    if (numero < 20)
      return Dicionarios.UnidadesDezPorExtenso[numero];

    // Trata números de 20-99
    if (numero < 100)
    {
      int dezena = numero / 10 * 10;
      int unidade = numero % 10;

      if (unidade == 0)
        return Dicionarios.DezenasPorExtenso[dezena];

      return $"{Dicionarios.DezenasPorExtenso[dezena]} e {Dicionarios.UnidadesPorExtenso[unidade]}";
    }

    // Trata números de 100-999
    if (numero < 1000)
    {
      int centena = numero / 100;
      int resto = numero % 100;

      if (numero == 100)
        return "cem";

      if (resto == 0)
        return Dicionarios.CentenasPorExtenso[centena];

      return $"{Dicionarios.CentenasPorExtenso[centena]} e " + Converter(resto);
    }

    // Trata números de 1000-999999
    if (numero < 1000000)
    {
      int milhares = numero / 1000;
      int resto = numero % 1000;
    }


    return "";
  }
}