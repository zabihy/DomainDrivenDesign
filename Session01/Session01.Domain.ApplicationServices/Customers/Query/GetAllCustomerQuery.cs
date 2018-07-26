using Session01.Domain.Contracts.Customers;
using Session01.Domain.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.ApplicationServices.Customers.Query
{
    public class GetAllCustomerQuery : IGetAllCustomerQuery
    {
        private readonly ICustomerRepository _customerRepository;

        public GetAllCustomerQuery(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> Execute()
        {
            return _customerRepository.Customers();
        }
    }
}
