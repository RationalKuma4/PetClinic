using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using PetClinic.WebService.Models;
using PetClinic.WebService.Models.CustomUser;

namespace PetClinic.WebService.Filters
{
    public class IdentityBasicAuthenticationAttribute : BasicAuthenticationAttribute
    {
        protected override async Task<IPrincipal> AuthenticateAsync(string userName, string password, CancellationToken cancellationToken)
        {
            UserManager<OwnerUser, int> userManager = CreateUserManager();
            cancellationToken.ThrowIfCancellationRequested();
            OwnerUser user = await userManager.FindAsync(userName, password);

            if (user == null) return null;

            cancellationToken.ThrowIfCancellationRequested();
            ClaimsIdentity identity = await userManager.ClaimsIdentityFactory.CreateAsync(userManager, user, "Basic");
            return new ClaimsPrincipal(identity);
        }

        private UserManager<OwnerUser, int> CreateUserManager()
        {
            return new UserManager<OwnerUser, int>(new CustomUserStore(new PetClinicDbContext()));
        }
    }
}