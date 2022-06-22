using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        [HttpGet]
        public ActionResult PersonalDetails()
        {
            List<String> Options = new List<string>();
            Options.Add("Choose an Option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);
            return View();
        }
        [HttpPost]//attribute
        public ActionResult PersonalDetails(FormCollection fc,ICollection<String> hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lasttname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.options = fc["Options"];


            return View("Details");

        }

    }
}