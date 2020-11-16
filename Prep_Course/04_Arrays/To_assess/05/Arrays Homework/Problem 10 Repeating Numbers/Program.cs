using System;

namespace Problem_10_Repeating_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Write a program that finds the repeating number. All other numbers occur only once.

                int counter = 0;
                int tempCounter = 1;
                int foundNumber = 0;
                int length = int.Parse(Console.ReadLine());
                int[] arr = new int[length];

                for (int i = 0; i < length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(arr);

                for (int i = 0; i < length - 1; i++)
                {
                    if (arr[i] == arr[i + 1]) tempCounter++;
                    else tempCounter = 1;
                    if (tempCounter > counter)
                    {
                        counter = tempCounter;
                        foundNumber = arr[i];
                    }
                }

                Console.WriteLine("{0} was found {1} times.", foundNumber, counter);
            }
        }
    }
}
