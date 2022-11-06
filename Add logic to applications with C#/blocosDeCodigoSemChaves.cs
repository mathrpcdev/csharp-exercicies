/*
Neste exercício aprendemos a como não usar as chaves de blocos de código
caso isso deixe o código mais limpo e legível.
Fazemos isso caso haja apenas uma linha em um bloco de código.
 */

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
