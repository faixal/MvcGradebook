using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcGradebook.Models
{
    public class TeacherModel
    {
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}