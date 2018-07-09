using Session01.Data.EF.Common;
using Session01.Domain.Contracts.Customers;
using Session01.Domain.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session01.Data.EF.Customers
{
    public class CustomerRepository :BaseEfRepository, ICustomerRepository
    {
        public CustomerRepository(Session01DbContext ctx) : base(ctx)
        {
        }

        public List<Customer> Customers()
        {
            return _ctx.Customers.ToList();
        }
    }
}
