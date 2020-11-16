using System;

namespace Compare_Character_Arrays_Lexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Write a program that compares two char arrays lexicographically(letter by letter).Research how to 
             *          convert string to char array.

                        Input:
                        On the first line you will receive the first array as string
                        On the second line you will receive the second array as string

                        Output:

                        Print First if the first array is lexicographically smaller
                        Print Second if the second array is lexicographically smaller
                        Print Equal if the arrays are equal*/

            string firstString = Console.ReadLine();
            char[] firstArray = firstString.ToCharArray();
            string secondString = Console.ReadLine();
            char[] secondArray = secondString.ToCharArray();
            bool isEqual = true;

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("Second");
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("First");
            }
            else
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstString[i] > secondString[i])
                    {
                        Console.WriteLine("Second");
                        isEqual = false;
                        break;
                    }
                    else if (firstString[i] < secondString[i])
                    {
                        Console.WriteLine("First");
                        isEqual = false;
                        break;
                    }

                }
            if (isEqual)
            {
                Console.WriteLine("Are equal");
            }
     
        }
    }
}
