using Microsoft.EntityFrameworkCore;
using Session01.Domain.Entities.Customers;
using Session01.Domain.Entities.Goods;
using Session01.Domain.Entities.Orders;
using Session01.Domain.Entities.Salesmans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Data.EF.Common
{
    public class Session01DbContext:DbContext
    {
        public DbSet<Salesman> SalesMen { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Good> Goods{ get; set; }


    }
}
