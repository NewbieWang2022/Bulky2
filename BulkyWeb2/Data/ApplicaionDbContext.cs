using BulkyWeb2.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb2.Data
{
    public class ApplicaionDbContext : DbContext
    {
        public ApplicaionDbContext(DbContextOptions<ApplicaionDbContext> options) : base(options) { 
        
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
