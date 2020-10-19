using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MillionAndUp.Admin.Domain;


namespace MillionAndUp.Admin.Infraestructure.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(it => it.ISBN)
                .HasMaxLength(13);
            builder.HasKey(it => it.ISBN);
            builder.Property(it => it.EditorialId)
                .IsRequired()
                .HasMaxLength(13);
            builder.Property(it => it.Title)
                .IsRequired()
                .HasMaxLength(45);
            builder.Property(it => it.Sypnosis)
                .IsRequired()
                .HasMaxLength(4000);
            builder.Property(it => it.NumberPages)
                .IsRequired()
                .HasMaxLength(45);

        }
    }
}
