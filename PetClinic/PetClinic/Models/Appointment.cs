using System;
using PetClinic.Models.Enums;

namespace PetClinic.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime DateAppointment { get; set; }
        public bool Completed { get; set; }
        public AppointmentType AppointmentType { get; set; }
        public string Observations { get; set; }

        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
