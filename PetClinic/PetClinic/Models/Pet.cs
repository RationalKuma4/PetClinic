using System;
using System.Collections.Generic;
using PetClinic.Models.Enums;

namespace PetClinic.Models
{
    public class Pet
    {
        public Pet()
        {
            Appointments = new HashSet<Appointment>();
        }
        
        public int PetId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public char Sex { get; set; }
        public string Breed { get; set; }
        public string Coulors { get; set; }
        public PetType PetType { get; set; }
        public string Observations { get; set; }


        public int OwnerUserId { get; set; }
        public virtual OwnerUser OwnerUser { get; set; }
        public int AppointmentId { get; set; }
        public virtual IEnumerable<Appointment> Appointments { get; set; }
    }
}
