using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Zone
    {
        public Guid ZoneId { get; set; }
        public string ZoneName { get; set; }
        public string ZoneDescription { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
