using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PetClinic.WebService.Models;

namespace PetClinic.WebService.Controllers
{
    public class VeterinariansController : ApiController
    {
        private PetClinicDbContext db = new PetClinicDbContext();

        // GET: api/Veterinarians
        public IQueryable<Veterinarian> GetVeterinarians()
        {
            return db.Veterinarians;
        }

        // GET: api/Veterinarians/5
        [ResponseType(typeof(Veterinarian))]
        public async Task<IHttpActionResult> GetVeterinarian(int id)
        {
            Veterinarian veterinarian = await db.Veterinarians.FindAsync(id);
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
            if (!ModelState.IsValid)
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

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Veterinarians
        [ResponseType(typeof(Veterinarian))]
        public async Task<IHttpActionResult> PostVeterinarian(Veterinarian veterinarian)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veterinarians.Add(veterinarian);

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

            return CreatedAtRoute("DefaultApi", new { id = veterinarian.VeterinarianId }, veterinarian);
        }

        // DELETE: api/Veterinarians/5
        [ResponseType(typeof(Veterinarian))]
        public async Task<IHttpActionResult> DeleteVeterinarian(int id)
        {
            Veterinarian veterinarian = await db.Veterinarians.FindAsync(id);
            if (veterinarian == null)
            {
                return NotFound();
            }

            db.Veterinarians.Remove(veterinarian);
            await db.SaveChangesAsync();

            return Ok(veterinarian);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeterinarianExists(int id)
        {
            return db.Veterinarians.Count(e => e.VeterinarianId == id) > 0;
        }
    }
}