using System;

namespace P4_NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            //output
            double greaterNum = Math.Max(firstNum, secondNum);

            //print output
            Console.WriteLine(greaterNum);
        }
    }
}
