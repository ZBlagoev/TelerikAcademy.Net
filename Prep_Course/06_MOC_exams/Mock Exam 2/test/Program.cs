using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(input % 10);


            int a = input / 10 % 10;
            int b = (input % 10 + input / 10 % 10) % 10;
            int c = input % 10;
        }
    }
}
