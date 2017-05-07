using System.Collections.Generic;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;
using PetClinic.WebService.Repositories.Interfaces.Base;
using PetClinic.WebService.Repositories.Interfaces.Veterinarian;

namespace PetClinic.WebService.Repositories
{
    public class RepositoryVeterinarian : IVeterinarianReader, IVeterinarianWriter, IDisposeDataBase
    {
        private readonly IVeterinarianService _service;
        public RepositoryVeterinarian(IVeterinarianService service)
        {
            _service = service;
        }

        public IEnumerable<Veterinarian> GetAllVeterinarians()
        {
            return _service.GetAllVeterinarians();
        }

        public async Task<Veterinarian> GetVeterinarian(int id)
        {
            return await _service.GetVeterinarianById(id);
        }

        public bool VeterinarianExists(int id)
        {
            return _service.VeterinarianExists(id);
        }

        public async Task RegisterVeterinarian(Veterinarian veterinarian)
        {
            await _service.CreateVeterinarian(veterinarian);
        }

        public async Task UpdateVeterinarian(int id, Veterinarian veterinarian)
        {
            await _service.UpdateVeterinarian(id, veterinarian);
        }

        public async Task RemoveVeterinarian(int id)
        {
            await _service.RemoveVeterinarian(id);
        }

        public void DisposeDataBase(bool disposing)
        {
            _service.Dispose(disposing);
        }
    }
}