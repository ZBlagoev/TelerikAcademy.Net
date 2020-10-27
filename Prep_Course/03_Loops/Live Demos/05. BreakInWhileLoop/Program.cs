using System;

namespace _05._BreakInWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 10)
            {
                if (counter == 4)
                {
                    Console.WriteLine("Counter == 4, exit application");
                    break;
                }
                Console.WriteLine(++counter);
            }
        }
    }
}
