using MillionAndUp.Admin.Domain;
using MillionAndUp.Admin.Infraestructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MillionAndUp.Admin.API.Infraestructure
{
    public class BookService : IBookService
    {
        #region Fields

        private readonly IUnitOfWork unitOfWork;

        #endregion

        #region Constructors

        public BookService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        public bool AddBook(int isbn, string title, string sypnosis, string numberOfPages, Editorial editorial, params Author[] authors)
        {
            unitOfWork.BookRepository.Add(new Book(title, sypnosis, numberOfPages, editorial, isbn, authors));

            return unitOfWork.SaveChanges();
        }

        public IEnumerable<Book> GetBooks()
        {
            return unitOfWork.BookRepository.GetRepositoryWithNestedEntity();
        }

        #endregion
    }
}
