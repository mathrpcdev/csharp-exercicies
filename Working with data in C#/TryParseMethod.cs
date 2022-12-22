/*
Author: Matheus Cavalcante
Data: 21/12/22
 */
 
string value = "102";
int result = 0;

// O parâmetro 'out' sempre virá antes da variável que for receber o parâmetro out.
// A variável precisa ser inicializada antes do método(.TryParse()) que for armazenar o valor do parâmetro out.
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to repoty the measurement.");
}

// A variável 'result' é global, então ela também pode ser manipulada fora do if-else statements.

Console.WriteLine($"Measuremente (w/ offset): {50 + result}");

// Intencionalmente fazendo com que o método TryParse dê erro de conversão de string para int.
string value2 = "bad";
int result2 = 0;

if (int.TryParse(value2, out result2))
{
    Console.WriteLine($"Measurement: {result2}"); // False
}
else
{
    Console.WriteLine("Unable to report the measurement"); // Esta será a saída verdadeira.
}
if (result2 > 0)
    Console.WriteLine($"Measurement (with offset): {50 + result2}"); // False
// TryParse() returns true if the conversion is successful, false if it's unsuccessful.
