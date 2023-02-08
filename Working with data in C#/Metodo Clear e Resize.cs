/* 
Matheus Cavalcante
08/02/2023
Objetivos: 1. Entender o comprimendo dos arrays, 2. limpar indexes, 3. adicionar novos indes,
4. adicionar novos elementos aos novos indexes, 5. Eliminar indexes.
 */

Console.WriteLine($"Este exercício contém um array de 4 indexes.");
Console.WriteLine($"[B14] - [A11] - [B12] - [A13]");

//   Indexes:         [0]    [1]    [2]     [3]
string[] pallets = { "B14", "A11", "B12", "A13" }; // O comprimento(Length) é de 4 casas/índices(indexes).
Console.WriteLine("");

Console.WriteLine($"O index [0] contém: [ {pallets[0]} ]");
Console.WriteLine("");
Console.WriteLine($"Abaixo iremos limpar o array do index 0 até o index 1, ou seja, 2 casas serão limpadas.");
Array.Clear(pallets, 0, 2); // (Array, index, Length)
Console.WriteLine($"Agora o index [0] contém: {pallets[0]} arrays.");

Console.WriteLine($"Limpando 2 casas de {pallets.Length} casas.");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Entendendo how to throw exceptions:
string[] indices = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Antes: {indices[0].ToLower()}");
Array.Clear(indices, 0, 2);
if (indices[0] != null)
//
{
    Console.WriteLine($"Depois: {indices[0].ToLower()}");
}

Console.WriteLine($"Clearing 2 ... count: {indices.Length}");
foreach (var indice in indices)
{
    Console.WriteLine($"-- {indice}");
}

// ends here.

// Resize the array to add more elements:

string[] objetos = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(objetos, 0, 2);
Console.WriteLine($"Clearing 2 .. count: {objetos.Length}");
foreach (var objeto in objetos)
{
    Console.WriteLine($"-- {objeto}");
}
Console.WriteLine("");
Array.Resize(ref objetos, 6);
Console.WriteLine($"Resizing 6 ... count: {objetos.Length}");

objetos[4] = "C01";
objetos[5] = "C02";

foreach (var objeto in objetos)
{
    Console.WriteLine($"-- {objeto}");
}

Console.WriteLine("");
Array.Resize(ref objetos, 3);
Console.WriteLine($"Resizing 3 ... count: {objetos.Length}");

foreach (var objeto in objetos)
{
    Console.WriteLine($"-- {objeto}");
}
