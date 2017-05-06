using System.ComponentModel.DataAnnotations;

namespace PetClinic.WebService.Models.Account
{
    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }
}