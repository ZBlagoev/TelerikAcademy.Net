using System;
using System.Linq;

namespace Problem_11_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Write a program that find all pairs of integers whose 
                   sum is equal to a given number.On the first line you
                   will receive the target sum, on the second line - the array*/

            {
                string[] array = Console.ReadLine().Trim().Split(',').ToArray(); 

                for (int i = 0; i < array.Length; i++)
                {
                    for (int counter = i + 1; counter < array.Length; counter++)
                    {
                        if (array[i] == array[counter])
                        {
                            Console.WriteLine(array[counter]);
                        }
                    }
                }
            }
        }
    }
}
