using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices
{
    public class PetService : IPetService
    {
        public async Task CreatePet(Pet pet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet> GetAllPets()
        {
            throw new NotImplementedException();
        }

        public async Task<Pet> GetPetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpatePet(Pet pet)
        {
            throw new NotImplementedException();
        }

        public async Task RemovePet(int id)
        {
            throw new NotImplementedException();
        }

        public bool PetExists(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}