using Newtonsoft.Json;
using PetClinic.WebService.Models.Account;

namespace PetClinic.Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var userObj = new RegisterBindingModel();
            string output = JsonConvert.SerializeObject(userObj);

        }
    }
}
