using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var personBronze = new Person(new CalcuateDiscountBoronz());

            Console.WriteLine(personBronze.Discount());

            Console.ReadKey();


            var personSilver = new Person(new CalculateDiscountSilver());

            Console.WriteLine(personSilver.Discount());

            Console.ReadKey();



            var personGold = new Person(new CalcluateDiscountGold());

            Console.WriteLine(personGold.Discount());

            Console.ReadKey();
        }
    }
}
