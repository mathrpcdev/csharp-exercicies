using System;

class fraudulentOrderIDs
{
    static void Main(string[] args)
    {
        /* 
           Neste exercício estou criando/instanciando um array de uma dimenssão contendo 3 objetos.
           Documentação utilizada: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
           "Arrays are zero indexed: an array with n elements is indexed from 0 to n-1".
        
           O SEGUNDO ARRAY, PARA EXEISTIR, SEMPRE INICIARÁ COM ALGO.
           EX: int[] exem1 = new int[3];    
        */

        // ARRAYS SÃO DE BASE ZERO.
        string[] fraudulentOrderIDs = new string[3];
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        //fraudulentOrderIDs[3] = "D000";  <-- new string [3] significa que vai do [0] até o [2].

        // ----------------------------------------------------------------------------------------------------------------------

        //  INVOCANDO ARRAYS DE CARACTERES.
        Console.WriteLine($"First array: {fraudulentOrderIDs[0]} ");
        Console.WriteLine($"First array: {fraudulentOrderIDs[1]} ");
        Console.WriteLine($"First array: {fraudulentOrderIDs[2]} ");

        fraudulentOrderIDs[0] = "F00"; // ESTE ARRAY [0] É DIFERENTE DO PRIMEIRO [0] ARRAY ("A123)"
        Console.WriteLine($"Reassing First: {fraudulentOrderIDs[0]}");

        // -----------------------------------------------------------------------------------------------------------------

        // OUTRA MANEIRA DE INICIALIZAR UM ARRAY.
        string[] fraudulentOrderIDs2 = {"A123", "B456", "C789"};

        Console.WriteLine($"First inicialization: {fraudulentOrderIDs2[0]}");
        Console.WriteLine($"Second inicialization:{fraudulentOrderIDs2[1]}");
        Console.WriteLine($"Third inicialization: {fraudulentOrderIDs2[2]}");

        fraudulentOrderIDs[0] = "F000";

        //INVOCANDO O CONTEÚDO DO PRIMEIRO "STORAGE" DO ARRAY 0. NO CASO O CONTEÚDO É UMA STRING DE CARACTERES.
        Console.WriteLine($"Reassing first inicialization: {fraudulentOrderIDs[0]}");

        //.Length MOSTRARÁ A QUANTIDADE TOTAL DE OBJETOS DENTRO DO ARRAY).
        Console.WriteLine($"Thereare {fraudulentOrderIDs2.Length} fraudulent orders to process.");

        // -------------------------- ULTIMO EXERCÍCIO ANTES DO CHALLENGE -----------------------
        /* 
           A cada objeto do array, será referênciada à uma nova variável chamada "name",
           e depois irá imprimir essa nova variável de a cordo com a quatidade dos objetos contido nos arrays.
           Ex: string names = "Matheus", "Alexandrina", "Roney";
           string armazenaObjetos = names;
        */
        string[] names = { "Bob", "Conrad", "Grant" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        int[] inventory = { 200, 450, 700, 175, 250 };
        int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (running total: {sum}).");
        }
        Console.WriteLine($"We have {sum} items in iventory.");
    }
}
