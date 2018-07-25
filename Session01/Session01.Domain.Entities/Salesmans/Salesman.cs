using System;
using System.Collections.Generic;
using System.Text;
using Session01.Domain.Entities.Orders;

namespace Session01.Domain.Entities.Salesmans
{
    public class Salesman
    {
        public int SalesmanId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
