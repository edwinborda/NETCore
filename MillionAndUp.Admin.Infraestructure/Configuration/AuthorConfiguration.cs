﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MillionAndUp.Admin.Domain;

namespace MillionAndUp.Admin.Infraestructure.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(it => it.Id);
            builder.Property(it => it.Id)
                .HasMaxLength(10);
            builder.Property(it => it.Name)
                .IsRequired()
                .HasMaxLength(45);
            builder.Property(it => it.LastName)
                .IsRequired()
                .HasMaxLength(45);

          
        }
    }
}
