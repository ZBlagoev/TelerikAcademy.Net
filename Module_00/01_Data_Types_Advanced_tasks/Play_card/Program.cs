using System;
using System.Linq;

namespace Play_card
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(PlayCardCheck(input));
        }

        static string PlayCardCheck(string input)
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            string result = "";

            if (cards.Contains(input))
            {
                result = $"yes {input}";
            }
            else
            {
                result = $"no {input}";
            }

            return result;
        }

    }
}
