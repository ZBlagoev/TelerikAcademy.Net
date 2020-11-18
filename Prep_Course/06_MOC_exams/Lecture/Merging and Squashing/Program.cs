using System;
using System.Collections.Generic;

namespace Merging_and_Squashing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            List<int> numbersAsList = new List<int>();
            

            int[] merged = new int[n - 1];
            int[] squashed = new int[n - 1];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

           
            //12 , 73 , 34 , 45
            for (int i = 0; i < n - 1; i++)
            {
                int a = numbers[i] / 10;
                int b = numbers[i] % 10;
                int c = numbers[i + 1] / 10;
                int d = numbers[i + 1] % 10;

                //Merging ab and cd produces bc
                int mergedNumber = b * 10 + c;
                merged[i] = mergedNumber;

                //Squashing ab and cd produces a(b+c)d - the middle digit is the sum of b and c
               
                int squashedNumber = a * 100 + (((b + c) % 10)*10) + d;
                squashed[i] = squashedNumber;
            }

            Console.WriteLine(string.Join(" ", merged));
            Console.WriteLine(string.Join(" ", squashed));

        }
    }
}
