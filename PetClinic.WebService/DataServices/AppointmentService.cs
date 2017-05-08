using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices
{
    public class AppointmentService : IAppointmentService
    {
        private readonly PetClinicDbContext _context;

        public AppointmentService(PetClinicDbContext context)
        {
            _context = context;
        }

        public async Task CreateAppointment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _context.Appointments;
        }

        public async Task<Appointment> GetAppointmentById(int id)
        {
            return await _context.Appointments.FindAsync(id);
        }

        public async Task UpdateAppointment(Appointment appointment)
        {
            _context.Entry(appointment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAppointment(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null) _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
        }

        public bool AppointmentExists(int id)
        {
            return _context.Appointments.Count(e => e.AppointmentId == id) > 0;
        }

        public void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}