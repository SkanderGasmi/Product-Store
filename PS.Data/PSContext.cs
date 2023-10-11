using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PS.Domain;
using System.Reflection.Emit;

namespace PS.Data
{
    public class PSContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public PSContext()
        {
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog = ProductStoreDB;Integrated Security = true";
            dbContextOptionsBuilder.UseSqlServer(connectionString);
        } 
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chemical>().OwnsOne(p => p.address);
        }



    }
}