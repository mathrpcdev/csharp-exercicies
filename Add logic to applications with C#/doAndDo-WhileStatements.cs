/*
Author: Mathues Cavalcante
Exercícios: do-while e while.

Este exercício é dividido em 3 partes para que possamos entender as diferenças do 'do-while' e 'while', e o uso
da palavra chave 'continue'
 */

//Exercício 1
/*
A regra de negócio que utiliza o 'do-while' statement funciona da seguinte forma:
A expressão booleana será avaliada após a instrução dentro do bloco de código. Se a expressão boleana
for verdadeira o código irá voltar para o início de seu looping.
 */

Random aleatory = new Random();
int current = 0;

do
{
    current = aleatory.Next(1, 11);
    Console.WriteLine($"Number - {current}");
} while (current != 7);

//Exercício 2
/*
Quando utilizados 'while' a expressão boleana será avaliada ANTES de inicializar o seu bloco de código.
 */
Random aleatorio = new Random();
int contagemAtual = aleatorio.Next(1, 11);

while (contagemAtual >= 3) // O número aleatório gerado irá ser avaliado se é TRUE or FALSE ao parâmetro passado em parênteses.
{
    Console.WriteLine(contagemAtual);
    contagemAtual = aleatorio.Next(1, 11); // Se o número que vier aqui for menor que 3, o bloco WHILE irá parar.
}
Console.WriteLine($"Last number : {current}"); // Aqui mostrará o último número aleatório que foi menor que 3. Dentro do bloco WHILE*.

//Exercício 3
/*
A palavra chava 'continue' obriga que o bloco de código continue seu looping enquanto a expressão boleana
dentro do código seja verdadeira. Quando a expressão booleana for falsa, ela encerrará o seu código e irá verificar
a expressão booleana final.
 */
Random random1 = new Random();
int numeroAtual = random1.Next(1, 11);

do
{
    numeroAtual = random1.Next(1, 11);

    if (numeroAtual >= 8)
        continue;

    Console.WriteLine($"The current number is: {numeroAtual}");
} while (numeroAtual != 7);
