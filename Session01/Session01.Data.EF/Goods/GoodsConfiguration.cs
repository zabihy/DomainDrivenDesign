using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session01.Domain.Entities.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Data.EF.Goods
{
    public class GoodsConfiguration : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> builder)
        {
            builder.HasKey(g => g.GoodId);
        }
    }
}
