using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Models
{
    public class VideoGame
    {
        [Key]
        public int GameId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string System { get; set; }

        public ICollection<TeamMember> TeamMembers { get; set; }
    }
}
