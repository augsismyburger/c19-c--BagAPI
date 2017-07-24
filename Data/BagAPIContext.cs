using Microsoft.EntityFrameworkCore;
using BagAPI.Models;

namespace BagAPI.Data
{
    public class BagAPIContext : DbContext
    {
        public BagAPIContext(DbContextOptions<BagAPIContext> options)
            : base(options)
        { }

        public DbSet<Toy> Toy { get; set; }
        public DbSet<Child> Child { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Order>()
                // .Property(b => b.DateCreated)
                // .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");
        }
    }
}