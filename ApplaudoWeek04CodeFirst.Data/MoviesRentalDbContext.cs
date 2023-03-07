using ApplaudoWeek04CodeFirst.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Data
{
    public  class MoviesRentalDbContext : DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PH8N518;Integrated Security=True; Initial Catalog=MovieRental;")
                //.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name })
                //.EnableSensitiveDataLogging()
                ;
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new CustomerConfiguration())
                            .ApplyConfiguration(new MovieConfiguration())
                            .ApplyConfiguration(new TagConfiguration ())
                            .ApplyConfiguration(new MovieTagConfiguration())
                            .ApplyConfiguration(new MovieCopyConfiguration())
                            .ApplyConfiguration(new MovieLikeConfiguration())
                            .ApplyConfiguration(new RentalConfiguration());
            }

            DbSet<Customer> Customers { get; set; }

            DbSet<Movie> Movies { get; set; }

            DbSet<MovieCopy> MovieCopies { get; set; }

            DbSet<MovieTagConfiguration> MovieTags { get; set; }

            DbSet<Rental> Rentals { get; set; }

            DbSet<Tag> Tags { get; set; }

            DbSet<MovieLike> MovieLikes { get; set; }
    }
}
