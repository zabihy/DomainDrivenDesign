using Session01.Domain.Entities.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.Contracts.Goods
{
    interface IGoodRepository
    {
        List<Good> Goods();
    }
}
