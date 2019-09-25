using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
using System;

namespace LibraryEF
{
    public class Context : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(local);database=northwind;integrated security=true;");
        }
    }
}
