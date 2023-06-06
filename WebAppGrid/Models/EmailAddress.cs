using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGrid.Models
{
    public class EmailAddress
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }

        public EmailAddress()
        { 
        }

        public EmailAddress(int id, string email, bool active = true, string firstName = null, string lastName = null, string comment = null)
        {
            ID = id;
            Email = email;
            Active = active;
            FirstName = firstName;
            LastName = lastName;
            Comment = comment;
        }
    }
}