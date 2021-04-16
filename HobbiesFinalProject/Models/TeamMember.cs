using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Models
{
    public class TeamMember
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string About { get; set; }
    }
}
