using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MillionAndUp.Admin.Domain
{
    public class Author
    {
        protected Author()
        {

        }

        public Author(string name, string lastname, int? id = null)
        {
            Name = name;
            LastName = lastname;
            Id = id ?? 0;
        }

        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; set; }
        public virtual ICollection<AuthorHasBook> AuthorsHasBooks { get; private set; }
    }
}
