using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());

            double parameter = Math.PI * r * 2;
            double parameter2 = Math.Round(parameter, 2);
            double area = Math.PI * r * r;
            double area2 = Math.Round(area, 2);
            Console.WriteLine("P is {0} and S is {1}", parameter2, area2);
        }

    }
}
