using System;

namespace _99_4_Legs
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i <= n; i += 7)
            {
                for (int j = 0; j <= n; j += 5)
                {
                    for (int k = 0; k <= n; k += 2)
                    {
                        if (i + j + k == n)
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);

        }
    }
}
