using MillionAndUp.Admin.Domain;
using System.Collections.Generic;

namespace MillionAndUp.Admin.API.Infraestructure
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        bool AddBook(int isbn, string title, string sypnosis, string numberOfPages, Editorial editorial, params Author[] authors);
    }
}
