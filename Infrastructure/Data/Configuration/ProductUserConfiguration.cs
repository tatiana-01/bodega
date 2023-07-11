using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductUserConfiguration : IEntityTypeConfiguration<ProductUser>
{
    public void Configure(EntityTypeBuilder<ProductUser> builder)
    {
        builder.ToTable("ProductoUsuario");

        builder.HasOne(p=>p.Users)
        .WithMany(p=>p.ProductsUsers)
        .HasForeignKey(p=>p.IdUser);

        builder.HasOne(p=>p.Products)
        .WithMany(p=>p.ProductsUsers)
        .HasForeignKey(p=>p.IdProduct);

    }
}
