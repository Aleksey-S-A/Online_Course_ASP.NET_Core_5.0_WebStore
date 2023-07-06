using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public class DatabaseContext : DbContext
    {
        // Доступ к таблицам
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Image> Image { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasOne(p => p.Product).WithMany(p => p.Images).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            var product1Id = Guid.Parse("c1ec07ab-6733-46e2-9cbc-6518cb0ca98e");
            var product2Id = Guid.Parse("72165b8c-2ae5-4836-9a94-771b7cb32a38");
            var image1 = new Image
            {
                Id = Guid.Parse("25ce7845-5b1f-41cc-9ff7-6ed56cbce7b7"),
                Url = "/images/Products/image1.jpg",
                ProductId = product1Id
            };
            var image2 = new Image
            {
                Id = Guid.Parse("25f334e6-9e67-4c3f-a562-91a5000f383e"),
                Url = "/images/Products/image2.jpg",
                ProductId = product2Id
            };
            modelBuilder.Entity<Image>().HasData(image1, image2);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                 .Property(p => p.Cost)
                 .HasColumnType("decimal(18,2)");

            List<Product> products = new List<Product>()
                 {
                     new Product(product1Id, "Алмаз5033", 3600, "ИБП 50 кВт/ 50 кВа, 380В"),
                     new Product(product2Id, "Топаз1033", 1800, "ИБП 10 кВт/ 10 кВа, 380В"),
                  };
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}