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
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasIndex( i => i.Title).IsUnique();

            builder.Property(x => x.Title).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.Property(x => x.PosterUrl).HasMaxLength(300);
            builder.Property(x => x.TrailerUrl).HasMaxLength(150);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Stock).HasDefaultValue(1);
            builder.Property(x => x.Available).HasDefaultValue(false);

            builder.HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Jurassic World: Dominion",
                    Description = "Cuatro años después de la destrucción de Isla Nublar, los dinosaurios conviven – y cazan – con los seres humanos en todo el mundo. Este frágil equilibrio cambiará el futuro y decidirá, de una vez por todas, si los seres humanos seguirán en la cúspide de los depredadores en un planeta que comparten con los animales más temibles de la creación.",
                    PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/VEZtsEQwsItZUoIdqzMwjvkwxI.jpg",
                    TrailerUrl = "https://youtu.be/9m9yRauMJIQ",
                    Price = 5,
                    Stock = 10,
                    Available = true
                },
                new Movie
                {
                    Id = 2,
                    Title = "Duro de entrenar",
                    Description = "El cómico estadounidense Kevin Hart quiere ser una estrella de acción, pero para conseguir un papel que cambie su vida, primero tiene que aprender a ser un héroe de acción.",
                    PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/xz91Gre0w7tyl99jGEh5oGc8DQ7.jpg",
                    TrailerUrl = "https://youtu.be/kAYOmh5Kh2U",
                    Price = 4,
                    Stock = 2,
                    Available = true
                },
                new Movie
                {
                    Id = 3,
                    Title = "El peor vecino del mundo",
                    Description = "Otto Anderson (Tom Hanks) es un viudo cascarrabias y muy obstinado. Cuando una alegre joven familia se muda a la casa de al lado, Otto encuentra la horma de su zapato en la espabilada, y muy embarazada, Marisol, lo que conlleva a una muy improbable amistad que pondrá su mundo patas arriba. Remake de la película sueca 'A Man Called Ove' de 2015.",
                    PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8bNLrZt9lrmnt6LsaGG8GfDfgYR.jpg",
                    TrailerUrl = "https://youtu.be/SC6CHBZa4Xg",
                    Price = 5,
                    Stock = 3,
                    Available = true
                }


            );
        }
    }
}
