using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices
{
    public class PetService : IPetService
    {
        private readonly PetClinicDbContext _context;

        public PetService(PetClinicDbContext context)
        {
            _context = context;
        }

        public async Task CreatePet(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Pet> GetAllPets()
        {
            return _context.Pets;
        }

        public async Task<Pet> GetPetById(int id)
        {
            return await _context.Pets.FindAsync(id);
        }

        public async Task UpatePet(Pet pet)
        {
            _context.Entry(pet).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task RemovePet(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet != null) _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();
        }

        public bool PetExists(int id)
        {
            return _context.Pets.Count(e => e.PetId == id) > 0;
        }

        public void Dispose(bool disposing)
        {
            if (disposing) _context.Dispose();
        }
    }
}