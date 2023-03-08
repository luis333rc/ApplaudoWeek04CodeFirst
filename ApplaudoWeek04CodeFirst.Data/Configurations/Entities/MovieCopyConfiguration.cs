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
    public class MovieCopyConfiguration : IEntityTypeConfiguration<MovieCopy>
    {
        public void Configure(EntityTypeBuilder<MovieCopy> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p=>p.Available).HasDefaultValue(true);

            builder.HasData(
                new MovieCopy { Id = 1, MovieId = 1, Available = true },
                new MovieCopy { Id = 2, MovieId = 1, Available = true },
                new MovieCopy { Id = 3, MovieId = 1, Available = true },
                new MovieCopy { Id = 4, MovieId = 2, Available = false },
                new MovieCopy { Id = 5, MovieId = 2, Available = true },
                new MovieCopy { Id = 6, MovieId = 3, Available = false },
                new MovieCopy { Id = 7, MovieId = 3, Available = true },
                new MovieCopy { Id = 8, MovieId = 3, Available = true }
            );
        }
    }
}
