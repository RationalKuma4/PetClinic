namespace PetClinic.Models
{
    public class OwnerUser
    {
        public int AccessFailedCount { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
    }
}
