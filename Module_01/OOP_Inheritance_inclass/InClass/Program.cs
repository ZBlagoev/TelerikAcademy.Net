using System;

namespace InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Mammal();

            

            Mammal mammal = new Mammal();

            mammal.PrintLifespan();
        }
    }

    public class Animal
    {
        public int Lifespan { get; set; }
    }

    public class Mammal : Animal
    {


        public void PrintLifespan()
        {
            Console.WriteLine(this.Lifespan);
        }

    }

}
