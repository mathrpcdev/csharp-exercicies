

// 1.0 : Envio uma string completa p/ um Array tipo char.   
string value = "abc123";
char[] valueArray = value.ToCharArray();

// Console.WriteLine(valueArray); // Printa: abc123
// 1.1 : Reverter o Array de tipo char original.
Array.Reverse(valueArray);
string result = new string(valueArray); // Estou fazendo casting aqui(char p/ string novamente)? // Também Estou inicializando uma nova instância ->"new array". 
Console.Write(result); // Printa: 321cba



/* 2.0 : Com o método Join(), eu insiro 1 (ou mais) caracter antes de cada tipo Char. */
string valor = "Abecedário25";
char[] valorDoArray = valor.ToCharArray(); // Converti string[] para char[].
Array.Reverse(valorDoArray);

string resultado = string.Join(",", valorDoArray); // Só consigo fazer isso pq converti o char[] pra string[] aqui.
Console.WriteLine(resultado);

string[] items = resultado.Split(','); // Cada ',' será apagada/anulada
foreach(string item in items) // Question: This string inside are like a new instance?
{
Console.WriteLine(item);
}