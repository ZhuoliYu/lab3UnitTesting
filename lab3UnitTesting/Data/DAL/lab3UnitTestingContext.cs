using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab3UnitTesting.Models;

namespace lab3UnitTesting.Data
{
    public class lab3UnitTestingContext : DbContext
    {
        public lab3UnitTestingContext (DbContextOptions<lab3UnitTestingContext> options)
            : base(options)
        {
        }

        public DbSet<lab3UnitTesting.Models.Pass>? Pass { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<Reservation> Reservation { get; set; }

        public DbSet<ParkingSpace> ParkingSpace { get; set; }
    }
}
