/* ***********************************CALLING METHODS CHALLENGE***************************************
 COMO CHEGUEI A RESPOSTA --> https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-6.0
******************************************************************************************************* */
using System;
namespace valorMaximo
{
    class maximo
    {
        static void Main(string[] args)
        {
            int primeiroValor = 600;
            int segundoValor = 700;

            int maiorValor = Math.Max(primeiroValor, segundoValor);

            Console.WriteLine(maiorValor);
        }
    }
}
