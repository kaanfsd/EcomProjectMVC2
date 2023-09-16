using Ecom.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomProjectMVC.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Smartphone",
                    Description = "High-performance smartphone with 6.4-inch display.",
                    Barcode = "SMP12345",
                    Manufacturer = "Samsung",
                    ListPrice = 499.99,
                    Price = 449.99,
                    Price50 = 429.99,
                    Price100 = 399.99
                },
                new Product
                {
                    Id = 2,
                    Title = "Laptop",
                    Description = "Thin and light laptop with Intel Core i7 processor.",
                    Barcode = "LTPT67890",
                    Manufacturer = "Dell",
                    ListPrice = 1099.99,
                    Price = 999.99,
                    Price50 = 949.99,
                    Price100 = 899.99
                },
                new Product
                {
                    Id = 3,
                    Title = "LED TV",
                    Description = "55-inch 4K Ultra HD Smart LED TV with HDR.",
                    Barcode = "TV1234",
                    Manufacturer = "Sony",
                    ListPrice = 799.99,
                    Price = 699.99,
                    Price50 = 649.99,
                    Price100 = 599.99
                },
                new Product
                {
                    Id = 4,
                    Title = "Wireless Earbuds",
                    Description = "Bluetooth wireless earbuds with noise cancellation.",
                    Barcode = "EB5678",
                    Manufacturer = "Apple",
                    ListPrice = 199.99,
                    Price = 179.99,
                    Price50 = 169.99,
                    Price100 = 159.99
                },
                new Product
                {
                    Id = 5,
                    Title = "Digital Camera",
                    Description = "20MP digital camera with 3-inch LCD screen.",
                    Barcode = "CAM4567",
                    Manufacturer = "Canon",
                    ListPrice = 299.99,
                    Price = 249.99,
                    Price50 = 239.99,
                    Price100 = 229.99
                },
                new Product
                {
                    Id = 6,
                    Title = "Coffee Maker",
                    Description = "Programmable coffee maker with built-in grinder.",
                    Barcode = "CM7890",
                    Manufacturer = "Breville",
                    ListPrice = 129.99,
                    Price = 109.99,
                    Price50 = 99.99,
                    Price100 = 89.99
                },
                new Product
                {
                    Id = 7,
                    Title = "Fitness Tracker",
                    Description = "Waterproof fitness tracker with heart rate monitor.",
                    Barcode = "FIT123",
                    Manufacturer = "Fitbit",
                    ListPrice = 79.99,
                    Price = 69.99,
                    Price50 = 64.99,
                    Price100 = 59.99
                },
                new Product
                {
                    Id = 8,
                    Title = "Backpack",
                    Description = "Durable backpack with multiple compartments.",
                    Barcode = "BP5678",
                    Manufacturer = "North Face",
                    ListPrice = 59.99,
                    Price = 49.99,
                    Price50 = 47.99,
                    Price100 = 44.99
                },
                new Product
                {
                    Id = 9,
                    Title = "Desk Chair",
                    Description = "Ergonomic office chair with lumbar support.",
                    Barcode = "CHAIR999",
                    Manufacturer = "Herman Miller",
                    ListPrice = 399.99,
                    Price = 349.99,
                    Price50 = 329.99,
                    Price100 = 299.99
                },
                new Product
                {
                    Id = 10,
                    Title = "Sneakers",
                    Description = "Running sneakers with cushioned soles.",
                    Barcode = "SNK1234",
                    Manufacturer = "Nike",
                    ListPrice = 129.99,
                    Price = 119.99,
                    Price50 = 109.99,
                    Price100 = 99.99
                }

                );
        }
    }
}
