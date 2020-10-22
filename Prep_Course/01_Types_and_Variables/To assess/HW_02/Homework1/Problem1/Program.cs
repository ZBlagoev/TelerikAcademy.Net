using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a program that will sum 3 whole numbers provided by you! \n"); //introduction

            Console.WriteLine("Please input your first whole number:");  //data prompt to user
            string a = Console.ReadLine();
            int firstNumber = int.Parse(a);
            Console.WriteLine("Please input your second whole number:");
            string b = Console.ReadLine();
            int secondNumber = int.Parse(b);
            Console.WriteLine("Please input your third whole number:");
            string c = Console.ReadLine();
            int thirdNumber = int.Parse(c);

            int sum = firstNumber + secondNumber + thirdNumber; //computation of provided data

            Console.WriteLine("\nThank you! The sum of your numbers is: " + sum); //finalization / output
            
        }
    }
}
