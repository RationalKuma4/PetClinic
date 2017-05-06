using System.ComponentModel.DataAnnotations;

namespace PetClinic.WebService.Models.Account
{
    public class AddExternalLoginBindingModel
    {
        [Required]
        [Display(Name = "Token de acceso externo")]
        public string ExternalAccessToken { get; set; }
    }
}