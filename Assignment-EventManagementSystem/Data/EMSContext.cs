using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS.Models;

namespace EMS.Data
{
    public class EMSContext : DbContext
    {
        public EMSContext (DbContextOptions<EMSContext> options)
            : base(options)
        {
        }

        public DbSet<EMS.Models.Evnts> Evnts { get; set; } = default!;
        public DbSet<EMS.Models.Bookings> Bookings { get; set; } = default!;
    }
}
