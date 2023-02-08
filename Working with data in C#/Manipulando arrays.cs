string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine(
    $"Este exercício de array de pallets contém {pallets.Length} elementos de string.");
Console.WriteLine($"___________________________________________________________________");

Console.WriteLine($"Antes de limpar as duas primeiras células [{pallets[0]}] . . .");
Array.Clear(pallets, 0, 2);
Console.WriteLine(" . .. .");

//Console.WriteLine($"Depois de pimpar as duas primeiras células: {pallets[0]}");
Console.WriteLine("");

foreach (var pallet in pallets) // Variável permanente --
{
    Console.WriteLine($"-- {pallet}"); // Outputs all the 4 cells.
}
Console.WriteLine("");

Console.WriteLine($"Limparei 2 células de array ... de {pallets.Length} no total das células.");
foreach (var pallet in pallets) // Variável permanente --
{
    Console.WriteLine($"-- {pallet}"); // Outputs all the 4 cells.
}
