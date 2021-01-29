using System;

namespace _03_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; n > 1 ; i++)
            {
                if (n % i == 0)
                {
                    int x = 0;

                    while (n % i == 0)
                    {
                        n /= i;
                        x++;
                    }

                    for (int j = x; j >= 1; j--)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
