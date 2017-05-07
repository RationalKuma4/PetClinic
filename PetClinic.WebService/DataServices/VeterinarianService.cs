using System;
using System.Collections.Generic;
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
        public void CreateVeterinarian(Veterinarian veterinarian)
        {
            _context.Veterinarians.Add(veterinarian);
            _context.SaveChangesAsync();
        }

        public IEnumerable<Veterinarian> GetAllVeterinarians()
        {
            return _context.Veterinarians;
        }

        public Task<Veterinarian> GetVeterinarianById(int id)
        {
            return _context.Veterinarians
                .FindAsync(id);
        }

        public void UpdateVeterinarian(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveVeterinarian(int id)
        {
            throw new NotImplementedException();
        }

        private bool VeterinarianExists(int id)
        {
            return _context.Veterinarians.Count(e => e.VeterinarianId == id) > 0;
        }
    }
}