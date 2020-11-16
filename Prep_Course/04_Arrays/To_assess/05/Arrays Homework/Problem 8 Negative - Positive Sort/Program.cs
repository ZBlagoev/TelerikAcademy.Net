using System;

namespace Problem_8_Negative___Positive_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Write a program that moves all negative numbers to the beginning and all positive to the end, 
                        without changing the order of positive negative
            */
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] order = new int[n];
            int br = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                if (array[j] < 0)
                {
                    order[br] = array[j];
                    br++;
                }
            }
            for (int j = 0; j < n; j++)
            {
                if (array[j] >= 0)
                {
                    order[br] = array[j];
                    br++
                }
            }
            foreach (int number in order)
            {
                Console.WriteLine(number + " ");
            }
        }
    }
}
