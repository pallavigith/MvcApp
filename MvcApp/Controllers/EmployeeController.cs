using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetEmployee()
        {
            List<Employee>EmployeeList = new List<Employee>()
            {


                 new  Employee { Id=1,Name="Pallavi",Company="Dell",Salary=34500},
             
                new  Employee{ Id=2,Name="Punam",Company="Hp",Salary=36500},
                new  Employee { Id=3,Name="Swati",Company="Dell",Salary=500},
                 new Employee { Id=4,Name="Hemanvi",Company="Dell",Salary=4500},


            };
            ViewBag.EmployeeList = EmployeeList;
            return View();
        }
    }
}

