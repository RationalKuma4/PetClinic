using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PetClinic.WebService.Models.Enums;

namespace PetClinic.WebService.Models
{
    public class Pet
    {
        public Pet()
        {
            Appointments = new HashSet<Appointment>();
        }

        [Key]
        public int PetId { get; set; }

        [Required]
        [DisplayName("Nombre")]
        [StringLength(20, ErrorMessage = "El maximo son 20 caracteres")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [DataType(DataType.Date, ErrorMessage = "No es una fecha")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Lugar de Nacimiento")]
        [DataType(DataType.Text)]
        public string PlaceOfBirth { get; set; }

        [DisplayName("Edad")]
        public int Age { get; set; }

        [Range(typeof(double), "1", "200", ErrorMessage = "Cantidad Incorrecta")]
        [DisplayName("Peso")]
        public decimal Weight { get; set; }

        [DisplayName("Altura")]
        [Range(typeof(double), "1", "200", ErrorMessage = "Cantidad Incorrecta")]
        public decimal Height { get; set; }

        [DisplayName("Sexo")]
        public char Sex { get; set; }

        [DisplayName("Raza")]
        [DataType(DataType.Text)]
        public string Breed { get; set; }

        [DisplayName("Color")]
        [DataType(DataType.Text)]
        public string Coulors { get; set; }

        [DisplayName("Tipo de Mascota")]
        public PetType PetType { get; set; }

        [DisplayName("Observaciones")]
        [DataType(DataType.Text)]
        public string Observations { get; set; }


        public int OwnerUserId { get; set; }
        public virtual OwnerUser OwnerUser { get; set; }
        public int AppointmentId { get; set; }
        public virtual IEnumerable<Appointment> Appointments { get; set; }

    }
}