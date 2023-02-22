using Microsoft.EntityFrameworkCore;
using RegisterWeb.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RegisterWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> User { get; set; }
    }
}

