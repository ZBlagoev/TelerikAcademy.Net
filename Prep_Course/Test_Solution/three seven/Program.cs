﻿using System;

namespace three_seven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your number:");

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0))
                {
                    continue;
                }

                Console.Write("{0} ", i);
            }

            
        }
    }
}
