using Microsoft.EntityFrameworkCore;
using petstorebackend.Entities;

namespace petstorebackend.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ProductEntity> Product { get; set; }
    }
}
