using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.DataServices
{
    public class AppointmentService : IAppointmentService
    {
        public async Task CreateAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            throw new NotImplementedException();
        }

        public async Task<Appointment> GetAppointmentById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAppointment(Veterinarian veterinarian)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public bool AppointmentExists(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}