using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetClinic.WebService.Repositories.Interfaces.Pet
{
    public interface IPetReader
    {
        IEnumerable<Models.Pet> GetPetsByOwnerId(int ownerId);
        Task<Models.Pet> GetPetByOwnerId(int ownerId, int petId);
    }
}