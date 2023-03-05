/* 
05/03/2023 (Não consegui fazer sem ajuda da AI).
Uso dos métodos Split(), Join(), Reverse(), e iterações.

- O primeiro exemplo foi feito com ajuda da IA e eu comentei.
- O segundo exemplo é da MSLearn com o código comentado pela IA. 
 */

string pangram1 = "The quick brown fox jumps over the lazy dog";
string[] palavras = pangram1.Split(' '); // Quebra a string "pangram1" em um array de 9 strings.

string pangram_invertido = "";
foreach (string palavra in palavras) {
    char[] caracteres = palavra.ToCharArray();  /* A cada "palavras[]'s arrays", cria-se uma nova string chamada "palavra". 
    A string "palavra é convertida em char[] e enviada para o "caracteres[]'s" char[] */

    Array.Reverse(caracteres); // Irá inverter cada uma das 9 "string[] palavras" 

    pangram_invertido += new string(caracteres) + " "; /* Adiciona cada uma das 9 strings, separadas por " " pelo método Split()
    e vai adicionando em ordem em "pangram_invertido" */
}

pangram_invertido = pangram_invertido.TrimEnd(); // remove o espaço extra no final, por conta do " + "  " " acima.
Console.WriteLine(pangram_invertido);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

//MSLearn Solution

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1: Divide a string em uma lista de palavras
string[] message = pangram.Split(' ');

// Step 2: Cria um novo array de strings com o mesmo tamanho da lista de palavras
string[] newMessage = new string[message.Length];

// Step 3: Inverte cada palavra individualmente e armazena no novo array
for (int i = 0; i < message.Length; i++)
{
    // Converte a palavra atual em um array de caracteres
    char[] letters = message[i].ToCharArray();
    // Inverte a ordem dos caracteres no array
    Array.Reverse(letters);
    // Converte o array de caracteres de volta para uma string e armazena no novo array
    newMessage[i] = new string(letters);
}

// Step 4: Junta as palavras novamente em uma única string e exibe no console
string result = String.Join(" ", newMessage);
Console.WriteLine(result);