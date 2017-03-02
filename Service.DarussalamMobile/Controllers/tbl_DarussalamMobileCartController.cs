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
    public class tbl_DarussalamMobileCartController : ApiController
    {
        private KARIM_INT_HOUSTONEEntities db = new KARIM_INT_HOUSTONEEntities();

        // GET: api/tbl_DarussalamMobileCart
        public IQueryable<tbl_DarussalamMobileCart> Gettbl_DarussalamMobileCart()
        {
            return db.tbl_DarussalamMobileCart;
        }

        // GET: api/tbl_DarussalamMobileCart/5
        [ResponseType(typeof(tbl_DarussalamMobileCart))]
        public async Task<IHttpActionResult> Gettbl_DarussalamMobileCart(int id)
        {
            tbl_DarussalamMobileCart tbl_DarussalamMobileCart = await db.tbl_DarussalamMobileCart.FindAsync(id);
            if (tbl_DarussalamMobileCart == null)
            {
                return NotFound();
            }

            return Ok(tbl_DarussalamMobileCart);
        }

        // GET: api/tbl_DarussalamMobileCart/5
        [ResponseType(typeof(tbl_DarussalamMobileCart))]
        public async Task<IHttpActionResult> Gettbl_DarussalamMobileCart(string id)
        {
            tbl_DarussalamMobileCart tbl_DarussalamMobileCart = await db.tbl_DarussalamMobileCart.FindAsync(id);
            if (tbl_DarussalamMobileCart == null)
            {
                return NotFound();
            }

            return Ok(tbl_DarussalamMobileCart);
        }

        // PUT: api/tbl_DarussalamMobileCart/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Puttbl_DarussalamMobileCart(int id, tbl_DarussalamMobileCart tbl_DarussalamMobileCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_DarussalamMobileCart.Id)
            {
                return BadRequest();
            }

            db.Entry(tbl_DarussalamMobileCart).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_DarussalamMobileCartExists(id))
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

        // POST: api/tbl_DarussalamMobileCart
        [ResponseType(typeof(tbl_DarussalamMobileCart))]
        public async Task<IHttpActionResult> Posttbl_DarussalamMobileCart(tbl_DarussalamMobileCart tbl_DarussalamMobileCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_DarussalamMobileCart.Add(tbl_DarussalamMobileCart);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tbl_DarussalamMobileCart.Id }, tbl_DarussalamMobileCart);
        }

        // DELETE: api/tbl_DarussalamMobileCart/5
        [ResponseType(typeof(tbl_DarussalamMobileCart))]
        public async Task<IHttpActionResult> Deletetbl_DarussalamMobileCart(int id)
        {
            tbl_DarussalamMobileCart tbl_DarussalamMobileCart = await db.tbl_DarussalamMobileCart.FindAsync(id);
            if (tbl_DarussalamMobileCart == null)
            {
                return NotFound();
            }

            db.tbl_DarussalamMobileCart.Remove(tbl_DarussalamMobileCart);
            await db.SaveChangesAsync();

            return Ok(tbl_DarussalamMobileCart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_DarussalamMobileCartExists(int id)
        {
            return db.tbl_DarussalamMobileCart.Count(e => e.Id == id) > 0;
        }
    }
}