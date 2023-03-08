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
    public class MovieTagConfiguration : IEntityTypeConfiguration<MovieTag>
    {
        public void Configure(EntityTypeBuilder<MovieTag> builder)
        {
            builder.HasKey(k => new { k.MovieId, k.TagId });

            builder.HasData(
                new MovieTag { MovieId = 1, TagId = 1 },
                new MovieTag { MovieId = 1, TagId = 9 },
                new MovieTag { MovieId = 2, TagId = 2 },
                new MovieTag { MovieId = 2, TagId = 4 },
                new MovieTag { MovieId = 2, TagId = 8 },
                new MovieTag { MovieId = 3, TagId = 1 },
                new MovieTag { MovieId = 3, TagId = 2 },
                new MovieTag { MovieId = 3, TagId = 5 },
                new MovieTag { MovieId = 3, TagId = 10 }
            );
        }
    }
}
