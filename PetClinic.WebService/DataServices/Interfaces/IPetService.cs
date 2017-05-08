using System.Collections.Generic;
using System.Threading.Tasks;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices.Interfaces
{
    public interface IPetService
    {
        Task CreatePet(Pet pet);
        IEnumerable<Pet> GetAllPets();
        Task<Pet> GetPetById(int id);
        Task UpatePet(Pet pet);
        Task RemovePet(int id);
        bool PetExists(int id);
        void Dispose(bool disposing);
    }
}