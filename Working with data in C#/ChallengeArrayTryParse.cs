/*
First Challenge: 27/12/2022
Microsoft Learn Solution. *Não consegui fazer de primeira.*
 */


string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = ""; // Significa que eu iniciei essa string sendo NULA.

// O var(value) está recebendo os  valores contidos no array de strings.
foreach (var value in values) // A utilização do "var" quer dizer que a variável "value" irá receber os valores implícitos já declarados. Pode ser implicitamente uma string, um número ou um Listm por exemplo.
{
    decimal number;
    if (decimal.TryParse(value, out number)) // Recebi os valores do array e transfiro eles para a variável criada dentro do bloco foreach através do método TryParse()
    {
        total += number; // Recebo o resultado e somo ele com o valor já explícito -> 0m
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
