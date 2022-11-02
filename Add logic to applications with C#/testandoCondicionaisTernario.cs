using System;

// Author: Matheus Cavalcante    --     Last update: 02/11/22
/* Neste exercício utilizo estruturas de decisão e interpolação para uso das variáveis no Console.WriteLine.
        Depois faço o mesmo exercício que dá o mesmo resultado, utilizando operadores condicionais  < X > Y ? SIM : ou NAO >
        Conhecidos também como Operador "Condicional Ternário".
        ** USE O OPERADOR CONDICIONAL QUANDO PRECISAR ADICIONAR A LÓGICA DE RAMIFICAÇÃO INLINE. ** */
class testandoCondicionaisTernario
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            $"***** ESTRUTURAS DE DECICSÃO PARA AVALIAR SE NUMBER1 É > QUE NUMBER2, VIVE-VERSA. *****\n"
        );

        int number1 = 1000;
        int number2 = 999;
        int descount1 = 100;
        int descount2 = 50;

        if (number1 > number2)
        {
            Console.WriteLine($"You have purchased more than {number2} dollars");
            Console.WriteLine($"You may receive {descount1} dollars of discont.");
        }
        else
        {
            Console.WriteLine($"You have purchased {number2} dollars");
            Console.WriteLine($"You may receive {descount2} dollars of discont.");
            Console.WriteLine();
        }

        Console.WriteLine(
            $"***** ABAIXO SEGUE O MESMO EXERCÍCIO, MAS UTILIZANDO OPERADORES CONDICIONAIS - TERNÁRIOS. *****\n"
        );
        //  >1000 = 100 ? <1000 : 50;

        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}");
        // OR...
        int saleAmount2 = 1001;
        Console.WriteLine($"Discount: {(saleAmount2 > 100 ? 100 : 50)}");
    }
}
