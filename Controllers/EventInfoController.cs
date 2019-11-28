using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using event_api.Models;

namespace event_api.Controllers
{
    public class EventInfoController : ApiController
    {
        private EventEntities db = new EventEntities();

        // GET: api/EventInfo
        public IQueryable<EventInfo> GetEventInfoes()
        {
            return db.EventInfoes;
        }

        // GET: api/EventInfo/5
        [ResponseType(typeof(EventInfo))]
        public IHttpActionResult GetEventInfo(int id)
        {
            EventInfo eventInfo = db.EventInfoes.Find(id);
            if (eventInfo == null)
            {
                return NotFound();
            }

            return Ok(eventInfo);
        }

        // PUT: api/EventInfo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEventInfo(int id, EventInfo eventInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventInfo.EventId)
            {
                return BadRequest();
            }

            db.Entry(eventInfo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventInfoExists(id))
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

        // POST: api/EventInfo
        [ResponseType(typeof(EventInfo))]
        public IHttpActionResult PostEventInfo(EventInfo eventInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EventInfoes.Add(eventInfo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eventInfo.EventId }, eventInfo);
        }

        // DELETE: api/EventInfo/5
        [HttpDelete]
        [ResponseType(typeof(EventInfo))]
        public IHttpActionResult DeleteEventInfo(int id)
        {
            EventInfo eventInfo = db.EventInfoes.Find(id);
            if (eventInfo == null)
            {
                return NotFound();
            }

            db.EventInfoes.Remove(eventInfo);
            db.SaveChanges();

            return Ok(eventInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventInfoExists(int id)
        {
            return db.EventInfoes.Count(e => e.EventId == id) > 0;
        }
    }
}