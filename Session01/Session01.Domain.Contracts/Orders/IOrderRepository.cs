using Session01.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.Contracts.Orders
{
    public interface IOrderRepository
    {
        List<OrderDto> Orders();
        Order Find(int id);
    }
}
