using Microsoft.EntityFrameworkCore;

namespace BulkyWeb2.Data
{
    public class ApplicaionDbContext : DbContext
    {
        public ApplicaionDbContext(DbContextOptions<ApplicaionDbContext> options) : base(options) { 
        
        }
    }
}
