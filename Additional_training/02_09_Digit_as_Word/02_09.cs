﻿using System;

namespace _02_09_Digit_as_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string digit = Console.ReadLine();

            switch (digit)
            {
                case "0": 
                    Console.WriteLine("zero");
                    break;
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                default: Console.WriteLine("not a digit");
                    break;
            }
        }
    }
}
