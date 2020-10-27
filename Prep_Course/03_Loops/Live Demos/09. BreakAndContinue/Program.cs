using System;

namespace _09._BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                int dice1 = random.Next(6) + 1;
                int dice2 = random.Next(6) + 1;

                //if 1 + 1 = print and continue
                if (dice1 + dice2 == 2)
                {
                    Console.WriteLine($"You've got 2. Took {i} turns");
                    continue;
                }

                //if 6 + 6 = print and exit
                if (dice1 + dice2 == 12)
                {
                    Console.WriteLine($"You did it! It took you {i} turns to get 12!");
                    break;
                }
            }
        }
    }
}
