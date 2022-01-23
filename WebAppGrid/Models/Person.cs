using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGrid.Models
{
    public class Person
    {
        public string Name{ get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public bool HaveKids { get; set; }

        public Person(string name, int age, DateTime dOB, bool haveKids)
        {
            Name = name;
            Age = age;
            DOB = dOB;
            HaveKids = haveKids;
        }
    }
}