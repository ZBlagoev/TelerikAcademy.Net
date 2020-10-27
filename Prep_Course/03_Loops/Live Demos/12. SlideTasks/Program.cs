using System;

namespace _12._SlideTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ////print nums from 10 to 1, comma separated
            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i == 1)
            //    {
            //        Console.Write(i);
            //    }
            //    else
            //    {
            //        Console.Write($"{i},");
            //    }
            //}

            ////sum all numbers from 1 to n
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);

            //sum all even numbers from 1 to n
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
