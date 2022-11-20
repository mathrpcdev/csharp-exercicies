/*
Author: Matheus Cavalcante
Exercício: Tipos de ponto flutuante(números fracionários) float, double e decimal
 */

/*
Em float e double é usado uma notação científica. Por exemplo:
O valor mínimo que o double pode armazenar é -3,4028235E+38, e o valor máximo é 3,4028235E+38.
A "notação E" significa que: "vezes 10 elevado à potência de"

Ou seja: 5E+38 no float significa: 5 * 10^38
Ex: 5E+2 = 5 * 10^2;  ou  5 * 10 * 10
 */

Console.WriteLine("");
Console.WriteLine("Floating point values");

Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue}");
Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue}");
