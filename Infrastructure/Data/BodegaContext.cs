using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

    public class BodegaContext : DbContext
    {
        public BodegaContext(DbContextOptions<BodegaContext> options) : base(options)
        {

        }
        public DbSet<Bodega> ? Bodega {get; set;}
        public DbSet<Estado> ? Estado {get; set;}
        public DbSet<InventoryMovement> ? InventoryMovement {get; set;}
        public DbSet<Product> ? Product {get; set;}
        public DbSet<User> ? User {get; set;}
    }
