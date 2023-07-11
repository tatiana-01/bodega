using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class BodegaContext : DbContext
{
    public BodegaContext(DbContextOptions<BodegaContext> options) : base(options)
    {

    }
    public DbSet<Bodega>? Bodegas { get; set; }
    public DbSet<Estado>? Estados { get; set; }
    public DbSet<InventoryMovement>? InventoryMovements { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<ProductUser> ProductUsers {get; set;}
    public DbSet<DetailsMovement> DetailsMovements {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductUser>().HasKey(p=> new {p.IdProduct, p.IdUser});
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
