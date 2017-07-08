using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGradebook.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RollNumber { get; set; }
    }
}