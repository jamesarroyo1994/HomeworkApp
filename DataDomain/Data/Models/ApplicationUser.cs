using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataDomain.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace SchoolSystem.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public Class Class { get; set;}
    }
}
