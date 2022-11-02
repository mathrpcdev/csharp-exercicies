using System;

/* Author: Matheus Cavalcante 31/10/2022
On this exercicies I've used my recent new C# vocabularies such as: Contains() method and negation(!) logic inside booleans expressions.
Dentro dos blocos de códigos criados eu fico ligando minhas duas variáveis globais(uma de tipo tipo string e uma de tipo int)
com o método Contains().
******  No final segue a solução da Microsoft  ******
 */
class challengePermission
{
    static void Main(string[] args)
    {
        string permissionAdmins = "Admin";
        string permissionManagers = "Manager";
        int level = 55;

        if ((permissionAdmins.Contains("Admin")) && (level > 55))
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else if ((permissionAdmins.Contains("Admin")) && (level <= 55))
        {
            Console.WriteLine("Welcome, Admin user.");
        }
        else if (
            (permissionAdmins.Contains("Admin"))
            || (!permissionManagers.Contains("Admin")) && (level >= 20)
        )
        {
            Console.WriteLine("Contact an Admin for access");
        }
        else if ((permissionManagers.Contains("Manager")) && (level < 20))
        {
            Console.WriteLine("You do not have sufficient privileges");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges");
        }

        // -->> Microsoft Learning Path (MLP) solution bellow:
        // The MLP's letters was me who added. I made this to diferentiate the variables from my previous code above.
        string permissionMLP = "Admin|Manager";
        int levelMLP = 53;

        if (permissionMLP.Contains("Admin"))
        {
            if (levelMLP > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else
            {
                Console.WriteLine("Welcome, Admin user.");
            }
        }
        else if (permissionMLP.Contains("Manager"))
        {
            if (levelMLP >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
}