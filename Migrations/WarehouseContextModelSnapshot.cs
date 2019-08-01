﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse;

namespace Warehouse.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    partial class WarehouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Warehouse.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Velika Gorica",
                            Zip = "10410"
                        });
                });

            modelBuilder.Entity("Warehouse.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("WarehouseId");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Antonio",
                            LastName = "Samardzic",
                            WarehouseId = 1
                        });
                });

            modelBuilder.Entity("Warehouse.Models.Goods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CurrentAmount");

                    b.Property<DateTime?>("DateOfManufacture");

                    b.Property<DateTime?>("ExpirationDate");

                    b.Property<int>("MinimalAmount");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int?>("WarehouseId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Goods");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentAmount = 1554,
                            DateOfManufacture = new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpirationDate = new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MinimalAmount = 1345,
                            Name = "Cake",
                            Price = 12.99m,
                            UnitOfMeasure = "pcs",
                            WarehouseId = 3
                        });
                });

            modelBuilder.Entity("Warehouse.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("GoodsId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PositionOnShelf");

                    b.Property<string>("Shelf");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GoodsId = 7,
                            Name = "Cake",
                            PositionOnShelf = "1",
                            Shelf = "D"
                        });
                });

            modelBuilder.Entity("Warehouse.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            CityId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kraš",
                            Street = "Ilica 34"
                        });
                });

            modelBuilder.Entity("Warehouse.Models.Employee", b =>
                {
                    b.HasOne("Warehouse.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Warehouse.Models.Goods", b =>
                {
                    b.HasOne("Warehouse.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Warehouse.Models.Warehouse", b =>
                {
                    b.HasOne("Warehouse.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
