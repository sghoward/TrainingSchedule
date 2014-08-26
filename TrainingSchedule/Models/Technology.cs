using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TrainingSchedule.Models
{
    public class Technology
    {
        [Key, Display(Name = "Technology ID")]
        [ScaffoldColumn(false)]
        public int TechID { get; set; }
        [Required, Display(Name = "Technology")]
        public string TechName { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Syllabus> Syllabus { get; set; }
    }
}