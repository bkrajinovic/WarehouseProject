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
                    Id = 1,
                    Name = "Velika Gorica",
                    Zip = "10410"
                },
                new City()
                {
                    Id = 2,
                    Name = "Zagreb",
                    Zip = "10000"
                },
                new City()
                {
                    Id = 3,
                    Name = "Split",
                    Zip = "21000"
                }
            );
        }

        public static void Employees(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 1,
                    FirstName = "Antonio",
                    LastName = "Samardzic",
                    WarehouseId = 1
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Bruno",
                    LastName = "Krajinovic",
                    WarehouseId = 2
                }
            );
        }

        public static void Goods(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goods>().HasData(
                new Goods()
                {
                    Id = 1,
                    Name = "Cake",
                    ExpirationDate = DateTime.Parse("2020-02-03"),
                    DateOfManufacture =DateTime.Parse("2019-05-03"),
                    MinimalAmount = 1345,
                    CurrentAmount = 1554,
                    UnitOfMeasure = "pcs",
                    Price = 12.99m,
                    WarehouseId = 1
                },
                 new Goods()
                {
                    Id = 2,
                    Name = "Milk",
                    ExpirationDate = DateTime.Parse("2020-02-03"),
                    DateOfManufacture =DateTime.Parse("2019-05-03"),
                    MinimalAmount = 1345,
                    CurrentAmount = 1554,
                    UnitOfMeasure = "l",
                    Price = 4.99m,
                    WarehouseId = 2
                }
            );
        }

        public static void Positions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position()
                {
                    Id = 1,
                    Name = "Cake",
                    Shelf = "D",
                    PositionOnShelf = "1"
                },
                 new Position()
                {
                    Id = 2,
                    Name = "Milk",
                    Shelf = "A",
                    PositionOnShelf = "1"
                }
            );
        }

        public static void Warehouses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Warehouse>().HasData(
                new Models.Warehouse()
                {
                    Id = 1,
                   Name = "Dukat",
                   Street = "Ilica 34",
                   CityId = 1
                },
                new Models.Warehouse()
                {
                    Id = 2,
                   Name = "Podravka",
                   Street = "Kurilovecka 5",
                   CityId = 2
                },
                new Models.Warehouse()
                {
                    Id = 3,
                   Name = "Kras",
                   Street = "Splitska 23",
                   CityId = 3
                }
            );
        }
    }
}