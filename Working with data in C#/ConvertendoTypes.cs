/*
Estes exercícios servirão para entender as regras de conversão em C#
Cast; Convert; ToString; ToInt32; .Parse().
Links importantes:
- https://learn.microsoft.com/en-us/dotnet/standard/base-types/conversion-tables
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
 */

/* Converversão de expansão é quando estou armazenando em um tipo de dado com espaço na memória maior que o
tipo de dado anterior, que tem um armazenamento de memória menor. Ou seja, não há perda de informação. */
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

decimal meuDecimal = 3.14m;
Console.WriteLine($"deciaml: {myDecimal}");

int meuInt = (int)meuDecimal; // Precisei fazer o casting e estou perdendo presisão.
Console.WriteLine($"int {meuInt}");

//

decimal myDecimal2 = 1.23456789m;
float myFloat = (float)myDecimal2; // Aqui estou perdendo a precisão do decimal, porém consigo fazer o casting.

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");

//
/* O ToString me permite converter tipos de dados numéricos em strings. */
int first = 5;
int second = 7;

string message = first.ToString() + second.ToString();
Console.WriteLine(message);

//


string primeiro = "5";
string segundo = "7";
int sum = int.Parse(primeiro) + int.Parse(segundo); // Estou convertendo strings para int e depois concateno. 5+7=57

Console.WriteLine(sum);

//
/* A classe .Convert é melhor usada para converter números fracionários para números inteiros e arredondando eles para cima.  */
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);

Console.WriteLine(result); // 5 * 7 = 35.

//
/* O casting sempre irá arredondar o número para baixo. Ex: (int)1.999m irá arredondar para 1.
Usando o Convert.ToInt32, por exemplo, se o número for 4.999m o número será arreedondado para baixo.
Se for 4.5, o número será arredondado para cima, ou seja, 5.
 */
int valor1 = (int)1.5m; // O número será arredondado para baixo.
Console.WriteLine(valor1);

int valor2 = Convert.ToInt32(1.5m); // O casting arredondará o número para cima.
Console.WriteLine(valor2);
