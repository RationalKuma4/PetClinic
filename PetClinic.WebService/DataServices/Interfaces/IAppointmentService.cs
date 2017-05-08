using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc.Async;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices.Interfaces
{
    public interface IAppointmentService
    {
        Task CreateAppointment(Appointment appointment);
        IEnumerable<Appointment> GetAllAppointments();
        Task<Appointment> GetAppointmentById(int id);
        Task UpdateAppointment(Appointment appointment);
        Task RemoveAppointment(int id);
        bool AppointmentExists(int id);
        void Dispose(bool disposing);
    }
}
