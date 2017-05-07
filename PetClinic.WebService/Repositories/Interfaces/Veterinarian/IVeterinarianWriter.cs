using System.Threading.Tasks;

namespace PetClinic.WebService.Repositories.Interfaces.Veterinarian
{
    public interface IVeterinarianWriter
    {
        Task RegisterVeterinarian(Models.Veterinarian veterinarian);
        Task UpdateVeterinarian(int id, Models.Veterinarian veterinarian);
        Task RemoveVeterinarian(int id);
    }
}