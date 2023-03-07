using ApplaudoWeek04CodeFirst.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Data.Configurations.Entities
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(p => p.FirstMidName).HasMaxLength(50);
            builder.Property(p => p.LastName).HasMaxLength(30);


            builder.HasData(
                new Customer { Id = 1, FirstMidName = "Max", LastName = "Jones" },
                new Customer { Id = 2, FirstMidName = "Eve", LastName = "Jackson" },
                new Customer { Id = 3, FirstMidName = "Mike", LastName = "Thompson" }
            );


        }
    }
}
