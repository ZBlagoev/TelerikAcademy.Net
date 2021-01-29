using System;

namespace _02_04_Change_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double price = double.Parse(Console.ReadLine());
            double paied = double.Parse(Console.ReadLine());

            double change = Math.Round(paied - price, 2);

            // calculation
            int amountLev = (int)change;
            change = Math.Round(change - amountLev, 2);

            int amount50st = (int)(change / 0.50);
            change = Math.Round(change - amount50st * 0.50, 2);

            int amount20st = (int)(change / 0.20);
            change = Math.Round(change - amount20st * 0.20, 2);

            int amount10st = (int)(change / 0.10);
            change = Math.Round(change - amount10st * 0.10, 2);

            int amount05st = (int)(change / 0.05);
            change = Math.Round(change - amount05st * 0.05, 2);

            int amount02st = (int)(change / 0.02);
            change = Math.Round(change - amount02st * 0.02, 2);

            int amount01st = (int)(change / 0.01);

            // output
            if (amountLev > 0)
            {
                Console.WriteLine($"{amountLev} x 1 lev");
            }

            if (amount50st > 0)
            {
                Console.WriteLine($"{amount50st} x 50 stotinki");
            }

            if (amount20st > 0)
            {
                Console.WriteLine($"{amount20st} x 20 stotinki");
            }

            if (amount10st > 0)
            {
                Console.WriteLine($"{amount10st} x 10 stotinki");
            }

            if (amount05st > 0)
            {
                Console.WriteLine($"{amount05st} x 5 stotinki");
            }

            if (amount02st > 0)
            {
                Console.WriteLine($"{amount02st} x 2 stotinki");
            }

            if (amount01st > 0)
            {
                Console.WriteLine($"{amount01st} x 1 stotinka");
            }

        }
    }
}
