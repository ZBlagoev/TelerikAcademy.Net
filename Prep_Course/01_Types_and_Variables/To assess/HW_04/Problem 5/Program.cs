using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, x1, x2;
            Console.Write("Enter A (A != 0): ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            double c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("X1={0}, X2={1}", x1, x2);
           

        }
    }
}