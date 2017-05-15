using System.Threading.Tasks;
using PetClinic.Models;

namespace PetClinic.DataServices
{
    public interface IRestDataServices
    {
        Task LoginAsync(OwnerUser owner);
    }
}
