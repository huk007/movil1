using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using movil1.Common.Models;
using movil1.Domain.Models;

namespace movil1.API.Controllers
{
    public class AlimentsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Aliments
        public IQueryable<Aliment> GetAliments()
        {
            return db.Aliments;
        }

        // GET: api/Aliments/5
        [ResponseType(typeof(Aliment))]
        public async Task<IHttpActionResult> GetAliment(int id)
        {
            Aliment aliment = await db.Aliments.FindAsync(id);
            if (aliment == null)
            {
                return NotFound();
            }

            return Ok(aliment);
        }

        // PUT: api/Aliments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAliment(int id, Aliment aliment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aliment.IdAliment)
            {
                return BadRequest();
            }

            db.Entry(aliment).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlimentExists(id))
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

        // POST: api/Aliments
        [ResponseType(typeof(Aliment))]
        public async Task<IHttpActionResult> PostAliment(Aliment aliment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Aliments.Add(aliment);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aliment.IdAliment }, aliment);
        }

        // DELETE: api/Aliments/5
        [ResponseType(typeof(Aliment))]
        public async Task<IHttpActionResult> DeleteAliment(int id)
        {
            Aliment aliment = await db.Aliments.FindAsync(id);
            if (aliment == null)
            {
                return NotFound();
            }

            db.Aliments.Remove(aliment);
            await db.SaveChangesAsync();

            return Ok(aliment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AlimentExists(int id)
        {
            return db.Aliments.Count(e => e.IdAliment == id) > 0;
        }
    }
}