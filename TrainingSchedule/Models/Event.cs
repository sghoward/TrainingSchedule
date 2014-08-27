using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TrainingSchedule.Models
{
    public class Event
    {
        [Key, Display(Name = "Event ID")]
        [ScaffoldColumn(false)]
        public int EventID { get; set; }

        [Required, Display(Name = "Name")]
        public string EventName { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime StartDate { get; set; }

        public int TechID { get; set; }
        public virtual Technology Tech { get; set; }

        public List<Event> eventList { get; set; }

    }
}