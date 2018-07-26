using Session01.Domain.Contracts.Commons;
using Session01.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.Contracts.Orders
{
    public interface IGetAllOrderQuery:IQuery<OrderDto>
    {
    }
}
