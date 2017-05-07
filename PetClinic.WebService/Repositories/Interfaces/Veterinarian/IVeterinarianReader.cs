using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetClinic.WebService.Repositories.Interfaces.Veterinarian
{
    public interface IVeterinarianReader
    {
        IEnumerable<Models.Veterinarian> GetAllVeterinarians();
        Task<Models.Veterinarian> GetVeterinarian(int id);
    }
}