/*
Author: Matheus Cavalcante
Este exercício tem como objetivo avaliar e "massagear" expressões boleanas de modo que a decisão lógica saia
de acordo com que o programador deseja. Também nós é apresentados métodos da
classe string como Contains(), Trim(), EndsWith(), StartsWith(), ToUpper() and ToLower().
 */

Console.WriteLine("a" == "a"); //Outputs true
Console.WriteLine("a" == "A"); //Outputs false
Console.WriteLine(1 == 2); //Outputs false

string myValue = "a";
Console.WriteLine(myValue == "a"); //Outputs true

Console.WriteLine("a" == "a "); //Outputs false

string value1 = " a";
string value2 = "A ";
Console.WriteLine(
    "Massaging my result: Estou tirando os espaçoes em branco e colocando todas as letras em minúsculo. Depois disso avalio se as duas strings ficaram idênticas"
);
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); //Outputs true
Console.WriteLine();

Console.WriteLine("a" != "a"); //outputs false
Console.WriteLine("a" != "A"); //outputs true
Console.WriteLine(1 != 2); //outputs true

string myValue2 = "a";
Console.WriteLine(myValue2 != "a"); //outputs false

Console.WriteLine(1 > 2); //outputs false
Console.WriteLine(1 < 2); //outputs true
Console.WriteLine(1 >= 1); //outputs true
Console.WriteLine(1 <= 1); //outputs true

string pantograma = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pantograma.Contains("fox"));
Console.WriteLine(pantograma.Contains("cow"));

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

string pantograma3 = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pantograma3.Contains("fox"));
Console.WriteLine(!pantograma3.Contains("cow"));
