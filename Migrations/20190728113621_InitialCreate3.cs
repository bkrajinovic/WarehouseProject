using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt", "Zip" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velika Gorica", null, "10410" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "UpdatedAt", "WarehouseId" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonio", "Samardzic", null, 1 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "CreatedAt", "CurrentAmount", "DateOfManufacture", "ExpirationDate", "MinimalAmount", "Name", "Price", "UnitOfMeasure", "UpdatedAt", "WarehouseId" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1554, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1345, "Cake", 12.99m, "pcs", null, 3 });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CreatedAt", "GoodsId", "Name", "PositionOnShelf", "Shelf", "UpdatedAt" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Cake", "1", "D", null });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "CityId", "CreatedAt", "Name", "Street", "UpdatedAt" },
                values: new object[] { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kraš", "Ilica 34", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
