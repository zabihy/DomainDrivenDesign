using Session10.ColaStoreProject.ValueObjects;
using System;

namespace Session10.ColaStoreProject.Entities
{
    public class Customer
    {
        public Customer(string name, string username, string password, Money credit)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.UserName = username;
            this.Password = password;
            this.Credit = credit;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Money Credit { get; internal set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
    }
}
