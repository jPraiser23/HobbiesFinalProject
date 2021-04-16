using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HobbiesFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HobbiesFinalProject.Data
{
    public class HobbiesContext : DbContext
    {
        public HobbiesContext(DbContextOptions<HobbiesContext> options)
            : base(options)
        {
        }

        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
