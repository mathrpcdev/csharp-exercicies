/* 
Este exercício serve para demonstrar que as variáveis dentro de um bloco de código IF é apenas visível dentro de 
seu próprio bloco de código. Variáveis locais != Variáveis globais.
 */

bool flag = true;
int value = 0;

if(flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");
