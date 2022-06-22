using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        [HttpGet]
        public ActionResult EmpDetails()
        {
            {
                List<String> Options = new List<string>();
                Options.Add("Choose an Option");
                Options.Add("Yes");
                Options.Add("No");
                ViewData["Options"] = new SelectList(Options);
                return View();

            }

        }
        [HttpPost]
        private ActionResult EmpDetails1(FormCollection fc, ICollection<string> Dept)
        {
            ViewBag.empname = fc["empname"];
            ViewBag.id = fc["id"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.dept =Dept;
            ViewBag.options = fc["Options"];
            return View("EmppDetails");




        }
    }
}