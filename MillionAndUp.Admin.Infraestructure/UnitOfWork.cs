using MillionAndUp.Admin.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillionAndUp.Admin.Infraestructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context context;

        public UnitOfWork(IEditorialRepository editorialRepository,
                          IBookRepository bookRepository,
                          IAuthorRepository authorRepository,
                          Context context)
        {
            EditorialRepository = editorialRepository;
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
            this.context = context;
        }

        public IEditorialRepository EditorialRepository { get; }

        public IBookRepository BookRepository { get; }

        public IAuthorRepository AuthorRepository { get; }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }
    }
}
