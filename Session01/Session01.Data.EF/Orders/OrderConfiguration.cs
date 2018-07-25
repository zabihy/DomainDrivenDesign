using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session01.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Data.EF.Orders
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.OrderId);

            builder.HasOne(o => o.Good)
                        .WithMany(g => g.Orders)
                            .HasForeignKey(o => o.GoodId)
                                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Customer)
                        .WithMany(c => c.Orders)
                            .HasForeignKey(o => o.CustomerId)
                                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Salesman)
            .WithMany(c => c.Orders)
                .HasForeignKey(o => o.SalesmanId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
