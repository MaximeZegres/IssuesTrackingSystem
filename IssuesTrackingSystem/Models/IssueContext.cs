using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssuesTrackingSystem.Models
{
    public class IssueContext : DbContext
    {
        public IssueContext(DbContextOptions<IssueContext> options)
            : base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
