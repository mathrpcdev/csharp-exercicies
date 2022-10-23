using System;

class fraudulentOrderIDs
{
    static void Main(string[] args)
    {
        /* CRIANDO UM SÍMBOLO ARRAY QUE ARMAZENARÁ UMA QUANTIDADE DE VETORES(?), INICIADAS
         UMA UMA INSTÂNCIA NA MEMÓRIA CONTENDO A QUANTIDADE DE STORAGES
         O SEGUNDO ARRAY, PARA EXEISTIR, SEMPRE INICIARÁ COM ALGO.
         EX: [] VAR [3]     */

        // ARRAYS ARE ZERO BASE .
        string[] fraudulentOrderIDs = new string[3];
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        //fraudulentOrderIDs[3] = "D000"; 

        // ----------------------------------------------------------------------------------------------------------------------

        // ESTES ARRAYS ESTÃO INVOCANDO UMA STRING DE CARACTERES.

        Console.WriteLine($"First array: {fraudulentOrderIDs[0]} ");
        Console.WriteLine($"First array: {fraudulentOrderIDs[1]} ");
        Console.WriteLine($"First array: {fraudulentOrderIDs[2]} ");

        fraudulentOrderIDs[0] = "F00";
        Console.WriteLine($"Reassing First: {fraudulentOrderIDs[0]}");

        // -----------------------------------------------------------------------------------------------------------------


        //  string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

        Console.WriteLine($"First inicialization: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second inicialization:{fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third inicialization: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        //INVOCANDO O CONTEÚDO DO PRIMEIRO "STORAGE" DO ARRAY 0. NO CASO O CONTEÚDO É UMA STRING DE CARACTERES.
        Console.WriteLine($"Reassing first inicialization: {fraudulentOrderIDs[0]}");

        //.Length MOSTRARÁ A QUANTIDADE TOTAL DE MATRIZES(OU VETORES?)
        Console.WriteLine($"Thereare {fraudulentOrderIDs.Length} fraudulent orders to process.");

        // -------------------------- ULTIMO EXERCÍCIO ANTES DO CHALLENGE -----------------------

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
