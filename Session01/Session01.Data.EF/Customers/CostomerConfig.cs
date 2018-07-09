using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session01.Domain.Entities.Customers;
using System;

namespace Session01.Data.EF.Customers
{
    public class CostomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            throw new NotImplementedException();
        }
    }
}
