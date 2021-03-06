﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IssuesTrackingSystem.Models
{
    public class Issue
    {
        [Key]
        public Guid Id { get; set; }
        public string UserPC { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public bool IsComplete { get; set; }
    }
}
