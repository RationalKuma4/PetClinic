using Microsoft.AspNet.Identity.EntityFramework;
using PetClinic.WebService.Models.CustomUser;
using System.Data.Entity;

namespace PetClinic.WebService.Models
{
    public class PetClinicDbContext : IdentityDbContext<OwnerUser, CustomRole,
        int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public PetClinicDbContext()
            : base("DefaultConnection") { }

        public static PetClinicDbContext Create()
        {
            return new PetClinicDbContext();
        }

        public DbSet<Veterinarian> Veterinarians { get; set; }

        //public DbSet<OwnerUser> OwnerUsers { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
    }
}