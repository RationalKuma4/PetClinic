using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;
using PetClinic.WebService.Repositories.Interfaces.Base;
using PetClinic.WebService.Repositories.Interfaces.Pet;

namespace PetClinic.WebService.Repositories
{
    public class RepositoryPet : IPetReader, IPetWriter, IDisposeDataBase
    {
        private readonly IPetService _service;

        public RepositoryPet(IPetService service)
        {
            _service = service;
        }

        public IEnumerable<Pet> GetPetsByOwnerId(int ownerId)
        {
            return _service.GetAllPets()
                .Where(p => p.OwnerUserId == ownerId);
        }

        public async Task<Pet> GetPetByOwnerId(int ownerId, int petId)
        {
            return await _service.GetPetById(petId);
        }

        public async Task RegisterPet(Pet pet)
        {
            await _service.CreatePet(pet);
        }

        public async Task UpatePet(int id, Pet pet)
        {
            await _service.UpatePet(pet);
        }

        public async Task RemovePet(int id)
        {
            await _service.RemovePet(id);
        }

        public void DisposeDataBase(bool disposing)
        {
            _service.Dispose(disposing);
        }
    }
}