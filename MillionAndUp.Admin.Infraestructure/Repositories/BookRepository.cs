using System.Linq;
using Microsoft.EntityFrameworkCore;
using MillionAndUp.Admin.Domain;
using MillionAndUp.Admin.Infraestructure.Interfaces;
using System.Collections.Generic;

namespace MillionAndUp.Admin.Infraestructure.Repositories
{
    public class BookRepository: Repository<Book>, IBookRepository
    {
        private readonly Context context;

        public BookRepository(Context context)
            :base(context)
        {
            this.context = context;
        }

        public IEnumerable<Book> GetRepositoryWithNestedEntity()
        {
            return context.Books.Include(it => it.Editorial)
                                .Include(it => it.AuthorsHasBooks)
                                    .ThenInclude(it => it.Author) //roslyn tiene un problema
                                .ToList();
        }
    }
}
