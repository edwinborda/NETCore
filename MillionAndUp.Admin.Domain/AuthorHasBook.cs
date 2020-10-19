using Newtonsoft.Json;

namespace MillionAndUp.Admin.Domain
{
    public class AuthorHasBook
    {
        protected AuthorHasBook()
        {

        }

        public AuthorHasBook(Author author, int ISBN)
        {
            if(author.Id > 0)
                AuthorId = author.Id;
            else
                Author = author;
            
            BookISBN = ISBN;
        }

        public int AuthorId { get; private set; }
        public int BookISBN { get; private set; }
        public virtual Author Author { get; private set; }
        public virtual Book Book{ get; private set; }
    }
}
