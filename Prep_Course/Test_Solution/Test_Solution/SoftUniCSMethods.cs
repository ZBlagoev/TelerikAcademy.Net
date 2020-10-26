using Microso
using System;

namespace Test_Solution
{
    class SoftUniCSMethods
    {
        public static void Main()
        {

            PrintHello();
            Console.WriteLine($" {getName()}!");

            int a = 5;
            int b = 6;

            int sum = SumNumbers(a, b);
            Console.WriteLine(sum);

        }

        // simple void method which prints a word
        public static void PrintHello()
        {
            Console.Write("Hello,");
        }

        // simple method 'tring' which returns a string
        public static string getName()
        {
            return "Zhelyazkko";
        }

        // method that takes 2 input numbers and returns their sums - written to take int and doubles
        public static int SumNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public static double SumNumbers(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

    }
}
