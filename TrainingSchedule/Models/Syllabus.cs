using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TrainingSchedule.Models
{
    public class Syllabus
    {
        [Key]
        [ScaffoldColumn(false)]
        public int SyllabusID { get; set; }

        [Required, Display(Name = "Syllabus Name")]
        public string SyllabusName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public int TechID { get; set; }
        public virtual Technology Tech { get; set; }
    }
}