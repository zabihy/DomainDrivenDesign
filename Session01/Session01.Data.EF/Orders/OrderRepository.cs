using Session01.Data.EF.Common;
using Session01.Domain.Contracts.Orders;
using Session01.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session01.Data.EF.Orders
{
    public class OrderRepository : BaseEfRepository, IOrderRepository
    {
        public OrderRepository(Session01DbContext context):base(context)
        {

        }
        public Order Find(int id)
        {
            return _ctx.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public List<OrderDto> Orders()
        {
            return _ctx.Orders.Select(o=>
                new OrderDto
                {
                    CustomerName = $"{o.Customer.FirstName} {o.Customer.LastName}",
                    GoodName = o.Good.Name,
                    OrderId = o.OrderId,
                    Price = o.Price,
                    Quantity = o.Quantity,
                    SalesmanName = $"{o.Salesman.FirstName} {o.Salesman.LastName}",
                    TotalPrice = o.TotalPrice
                }).ToList();
        }
    }
}
