using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetClinic.WebService.Repositories.Interfaces.Appointment
{
    public interface IAppointmentReader
    {
        IEnumerable<Models.Appointment> GetAppointments();
        Task<Models.Appointment> GetAppointmentById(int id);
    }
}