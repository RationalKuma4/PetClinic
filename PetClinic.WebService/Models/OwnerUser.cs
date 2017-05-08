using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PetClinic.WebService.Models.CustomUser;

namespace PetClinic.WebService.Models
{
    public class OwnerUser : IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public OwnerUser()
        {
            Pets = new HashSet<Pet>();
        }

        [DisplayName("Direccion")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        
        public ICollection<Pet> Pets { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<OwnerUser, int> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}