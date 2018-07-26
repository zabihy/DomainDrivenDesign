using Session01.Data.EF.Common;
using Session01.Domain.Contracts.Goods;
using Session01.Domain.Entities.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session01.Data.EF.Goods
{
    public class GoodRepository : BaseEfRepository, IGoodRepository
    {
        public GoodRepository(Session01DbContext ctx) : base(ctx)
        {
        }

        public List<Good> Goods()
        {
            return _ctx.Goods.ToList();
        }
    }
}
