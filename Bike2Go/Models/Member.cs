using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bike2Go.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public DateTime JoinDate { get; set; }

        public Experience Experience { get; set; }

        public int ExperienceId { get; set; }

        public Membership Membership { get; set; }

        public int MembershipId { get; set; }
        
    }
}