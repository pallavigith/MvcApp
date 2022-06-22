using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace MvcApp.Controllers

{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public int Salary { get; internal set; }
    }
}