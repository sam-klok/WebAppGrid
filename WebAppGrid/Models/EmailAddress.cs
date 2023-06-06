using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGrid.Models
{
    public class EmailAddress
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }

        public EmailAddress(string email, bool active = true, string firstName = null, string lastName = null, string comment = null)
        {
            Email = email;
            Active = active;
            FirstName = firstName;
            LastName = lastName;
            Comment = comment;
        }
    }
}