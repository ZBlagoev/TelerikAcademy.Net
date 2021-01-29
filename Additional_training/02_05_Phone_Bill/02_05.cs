using System;

namespace _02_05_Phone_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int messages = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            double messageTax = 0.00;
            double messageCost = 0.00;
            double minutesTax = 0.00;
            double minutesCost = 0.00;

            double bill = 12.00;

            // calculation
            if (messages > 20)
            {
                messageCost = (messages - 20) * 0.06;
                messageTax = messageCost * 0.20;
                messages -= 20;
            }
            else
            {
                messages = 0;
            }

            if (minutes > 60)
            {
                minutesCost = (minutes - 60) * 0.10;
                minutesTax = minutesCost * 0.20;
                minutes -= 60;
            }
            else
            {
                minutes = 0;
            }

            bill += messageCost + messageTax + minutesCost + minutesTax;

            // output
            Console.WriteLine($"{messages} additional messages for {messageCost:0.00} levas");
            Console.WriteLine($"{minutes} additional minutes for {minutesCost:0.00} levas");
            Console.WriteLine($"{(minutesTax + messageTax):0.00} additional taxes");
            Console.WriteLine($"{bill:0.00} total bill");
        }
    }
}
