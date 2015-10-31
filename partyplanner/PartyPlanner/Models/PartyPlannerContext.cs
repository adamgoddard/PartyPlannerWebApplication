using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PartyPlanner.Models
{
    public class PartyPlannerContext : DbContext
    {
        public PartyPlannerContext() : base("PartyPlanner")
        {

        }

        public DbSet<Entertainer> Entertainer { get; set; }
        public DbSet<Customer> Customer { get; set; }

    }
}