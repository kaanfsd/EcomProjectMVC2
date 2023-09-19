using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomProjectMVC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyForCategoryProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 500.0, 450.0, 400.0, 430.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 1100.0, 1000.0, 900.0, 950.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 800.0, 700.0, 600.0, 650.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 200.0, 180.0, 160.0, 170.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 300.0, 250.0, 230.0, 240.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 130.0, 110.0, 90.0, 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 80.0, 70.0, 60.0, 65.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 60.0, 50.0, 45.0, 48.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 400.0, 350.0, 300.0, 330.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 13, 130.0, 120.0, 100.0, 110.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 499.99000000000001, 449.99000000000001, 399.99000000000001, 429.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 1099.99, 999.99000000000001, 899.99000000000001, 949.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 799.99000000000001, 699.99000000000001, 599.99000000000001, 649.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 199.99000000000001, 179.99000000000001, 159.99000000000001, 169.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 299.99000000000001, 249.99000000000001, 229.99000000000001, 239.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 129.99000000000001, 109.98999999999999, 89.989999999999995, 99.989999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 79.989999999999995, 69.989999999999995, 59.990000000000002, 64.989999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 59.990000000000002, 49.990000000000002, 44.990000000000002, 47.990000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 399.99000000000001, 349.99000000000001, 299.99000000000001, 329.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50" },
                values: new object[] { 129.99000000000001, 119.98999999999999, 99.989999999999995, 109.98999999999999 });
        }
    }
}
