using System;
using EFCore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data.Concrete.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<ProductCategory>? productCategories{get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1441;Database=EfCoreDbMany;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductCategory>()
        .HasKey(x=>new{x.ProductId,x.CategoryId});
        base.OnModelCreating(modelBuilder);
    }
}
