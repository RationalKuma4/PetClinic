using System.Collections.Generic;

namespace PetClinic.WebService.Repositories.Interfaces.Veterinarian
{
    public interface IVeterinarianReader
    {
        IEnumerable<Models.Veterinarian> GetAllVeterinarians();
        Models.Veterinarian GetVeterinarian(int id);
    }
}