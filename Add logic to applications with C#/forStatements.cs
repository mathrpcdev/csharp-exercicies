string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

/* string[] nomes = { "Matheus", "Maria", "Letícia", "Fenômeno" };
foreach (var nome in nomes)
{
    // Não é possível re-assinar a variável nome
    if (nome == "Letícia")   nome = "Sammy";
} */

/*
Dessa maneira é possível ir até determinado Index e substituir o valor dentro dele por outro valor.
 */
string[] nomes = { "Matheus", "Maria", "Letícia", "Fenômeno" };
for (int contagem = 0; contagem < nomes.Length; contagem++)
{
    if (nomes[contagem] == "Letícia")
        nomes[contagem] = "Sammy";
    foreach (var nome in nomes)
    {
        Console.WriteLine(nome);
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int j = 10; j >= 0; j--)
{
    Console.WriteLine(j);
}

for (int counter = 0; counter < 10; counter += 3)
{
    Console.WriteLine(counter);
}

for (int contador = 0; contador < 10; contador++)
{
    Console.WriteLine(contador);
    if (contador == 7)
        break;
}
