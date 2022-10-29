/*
Neste exercício eu inicio instanciando uma nova classe Random() alocando dois número aleatórios em duas variáveis.
Deve haver uma possibilidade de 50% para um ou outro jogardor ganharem a disputa.
******  No final segue a solução da Microsoft  ******
*/

Random randomNumber = new Random();

int cara = randomNumber.Next(1, 11);
int coroa = randomNumber.Next(1, 11);

string nameGibson = "Gibson";
string nameAna = "Ana";

if ((cara < 6) || (cara >= 0))
{
    Console.WriteLine($"Hello {nameGibson}, you rolled {cara}");
    Console.WriteLine($"You got the number {cara}. It's heads!");
}
if ((coroa >= 6) || (coroa <= 11))
{
    Console.WriteLine($"Hello {nameAna}, you rolled {coroa}. Congratulations!");
    Console.WriteLine($"You've got number {coroa}. It's tails!");
}

// --> Microsof Solution

Random coin = new Random();
int flip = coin.Next();
Console.WriteLine((flip == 0 ? "heads" : "tails"));
