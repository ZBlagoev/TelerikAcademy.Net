using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int oddN;
            int evenN;

            //calculation
            evenN = (n - 1 + (1 % 2)) / 2 + (1 - (1 % 2));
            oddN = n - evenN;

            // output
            Console.WriteLine(n);
            Console.WriteLine(evenN);
            Console.WriteLine(oddN);
        }
    }
}
