using MillionAndUp.Admin.Domain;
using System.Collections.Generic;

namespace MillionAndUp.Admin.Infraestructure.Interfaces
{
    public interface IBookRepository: IRepository<Book>
    {
        IEnumerable<Book> GetRepositoryWithNestedEntity();
    }
}
