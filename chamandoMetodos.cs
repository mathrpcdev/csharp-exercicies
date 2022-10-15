//---------->> É preciso estudar o problema do Main <<-----------------
//********************************************************************************************************
//***********************************EXERCÍCIO******************************
// ----------------->  stateful (instance) and stateless (static) METHODS <----------------------------------
//********************************************************************************************************

using System;
/* PARA  CHAMAR MÉTODOS EM/DE UMA CLASSE USAMOS:
   className.methodName(); --> o símbolo . é o OPERADOR DE ACESSO AO "MEMBRO" (access operator)
   O  .  acessa o método(method) definido na classe. Ex: Random (é uma classe).        */


namespace teste
{

    class Myapp
    {

        static void Main(string[] args)
        {

            /* PARA  CHAMAR MÉTODOS EM/DE UMA CLASSE USAMOS:
    className.methodName(); --> o símbolo . é o OPERADOR DE ACESSO AO "MEMBRO" (access operator)
    O  .  acessa o método(method) definido na classe. Ex: Random (é uma classe).               */

            Random dice = new Random();
            int roll = dice.Next(1, 7);

            Console.WriteLine(roll);

            /* Não é possível um statelss method(que são os métodos staticos) acessar um MÉTODO DE INSTÂNCIA, como o Next().
            MÉTODOS DE INSTÂNCIA PRECISAM CRIAR UM OBJETO PARA QUE O MESMO SEJA ACESSADO POR ELE. Portanto:
            Instanciamos uma classe at'raves do método ' = new classeQualquer*'  */
            //int result = Random.Next();

            Random secondDice = new Random();
            /*O método Next() RECEBE 2 PARAMETROS SEPARADOS POR , (VÍRGULAS)
             A ASSINATURA DO MÉTODO É: O NÚMERO DE PARÂMETROS DE ENTRADA(DENTRO DE PARÊNTESES) E O SEU TYPE   */
            int secondRoll = secondDice.Next(1, 10);

            Console.WriteLine(secondRoll);
            Console.WriteLine("-------------OVERLODED METHODS-----------------\n");

            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("----------------------------OS TRÊS MÉTODOS QUE O RANDOM.NEXT() COMPORTA-------------");

            Random thirdDice = new Random();

            //MOSTRARÁ UM VALOR MÁXIMO E ALEATÓRIO QUE IM INT TYPE COMPORTA
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
