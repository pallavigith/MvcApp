using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult GetAllProduct()

        {
            List<Product> Productlist = new List<Product>()
            {


            new Product { Id=1,Name="Laptop",Company="Dell",Price=34500},
             new Product { Id=1,Name="Laptop",Company="Hp",Price=36500},

            new Product { Id=1,Name="Keyboard",Company="Dell",Price=500},
             new Product { Id=1,Name="Mouse",Company="Dell",Price=4500},


            };
            ViewBag.ProductList = Productlist;
            return View();
        }
    }
}