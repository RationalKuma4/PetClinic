using System.Collections.Generic;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;
using PetClinic.WebService.Repositories.Interfaces.Appointment;
using PetClinic.WebService.Repositories.Interfaces.Base;

namespace PetClinic.WebService.Repositories
{
    public class RepositoryAppointment : IAppointmentReader, IAppointmentWriter, IDisposeDataBase
    {
        private readonly IAppointmentService _service;

        public RepositoryAppointment(IAppointmentService service)
        {
            _service = service;
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            return _service.GetAllAppointments();
        }

        public async Task<Appointment> GetAppointmentById(int id)
        {
            return await _service.GetAppointmentById(id);
        }

        public async Task RegisterAppointment(Appointment appointment)
        {
            await _service.CreateAppointment(appointment);
        }

        public async Task UpdateAppointment(int id, Appointment appointment)
        {
            await _service.UpdateAppointment(appointment);
        }

        public async Task RemoveAppointment(int id)
        {
            await _service.RemoveAppointment(id);
        }

        public void DisposeDataBase(bool disposing)
        {
            _service.Dispose(disposing);
        }
    }
}