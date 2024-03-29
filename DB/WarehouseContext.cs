using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Warehouse.Extensions;
using Warehouse.Models;

namespace Warehouse
{
    public class WarehouseContext : IdentityDbContext<AuthUser>
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        {
            //construtor
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Models.Warehouse> Warehouses { get; set; }


        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if (entry.Entity is BaseModel)
                {
                    var now = DateTime.UtcNow;
                    BaseModel entity = (BaseModel)entry.Entity;
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            entity.UpdatedAt = now;
                            break;
                        case EntityState.Added:
                            entity.CreatedAt = now;
                            break;
                    }
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

{

    var cascadeFKs = modelBuilder.Model.GetEntityTypes()
        .SelectMany(t => t.GetForeignKeys())
        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

    foreach (var fk in cascadeFKs)
        fk.DeleteBehavior = DeleteBehavior.Restrict;

    base.OnModelCreating(modelBuilder);
}
        }

        

    }
}