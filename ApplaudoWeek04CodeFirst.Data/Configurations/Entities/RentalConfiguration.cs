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
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.HasKey(k => new { k.Id });
            builder.Property(p => p.RentalDate).HasDefaultValue(DateTime.Now);

            builder.HasData(
                new Rental { Id = 1, CustomerId = 1, MovieCopyId = 1, RentalDate = new DateTime(2023, 01, 05, 10, 50, 0), ReturnDate = new DateTime(2023, 01, 06, 11, 50, 0) },
                new Rental { Id = 2, CustomerId = 1, MovieCopyId = 2, RentalDate = new DateTime(2023, 01, 05, 14, 50, 0), ReturnDate = new DateTime(2023, 01, 07, 18, 00, 0) },
                new Rental { Id = 3, CustomerId = 2, MovieCopyId = 3, RentalDate = new DateTime(2023, 01, 06, 10, 50, 0), ReturnDate = new DateTime(2023, 01, 08, 16, 50, 0) },
                new Rental { Id = 4, CustomerId = 2, MovieCopyId = 4, RentalDate = new DateTime(2023, 01, 07, 18, 50, 0), ReturnDate = new DateTime(2023, 01, 09, 10, 30, 0) },
                new Rental { Id = 5, CustomerId = 3, MovieCopyId = 5, RentalDate = new DateTime(2023, 01, 10, 8, 50, 0), ReturnDate = new DateTime(2023, 01, 11, 18, 50, 0) },
                new Rental { Id = 6, CustomerId = 3, MovieCopyId = 6, RentalDate = new DateTime(2023, 01, 11, 9, 50, 0), ReturnDate = new DateTime(2023, 01, 12, 14, 40, 0) },
                new Rental { Id = 7, CustomerId = 3, MovieCopyId = 7, RentalDate = new DateTime(2023, 01, 13, 16, 50, 0) },
                new Rental { Id = 8, CustomerId = 3, MovieCopyId = 8, RentalDate = new DateTime(2023, 01, 14, 18, 50, 0), ReturnDate = new DateTime(2023, 01, 16, 13, 50, 0) }
            );

        }
    }
}
