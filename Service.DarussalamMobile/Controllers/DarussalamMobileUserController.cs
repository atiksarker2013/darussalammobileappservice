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
    public class DarussalamMobileUserController : ApiController
    {
        private KARIM_INT_HOUSTONEEntities db = new KARIM_INT_HOUSTONEEntities();

        // GET: api/DarussalamMobileUser
        public IQueryable<tbl_DarussalamMobileUser> Gettbl_DarussalamMobileUser()
        {
            return db.tbl_DarussalamMobileUser;
        }

        // GET: api/DarussalamMobileUser/5
        [ResponseType(typeof(tbl_DarussalamMobileUser))]
        public async Task<IHttpActionResult> Gettbl_DarussalamMobileUser(int id)
        {
            tbl_DarussalamMobileUser tbl_DarussalamMobileUser = await db.tbl_DarussalamMobileUser.FindAsync(id);
            if (tbl_DarussalamMobileUser == null)
            {
                return NotFound();
            }

            return Ok(tbl_DarussalamMobileUser);
        }

        // PUT: api/DarussalamMobileUser/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Puttbl_DarussalamMobileUser(int id, tbl_DarussalamMobileUser tbl_DarussalamMobileUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_DarussalamMobileUser.Id)
            {
                return BadRequest();
            }

            db.Entry(tbl_DarussalamMobileUser).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_DarussalamMobileUserExists(id))
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

        // POST: api/DarussalamMobileUser
        [ResponseType(typeof(tbl_DarussalamMobileUser))]
        public async Task<IHttpActionResult> Posttbl_DarussalamMobileUser(tbl_DarussalamMobileUser tbl_DarussalamMobileUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_DarussalamMobileUser.Add(tbl_DarussalamMobileUser);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tbl_DarussalamMobileUser.Id }, tbl_DarussalamMobileUser);
        }

        // DELETE: api/DarussalamMobileUser/5
        [ResponseType(typeof(tbl_DarussalamMobileUser))]
        public async Task<IHttpActionResult> Deletetbl_DarussalamMobileUser(int id)
        {
            tbl_DarussalamMobileUser tbl_DarussalamMobileUser = await db.tbl_DarussalamMobileUser.FindAsync(id);
            if (tbl_DarussalamMobileUser == null)
            {
                return NotFound();
            }

            db.tbl_DarussalamMobileUser.Remove(tbl_DarussalamMobileUser);
            await db.SaveChangesAsync();

            return Ok(tbl_DarussalamMobileUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_DarussalamMobileUserExists(int id)
        {
            return db.tbl_DarussalamMobileUser.Count(e => e.Id == id) > 0;
        }
    }
}