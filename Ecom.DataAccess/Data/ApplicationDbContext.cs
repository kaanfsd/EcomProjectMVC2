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
                    ListPrice = 500,
                    Price = 450,
                    Price50 = 430,
                    Price100 = 400,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Laptop",
                    Description = "Thin and light laptop with Intel Core i7 processor.",
                    Barcode = "LTPT67890",
                    Manufacturer = "Dell",
                    ListPrice = 1100,
                    Price = 1000,
                    Price50 = 950,
                    Price100 = 900,
                    CategoryId =13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "LED TV",
                    Description = "55-inch 4K Ultra HD Smart LED TV with HDR.",
                    Barcode = "TV1234",
                    Manufacturer = "Sony",
                    ListPrice = 800,
                    Price = 700,
                    Price50 = 650,
                    Price100 = 600,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Wireless Earbuds",
                    Description = "Bluetooth wireless earbuds with noise cancellation.",
                    Barcode = "EB5678",
                    Manufacturer = "Apple",
                    ListPrice = 200,
                    Price = 180,
                    Price50 = 170,
                    Price100 = 160,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Digital Camera",
                    Description = "20MP digital camera with 3-inch LCD screen.",
                    Barcode = "CAM4567",
                    Manufacturer = "Canon",
                    ListPrice = 300,
                    Price = 250,
                    Price50 = 240,
                    Price100 = 230,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Coffee Maker",
                    Description = "Programmable coffee maker with built-in grinder.",
                    Barcode = "CM7890",
                    Manufacturer = "Breville",
                    ListPrice = 130,
                    Price = 110,
                    Price50 = 100,
                    Price100 = 90,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 7,
                    Title = "Fitness Tracker",
                    Description = "Waterproof fitness tracker with heart rate monitor.",
                    Barcode = "FIT123",
                    Manufacturer = "Fitbit",
                    ListPrice = 80,
                    Price = 70,
                    Price50 = 65,
                    Price100 = 60,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 8,
                    Title = "Backpack",
                    Description = "Durable backpack with multiple compartments.",
                    Barcode = "BP5678",
                    Manufacturer = "North Face",
                    ListPrice = 60,
                    Price = 50,
                    Price50 = 48,
                    Price100 = 45,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 9,
                    Title = "Desk Chair",
                    Description = "Ergonomic office chair with lumbar support.",
                    Barcode = "CHAIR999",
                    Manufacturer = "Herman Miller",
                    ListPrice = 400,
                    Price = 350,
                    Price50 = 330,
                    Price100 = 300,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 10,
                    Title = "Sneakers",
                    Description = "Running sneakers with cushioned soles.",
                    Barcode = "SNK1234",
                    Manufacturer = "Nike",
                    ListPrice = 130,
                    Price = 120,
                    Price50 = 110,
                    Price100 = 100,
                    CategoryId = 13,
                    ImageUrl = ""
                }

                );
        }
    }
}
