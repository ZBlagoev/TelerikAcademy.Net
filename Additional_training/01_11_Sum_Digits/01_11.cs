using System;

namespace _01_11_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            
            while (a > 0)
            {
                sum += a % 10;
                a = a / 10;
            }
            
            Console.WriteLine(sum);
        }
    }
}
