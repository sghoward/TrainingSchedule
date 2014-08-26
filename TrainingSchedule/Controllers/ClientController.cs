using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingSchedule.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Event(int  eventID)
        {
            //get specific event and return to next view
            return View();
        }

        //public ActionResult UpcomingEvent()
        //{
        //    return View(getAllEvents());
        //}

        //public List<Events> getAllEvents()
        //{
        //    List<Events> results = new List<Events>();
        //    return results;

        //}

        //public Events getEvent(int eventID)
        //{
        //    //use db context to get a single event
        //    return events;
        //}
        
        public void AddEvent(int eventId)
        {
            //add an event to the users events
        }
    }
}

