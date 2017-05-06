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
    }
}