using System;
using EShop.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Concrete.Contexts;

public class EShopDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public EShopDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<ProductCategory>? ProductCategories { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(x => new { x.ProductId, x.CategoryId });
            //Product => ProductCategory  1'e çok ilişki
            entity.HasOne(pc => pc.Product)
            .WithMany(p => p.ProductCategories)
            .HasForeignKey(pc => pc.ProductId);
            //Category => ProductCategory 1'e çok ilişki
            entity.HasOne(pc => pc.Category)
            .WithMany(c => c.ProductCategories)
            .HasForeignKey(pc => pc.CategoryId);

            builder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).ValueGeneratedOnAdd();
                entity.Property(c => c.Name).HasMaxLength(200).IsRequired();
                entity.Property(c => c.Description).HasMaxLength(500);
                entity.HasData(

                new Category("Elektronik", "/images/categories/electronics.jpg")
                {
                    Id = 1,
                    Name = "Elektronik",
                    Description = "Telefon, bilgisayar ve diğer elektronik ürünler.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Moda", "/images/categories/fashion.jpg")
                {
                    Id = 2,
                    Name = "Moda",
                    Description = "Kadın, erkek ve çocuk giyim ürünleri.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Ev ve Yaşam", "/images/categories/home.jpg")
                {
                    Id = 3,
                    Name = "Ev ve Yaşam",
                    Description = "Mobilya, dekorasyon ve ev ürünleri.",
                    IsActive = false, // Pasif kategori
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Spor ve Outdoor", "/images/categories/sports.jpg")
                {
                    Id = 4,
                    Name = "Spor ve Outdoor",
                    Description = "Spor ekipmanları ve açık hava ürünleri.",
                    IsActive = false, // Pasif kategori
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Kitap, Film ve Müzik", "/images/categories/books.jpg")
                {
                    Id = 5,
                    Name = "Kitap, Film ve Müzik",
                    Description = "Kitaplar, filmler ve müzik ürünleri.",
                    IsActive = true,
                    IsDeleted = true, // Silinmiş kategori
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Oyuncak ve Bebek", "/images/categories/toys.jpg")
                {
                    Id = 6,
                    Name = "Oyuncak ve Bebek",
                    Description = "Çocuk oyuncakları ve bebek ürünleri.",
                    IsActive = true,
                    IsDeleted = true, // Silinmiş kategori
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Kozmetik ve Kişisel Bakım", "/images/categories/beauty.jpg")
                {
                    Id = 7,
                    Name = "Kozmetik ve Kişisel Bakım",
                    Description = "Cilt bakım ürünleri ve kozmetik.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Ayakkabı ve Çanta", "/images/categories/shoes.jpg")
                {
                    Id = 8,
                    Name = "Ayakkabı ve Çanta",
                    Description = "Günlük ve özel ayakkabılar ile çantalar.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Petshop", "/images/categories/petshop.jpg")
                {
                    Id = 9,
                    Name = "Petshop",
                    Description = "Evcil hayvan ürünleri ve aksesuarları.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                },
                new Category("Oto Aksesuarları", "/images/categories/auto.jpg")
                {
                    Id = 10,
                    Name = "Oto Aksesuarları",
                    Description = "Araç içi ve dışı aksesuarlar.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                }
            );
        

                builder.Entity<Product>(entity =>
                {
                    entity.HasKey(p => p.Id);
                    entity.Property(p => p.Id).ValueGeneratedOnAdd();
                    entity.Property(p => p.Name).HasMaxLength(200).IsRequired();
                    entity.Property(p => p.Price).HasColumnType("decimal(10,2)");
                    entity.Property(p => p.ImageUrl).IsRequired();
                });
            });
            base.OnModelCreating(builder);
        });

    }

}

