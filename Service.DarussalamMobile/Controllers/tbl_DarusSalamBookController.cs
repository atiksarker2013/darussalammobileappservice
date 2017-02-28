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
using Service.DarussalamMobile;

namespace Service.DarussalamMobile.Controllers
{
    public class tbl_DarusSalamBookController : ApiController
    {
        private KARIM_INT_HOUSTONEEntities db = new KARIM_INT_HOUSTONEEntities();

        // GET: api/tbl_DarusSalamBook
        public IQueryable<tbl_DarusSalamBook> Gettbl_DarusSalamBook()
        {
            return db.tbl_DarusSalamBook;
        }

        // GET: api/tbl_DarusSalamBook/5
        [ResponseType(typeof(tbl_DarusSalamBook))]
        public async Task<IHttpActionResult> Gettbl_DarusSalamBook(int id)
        {
            tbl_DarusSalamBook tbl_DarusSalamBook = await db.tbl_DarusSalamBook.FindAsync(id);
            if (tbl_DarusSalamBook == null)
            {
                return NotFound();
            }

            return Ok(tbl_DarusSalamBook);
        }

        // PUT: api/tbl_DarusSalamBook/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Puttbl_DarusSalamBook(int id, tbl_DarusSalamBook tbl_DarusSalamBook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_DarusSalamBook.Id)
            {
                return BadRequest();
            }

            db.Entry(tbl_DarusSalamBook).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_DarusSalamBookExists(id))
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

        // POST: api/tbl_DarusSalamBook
        [ResponseType(typeof(tbl_DarusSalamBook))]
        public async Task<IHttpActionResult> Posttbl_DarusSalamBook(tbl_DarusSalamBook tbl_DarusSalamBook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_DarusSalamBook.Add(tbl_DarusSalamBook);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tbl_DarusSalamBook.Id }, tbl_DarusSalamBook);
        }

        // DELETE: api/tbl_DarusSalamBook/5
        [ResponseType(typeof(tbl_DarusSalamBook))]
        public async Task<IHttpActionResult> Deletetbl_DarusSalamBook(int id)
        {
            tbl_DarusSalamBook tbl_DarusSalamBook = await db.tbl_DarusSalamBook.FindAsync(id);
            if (tbl_DarusSalamBook == null)
            {
                return NotFound();
            }

            db.tbl_DarusSalamBook.Remove(tbl_DarusSalamBook);
            await db.SaveChangesAsync();

            return Ok(tbl_DarusSalamBook);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_DarusSalamBookExists(int id)
        {
            return db.tbl_DarusSalamBook.Count(e => e.Id == id) > 0;
        }
    }
}