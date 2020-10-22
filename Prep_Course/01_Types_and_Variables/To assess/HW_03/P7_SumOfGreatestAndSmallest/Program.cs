using System;

namespace P7_SumOfGreatestAndSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            
            //output
            double sumGreatestSmallest = Math.Max(firstNum, Math.Max(secondNum, thirdNum)) 
                + Math.Min(firstNum, Math.Min(secondNum, thirdNum));
            
            //print output
            Console.WriteLine(sumGreatestSmallest);
        }
    }
}
