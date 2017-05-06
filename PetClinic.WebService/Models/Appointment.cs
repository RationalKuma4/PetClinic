using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PetClinic.WebService.Models.Enums;

namespace PetClinic.WebService.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        [DisplayName("Fecha de la Cita")]
        [DataType(DataType.Date, ErrorMessage = "No es una fecha")]
        public DateTime DateAppointment { get; set; }

        [DisplayName("Cita completada")]
        public bool Completed { get; set; }

        [DisplayName("Tipo de Cita")]
        public AppointmentType AppointmentType { get; set; }

        [DisplayName("Observaciones")]
        [DataType(DataType.Text)]
        public string Observations { get; set; }

        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
    }
}