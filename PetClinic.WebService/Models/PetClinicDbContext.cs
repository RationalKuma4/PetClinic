using Microsoft.AspNet.Identity.EntityFramework;
using PetClinic.WebService.Models.CustomUser;

namespace PetClinic.WebService.Models
{
    public class PetClinicDbContext : IdentityDbContext<OwnerUser, CustomRole,
        int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public PetClinicDbContext()
            : base("DefaultConnection") { }

        public static PetClinicDbContext Create()
        {
            return new PetClinicDbContext();
        }

        public System.Data.Entity.DbSet<PetClinic.WebService.Models.Veterinarian> Veterinarians { get; set; }

        public System.Data.Entity.DbSet<PetClinic.WebService.Models.OwnerUser> OwnerUsers { get; set; }

        public System.Data.Entity.DbSet<PetClinic.WebService.Models.Pet> Pets { get; set; }

        public System.Data.Entity.DbSet<PetClinic.WebService.Models.Appointment> Appointments { get; set; }
    }
}