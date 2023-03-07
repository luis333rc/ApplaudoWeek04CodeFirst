using ApplaudoWeek04CodeFirst.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Data.Configurations.Entities
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(40).IsRequired();

            builder.HasData(
                new Tag { Id = 1, Name = "Action" },
                new Tag { Id = 2, Name = "Horror" },
                new Tag { Id = 3, Name = "Comedy" },
                new Tag { Id = 4, Name = "Thriller" },
                new Tag { Id = 5, Name = "Thriller" },
                new Tag { Id = 6, Name = "Mystery" },
                new Tag { Id = 7, Name = "Drama" },
                new Tag { Id = 8, Name = "Fantasy" },
                new Tag { Id = 9, Name = "G" },
                new Tag { Id = 10, Name = "PG" },
                new Tag { Id = 11, Name = "PG-14" },
                new Tag { Id = 12, Name = "R" }
            );
        }
    }
}
