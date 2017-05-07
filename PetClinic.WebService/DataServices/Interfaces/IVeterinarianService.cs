using System.Collections.Generic;
using System.Threading.Tasks;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices.Interfaces
{
    public interface IVeterinarianService
    {
        Task CreateVeterinarian(Veterinarian veterinarian);
        IEnumerable<Veterinarian> GetAllVeterinarians();
        Task<Veterinarian> GetVeterinarianById(int id);
        Task UpdateVeterinarian(int id, Veterinarian veterinarian);
        Task RemoveVeterinarian(int id);
        bool VeterinarianExists(int id);
        void Dispose(bool disposing);
    }
}