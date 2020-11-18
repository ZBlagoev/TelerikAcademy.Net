using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //int firstNumber = number / 100;
            //int secondNumber = number % 100 / 10;
            //int thirdNumber = number % 10;

            string input = Console.ReadLine();

            int firstNumber = input[0] - 48;
            int secondNumber = input[1] - 48;
            int thirdNumber = input[2] - 48;

            // + +; + *; * +; * * 
            int[] numbers = new int[4];

            //int max = 0;

            //int firstCase = firstNumber + secondNumber + thirdNumber;
            //int secondCase = firstNumber + secondNumber * thirdNumber;
            //int thirdCase = firstNumber * secondNumber + thirdNumber;
            //int forthCase = firstNumber * secondNumber * thirdNumber;

            //max = Math.Max(firstCase, Math.Max(secondCase, Math.Max(thirdCase, forthCase)));

            //Console.WriteLine(max);

            numbers[0] = firstNumber + secondNumber + thirdNumber;
            numbers[1] = firstNumber + secondNumber * thirdNumber;
            numbers[2] = firstNumber * secondNumber + thirdNumber;
            numbers[3] = firstNumber * secondNumber * thirdNumber;
            Array.Sort(numbers);

            int max = numbers[3];

            Console.WriteLine(max);
        }
    }
}
