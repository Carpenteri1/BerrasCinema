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
        public DbSet<Movies> Movie { get; set; }
        public DbSet<Order> TicketOrders { get; set; }
    }
}
