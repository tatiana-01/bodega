using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Usuario");

        builder.Property(p=>p.Id)
        .IsRequired();

        builder.Property(p=>p.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p=>p.Email)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p=>p.UpdateDate)
        .IsRequired();

        builder.Property(p=>p.Photo)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p=>p.Password)
        .IsRequired()
        .HasMaxLength(100);
    }
}
