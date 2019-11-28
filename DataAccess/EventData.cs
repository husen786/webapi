using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using event_api.Models;
namespace event_api.DataAccess
{
    
    public class EventData
    {
        private EventEntities db = new EventEntities();
        private IEnumerable<string> Message;
        public IEnumerable<EventInfo> getAllevents()
        {
            List<EventInfo> events = db.EventInfoes.ToList();            
            return events;            
        }
        public EventInfo getEvent(int id)
        {
            EventInfo eventInfo = new EventInfo();
            eventInfo = db.EventInfoes.Where(x => x.EventId == id).FirstOrDefault();
            return eventInfo;
        }
        
    }
}