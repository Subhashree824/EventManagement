using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore

namespace EventAPI.Models
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext>options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Event>Events{ get; set; }
    }
}
