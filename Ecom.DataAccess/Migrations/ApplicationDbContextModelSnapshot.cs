﻿// <auto-generated />
using EcomProjectMVC.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcomProjectMVC.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecom.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("Ecom.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "SMP12345",
                            Description = "High-performance smartphone with 6.4-inch display.",
                            ListPrice = 499.99000000000001,
                            Manufacturer = "Samsung",
                            Price = 449.99000000000001,
                            Price100 = 399.99000000000001,
                            Price50 = 429.99000000000001,
                            Title = "Smartphone"
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "LTPT67890",
                            Description = "Thin and light laptop with Intel Core i7 processor.",
                            ListPrice = 1099.99,
                            Manufacturer = "Dell",
                            Price = 999.99000000000001,
                            Price100 = 899.99000000000001,
                            Price50 = 949.99000000000001,
                            Title = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            Barcode = "TV1234",
                            Description = "55-inch 4K Ultra HD Smart LED TV with HDR.",
                            ListPrice = 799.99000000000001,
                            Manufacturer = "Sony",
                            Price = 699.99000000000001,
                            Price100 = 599.99000000000001,
                            Price50 = 649.99000000000001,
                            Title = "LED TV"
                        },
                        new
                        {
                            Id = 4,
                            Barcode = "EB5678",
                            Description = "Bluetooth wireless earbuds with noise cancellation.",
                            ListPrice = 199.99000000000001,
                            Manufacturer = "Apple",
                            Price = 179.99000000000001,
                            Price100 = 159.99000000000001,
                            Price50 = 169.99000000000001,
                            Title = "Wireless Earbuds"
                        },
                        new
                        {
                            Id = 5,
                            Barcode = "CAM4567",
                            Description = "20MP digital camera with 3-inch LCD screen.",
                            ListPrice = 299.99000000000001,
                            Manufacturer = "Canon",
                            Price = 249.99000000000001,
                            Price100 = 229.99000000000001,
                            Price50 = 239.99000000000001,
                            Title = "Digital Camera"
                        },
                        new
                        {
                            Id = 6,
                            Barcode = "CM7890",
                            Description = "Programmable coffee maker with built-in grinder.",
                            ListPrice = 129.99000000000001,
                            Manufacturer = "Breville",
                            Price = 109.98999999999999,
                            Price100 = 89.989999999999995,
                            Price50 = 99.989999999999995,
                            Title = "Coffee Maker"
                        },
                        new
                        {
                            Id = 7,
                            Barcode = "FIT123",
                            Description = "Waterproof fitness tracker with heart rate monitor.",
                            ListPrice = 79.989999999999995,
                            Manufacturer = "Fitbit",
                            Price = 69.989999999999995,
                            Price100 = 59.990000000000002,
                            Price50 = 64.989999999999995,
                            Title = "Fitness Tracker"
                        },
                        new
                        {
                            Id = 8,
                            Barcode = "BP5678",
                            Description = "Durable backpack with multiple compartments.",
                            ListPrice = 59.990000000000002,
                            Manufacturer = "North Face",
                            Price = 49.990000000000002,
                            Price100 = 44.990000000000002,
                            Price50 = 47.990000000000002,
                            Title = "Backpack"
                        },
                        new
                        {
                            Id = 9,
                            Barcode = "CHAIR999",
                            Description = "Ergonomic office chair with lumbar support.",
                            ListPrice = 399.99000000000001,
                            Manufacturer = "Herman Miller",
                            Price = 349.99000000000001,
                            Price100 = 299.99000000000001,
                            Price50 = 329.99000000000001,
                            Title = "Desk Chair"
                        },
                        new
                        {
                            Id = 10,
                            Barcode = "SNK1234",
                            Description = "Running sneakers with cushioned soles.",
                            ListPrice = 129.99000000000001,
                            Manufacturer = "Nike",
                            Price = 119.98999999999999,
                            Price100 = 99.989999999999995,
                            Price50 = 109.98999999999999,
                            Title = "Sneakers"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
