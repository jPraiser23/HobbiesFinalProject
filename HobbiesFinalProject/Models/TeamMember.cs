using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Models
{
    public class TeamMember
    {
        [Key]
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string About { get; set; }
        public int GameId { get; set; }
        public VideoGame VideoGames { get; set; }
    }
}
