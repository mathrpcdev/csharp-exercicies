using System;

namespace Matheus
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------*EXERCÍCIO DE ACRESCIMO E DECRESCIMO DE VALORES*-----------------------------------------------

            int value = 5;

            value = value + 5;
            Console.WriteLine("Primeira incrementação: " + value);

            value += 5;
            Console.WriteLine("Segunda incrementação: " + value);

            value++;
            Console.WriteLine("Terceira incrementação: " + value);

            Console.WriteLine("---------------------------------------------------------");

            //5+16-5=11;
            value = value - 5;
            Console.WriteLine("Primeiro decrescimento: " + value);

            value -= 5;
            Console.WriteLine("Segundo decrescimo: " + value);

            value--;
            Console.WriteLine("Terceiro decrescimo: " + value);
            Console.WriteLine();

            Console.WriteLine(
                "------------*ACRESCENTANDO APENAS UM VALOR*-----------------------------"
            );

            int valor = 1;
            valor++;
            Console.WriteLine("Primeiro: " + valor);
            Console.WriteLine("Segundo: " + valor++);
            Console.WriteLine("Terceiro: " + valor);
            Console.WriteLine("Quarto: " + (++valor));

            Console.WriteLine(
                "------------------DIMINUINDO(DECRESCENDO)UM VALOR QUALQUER(Ex: Diminuindo --um)"
            );

            int value1 = 1;
            value1 = 1;
            value1--;

            Console.WriteLine("Primeiro: " + value1);
            Console.WriteLine("Segundo: " + value1++);
            Console.WriteLine("Terceiro: " + value1);
            Console.WriteLine("Quarto: " + (++value1));

            int value2 = 2;
            value2 = 2;
            value2--;

            Console.WriteLine("Primeiro: " + value2);
            Console.WriteLine("Segundo: " + value2--);
            Console.WriteLine("Terceiro: " + value2);
            Console.WriteLine("Quarto: " + (--value2));
        }
    }
}



