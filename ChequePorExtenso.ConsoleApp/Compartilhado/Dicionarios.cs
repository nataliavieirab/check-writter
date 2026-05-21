namespace Compartilhado;

public static class Dicionarios
{
  public static readonly Dictionary<int, string> UnidadesPorExtenso = new()
  {
    {0, "zero"},
    {1, "um"},
    {2, "dois"},
    {3, "três"},
    {4, "quatro"},
    {5, "cinco"},
    {6, "seis"},
    {7, "sete"},
    {8, "oito"},
    {9, "nove"},
  };

  public static readonly Dictionary<int, string> UnidadesDezPorExtenso = new()
  {
    {10, "dez"},
    {11, "onze"},
    {12, "doze"},
    {13, "treze"},
    {14, "quatorze"},
    {15, "quinze"},
    {16, "dezesseis"},
    {17, "dezessete"},
    {18, "dezoito"},
    {19, "dezenove"},
  };

  public static readonly Dictionary<int, string> DezenasPorExtenso = new()
  {
    {20, "vinte"},
    {30, "trinta"},
    {40, "quarenta"},
    {50, "cinquenta"},
    {60, "sessenta"},
    {70, "setenta"},
    {80, "oitenta"},
    {90, "noventa"},
  };

  public static readonly Dictionary<int, string> CentenasPorExtenso = new()
  {
    {1, "cento"},
    {2, "duzentos"},
    {3, "trezentos"},
    {4, "quatrocentos"},
    {5, "quinhentos"},
    {6, "seissentos"},
    {7, "setecentos"},
    {8, "oitocentos"},
    {9, "novecentos"},
  };
}