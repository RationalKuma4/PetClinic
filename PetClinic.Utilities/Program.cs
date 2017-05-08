using Newtonsoft.Json;
using PetClinic.WebService.Models;
using PetClinic.WebService.Models.Account;

namespace PetClinic.Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            //var userObj = new RegisterBindingModel();
            //var pet = new Pet();
            //var appointment = new Appointment();
            var vet = new Veterinarian();
            string output = JsonConvert.SerializeObject(vet);

        }
    }
}
