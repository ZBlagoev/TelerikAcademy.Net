using System;

namespace Problem_6_Is_Array_Symmetric
{
    class Program
    {
        static void Main(string[] args)
        {
            /*        Write a program that finds if an array of integers is symmetric - that is, the
                    first number is equal to the last, the second - to the second last and so on*/

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            bool isEqual = true;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n; j++)
            {
                if (array[j] != array[n - j - 1])
                {
                    isEqual = false;
                    break;
                }
           }
            if (isEqual)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
