using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssuesTrackingSystem.Models
{
    public class Issue
    {
        public Guid Id { get; set; }
        public string UserPC { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public enum Priority { Low, Medium, High }
        public bool IsComplete { get; set; }
    }
}
