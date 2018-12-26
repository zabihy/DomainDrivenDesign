using Session10.ColaStoreProject.Constants;
using Session10.ColaStoreProject.Services;
using Session10.ColaStoreProject.ValueObjects;
using System;
using System.Linq;

namespace Session10.ColaStoreProject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MessageLookup.WELCOME);

            var randomCustomer = Gateway.GetAdminCustomer();

            Console.WriteLine(MessageLookup.DEFAULT_USER(randomCustomer.UserName));
            Console.WriteLine(MessageLookup.DEFAULT_PASS(randomCustomer.Password));
            Console.WriteLine(MessageLookup.DEFAULT_CREDIT(randomCustomer.Credit));

            try
            {
                var order = ColaStore.GetOrder();

                var groupedColas = order.Colas.GroupBy(c => c.ColaType);

                foreach (var grouped in groupedColas)
                {
                    Console.WriteLine($"{Enum.GetName(typeof(ColaType), grouped.Key)} Cola Quantity: {grouped.Count()}");
                    Console.WriteLine($"{Enum.GetName(typeof(ColaType), grouped.Key)} Cola Total Price: {grouped.Sum(c=>c.Price.Credit)}");
                }

                Console.WriteLine(MessageLookup.EXIT);

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.ReadKey();
            }
        }
    }
}
