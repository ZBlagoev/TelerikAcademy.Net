using System;

namespace _02_03_Season_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());

            int month = 0;

            // calculation
            switch (input)
            {
                case "January": month = 100; break;
                case "February": month = 200; break;
                case "March": month = 300; break;
                case "April": month = 400; break;
                case "May": month = 500; break;
                case "June": month = 600; break;
                case "July": month = 700; break;
                case "August": month = 800; break;
                case "September": month = 900; break;
                case "October": month = 1000; break;
                case "November": month = 1100; break;
                case "December": month = 1200; break;
            }

            if (month + day >= 320 && month + day < 621)
            {
                Console.WriteLine("Spring");
            }
            else if (month + day >= 621 && month + day < 922)
            {
                Console.WriteLine("Summer");
            }
            else if (month + day >= 922 && month + day < 1221)
            {
                Console.WriteLine("Autumn");
            }
            else
            {
                Console.WriteLine("Winter");
            }

        }
    }
}
