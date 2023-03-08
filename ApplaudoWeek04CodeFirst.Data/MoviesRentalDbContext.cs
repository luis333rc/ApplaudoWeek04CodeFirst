using ApplaudoWeek04CodeFirst.Data.Configurations.Entities;
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
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PH8N518;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Database=MovieRental;")
                //.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name })
                //.EnableSensitiveDataLogging()
                ;
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new CustomerConfiguration())
                            .ApplyConfiguration(new MovieConfiguration())
                            .ApplyConfiguration(new TagConfiguration())
                            .ApplyConfiguration(new MovieTagConfiguration())
                            .ApplyConfiguration(new MovieCopyConfiguration())
                            .ApplyConfiguration(new MovieLikeConfiguration())
                            .ApplyConfiguration(new RentalConfiguration());
            }

            public DbSet<Customer> Customers { get; set; }

            public DbSet<Movie> Movies { get; set; }

            public DbSet<MovieCopy> MovieCopies { get; set; }

            public DbSet<MovieTag> MovieTags { get; set; }

            public DbSet<Rental> Rentals { get; set; }

            public DbSet<Tag> Tags { get; set; }

            public DbSet<MovieLike> MovieLikes { get; set; }
    }
}
