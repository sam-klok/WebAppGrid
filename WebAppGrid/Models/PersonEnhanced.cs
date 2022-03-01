using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGrid.Models
{
    public class PersonEnhanced : Person
    {
        public PersonEnhanced(int id, string name, int age, DateTime dOB, DateTime? schoolGraduation, bool haveKids) 
            : base(id, name, age, dOB, schoolGraduation, haveKids)
        {
            
        }

        public DateTime? SchoolGraduationDate {
            get
            {
                if (SchoolGraduation == null)
                    return null;

                return SchoolGraduation.Value.Date;
            }
        }
    }
}