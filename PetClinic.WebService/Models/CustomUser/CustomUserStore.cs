using Microsoft.AspNet.Identity.EntityFramework;

namespace PetClinic.WebService.Models.CustomUser
{
    public class CustomUserStore : UserStore<OwnerUser, CustomRole, int,
        CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public CustomUserStore(PetClinicDbContext context)
            : base(context) { }
    }
}