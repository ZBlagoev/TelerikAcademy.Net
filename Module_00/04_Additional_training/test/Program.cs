using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2
                },
                { 3, 4
                }
            };


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }

                Console.WriteLine();
            }


        }

    }
}
