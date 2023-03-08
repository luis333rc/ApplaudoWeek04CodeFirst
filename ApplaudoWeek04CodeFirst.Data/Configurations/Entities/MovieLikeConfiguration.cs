using ApplaudoWeek04CodeFirst.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Data.Configurations.Entities
{
    public class MovieLikeConfiguration : IEntityTypeConfiguration<MovieLike>
    {
        public void Configure(EntityTypeBuilder<MovieLike> builder)
        {
            builder.HasKey(a => new { a.MovieId, a.CustomerId });

            builder.HasOne(o => o.Movie)
                    .WithMany( m => m.MovieLikes)
                    .HasForeignKey(o => o.MovieId);

            builder.HasOne(o => o.Customer)
                    .WithMany(m => m.MovieLikes)
                    .HasForeignKey(o => o.CustomerId);

            builder.HasData(
                new MovieLike { MovieId = 1, CustomerId = 1, Likes = 4 },
                new MovieLike { MovieId = 1, CustomerId = 2, Likes = 3 },
                new MovieLike { MovieId = 1, CustomerId = 3, Likes = 5 },
                new MovieLike { MovieId = 2, CustomerId = 1, Likes = 2 },
                new MovieLike { MovieId = 2, CustomerId = 2, Likes = 3 },
                new MovieLike { MovieId = 2, CustomerId = 3, Likes = 5 },
                new MovieLike { MovieId = 3, CustomerId = 1, Likes = 4 },
                new MovieLike { MovieId = 3, CustomerId = 2, Likes = 5 },
                new MovieLike { MovieId = 3, CustomerId = 3, Likes = 4 }
            );
        }
    }
}
