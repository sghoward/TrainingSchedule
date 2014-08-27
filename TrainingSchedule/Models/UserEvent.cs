using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingSchedule.Models
{
    [Table("UserEvents")]
    public class UserEvent
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserEventID { get; set; }
        
        public int UserId { get; set; }
        public int  EventID{get; set;}
        public bool Attending { get; set; }
    }
}