using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetClinic.WebService.Models
{
    public class Veterinarian
    {
        [Key]
        public int VeterinarianId { get; set; }

        [Required]
        [DisplayName("Nombre")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DisplayName("Apellido")]
        [DataType(DataType.Text)]
        public string Lastname { get; set; }

        [DisplayName("Nombre Clinica")]
        [DataType(DataType.Text)]
        public string ClinicName { get; set; }

        [DisplayName("Direccion clinica")]
        [DataType(DataType.Text)]
        public string ClinicAddress { get; set; }

        [DisplayName("Horas de servicio")]
        [DataType(DataType.Text)]
        public string ServiceHours { get; set; }

        [DisplayName("Telefono clinica")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [DisplayName("Correo electronico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Observaciones")]
        [DataType(DataType.Text)]
        public string Observations { get; set; }

        public int OwnerUserId { get; set; }
        public virtual OwnerUser OwnerUser { get; set; }
    }
}