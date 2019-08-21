using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Shelf = table.Column<string>(nullable: false),
                    PositionOnShelf = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Street = table.Column<string>(maxLength: 20, nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    WarehouseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: true),
                    DateOfManufacture = table.Column<DateTime>(nullable: true),
                    MinimalAmount = table.Column<int>(nullable: false),
                    CurrentAmount = table.Column<int>(nullable: false),
                    UnitOfMeasure = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    WarehouseId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt", "Zip" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 13, 8, 16, 41, 562, DateTimeKind.Utc).AddTicks(6935), "Velika Gorica", null, "10410" },
                    { 2, new DateTime(2019, 8, 13, 8, 16, 41, 562, DateTimeKind.Utc).AddTicks(9004), "Zagreb", null, "10000" },
                    { 3, new DateTime(2019, 8, 13, 8, 16, 41, 562, DateTimeKind.Utc).AddTicks(9028), "Split", null, "21000" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CreatedAt", "Name", "PositionOnShelf", "Shelf", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 13, 8, 16, 41, 567, DateTimeKind.Utc).AddTicks(1601), "Cake", "1", "D", null },
                    { 2, new DateTime(2019, 8, 13, 8, 16, 41, 567, DateTimeKind.Utc).AddTicks(3346), "Milk", "1", "A", null }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "CityId", "CreatedAt", "Name", "Street", "UpdatedAt" },
                values: new object[] { 1, 1, new DateTime(2019, 8, 13, 8, 16, 41, 568, DateTimeKind.Utc).AddTicks(37), "Dukat", "Ilica 34", null });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "CityId", "CreatedAt", "Name", "Street", "UpdatedAt" },
                values: new object[] { 2, 2, new DateTime(2019, 8, 13, 8, 16, 41, 568, DateTimeKind.Utc).AddTicks(1801), "Podravka", "Kurilovecka 5", null });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "CityId", "CreatedAt", "Name", "Street", "UpdatedAt" },
                values: new object[] { 3, 3, new DateTime(2019, 8, 13, 8, 16, 41, 568, DateTimeKind.Utc).AddTicks(1825), "Kras", "Splitska 23", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "UpdatedAt", "WarehouseId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 13, 8, 16, 41, 563, DateTimeKind.Utc).AddTicks(7542), "Antonio", "Samardzic", null, 1 },
                    { 2, new DateTime(2019, 8, 13, 8, 16, 41, 563, DateTimeKind.Utc).AddTicks(9389), "Bruno", "Krajinovic", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "CreatedAt", "CurrentAmount", "DateOfManufacture", "ExpirationDate", "MinimalAmount", "Name", "PositionId", "Price", "UnitOfMeasure", "UpdatedAt", "WarehouseId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 13, 8, 16, 41, 565, DateTimeKind.Utc).AddTicks(1354), 1554, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1345, "Cake", null, 12.99m, "pcs", null, 1 },
                    { 2, new DateTime(2019, 8, 13, 8, 16, 41, 566, DateTimeKind.Utc).AddTicks(4920), 1554, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1345, "Milk", null, 4.99m, "l", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WarehouseId",
                table: "Employees",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_PositionId",
                table: "Goods",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_WarehouseId",
                table: "Goods",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_CityId",
                table: "Warehouses",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
