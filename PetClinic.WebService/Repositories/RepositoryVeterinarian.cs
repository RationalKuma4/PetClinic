using System;
using System.Collections.Generic;
using PetClinic.WebService.Models;
using PetClinic.WebService.Repositories.Interfaces.Veterinarian;

namespace PetClinic.WebService.Repositories
{
    public class RepositoryVeterinarian : IVeterinarianReader, IVeterinarianWriter
    {
        public RepositoryVeterinarian()
        {

        }
        public IEnumerable<Veterinarian> GetAllVeterinarians()
        {
            throw new NotImplementedException();
        }

        public Veterinarian GetVeterinarian(int id)
        {
            throw new NotImplementedException();
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