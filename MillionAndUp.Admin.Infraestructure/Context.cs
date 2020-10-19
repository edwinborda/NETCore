using Microsoft.EntityFrameworkCore;
using MillionAndUp.Admin.Domain;
using MillionAndUp.Admin.Infraestructure.Configuration;

namespace MillionAndUp.Admin.Infraestructure
{
    public class Context: DbContext
    {
        public Context(DbContextOptions dbContextOptions)
            :base(dbContextOptions)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Editorial> Editorials { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new AuthorHasBookConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new EditorialConfiguration());
        }

    }
}
