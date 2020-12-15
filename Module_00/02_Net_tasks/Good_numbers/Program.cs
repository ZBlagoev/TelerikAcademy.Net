using System;
using System.Linq;

namespace Good_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            bool isError;

            int[] borders = new int[2];

            do
            {
                input = Console.ReadLine();

                try
                {
                    borders = input.Split().Select(int.Parse).ToArray();
                    isError = false;
                }
                catch (FormatException e)
                {
                    isError = true;
                    Console.WriteLine("Please input two int numbers separated by space", e);
                }

            } while (isError);

            Console.WriteLine(GoodNumbersFinder(borders));
        }


        static int GoodNumbersFinder(int[] borders)
        {            
            int goodNumbers = 0;

            for (int number = borders[0]; number <= borders[1]; number++)
            {
                int buffer = number;

                int alarm = 0;

                while (buffer != 0)
                {
                    int current = buffer % 10;

                    if (current == 0)
                    {
                        buffer /= 10;
                        continue;
                    }

                    if (number % current != 0)
                    {
                        alarm++;
                        break;
                    }

                    buffer /= 10;
                }

                if (alarm == 0)
                {
                    goodNumbers++;
                }

            }

            return goodNumbers;
        }



    }
}
