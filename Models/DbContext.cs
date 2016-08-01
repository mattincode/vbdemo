using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace VBdemo.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./vbdemo.db");
        }

        //TODO: Add initial data
        //TODO: Add web-API
        //TODO: Add aurelia webb-app
        //TODO: Add static file serving
        //TODO: Add HTML-canvas page that paint bookings
        //TODO: Add to github

    }
}
