using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BerrasCinema.Models;

namespace BerrasCinema
{
    public class CinemaDBContext : DbContext
    {
        public CinemaDBContext(DbContextOptions<CinemaDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne<Movies>(s => s.Movies)
                .WithMany(g => g.Orders)
                .HasForeignKey(s => s.MovieID);
        }

        public DbSet<Movies> Movie { get; set; }
        public DbSet<Order> TicketOrders { get; set; }
    }
}
