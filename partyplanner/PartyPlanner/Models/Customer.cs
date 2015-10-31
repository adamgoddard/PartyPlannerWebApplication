using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyPlanner.Models
{
    public class Customer
    {
        public int id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string Town { get; set; }

        public string City { get; set; }

        public int PhoneNumber { get; set; }

    }
}