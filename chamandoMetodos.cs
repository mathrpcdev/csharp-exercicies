//***********************************************************************
//*************************  EXERCÍCIO  *********************************
// -------->  stateful (instance) and stateless (static) METHODS <-------
//***********************************************************************

/* PARA  CHAMAR MÉTODOS EM/DE UMA CLASSE USAMOS:
   className.methodName(); --> o símbolo . é o OPERADOR DE ACESSO AO "MEMBRO" (access operator)
   O  .  acessa o método(method) definido na classe. Ex: Random (é uma classe) e Next() é um método que pertence a Random class.      
*/
using System;

namespace teste
{
    class Myapp
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            Random secondDice = new Random();
            int secondRoll = secondDice.Next(1, 10);
            Console.WriteLine(secondRoll);
           
            /* OBSERVACÕES: Statelss method(métodos staticos).
             OS MÉTODOS DE INSTÂNCIA PRECISAM DE UM OBJETO JÁ CRIADO PARA QUE O MESMO(O MÉTODO) SEJA ACESSADO POR ELE(ACESSADA PELO NOVO OBJETO). 
            
             OBS2: O método Next() RECEBE 2 PARAMETROS SEPARADOS POR , (VÍRGULAS)
             A ASSINATURA DO MÉTODO É: O NÚMERO DE PARÂMETROS DE ENTRADA(DENTRO DE PARÊNTESES) E O SEU TIPO.          
            */
            

            Console.WriteLine("-------------OVERLODED METHODS-----------------\n");

            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
           
            Console.WriteLine("----------------------------OS TRÊS MÉTODOS QUE O RANDOM.NEXT() COMPORTA-------------");
            Random thirdDice = new Random();

            //MOSTRARÁ UM VALOR MÁXIMO E ALEATÓRIO QUE UM INT TYPE COMPORTA
            int thirdRoll = thirdDice.Next();

            //O OUTPUT SERÁ DE 0 À 100
            int fourthRoll = thirdDice.Next(101);

            //IRÁ MOSTRAR VALORES ENTRE 50 À 100
            int fifithRoll = thirdDice.Next(50, 101);

            Console.WriteLine($"Primeiro número aleatório: {thirdRoll}");
            Console.WriteLine($"Primeiro número aleatório: {fourthRoll}");
            Console.WriteLine($"Primeiro número aleatório: {fifithRoll}");
        }
    }
}
