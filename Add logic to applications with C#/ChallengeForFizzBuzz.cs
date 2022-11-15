/*
Author: Matheus Cavalcante
Ao final do Challenge segue a versão da plataforma Microsoft Learn.
O símbolo '%' chama-se módulo
 */

for (int number = 0; number <= 100; number++)
{
    if ((number % 3 == 0) && (number % 5 == 0)) // Obtém o módulo da divisão por 3 e por 5 e verifica se resta zero.
    {
        Console.WriteLine($"{number} - FizzBuzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine($"{number} - Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine($"{number} - Buzz");
    }
    else
    {
        Console.WriteLine($"{number}");
    }
}

/*
// Outra maneira que eu também fiz e deu certo:

for (int number = 0; number <= 100; number++)
{
    if (((number % 3) == 0) && ((number % 5) == 0))
    {
        
        Console.WriteLine($"{number} - FizzBuzz");
    }
    else if ((number % 3) == 0)
    {
        Console.WriteLine($"{number} - Fizz");
    }
    else if ((number % 5) == 0)
    {
        Console.WriteLine($"{number} - Buzz");
    }else{
        Console.WriteLine($"{number}");
    }

}
 */


// --> Microsoft Learn Solution:

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}
