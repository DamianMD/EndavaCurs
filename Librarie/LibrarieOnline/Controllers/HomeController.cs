using LibrarieOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrarieOnline.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
            ViewBag.Message = " Your application descrpiton page.";
        }

        public ActionResult Books()
        {
            var books = new List<Book>()
            {
                new Book ()
                {
                    Id = 1,
                    Name = "Song of Ice and Fire",
                    Author = "Josh Martin",
                    Description = "Action/Fantasy"
          
                },
                new Book()
                {
                    Id = 2,
                    Name = " Php is thras and here is why",
                    Author = "Valeriu Seremet",
                    Description = "..."
                }
            };
            return View("View",books);
            
            
        }
    }
}