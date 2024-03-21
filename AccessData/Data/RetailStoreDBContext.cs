using AccessData.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccessData.Data
{
    public class RetailStoreDBContext : DbContext
    {
        public RetailStoreDBContext(DbContextOptions<RetailStoreDBContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleProduct> SaleProduct { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=retailStoreDB;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
