using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HobbiesFinalProject.Models;
using HobbiesFinalProject.Models.Config;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new VideoGameConfig());
            modelBuilder.ApplyConfiguration(new TeamMemberConfig());
        }
    }
}
