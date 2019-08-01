using System;
using Microsoft.EntityFrameworkCore;
using Warehouse.Models;

namespace Warehouse.Extensions
{
    public static class Seeds
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Cities(modelBuilder);
            Employees(modelBuilder);
            Goods(modelBuilder);
            Positions(modelBuilder);
            Warehouses(modelBuilder);

        }

        public static void Cities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 7,
                    Name = "Velika Gorica",
                    Zip = "10410"
                }
            );
        }

        public static void Employees(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 4,
                    FirstName = "Antonio",
                    LastName = "Samardzic",
                    WarehouseId = 1
                }
            );
        }

        public static void Goods(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goods>().HasData(
                new Goods()
                {
                    Id = 7,
                    Name = "Cake",
                    ExpirationDate = DateTime.Parse("2020-02-03"),
                    DateOfManufacture =DateTime.Parse("2019-05-03"),
                    MinimalAmount = 1345,
                    CurrentAmount = 1554,
                    UnitOfMeasure = "pcs",
                    Price = 12.99m,
                    WarehouseId = 3
                }
            );
        }

        public static void Positions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position()
                {
                    Id = 7,
                    Name = "Cake",
                    GoodsId = 7,
                    Shelf = "D",
                    PositionOnShelf = "1"
                }
            );
        }

        public static void Warehouses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Warehouse>().HasData(
                new Models.Warehouse()
                {
                    Id = 4,
                   Name = "Test1",
                   Street = "Ilica 34",
                   CityId = 1
                }
            );
        }
    }
}