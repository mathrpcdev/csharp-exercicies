// Interpolation exercicies within the if statement.
class diceGameIterations
{
    static void Main(string[] args)
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll1 + roll1;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 to total points!");
                total += 6;
            }
        }
        else
        {
            Console.WriteLine("You rolled doubles! +2 to total points!");
            total += 2;
        }

        if (total >= 16)
        {
            Console.WriteLine("Congratulations! I've got a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You've got a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }

        Random dado = new Random();

        int jogada1 = dado.Next();
        int jogada2 = dado.Next();
        int jogada3 = dado.Next();

        int resultado = jogada1 + jogada2 + jogada3;

        Console.WriteLine($"Dice roll: {jogada1} + {jogada2} + {jogada3} = {resultado}");

        if ((jogada1 == jogada2) || (jogada2 == jogada3) || (jogada1 == jogada3))
            if ((jogada1 == jogada2) && (jogada2 == jogada3))
            {
                Console.WriteLine("You rolled triples! You'll receive +6 bonus points.");
                resultado += 6;
            }
            else
            {
                Console.WriteLine(
                    "You rolled the same value two times! You'll receive +2 bonus points."
                );
            }

        if (resultado >= 15)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}

