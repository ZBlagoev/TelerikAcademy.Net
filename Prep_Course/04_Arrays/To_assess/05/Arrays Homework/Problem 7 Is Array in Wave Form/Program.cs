using System;

namespace Problem_7_Is_Array_in_Wave_Form
{
    class Program
    {
        static void Main(string[] args)
        {
            /*              Problem 7.Is Array in Wave Form
                            Write a program that determines if an array of integers is in Wave Form -
                            e.g.first > second < third > fourth < fifth > ...*/

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            bool isWave = true;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

                for (int i = 1; i < n - 2 && i % 2 != 0; i++)
            {
                if (n % 2 == 0 && array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        isWave = true;
                        i++;
                    }
                    else
                    {
                        isWave = false;
                        break;
                    }
                }
                if (isWave = true && array[n] > array[n - 1])
                {
                    isWave = true;
                }
                else
                {
                    isWave = false;
                }

            }

        }
 
    }
}
