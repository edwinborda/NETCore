using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MillionAndUp.Admin.Domain;

namespace MillionAndUp.Admin.Infraestructure.Configuration
{
    public class EditorialConfiguration : IEntityTypeConfiguration<Editorial>
    {
        public void Configure(EntityTypeBuilder<Editorial> builder)
        {
            builder.HasKey(it => it.Id);
            builder.Property(it => it.Id)
                .HasMaxLength(10);
            builder.Property(it => it.Name)
                .IsRequired()
                .HasMaxLength(45);
            builder.Property(it => it.Campus)
                .IsRequired()
                .HasMaxLength(45);
        }
    }
}
