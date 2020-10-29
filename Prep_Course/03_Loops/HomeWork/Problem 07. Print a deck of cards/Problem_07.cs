/*
Write a program that generates and prints all possible cards from 
a standard deck of 52 cards (without the jokers).

The cards should be printed using the classical notation 
(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
Use 2 nested for-loops and a switch-case statement.
Note: You may use the suit symbols instead of text.
*/

using System;

namespace Problem_07._Print_a_deck_of_cards
{
    class Problem_07
    {
        static void Main(string[] args)
        {
            // calculation & output
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 5; j < 7; j--) // disclaimer - i had to google the part about the suits
                {
                    if (i < 11) 
                    {
                        Console.Write($"{i} of {(char)j} ");
                    }
                    switch (i)
                    {
                        case 11:
                            Console.Write($"J of {(char)j} ");
                            break;
                        case 12:
                            Console.Write($"Q of {(char)j} ");
                            break;
                        case 13:
                            Console.Write($"K of {(char)j} ");
                            break;
                        case 14:
                            Console.Write($"A of {(char)j} ");
                            break;
                    }

                    // had to google that part too
                    if (j == 3)
                    {
                        j = 7;
                    }
                    if (j == 6)
                    {
                        break;
                    }
                }


                Console.WriteLine();
            }
        }
    }
}