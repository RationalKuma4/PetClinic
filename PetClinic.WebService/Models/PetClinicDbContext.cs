using Microsoft.AspNet.Identity.EntityFramework;

namespace PetClinic.WebService.Models
{
    public class PetClinicDbContext : IdentityDbContext<OwnerUser>
    {
        public PetClinicDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static PetClinicDbContext Create()
        {
            return new PetClinicDbContext();
        }
    }
}