using Session10.ColaStoreProject.Constants;
using Session10.ColaStoreProject.Entities;
using Session10.ColaStoreProject.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Session10.ColaStoreProject.Services
{
    public static class ColaStore
    {
        static List<Cola> Colas { get; set; }
        static Random Random;
        static ColaStore()
        {
            Random = new Random(0);

            Colas = new List<Cola>();

            for (int i = 0; i < 10; i++)
            {
                Colas.Add(new BlackCola(new Money(1_000)));
                Colas.Add(new OrangeCola(new Money(1_000)));
                Colas.Add(new LimonCola(new Money(1_000)));
            }
        }

        private static Order GetOrder(ColaType colaType, int quantity)
        {
            Console.WriteLine(MessageLookup.ENTER_USERNAME);

            string username = Console.ReadLine();

            Console.WriteLine(MessageLookup.ENTER_PASSWORD);

            string password = Console.ReadLine();

            var colasOrdered = Colas.Take(quantity).ToList();

            var totalColaCount = Colas.Count(c => c.ColaType == colaType);

            //Contract.Requires<InvalidOperationException>(colasOrdered.Count < totalColaCount, ErrorMessageLookup.LOW_COLA);
            if(colasOrdered.Count>totalColaCount)
            {
                throw new InvalidOperationException(ErrorMessageLookup.LOW_COLA);
            }

            var money = new Money(0);

            foreach (var cola in colasOrdered)
            {
                money = money + cola.Price;
            }

            var order=new Order(Gateway.Pay(username, password, money), colasOrdered);

            foreach (var item in colasOrdered)
            {
                Colas.Remove(item);
            }

            return order;
        }

        public static Order GetOrder()
        {
            var colaType = ColaType.None;

            while(colaType==ColaType.None)
            {
                Console.WriteLine(MessageLookup.ENTER_COLA_TYPE);

                colaType = ColaTypeFactory.GetColaType(Console.ReadLine());
            }

            int quantity = 0;

            while(quantity<=0)
            {
                Console.WriteLine(MessageLookup.ENTER_QUANTITY);

                int.TryParse(Console.ReadLine(), out quantity);
            }

            return GetOrder(colaType, quantity);
        }
    }
}
