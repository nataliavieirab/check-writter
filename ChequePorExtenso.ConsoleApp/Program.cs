using ModuloConversor;

decimal valorEntrada = 999;

Console.Clear();

Console.WriteLine($"\nValor de entrada: R$ {valorEntrada}");

string valorPorExtenso = ChequePorExtenso.Converter(valorEntrada);

Console.WriteLine($"\nValor por extenso:");
Console.WriteLine($">> {valorPorExtenso}");