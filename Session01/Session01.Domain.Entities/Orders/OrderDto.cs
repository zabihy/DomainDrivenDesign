using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.Entities.Orders
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public string SalesmanName { get; set; }
        public string GoodName { get; set; }

    }
}
