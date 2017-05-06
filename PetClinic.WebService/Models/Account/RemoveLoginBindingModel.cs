using System.ComponentModel.DataAnnotations;

namespace PetClinic.WebService.Models.Account
{
    public class RemoveLoginBindingModel
    {
        [Required]
        [Display(Name = "Proveedor de inicio de sesión")]
        public string LoginProvider { get; set; }

        [Required]
        [Display(Name = "Clave de proveedor")]
        public string ProviderKey { get; set; }
    }
}