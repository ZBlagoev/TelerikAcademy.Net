/*
Добри числа
Иванчо нарича едно число добро, ако то се дели на всяка негова цифра различна от 0.

Например: - 13 не е добро - не се дели на 3 - 36 е добро - дели се на 3 и на 6 - 102 e добро - 
дели се на 1 и на 2 - 103 не е добро - не се дели на 3

Помогнете на Иванчо като напишете програма, която намира броя на всички добри числа между дадени A и B 
(включително).

Вход
От първия ред се въвеждат числата A и B.

Изход
Изведете броя на добрите числа на единствен ред.

Ограничения
1 <= A <= B <= 100000
*/

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
