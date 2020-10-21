using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int year = int.Parse(Console.ReadLine());

            int yearDragon = 2000;
            int yearSnake = 2001;
            int yearHorse = 2002;
            int yearSheep = 2003;
            int yearMonkey = 2004;
            int yearRooster = 2005;
            int yearDog = 2006;
            int yearPig = 2007;
            int yearRat = 2008;
            int yearOx = 2009;
            int yearTiger = 2010;
            //int yearHare = 2011;

            string yearSign;

            // calculation
            if ((Math.Abs(year - yearDragon) % 12 == 0))
            {
                yearSign = "Dragon";
            }
            else if ((Math.Abs(year - yearSnake) % 12 == 0))
            {
                yearSign = "Snake";
            }
            else if ((Math.Abs(year - yearHorse) % 12 == 0))
            {
                yearSign = "Horse";
            }
            else if ((Math.Abs(year - yearSheep) % 12 == 0))
            {
                yearSign = "Sheep";
            }
            else if ((Math.Abs(year - yearMonkey) % 12 == 0))
            {
                yearSign = "Monkey";
            }
            else if ((Math.Abs(year - yearRooster) % 12 == 0))
            {
                yearSign = "Rooster";
            }
            else if ((Math.Abs(year - yearDog) % 12 == 0))
            {
                yearSign = "Dog";
            }
            else if ((Math.Abs(year - yearPig) % 12 == 0))
            {
                yearSign = "Pig";
            }
            else if ((Math.Abs(year - yearRat) % 12 == 0))
            {
                yearSign = "Rat";
            }
            else if ((Math.Abs(year - yearOx) % 12 == 0))
            {
                yearSign = "Ox";
            }
            else if ((Math.Abs(year - yearTiger) % 12 == 0))
            {
                yearSign = "Tiger";
            }
            else 
            {
                yearSign = "Hare";
            }

            // output
            Console.WriteLine(yearSign);


        }
    }
}
