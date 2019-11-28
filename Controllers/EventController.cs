using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using event_api.DataAccess;
using event_api.Models;
namespace event_api.Controllers
{
    public class EventController : ApiController
    {
        private EventData data = new EventData();
        private EventEntities db = new EventEntities();
        public IHttpActionResult GetEvents()
        {
            var events = this.data.getAllevents();
            return Ok(events);

        }

        public IHttpActionResult GetEvent(int id)
        {
            EventInfo eventInfo = new EventInfo();
            eventInfo = this.data.getEvent(id);
            if(eventInfo==null)
            {
                return NotFound();
            }
            return Ok(eventInfo);
        }

        
        public IHttpActionResult DeleteEvent(int id)
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


    }
}
