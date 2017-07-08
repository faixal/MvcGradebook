using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGradebook.Models
{
    public class StudentMappingsModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<MappingModel> Mappings { get; set; }
    }
}