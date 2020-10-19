using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MillionAndUp.Admin.Domain
{
    public class Book
    {
        protected Book()
        {

        }

        public Book(string title, string sypnosis, string numberPages, Editorial editorial, int? isbn = null, params Author[] authors)
        {
            Title = title;
            Sypnosis = sypnosis;
            NumberPages = numberPages;
            AddAuthors(authors);
            AddEditorial(editorial);
            ISBN = isbn ?? 0;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ISBN { get; private set; }
        public int EditorialId { get; private set; }
        public string Title { get; private set; }
        public string Sypnosis { get; private set; }
        public string NumberPages { get; private set; }

        public virtual ICollection<AuthorHasBook> AuthorsHasBooks { get; private set; }
        public virtual Editorial Editorial { get; private set; }

        public void AddAuthors(params Author[] authors)
        {
            var authorsForBooks = new List<AuthorHasBook>();
            authors.Aggregate(authorsForBooks, (current, author) =>
            {
                current.Add(new AuthorHasBook(author, this.ISBN));

                return authorsForBooks;
            });

            AuthorsHasBooks = authorsForBooks;

        }

        public void AddEditorial(Editorial editorial)
        {
            if (editorial.Id == 0)
                Editorial = editorial;
            else
                EditorialId = editorial.Id;

        }

        public void AddEditorialById(int editorialId)
        {
            EditorialId = editorialId;
        }
    }
}
