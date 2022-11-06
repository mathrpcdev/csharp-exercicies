using System;
using MyApp.Utilities; // Eu também posso classes utilizando usings. Tornando o código mais simples.

/*
Neste exemplo entendemos que
 */

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Reversed Value message: {reversedValue}");
        }
    }
}

namespace MyApp.Utilities // Foi movida a classe Utility para dentro de um novo namespace (MyApp.Utilities)
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
