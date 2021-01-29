using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Leshta(a, b));
        }

        static int Leshta(int a, int b)
        {
            if (a > b)
            {
                a *= 5;
            }
            else
            {
                b *= 5;
            }


            return a | b;
        }
    }
}
