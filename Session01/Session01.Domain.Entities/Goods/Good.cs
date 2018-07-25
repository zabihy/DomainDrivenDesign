using System;
using System.Collections.Generic;
using System.Text;
using Session01.Domain.Entities.Orders;

namespace Session01.Domain.Entities.Goods
{
    public class Good
    {
        public int GoodId { get; set; }
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
