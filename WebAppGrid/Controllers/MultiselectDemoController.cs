using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGrid.Models;

namespace WebAppGrid.Controllers
{
    public class MultiselectDemoController : Controller
    {
        List<Person> people;

        public MultiselectDemoController()
        {
            people = new List<Person>()
            {
                new Person( 1,"Sam Klok",       30,DateTime.Parse("01/01/1980")        ,DateTime.Parse("01/01/1980 11:12")     ,true),
                new Person( 2,"Tristan",        10,DateTime.Parse("02/01/2010")        ,DateTime.Parse("02/01/2010 14:35")     ,false),
                new Person( 3,"McKayla",        09,DateTime.Parse("03/01/2012")        ,DateTime.Parse("03/01/2012")           ,false),
                new Person( 4,"Anastasia",      20,DateTime.Parse("04/01/1980")        ,DateTime.Parse("04/01/1980")           ,false),
                new Person( 5,"Amanda",         25,DateTime.Parse("05/07/1980")        ,DateTime.Parse("05/07/1980")           ,true),
                new Person( 6,"Dedushka",       80,DateTime.Parse("05/16/1980")        ,null                                   ,true),
                new Person( 7,"Babushka",       81,DateTime.Parse("08/01/1980")        ,null                                   ,true),
                new Person( 8,"John Smith",     54,DateTime.Parse("12/01/1980")        ,null                                   ,false),
                new Person( 9,"Joseph Boles",   65,DateTime.Parse("11/21/1980")        ,null                                   ,false),
                new Person(10,"Priyanka Agrwal",33,DateTime.Parse("01/01/1980")        ,null                                   ,false),
                new Person(11,"Solomon Klokov", 0 ,DateTime.Parse("02/28/2022 10:30")  ,null                                   ,false),
                new Person(12,"Solomeya Klokov",0 ,DateTime.Now                        ,null                                   ,false),
                new Person(13,"Archie - bald",  2 ,DateTime.Parse("05/15/2020")        ,null                                   ,false),
            };

        }
    
        public ActionResult MulSelIndex()
        {
            var soccerClub = new SoccerClub()
            {
                Name = "Family Club",
                Players = "Sam Klok,Tristan,McKayla".Split(','), // comma separated list
                //PlayersOptions = people.Select(p => new SelectListItem { Value = p.Name }).ToList()
                //PlayersOptions = people.Select(p => new SelectListItem { Text = p.Name, Value = p.Id.ToString() }).ToList()
                PlayersOptions = people.Select(p => new SelectListItem { Text = p.Name, Value = p.Name }).ToList()
            };

            return View(soccerClub);
        }

        //public List<string> PeopleNames()
        //{
        //    return people.Select(p => p.Name).ToList();
        //}
        
    }
}