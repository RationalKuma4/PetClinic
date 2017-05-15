using System.Threading.Tasks;

namespace PetClinic.WebService.Repositories.Interfaces.Appointment
{
    public interface IAppointmentWriter
    {
        Task RegisterAppointment(Models.Appointment appointment);
        Task UpdateAppointment(int id, Models.Appointment appointment);
        Task RemoveAppointment(int id);
    }
}