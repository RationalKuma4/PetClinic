namespace PetClinic.Models
{
    public class Veterinarian
    {
        public int VeterinarianId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClinicName { get; set; }
        public string ClinicAddress { get; set; }
        public string ServiceHours { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Observations { get; set; }

        public int OwnerUserId { get; set; }
        public virtual OwnerUser OwnerUser { get; set; }
    }
}
