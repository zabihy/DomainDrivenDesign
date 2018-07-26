using Session01.Data.EF.Common;
using Session01.Domain.Contracts.Salesmans;
using Session01.Domain.Entities.Salesmans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session01.Data.EF.Salesmans
{
    public class SalesmanRepository : BaseEfRepository, ISalesmanRepository
    {
        public SalesmanRepository(Session01DbContext ctx) : base(ctx)
        {
        }

        public List<Salesman> Salesmen()
        {
            return _ctx.SalesMen.ToList();
        }
    }
}
