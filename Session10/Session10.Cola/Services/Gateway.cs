using Session10.ColaStoreProject.Constants;
using Session10.ColaStoreProject.Entities;
using Session10.ColaStoreProject.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Session10.ColaStoreProject.Services
{
    public static class Gateway
    {
        static Random Random;
        static Gateway()
        {
            Random = new Random();

            Customers = new List<Customer>();

            var admin = CustomerGenerator.GenerateAdmin();

            Customers.Add(admin);

            for (int i = 0; i < 100; i++)
            {
                var customer = CustomerGenerator.Generate();

                if (!Customers.Any(c=>c.UserName==customer.UserName))
                {
                    Customers.Add(customer);
                }
            }

            Transactions = new List<Transaction>();
        }

        private static List<Customer> Customers { get; set; }

        private static List<Transaction> Transactions { get; set; }

        public static Customer GetRandomCustomer()
        {
            return Customers[Random.Next(0, Customers.Count - 1)];
        }

        public static Customer GetAdminCustomer()
        {
            return Customers[0];
        }

        public static Transaction Pay(string userName, string password, Money money)
        {
            var customer = Customers.FirstOrDefault(c => c.UserName.ToLower() == userName && c.Password == password);

            //Contract.Requires<NullReferenceException>(customer != null, ErrorMessageLookup.INVALID_USERNAME_OR_PASSWORD);
            if(customer==null)
            {
                throw new NullReferenceException(ErrorMessageLookup.INVALID_USERNAME_OR_PASSWORD);
            }

            //Contract.Requires<InvalidOperationException>(customer.Credit >= money, ErrorMessageLookup.LOW_CREDIT);
            if(customer.Credit<money)
            {
                throw new InvalidOperationException(ErrorMessageLookup.LOW_CREDIT);
            }

            customer.Credit = customer.Credit - money;

            var transaction = new Transaction(customer.Id, money);

            Transactions.Add(transaction);

            return transaction;
        }
    }
}
