/*
Faço uma tomada de decição a cada vez que uma variável(Nível de empregado) mudar.
Ou seja, eu coloco como parâmetro a variável que eu desejo avaliar se houve alguma mudança.
O bloco de códico switch irá avaliar cada possível caso(case) parâmetrizado, e quando achar o caso que dar match irá executar uma ação.
São 3 exercícios que fazem a mesma coisa.
 */

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

int employeeLevel2 = 201;
string employeeName2 = "Matheus Cavalcante,";
string title2 = "";

switch (employeeLevel2)
{
    case 100:
        title2 = "Junior advocate";
        break;
    case 200:
        title2 = "Senior advocate";
        break;
    case 300:
        title2 = "Administrador";
        break;
    case 400:
        title2 = "Gerente Senior";
        break;
    default:
        title2 = "Associado";
        break;
}
Console.WriteLine($"{employeeName2} {title2}");

int nivelDoEmpregado = 100;
string nomeDoEmpregado = "John Smith";
string titulo = "";

switch (nivelDoEmpregado)
{
    case 100:
    case 200:
        titulo = "Senior Associate";
        break;
    case 300:
        titulo = "Manager";
        break;
    case 400:
        titulo = "Senior Manager";
        break;
    default:
        titulo = "Associate";
        break;
}

Console.WriteLine($"{nomeDoEmpregado}, {titulo}");
