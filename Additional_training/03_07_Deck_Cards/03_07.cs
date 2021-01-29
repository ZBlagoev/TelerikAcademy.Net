using System;

namespace _03_07_Deck_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string card = Console.ReadLine().ToUpper();

            string[] values = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

            int index = Array.IndexOf(values, card);

            for (int i = 0; i <= index; i++)
            {
                Console.WriteLine($"{values[i]} of spades, {values[i]} of clubs, {values[i]} of hearts, {values[i]} of diamonds");
            }

        }
    }
}
