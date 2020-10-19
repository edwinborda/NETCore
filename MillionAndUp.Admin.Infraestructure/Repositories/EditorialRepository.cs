using MillionAndUp.Admin.Domain;
using MillionAndUp.Admin.Infraestructure.Interfaces;

namespace MillionAndUp.Admin.Infraestructure.Repositories
{
    public class EditorialRepository: Repository<Editorial>, IEditorialRepository
    {
        public EditorialRepository(Context context)
            : base(context)
        {

        }
    }
}
