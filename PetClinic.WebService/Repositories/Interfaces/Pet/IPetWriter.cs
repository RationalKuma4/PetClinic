using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetClinic.WebService.Repositories.Interfaces.Pet
{
    public interface IPetWriter
    {
        Task RegisterPet(Models.Pet pet);
        Task UpatePet(int id, Models.Pet pet);
        Task RemovePet(int id);
    }
}