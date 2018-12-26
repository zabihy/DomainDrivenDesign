using Session10.ColaStoreProject.ValueObjects;
using System;

namespace Session10.ColaStoreProject.Entities
{
    public class Transaction
    {
        public Transaction(Guid customerId, Money money)
        {
            Id = Guid.NewGuid();
            DateTransaction = DateTime.Now;
        }
        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }
        public Money Money { get; private set; }
        public DateTime DateTransaction { get; private set; }
        public bool Commited { get; set; }
    }
}
