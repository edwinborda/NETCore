using MillionAndUp.Admin.Domain;
using System.Collections.Generic;

namespace MillionAndUp.Admin.API.Infraestructure
{
    public interface IAuthorService
    {
        IEnumerable<Author> getAuthors();
    }
}
