using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;
using PetClinic.WebService.Repositories.Interfaces.Veterinarian;

namespace PetClinic.WebService.Repositories
{
    public class RepositoryVeterinarian : IVeterinarianReader, IVeterinarianWriter
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

        public Task<Veterinarian> GetVeterinarian(int id)
        {
            return _service.GetVeterinarianById(id);
        }

        public void RegisterVeterinarian(Veterinarian veterinarian)
        {
            throw new NotImplementedException();
        }

        public void UpdateVeterinarian(Veterinarian veterinarian)
        {
            throw new NotImplementedException();
        }
    }
}