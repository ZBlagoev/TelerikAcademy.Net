using System;

namespace P6_SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            double fourthNum = double.Parse(Console.ReadLine());
            double fifthNum = double.Parse(Console.ReadLine());
            
            //output
            double sum = firstNum + secondNum + thirdNum + fourthNum + fifthNum;

            //print output
            Console.WriteLine(sum);
        }
    }
}
