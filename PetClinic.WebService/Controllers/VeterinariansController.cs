using System;
using System.Data.Entity.Infrastructure;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PetClinic.WebService.Models;
using PetClinic.WebService.Repositories.Interfaces.Base;
using PetClinic.WebService.Repositories.Interfaces.Veterinarian;

namespace PetClinic.WebService.Controllers
{
    public class VeterinariansController : ApiController
    {
        //private PetClinicDbContext db = new PetClinicDbContext();
        private readonly IVeterinarianReader _reader;
        private readonly IVeterinarianWriter _writer;
        private readonly IDisposeDataBase _dispose;

        public VeterinariansController(IVeterinarianReader reader, IVeterinarianWriter writer, IDisposeDataBase dispose)
        {
            /*Contract.Requires<ArgumentNullException>(reader != null);
            Contract.Requires<ArgumentNullException>(writer != null);
            Contract.Requires<ArgumentNullException>(dispose != null);*/

            _reader = reader;
            _writer = writer;
            _dispose = dispose;
        }

        // GET: api/Veterinarians
        public IQueryable<Veterinarian> GetVeterinarians()
        {
            //return db.Veterinarians;
            return (IQueryable<Veterinarian>)_reader.GetAllVeterinarians();
        }

        // GET: api/Veterinarians/5
        [ResponseType(typeof(Veterinarian))]
        public async Task<IHttpActionResult> GetVeterinarian(int id)
        {
            /*Veterinarian veterinarian = await db.Veterinarians.FindAsync(id);
            if (veterinarian == null)
            {
                return NotFound();
            }
            return Ok(veterinarian);*/
            var veterinarian = await _reader.GetVeterinarian(id);
            if (veterinarian == null)
            {
                return NotFound();
            }
            return Ok(veterinarian);
        }

        // PUT: api/Veterinarians/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeterinarian(int id, Veterinarian veterinarian)
        {
            /*if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != veterinarian.VeterinarianId)
            {
                return BadRequest();
            }
            db.Entry(veterinarian).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeterinarianExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);*/

            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != veterinarian.VeterinarianId) return BadRequest();

            try
            {
                await _writer.UpdateVeterinarian(id, veterinarian);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_reader.VeterinarianExists(id)) return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Veterinarians
        [ResponseType(typeof(Veterinarian))]
        public async Task<IHttpActionResult> PostVeterinarian(Veterinarian veterinarian)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                await _writer.RegisterVeterinarian(veterinarian);
            }
            catch (DbUpdateException)
            {
                if (_reader.VeterinarianExists(veterinarian.VeterinarianId)) return Conflict();
                throw;
            }

            return CreatedAtRoute("DefaultApi", new { id = veterinarian.VeterinarianId }, veterinarian);

            /*db.Veterinarians.Add(veterinarian);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VeterinarianExists(veterinarian.VeterinarianId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return CreatedAtRoute("DefaultApi", new { id = veterinarian.VeterinarianId }, veterinarian);*/
        }

        // DELETE: api/Veterinarians/5
        [ResponseType(typeof(Veterinarian))]
        public async Task<IHttpActionResult> DeleteVeterinarian(int id)
        {
            /*Veterinarian veterinarian = await db.Veterinarians.FindAsync(id);
            if (veterinarian == null)
            {
                return NotFound();
            }

            db.Veterinarians.Remove(veterinarian);
            await db.SaveChangesAsync();

            return Ok(veterinarian);*/

            var veterinarian = await _reader.GetVeterinarian(id);
            if (veterinarian == null) return NotFound();

            await _writer.RemoveVeterinarian(id);
            return Ok(veterinarian);
        }

        protected override void Dispose(bool disposing)
        {
            _dispose.DisposeDataBase(disposing);
            base.Dispose(disposing);
        }
    }
}