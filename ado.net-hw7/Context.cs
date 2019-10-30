using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw7
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<Videgame> Videogames { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<VideogameRatings> VideogamesRatings { get; set; }
        public DbSet<UserRating> UserRatings { get; set; }
        public DbSet<User> DbUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-305-03;Database=VideogameRatings;Trusted_Connection=true;");
        }
    }
}
