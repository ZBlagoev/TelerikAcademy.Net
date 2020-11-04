using System;

namespace LoopTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);

                if (i == 1)
                {
                    i = 9;
                }

                if (i == 6)
                {
                    break;
                }
            }
            
            
        }
    }
}



