using System;

namespace _02_10_Chinese_Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int year = int.Parse(Console.ReadLine());

            string zodiac;

            // calculation & output
            for (int i = 2000; i < 2012; i++)
            {
                if (Math.Abs(i - year) % 12 == 0)
                {
                    zodiac = i.ToString();

                    switch (zodiac)
                    {
                        case "2000": 
                            Console.WriteLine("Dragon");
                            break;
                        case "2001":
                            Console.WriteLine("Snake");
                            break;
                        case "2002":
                            Console.WriteLine("Horse");
                            break;
                        case "2003":
                            Console.WriteLine("Sheep");
                            break;
                        case "2004":
                            Console.WriteLine("Monkey");
                            break;
                        case "2005":
                            Console.WriteLine("Rooster");
                            break;
                        case "2006":
                            Console.WriteLine("Dog");
                            break;
                        case "2007":
                            Console.WriteLine("Pig");
                            break;
                        case "2008":
                            Console.WriteLine("Rat");
                            break;
                        case "2009":
                            Console.WriteLine("Ox");
                            break;
                        case "2010":
                            Console.WriteLine("Tiger");
                            break;
                        case "2011":
                            Console.WriteLine("Hare");
                            break;

                    }
                }
                else
                {
                    continue;
                }
            }



        }
    }
}
