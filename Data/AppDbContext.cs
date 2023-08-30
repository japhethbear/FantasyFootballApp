using Microsoft.EntityFrameworkCore;
using FantasyFootballApp.Models; // Import your User model

namespace FantasyFootballApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Manager> Managers { get; set; } // DbSet for your User entity
        public DbSet<Team> Teams { get; set; }
        // Add other DbSet properties for other entities if needed

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity relationships and constraints here
        }
    }
}
