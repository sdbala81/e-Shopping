using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eShopping.Inventory.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<byte>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Groceries", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f9f118b-8d41-4ee0-a294-5cbcfb6f61c1"), (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onion", 1.3899999999999999, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1eae3b54-8ed5-4b52-bd6a-f6f078d73ed7"), (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", 1.8899999999999999, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3fc6b8d7-5820-4e65-9c0f-2b7d0d3e6a35"), (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keyboard", 50.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4bd2e6d9-9c69-4c4a-b1c9-07bf4f335f52"), (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sugar", 2.9900000000000002, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e33d8df-793f-4f60-9d2d-8e0ac731fddc"), (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fish", 5.9900000000000002, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f2a37e4-40d9-4c82-89b1-68dc5e19a0c6"), (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop", 1000.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88a870e5-0b3e-4311-ae97-2091a5c34359"), (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salt", 1.99, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7892f96-297a-4a82-8c2e-1c78d21a5aeb"), (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse", 25.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc5e6e68-0ea5-4885-b86a-f1179c7cfd04"), (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potato", 1.29, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bff5b892-23e9-497d-b29a-85a3d4d228e6"), (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shrimp", 4.5599999999999996, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d06a9d0b-7fcd-4931-97d9-0c18ea0ef9bf"), (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rice", 10.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d25c7a45-83a3-4a23-9c4e-3b0be30b3ad7"), (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato", 1.99, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4d138a1-9f4c-42a3-86f7-6c5bb6e871f9"), (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desktop", 1500.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9a6aa9f-376a-4f0d-ae5d-0d5c1e31c4ed"), (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banana", 1.5800000000000001, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5628703-8f6f-4edf-9683-91ea9c44b5fc"), (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wheat", 5.6900000000000004, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fca2dbfc-7e5c-4d5f-9c2e-926c6c2de2bb"), (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orange", 2.5899999999999999, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductCategory");
        }
    }
}
