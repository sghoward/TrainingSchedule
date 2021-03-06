﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace TrainingSchedule.Models 
{

    public class TrainingContext : DbContext
    {
        public DbSet<Syllabus> Syllabuses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }
    }
}