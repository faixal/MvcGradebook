using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using MvcGradebook.Models;

namespace MvcGradebook.Controllers
{
    public class StudentsController : ApiController
    {
        private GradebookEntities db = new GradebookEntities();
        public IEnumerable<Student> Get()
        {
            var studentsList = db.Students.ToList();
            return studentsList;
        }

        public StudentMappingsModel Get(int id)
        {
            var student = db.Students.Find(id);
            var mappingsList = student.Mappings.Where(x=>x.Room == "15").ToList();

            StudentMappingsModel result = new StudentMappingsModel();

            result.FirstName = student.FirstName;
            result.LastName = student.LastName;
            result.Mappings = new List<MappingModel>();
            foreach (var item in mappingsList)
            {
                result.Mappings.Add(new MappingModel
                {
                    MappingId = item.MappingId,
                    StudentId = item.StudentId,
                    TeacherId = item.TeacherId,
                    Room = item.Room,
                    Subject = item.Subject,
                    RecCreatedDate = item.RecCreatedDate
                });
            }

            return result;
        }

        public Student Post(Student model)
        {
            db.Students.Add(model);
            db.SaveChanges();

            return model;
        }
    }
}
