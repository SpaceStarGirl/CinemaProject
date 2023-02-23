using Microsoft.EntityFrameworkCore;
using System;
using CinemaProject.Models;

namespace CinemaProject.Data
{
    public class DatabaseContext : DbContext
    {
        // table reference / handle
        //public DbSet<Person> Person { get; set; }

        // hvis jeg glemmer denne, kommer der åbenbart ikke en tabel
        //public DbSet<Car> Car { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=PC623031\\SQLEXPRESS;" +
                "Initial Catalog=testAPI;Integrated Security=True");
        }
        // table reference / handle
        //public DbSet<Person> Person { get; set; }

        // hvis jeg glemmer denne, kommer der åbenbart ikke en tabel
        //public DbSet<Car> Car { get; set; }
        public DbSet<CinemaProject.Models.Movie> Movie { get; set; }
        // table reference / handle
        //public DbSet<Person> Person { get; set; }

        // hvis jeg glemmer denne, kommer der åbenbart ikke en tabel
        //public DbSet<Car> Car { get; set; }
        public DbSet<CinemaProject.Models.Genre> Genre { get; set; }
        // table reference / handle
        //public DbSet<Person> Person { get; set; }

        // hvis jeg glemmer denne, kommer der åbenbart ikke en tabel
        //public DbSet<Car> Car { get; set; }
        public DbSet<CinemaProject.Models.Language> Language { get; set; }
    }
}
