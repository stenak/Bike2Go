using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bike2Go.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
        public int Discount { get; set; }
        public int DurationInMonths { get; set; }
    }
}