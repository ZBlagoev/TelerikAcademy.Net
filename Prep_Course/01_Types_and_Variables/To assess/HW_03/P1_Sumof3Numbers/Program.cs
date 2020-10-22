using System;

namespace P1_Sumof3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            
            //output
            int sum = firstNum + secondNum + thirdNum;

            //print output
            Console.WriteLine(sum);
        }
    }
}
