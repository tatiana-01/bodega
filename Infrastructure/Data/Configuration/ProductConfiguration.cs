using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Producto");

        builder.Property(p=>p.Id)
        .IsRequired();

        builder.Property(p=>p.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p=>p.Description)
        .IsRequired()
        .HasMaxLength(250);

        builder.Property(p=>p.Quantity)
        .IsRequired();

        builder.Property(p=>p.CreatedAt)
        .IsRequired();

        builder.Property(p=>p.UpdatedAt)
        .IsRequired();

        builder.Property(p=>p.Price)
        .IsRequired();

        builder.HasOne(p=>p.Estado)
        .WithMany(p=>p.Products)
        .HasForeignKey(p=>p.EstadoId);
    }
}
