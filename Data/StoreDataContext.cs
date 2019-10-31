using DevApi.Data.Maps;
using DevApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DevApi.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Products> Products { get; set; }   
      public DbSet<Category> Categories { get; set; }   
         

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=DevApiDB;Integrated Security=True");
        }

        
    protected override void OnModelCreating(ModelBuilder builder)
    {
         builder.ApplyConfiguration(new ProductMap());
         builder.ApplyConfiguration(new CategoryMap());
    }
    }
}