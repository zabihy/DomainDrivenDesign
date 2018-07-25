using System;
using System.Collections.Generic;
using System.Text;
using Session01.Domain.Entities.Orders;

namespace Session01.Domain.Entities.Customers
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
