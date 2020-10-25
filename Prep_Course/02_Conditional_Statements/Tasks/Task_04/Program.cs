/*
Calculate Change
Write a program that determines the least amount of coins needed for a cashier to return change.

For example, if the price of something is 0.76 leva and the customer has paid 1 leva, 
the least amount of coins is 1 x 20 stotinki and 2 x 2 stotinki.

Use the coins of 1 lev, 50, 20, 10, 5, 2 and 1 stotinki.

Input
On the first line, you will receive the price in leva.
On the second line, you will receive how much the customer has paid in leva.
Output
There is a variable amount of output lines.
Print each required denomination on a new line, ordered from highest to lowest.
*/

using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double itemPrice = double.Parse(Console.ReadLine());
            int custAmount = int.Parse(Console.ReadLine());

            double change;

            // calculation
            change = custAmount - itemPrice;

            double amount1Lev = change;
            change = Math.Round(change - ((int)amount1Lev * 1), 2);

            double amount50st = change / 0.5;
            change = Math.Round(change - ((int)amount50st * 0.5), 2);

            double amount20st = change / 0.2;
            change = Math.Round(change - ((int)amount20st * 0.2), 2);

            double amount10st = change / 0.1;
            change = Math.Round(change - ((int)amount10st * 0.1), 2);

            double amount05st = change / 0.05;
            change = Math.Round(change - ((int)amount05st * 0.05), 2);

            double amount02st = change / 0.02;
            change = Math.Round(change - ((int)amount02st * 0.02), 2);

            double amount01st = change / 0.01;
            change = Math.Round(change - ((int)amount01st * 0.01), 2);

            // output
            // 1 lev
            if ((int)amount1Lev != 0)
            {
                Console.WriteLine($"{(int)amount1Lev} x 1 lev");
            }
                // 50 st
            if ((int)amount50st != 0)
            {
                Console.WriteLine($"{(int)amount50st} x 50 stotinki");
            }
                // 20 st
            if ((int)amount20st != 0)
            {
                Console.WriteLine($"{(int)amount20st} x 20 stotinki");
            }
                // 10 st
            if ((int)amount10st != 0)
            {
                Console.WriteLine($"{(int)amount10st} x 10 stotinki");
            }
                // 5 st
            if ((int)amount05st != 0)
            {
                Console.WriteLine($"{(int)amount05st} x 5 stotinki");
            }
                // 2 st
            if ((int)amount02st != 0)
            {
                Console.WriteLine($"{(int)amount02st} x 2 stotinki");
            }
                // 1 st
            if ((int)amount01st != 0)
            {
                Console.WriteLine($"{(int)amount01st} x 1 stotinka");
            }


        }
    }
}
