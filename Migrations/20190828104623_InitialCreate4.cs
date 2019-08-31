using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 185, DateTimeKind.Utc).AddTicks(5161), new DateTime(2019, 8, 28, 10, 46, 23, 185, DateTimeKind.Utc).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 185, DateTimeKind.Utc).AddTicks(6030), new DateTime(2019, 8, 28, 10, 46, 23, 185, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 185, DateTimeKind.Utc).AddTicks(6040), new DateTime(2019, 8, 28, 10, 46, 23, 185, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 185, DateTimeKind.Utc).AddTicks(9659), new DateTime(2019, 8, 28, 10, 46, 23, 185, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 186, DateTimeKind.Utc).AddTicks(466), new DateTime(2019, 8, 28, 10, 46, 23, 186, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 186, DateTimeKind.Utc).AddTicks(5354), new DateTime(2019, 8, 28, 10, 46, 23, 186, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(1235), new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(3885), new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(4575), new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(7525), new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(8269), new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(8279), new DateTime(2019, 8, 28, 10, 46, 23, 187, DateTimeKind.Utc).AddTicks(8280) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 902, DateTimeKind.Utc).AddTicks(695), new DateTime(2019, 8, 26, 9, 58, 40, 902, DateTimeKind.Utc).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 902, DateTimeKind.Utc).AddTicks(3955), new DateTime(2019, 8, 26, 9, 58, 40, 902, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 902, DateTimeKind.Utc).AddTicks(3989), new DateTime(2019, 8, 26, 9, 58, 40, 902, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 903, DateTimeKind.Utc).AddTicks(6484), new DateTime(2019, 8, 26, 9, 58, 40, 903, DateTimeKind.Utc).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 903, DateTimeKind.Utc).AddTicks(9177), new DateTime(2019, 8, 26, 9, 58, 40, 903, DateTimeKind.Utc).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 905, DateTimeKind.Utc).AddTicks(5346), new DateTime(2019, 8, 26, 9, 58, 40, 905, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 911, DateTimeKind.Utc).AddTicks(4102), new DateTime(2019, 8, 26, 9, 58, 40, 911, DateTimeKind.Utc).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 912, DateTimeKind.Utc).AddTicks(5005), new DateTime(2019, 8, 26, 9, 58, 40, 912, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 912, DateTimeKind.Utc).AddTicks(7490), new DateTime(2019, 8, 26, 9, 58, 40, 912, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 913, DateTimeKind.Utc).AddTicks(7502), new DateTime(2019, 8, 26, 9, 58, 40, 913, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 914, DateTimeKind.Utc).AddTicks(285), new DateTime(2019, 8, 26, 9, 58, 40, 914, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 26, 9, 58, 40, 914, DateTimeKind.Utc).AddTicks(321), new DateTime(2019, 8, 26, 9, 58, 40, 914, DateTimeKind.Utc).AddTicks(322) });
        }
    }
}
