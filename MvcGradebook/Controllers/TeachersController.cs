using DataAccess;
using MvcGradebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MvcGradebook.Controllers
{
    public class TeachersController : Controller
    {
        private GradebookEntities db = new GradebookEntities();
        // GET: Teachers
        public ActionResult Index()
        {
            IEnumerable<Teacher> teachers = db.Teachers.ToList();
            return View(teachers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeacherModel teacher)
        {
            if (ModelState.IsValid)
            {
                Teacher dbTeacher = new Teacher
                {
                    TeacherName = teacher.TeacherName,
                    Email = teacher.Email
                };

                db.Teachers.Add(dbTeacher);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }        

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }
    }
}