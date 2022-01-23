using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGrid.Models;

namespace WebAppGrid.Controllers
{
    public class HomeController : Controller
    {
        List<Person> people;

        public HomeController()
        {
            people = new List<Person>() 
            {  
                new Person("Serge",30,DateTime.Parse("1/1/1980"),true),
            };
        }

        public ActionResult Index()
        {
            return View(people);
        }

        public ActionResult IndexClassic()
        {
            return View(people);
        }

        public ActionResult IndexBak()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}