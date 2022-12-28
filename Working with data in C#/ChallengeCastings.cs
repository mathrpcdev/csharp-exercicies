/*
Second Challenge: 27/12/2022
Ao final encontra-se a versão da Microsoft Learn.
 */

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Dividir value1 pelo value2
var result1 = value1 / value2;
result1 = Convert.ToInt32(result1);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//Dividir value2 pelo value3 e mostre o resultado convertido para decimal.
decimal result2 = (decimal)value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//Dividir o value3 pelo value1. Mostrar o resultado c/ casting para float.
float result3 = (float)value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// --> Microsoft Learn solution
int valor1 = 12;
decimal valor2 = 6.2m;
float valor3 = 4.3f;

int resultado1 = Convert.ToInt32((decimal)valor1 / valor2);
Console.WriteLine($"Divide valor1 by valor2, duisplay the resultado as an int: {resultado1}");

decimal resultado2 = valor2 / (decimal)valor3;
Console.WriteLine($"Divide valor2 by valor3, dysplay the resultado as a decimal: {resultado2}");

float resultado3 = valor3 / valor1;
Console.WriteLine($"Divide valor3 by valor1, display the resultado as a float: {resultado3}");
