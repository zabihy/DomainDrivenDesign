using Session10.ColaStoreProject.Constants;
using Session10.ColaStoreProject.Entities;
using Session10.ColaStoreProject.ValueObjects;
using System;

namespace Session10.ColaStoreProject.Services
{
    internal class CustomerGenerator
    {
        private static string[] FirstNames = new string[] { "Ali", "Hassan", "Hossein", "Reza", "Ahmad", "Mohammad", "Mostafa", "Mojtaba", "Morteza", "Zahra", "Fatemeh", "Khosro", "Katayoon", "Mohaddese" };
        private static string[] LastNames = new string[] { "Zabihi", "Alavi", "Masoomi", "Oroomand", "Rezaee", "Soha", "Safari", "Abbasi", "Soltani", "Mire", "Hashemi", "Samaee", "Rostami", "Baghaee" };
        private static Random Random = new Random();
        public static Customer Generate()
        {
            string name = $"{FirstNames[Random.Next(FirstNames.Length - 1)]} {LastNames[Random.Next(LastNames.Length - 1)]}";
            string userName = name.Replace(" ","");
            return new Customer(name, userName, AppConstants.DEFAULT_PASS, new Money(Random.Next(1_000, 10_000)));
        }

        public static Customer GenerateAdmin()
        {
            string name = AppConstants.DEFAULT_PASS;
            string userName = AppConstants.ADMIN_USER;
            return new Customer(name, userName, AppConstants.DEFAULT_PASS, new Money(Random.Next(1_000, 10_000)));
        }
    }
}
