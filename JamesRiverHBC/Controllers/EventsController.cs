using JamesRiverHBC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace JamesRiverHBC.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        //http://localhost:49334/Events/GetEvents
        [HttpPost]
        public object GetEvents()
        {
            object events;
            using (Models.jrhbEventsEntities eventsContext = new Models.jrhbEventsEntities())
            {
                return null;
                try
                {
                    //events = eventsContext.Events.Where(a => a.Active == true).OrderBy(o => o.EventWhen).ToList();
                    //return Json(events);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}