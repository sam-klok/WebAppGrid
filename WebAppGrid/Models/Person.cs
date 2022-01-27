using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGrid.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name{ get; set; }  // It's unique
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public bool HasKids { get; set; }

        public Person(int id, string name, int age, DateTime dOB, bool haveKids)
        {
            Id = id;
            Name = name;
            Age = age;
            DOB = dOB;
            HasKids = haveKids;
        }
    }
}