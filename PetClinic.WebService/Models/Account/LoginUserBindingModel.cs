using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetClinic.WebService.Models.Account
{
    public class LoginUserBindingModel
    {
        [Required]
        [DisplayName("Usuario")]
        public string User { get; set; }
        [Required]
        [DisplayName("Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}