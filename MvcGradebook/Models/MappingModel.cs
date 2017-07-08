using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGradebook.Models
{
    public class MappingModel
    {
        public int MappingId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public string Subject { get; set; }
        public string Room { get; set; }
        public System.DateTime RecCreatedDate { get; set; }
    }
}