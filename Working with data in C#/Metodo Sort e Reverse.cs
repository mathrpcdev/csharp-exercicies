/* 05/01/23
Métodos de ordenações de Arrays Sort() e Reverse().
Ambos os métodos seguem a ordem crescente e alfanumérica.
 */

string[] algo = { "B14", "A11", "B12", "A13" };
Array.Sort(algo); // Ordena em forma crescente e alfanumérica.
Console.WriteLine("Ordene...");
foreach (var algos in algo)
{
    Console.WriteLine($" -- {algos}");
}

Console.WriteLine("");

Array.Reverse(algo); // Ordena em forma decrescente e alfanumérica.
foreach (var algos in algo)
{
    Console.WriteLine($" -- {algos}");
}