using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorApp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<GuardianDetails> GuardianRoster { get; set; }
        
    }
}

