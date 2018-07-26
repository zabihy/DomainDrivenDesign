using Session01.Domain.Contracts.Orders;
using Session01.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.ApplicationServices.Customers.Query
{
    public class GetAllOrderQuery : IGetAllOrderQuery
    {
        private readonly IOrderRepository _repo;

        public GetAllOrderQuery(IOrderRepository repo)
        {
            _repo = repo;
        }
        public List<OrderDto> Execute()
        {
            return _repo.Orders();
        }
    }
}
