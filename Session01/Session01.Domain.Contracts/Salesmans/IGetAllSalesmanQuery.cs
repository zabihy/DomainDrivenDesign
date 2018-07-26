using Session01.Domain.Contracts.Commons;
using Session01.Domain.Entities.Salesmans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.Contracts.Salesmans
{
    public interface IGetAllSalesmanQuery:IQuery<Salesman>
    {
    }
}
