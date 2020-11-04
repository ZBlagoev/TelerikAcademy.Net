/*
Write a program that reads two int arrays of size N from the console 
and compares them element by element.

Input:
On the first line you will receive the number N
On the next N lines the numbers of the first array will be given
On the next N lines the numbers of the second array will be given

Output:
Print Equal if the two arrays are the same and Not equal if they are not
*/


using System;

namespace Problem_1._Compare_arrays
{
    class Problem_01
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 1. Compare arrays");

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            string[] arrA = new string[n];
            string[] arrB = new string[n];

            int check = 0;

                // fill arr A
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a{i + 1}: ");
                arrA[i] = Console.ReadLine();
            }
                // fill arr B
            for (int j = n; j < 2 * n; j++)
            {
                Console.Write($"b{j + 1 - n}: ");
                arrB[j - n] = Console.ReadLine();
            }

            // calculation
            for (int i = 1; i < n; i++)
            {
                if (arrA[i] != arrB[i])
                {
                    check++;
                }
            }

            // output
            if (check != 0)
            {
                Console.WriteLine("Not equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }

        }
    }
}
