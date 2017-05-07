using System.Collections.Generic;
using System.Threading.Tasks;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices.Interfaces
{
    public interface IVeterinarianService
    {
        void CreateVeterinarian(Veterinarian veterinarian);
        IEnumerable<Veterinarian> GetAllVeterinarians();
        Task<Veterinarian> GetVeterinarianById(int id);
        void UpdateVeterinarian(int id);
        void RemoveVeterinarian(int id);
    }
}