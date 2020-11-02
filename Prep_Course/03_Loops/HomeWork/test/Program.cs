using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            for (int i = 0; i <= 255; i++)

            {

                Console.WriteLine("{0} = {1}", i, (char)i);
                //Console.WriteLine("L♠♥♦♣\n");
            }

        }
    }
}