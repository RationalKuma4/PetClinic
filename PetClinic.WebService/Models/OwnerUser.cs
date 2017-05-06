using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PetClinic.WebService.Models
{
    public class OwnerUser : IdentityUser
    {
        public OwnerUser()
        {
            Pets = new HashSet<Pet>();
        }

        [DisplayName("Direccion")]
        [DataType(DataType.Text)]
        public string Address { get; set; }


        public int VeterinarianId { get; set; }
        public virtual Veterinarian Veterinarian { get; set; }
        public int PetId { get; set; }
        public ICollection<Pet> Pets { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<OwnerUser> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }
    }
}