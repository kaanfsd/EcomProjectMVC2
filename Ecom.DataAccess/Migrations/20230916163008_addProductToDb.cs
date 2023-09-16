using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcomProjectMVC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Description", "ListPrice", "Manufacturer", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "SMP12345", "High-performance smartphone with 6.4-inch display.", 499.99000000000001, "Samsung", 449.99000000000001, 399.99000000000001, 429.99000000000001, "Smartphone" },
                    { 2, "LTPT67890", "Thin and light laptop with Intel Core i7 processor.", 1099.99, "Dell", 999.99000000000001, 899.99000000000001, 949.99000000000001, "Laptop" },
                    { 3, "TV1234", "55-inch 4K Ultra HD Smart LED TV with HDR.", 799.99000000000001, "Sony", 699.99000000000001, 599.99000000000001, 649.99000000000001, "LED TV" },
                    { 4, "EB5678", "Bluetooth wireless earbuds with noise cancellation.", 199.99000000000001, "Apple", 179.99000000000001, 159.99000000000001, 169.99000000000001, "Wireless Earbuds" },
                    { 5, "CAM4567", "20MP digital camera with 3-inch LCD screen.", 299.99000000000001, "Canon", 249.99000000000001, 229.99000000000001, 239.99000000000001, "Digital Camera" },
                    { 6, "CM7890", "Programmable coffee maker with built-in grinder.", 129.99000000000001, "Breville", 109.98999999999999, 89.989999999999995, 99.989999999999995, "Coffee Maker" },
                    { 7, "FIT123", "Waterproof fitness tracker with heart rate monitor.", 79.989999999999995, "Fitbit", 69.989999999999995, 59.990000000000002, 64.989999999999995, "Fitness Tracker" },
                    { 8, "BP5678", "Durable backpack with multiple compartments.", 59.990000000000002, "North Face", 49.990000000000002, 44.990000000000002, 47.990000000000002, "Backpack" },
                    { 9, "CHAIR999", "Ergonomic office chair with lumbar support.", 399.99000000000001, "Herman Miller", 349.99000000000001, 299.99000000000001, 329.99000000000001, "Desk Chair" },
                    { 10, "SNK1234", "Running sneakers with cushioned soles.", 129.99000000000001, "Nike", 119.98999999999999, 99.989999999999995, 109.98999999999999, "Sneakers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
