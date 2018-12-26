using Session10.ColaStoreProject.ValueObjects;
using System;
using System.Collections.Generic;

namespace Session10.ColaStoreProject.Entities
{
    public class Order
    {
        public Order(Transaction transaction, IEnumerable<Cola> colas)
        {
            Id = Guid.NewGuid();
            Transaction = transaction;
            Colas = colas;
        }
        public Guid Id { get; private set; }
        public Transaction Transaction { get; private set; }
        public IEnumerable<Cola> Colas { get; private set; }
    }
}
