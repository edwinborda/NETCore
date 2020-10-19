﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MillionAndUp.Admin.Domain;

namespace MillionAndUp.Admin.Infraestructure.Configuration
{
    public class AuthorHasBookConfiguration: IEntityTypeConfiguration<AuthorHasBook>
    {
        public void Configure(EntityTypeBuilder<AuthorHasBook> builder)
        {
            builder.HasKey(it => new { it.AuthorId, it.BookISBN});

            builder.HasOne(b => b.Book)
                .WithMany(c => c.AuthorsHasBooks)
                .HasForeignKey(f => f.BookISBN);

            builder.HasOne(b => b.Author)
                .WithMany(c => c.AuthorsHasBooks)
                .HasForeignKey(f => f.AuthorId);
        }
        
    }
}
