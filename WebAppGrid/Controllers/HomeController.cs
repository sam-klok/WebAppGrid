﻿using System;
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
                new Person( 1,"Sam Klok",       30,DateTime.Parse("01/01/1980"),true),
                new Person( 2,"Tristan",        10,DateTime.Parse("02/01/2010"),false),
                new Person( 3,"McKayla",        09,DateTime.Parse("03/01/2012"),false),
                new Person( 4,"Anastasia",      20,DateTime.Parse("04/01/1980"),false),
                new Person( 5,"Amanda",         25,DateTime.Parse("05/07/1980"),true),
                new Person( 6,"Dedushka",       80,DateTime.Parse("05/16/1980"),true),
                new Person( 7,"Babushka",       81,DateTime.Parse("08/01/1980"),true),
                new Person( 8,"John Smith",     54,DateTime.Parse("12/01/1980"),false),
                new Person( 9,"Joseph Boles",   65,DateTime.Parse("11/21/1980"),false),
                new Person(10,"Priyanka Agrwal",33,DateTime.Parse("01/01/1980"),false),
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