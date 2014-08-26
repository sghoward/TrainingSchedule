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

        public ActionResult Event()
        {
            return View();
        }

        public ActionResult UpcomingEvent()
        {
            return View();
        }

        public List<Event> getAllEvents()
        {
            List<Event> results = new List<Event>();
            return results;

        }

        public Event getEvent(int eventID)
        {
            //use db context to get a single event
            return event;
        }


    }
}
