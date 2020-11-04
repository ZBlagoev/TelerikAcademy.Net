/*
Write a program that compares two char arrays lexicographically 
(letter by letter). Research how to convert string to char array.



Input:
On the first line you will receive the first array as string
On the second line you will receive the second array as string


Output:
Print First if the first array is lexicographically smaller
Print Second if the second array is lexicographically smaller
Print Equal if the arrays are equal
*/

using System;

namespace Problem_2._Compare_Char_Arrays_Lex
{
    class Problem_02
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 2. Compare Character Arrays Lexicographically");

            Console.Write("string 1: ");
            string stringA = Console.ReadLine();
            Console.Write("string 2: ");
            string stringB = Console.ReadLine();

            char[] arrA = new char[stringA.Length];
            char[] arrB = new char[stringB.Length];

                // fill arrA
            for (int i = 0; i < stringA.Length; i++)
            {
                arrA[i] = stringA[i];
            }
                // fill arrB
            for (int j = 0; j < stringB.Length; j++)
            {
                arrB[j] = stringB[j];
            }

            string result = "";

            int A = 0;
            int B = 0;

            // calculation
            if (arrA.Length > arrB.Length)
            {
                A++;
            }
            else if (arrA.Length < arrB.Length)
            {
                B++;
            }
            else if (arrA.Length == arrB.Length)
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] > arrB[i])
                    {
                        A++;
                    }
                    else if (arrA[i] < arrB[i])
                    {
                        B++;
                    }
                }
            }

            // output
            if (A > B)
            {
                Console.WriteLine($"result: Second");
            }
            else if (A < B)
            {
                Console.WriteLine($"result: First");
            }
            else
            {
                Console.WriteLine($"result: Equal");
            }

        }
    }
}
