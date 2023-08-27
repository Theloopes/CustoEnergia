Console.WriteLine("Custo aproximado de energia com Ar condicionado.");
Console.WriteLine("");
Console.WriteLine("Qual o consumo em kWh por mês do aparelho?");
double kWh = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Quantas horas por dia você utiliza o Ar condicionado?");
double usodiario = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Qual o custo da energia por kWh?");
double vlEnergia = Convert.ToDouble(Console.ReadLine()!);
double custo = kWh * usodiario * vlEnergia;
double vlTotal = Math.Round(custo, 2);

Console.WriteLine("--- Custo de Energia ---");
Console.WriteLine("");
Console.WriteLine($"Consumo do aparelho (em kWh/mês)...: {kWh}");
Console.WriteLine($"Horas de uso por dia...............: {usodiario}");
Console.WriteLine($"Custo da energia (em R$/kWh).......: {vlEnergia}");
Console.WriteLine("");
Console.WriteLine($"Custo estimado: R${vlTotal}");