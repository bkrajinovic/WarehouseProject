using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(3324), new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(4338), new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(4348), new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(7915), new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(8661), new DateTime(2019, 8, 13, 10, 18, 58, 195, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 196, DateTimeKind.Utc).AddTicks(3530), new DateTime(2019, 8, 13, 10, 18, 58, 196, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 196, DateTimeKind.Utc).AddTicks(9350), new DateTime(2019, 8, 13, 10, 18, 58, 196, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(1995), new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(2681), new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(5470), new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(6193), new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(6203), new DateTime(2019, 8, 13, 10, 18, 58, 197, DateTimeKind.Utc).AddTicks(6203) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 562, DateTimeKind.Utc).AddTicks(6935), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 562, DateTimeKind.Utc).AddTicks(9004), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 562, DateTimeKind.Utc).AddTicks(9028), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 563, DateTimeKind.Utc).AddTicks(7542), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 563, DateTimeKind.Utc).AddTicks(9389), null });

            migrationBuilder.UpdateData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 565, DateTimeKind.Utc).AddTicks(1354), null });

            migrationBuilder.UpdateData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 566, DateTimeKind.Utc).AddTicks(4920), null });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 567, DateTimeKind.Utc).AddTicks(1601), null });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 567, DateTimeKind.Utc).AddTicks(3346), null });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 568, DateTimeKind.Utc).AddTicks(37), null });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 568, DateTimeKind.Utc).AddTicks(1801), null });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 13, 8, 16, 41, 568, DateTimeKind.Utc).AddTicks(1825), null });
        }
    }
}
