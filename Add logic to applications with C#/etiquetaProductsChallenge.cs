/*
Neste Challange tive que módificar o código desenhado em if-else if-if e escreve-lo novamente utilizando o switch-case.
O código que foi modificado encontra-se ao final desde exercício comentado.
*/

// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] etiquetaDoProduto = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (etiquetaDoProduto[0])
{
    case "01":
        type = "Sweet shirts";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweet pants";
        break;
    default:
        type = "Other";
        break;
}

switch (etiquetaDoProduto[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}

switch (etiquetaDoProduto[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
}

Console.WriteLine($"{size} {color} {type}");

// --> Aqui inicia o código original que precisou ser modificado.

// SKU = Stock Keeping Unit
/* string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
 */
