using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieBookingSystem.Models;

namespace MovieBookingSystem.Data
{
    public class MovieBookingSystemContext : DbContext
    {
        public MovieBookingSystemContext (DbContextOptions<MovieBookingSystemContext> options)
            : base(options)
        {
        }

        public DbSet<MovieBookingSystem.Models.Booking> Booking { get; set; } = default!;
    }
}
