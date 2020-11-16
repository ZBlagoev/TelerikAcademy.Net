using System;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace Problem_1_Compare_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Write a program that reads two int arrays of size N from the console and compares them element by element.


                        Input:

                        On the first line you will receive the number N
                        On the next N lines the numbers of the first array will be given
                        On the next N lines the numbers of the second array will be given

                        Output:

                        Print Equal if the two arrays are the same and Not equal if they are not*/


            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            bool isEqual = true;


            for (int i = 0; i < n; i++)
            {
                first[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Plese enter the elements of the second array");
            for (int j = 0; j < n; j++)
            {
                second[j] = int.Parse(Console.ReadLine());
            }

            for (int counter = 0; counter < n; counter++)
            {

                if (first[counter] != second[counter])
                {
                    isEqual = false;
                    break;
                }

            }
            if (isEqual)
            {
                Console.WriteLine("Are equal");
            }
            else {
                Console.WriteLine("Not equal");
            }

        }
    }
}
