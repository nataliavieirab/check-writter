using ModuloConversor;

decimal valorEntrada = 55.55m;

Console.Clear();

Console.WriteLine($"\nValor de entrada: R$ {valorEntrada}");

string valorPorExtenso = ChequePorExtenso.Converter(valorEntrada);

Console.WriteLine($"\nValor por extenso:");
Console.WriteLine($">> {valorPorExtenso}");