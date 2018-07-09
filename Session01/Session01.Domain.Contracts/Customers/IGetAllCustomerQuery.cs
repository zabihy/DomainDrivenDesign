using Session01.Domain.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.Contracts.Customers
{
    public interface IGetAllCustomerQuery
    {
        List<Customer> Execute();
    }
}
