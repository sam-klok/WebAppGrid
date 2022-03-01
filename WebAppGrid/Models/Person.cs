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
        public DateTime? SchoolGraduation { get; set; }
        public bool HasKids { get; set; }

        public Person(int id, string name, int age, DateTime dOB, DateTime? schoolGraduation, bool haveKids)
        {
            Id = id;
            Name = name;
            Age = age;
            DOB = dOB;
            SchoolGraduation = schoolGraduation;
            HasKids = haveKids;
        }

        // to convert SchoolGraduation into Date only for better filtering in the MVC Grid
        public DateTime? SchoolGraduationDateOnly
        {
            get
            {
                if (SchoolGraduation == null)
                    return null;

                return SchoolGraduation.Value.Date;
            }
        }
    }
}