using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingSchedule.Models;
namespace TrainingSchedule.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/
        TrainingContext db = new TrainingContext();
        UsersContext uc = new UsersContext();

        public ActionResult Index()
        {
            return View(db.UserEvents.Where(x => x.Attending.Equals(true)).ToList());
        }

        public ActionResult Event()
        {
            //get specific event and return to next view
            return View();
        }

        public ActionResult UpcomingEvent()
        {
            return View(getAllEvents());
        }

        public IQueryable<Event> getAllEvents()
        {
            
            return db.Events;

        }

        public IQueryable<Event> getEvent(int eventID)
        {
            //use db context to get a single event
            return db.Events.Where(x => x.EventID.Equals(eventID));
        }
        
        public void AddEvent(int eventId)
        {
            IQueryable<UserProfile> c = uc.UserProfiles.Where(x => x.UserName.Equals(User.Identity.Name));
            var idResult = c.Select(x => x.UserId);
            db.UserEvents.Add(new UserEvent{
                UserId = int.Parse(idResult.ToString()),
                EventID = eventId,
                Attending = true,   
            });
        }
    }
}

