namespace PetClinic.WebService.Repositories.Interfaces.Veterinarian
{
    public interface IVeterinarianWriter
    {
        void RegisterVeterinarian(Models.Veterinarian veterinarian);
        void UpdateVeterinarian(Models.Veterinarian veterinarian);
    }
}