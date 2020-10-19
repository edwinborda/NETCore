using MillionAndUp.Admin.Domain;
using MillionAndUp.Admin.Infraestructure.Interfaces;

namespace MillionAndUp.Admin.Infraestructure.Repositories
{
    public class AuthorRepository: Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(Context context)
            :base(context)
        {

        }
    }
}
