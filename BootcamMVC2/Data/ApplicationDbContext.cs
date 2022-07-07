using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootcamMVC2.Models;

namespace BootcamMVC2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new Models.Genre
            {
                Id = 1,
                Name = "Masculino"
            });

            modelBuilder.Entity<Genre>().HasData(new Models.Genre
            {
                Id = 2,
                Name = "Femenino"
            });

            var person = new Person()
            {
                Id = 1,
                LastName = "Santos",
                Name = "Gerson",
                GenreId = 1
            };
            modelBuilder.Entity<Person>().HasData(person);

            person = new Person()
            {
                Id = 2,
                LastName = "Arias",
                Name = "Heger",
                GenreId = 1
            };
            modelBuilder.Entity<Person>().HasData(person);

            person = new Person()
            {
                Id = 3,
                LastName = "Dominguez",
                Name = "Jose",
                GenreId = 1
            };
            modelBuilder.Entity<Person>().HasData(person);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}
