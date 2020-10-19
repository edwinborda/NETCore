using MillionAndUp.Admin.Domain;
using System.Collections.Generic;

namespace MillionAndUp.Admin.API.Infraestructure
{
    public interface IEditorialService
    {
        IEnumerable<Editorial> GetEditorials();
        bool AddEditorial(string name, string campus);
    }
}
