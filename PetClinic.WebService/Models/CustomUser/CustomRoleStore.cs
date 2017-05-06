using Microsoft.AspNet.Identity.EntityFramework;

namespace PetClinic.WebService.Models.CustomUser
{
    public class CustomRoleStore : RoleStore<CustomRole, int, CustomUserRole>
    {
        public CustomRoleStore(PetClinicDbContext context)
            : base(context) { }
    }
}