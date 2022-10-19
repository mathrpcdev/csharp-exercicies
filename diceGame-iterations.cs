class teste
{
    static void Main(string[] args)
    {
        Random dado = new Random();

        int jogada1 = dado.Next();
        int jogada2 = dado.Next();
        int jogada3 = dado.Next();

        int total = jogada1 + jogada2 + jogada3;

        Console.WriteLine($"Dice roll: {jogada1} + {jogada2} + {jogada3} = {total}");

        if ((jogada1 == jogada2) || (jogada2 == jogada3) || (jogada1 == jogada3))
            if ((jogada1 == jogada2) && (jogada2 == jogada3))
            {
                Console.WriteLine("You rolled triples! You'll receive +6 bonus points.");
                total += 6;
            }
            else
            {
                Console.WriteLine(
                    "You rolled the same value two times! You'll receive +2 bonus points."
                );
            }

        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}
