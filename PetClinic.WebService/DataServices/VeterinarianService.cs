using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices
{
    public class VeterinarianService : IVeterinarianService
    {
        private readonly PetClinicDbContext _context;
        public VeterinarianService(PetClinicDbContext context)
        {
            _context = context;
        }

        public bool VeterinarianExists(int id)
        {
            return _context.Veterinarians.Count(e => e.VeterinarianId == id) > 0;
        }

        public async Task CreateVeterinarian(Veterinarian veterinarian)
        {
            _context.Veterinarians.Add(veterinarian);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Veterinarian> GetAllVeterinarians()
        {
            return _context.Veterinarians;
        }

        public async Task<Veterinarian> GetVeterinarianById(int id)
        {
            return await _context.Veterinarians.FindAsync(id);
        }

        public async Task UpdateVeterinarian(int id, Veterinarian veterinarian)
        {
            _context.Entry(veterinarian).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveVeterinarian(int id)
        {
            var veterinarian = await _context.Veterinarians.FindAsync(id);
            if (veterinarian != null) _context.Veterinarians.Remove(veterinarian);
            await _context.SaveChangesAsync();
        }

        public void Dispose(bool disposing)
        {
            if (disposing) _context.Dispose();
        }
    }
}