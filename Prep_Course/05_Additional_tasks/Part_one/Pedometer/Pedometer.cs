/*
Вчера Гошо си купи крачкомер. За съжаление, Гошо все още не се е 
научил да гледа какво купува. Крачкомера му  мери в мили, 
а той разбира само от метри.

Напишете програма, която по отчетените мили от крачкомера пресмята 
колко метра е изминал Гошо.

Вход

От първия ред се въвежда едно число - изминатите мили.

Изход

Изведете изминатите метри на единствен ред.
*/

using System;

namespace Pedometer
{
    class Pedometer
    {
        static void Main(string[] args)
        {
            /*
            // input
            int miles = int.Parse(Console.ReadLine());
            int meters = 0;

            // calculations
            meters = miles * 1609;

            // output
            Console.WriteLine(meters);
            */

            double miles = double.Parse(Console.ReadLine());
            double meters = 0.00;

            meters = miles * 1609;

            Console.WriteLine(Math.Floor(meters));

        }
    }
}
