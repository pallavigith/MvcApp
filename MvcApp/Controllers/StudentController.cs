using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult AddStudent()
        {
            return View();
        }
            [HttpPost]
            public ActionResult AddStudent(Student student)
        {
            return View();
        }
        }

}