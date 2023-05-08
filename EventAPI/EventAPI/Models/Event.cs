using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public DateTime Schedule { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string ModeratorId { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int RigorRank { get; set; }
        public List<string> Attendees { get; set; }
    }
}
