/* 
Neste exercício retirei duas variáveis de um código local para ficar acessíveis globalmente
(variáveis: numbers, total e found). Assim feito, consegui fazer o código rodar.
 */

int[] numeros = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool achado = true;

foreach (int numero in numeros)
{
    total += numero;
    if (numero == 42)
    {
        if (achado)
        {
            Console.WriteLine("Set contains 42");
        }
    }
}
Console.WriteLine($"Total: {total}");

// --> Microsoft Learn Challenge Solution

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total2 = 0;
bool found = false;

foreach (int number in numbers)
{
    total2 += number;
    if (number == 42) found = true;
}

if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"total: {total2}");
