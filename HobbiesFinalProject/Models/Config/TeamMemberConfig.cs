using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Models.Config
{
    public class TeamMemberConfig : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> entity)
        {
            entity.HasData(
                new TeamMember
                {
                    MemberId = 1,
                    FirstName = "Jamie",
                    LastName = "Miozzi",
                    City = "Cincinnati",
                    State = "Ohio",
                    About = @"Hi my name is Jamie Miozzi. I am from Cleveland Ohio origionally but I've spent the past three years here in Cincinnatti. I am currently a third year student at The University of Cincinnati studying IT software development.",
                    GameId = 1
                },
                new TeamMember
                {
                    MemberId = 2,
                    FirstName = "Travis",
                    LastName = "Newberry",
                    City = "Georgetown",
                    State = "Ohio",
                    About = @"My name is Travis and I have been going to UC Clermont following the IT Program. I plan to transfer to main compus in the fall to continue my education. I curently work night shifts at Kroger and enjoy playing chess as well as many video games in my spare time.",
                    GameId = 21
                },
                new TeamMember
                {
                    MemberId = 3,
                    FirstName = "John",
                    LastName = "Praiser",
                    City = "Cincinnati",
                    State = "Ohio",
                    About = @"I am 4th year at the University of Cincinnati. I am planning to graduate next year. I am Software Development major with interests including new technology, software development, and video game development/entertainment.",
                    GameId = 1
                },
                new TeamMember
                {
                    MemberId = 4,
                    FirstName = "Madison",
                    LastName = "Rosas",
                    City = "Cincinnati",
                    State = "Ohio",
                    About = @"I am a 5th year senior at the University of Cincinnati. I am graduating on April 30th! I am an IT major with a focus on Networking/System Administration and Software Development. I currently work part-time for a tech company called Genuen and am transitioning to full time after graduation. I am excited to move on to the 'real world.'",
                    GameId = 1
                },
                new TeamMember
                {
                    MemberId = 5,
                    FirstName = "Jeremy",
                    LastName = "Shepherd",
                    City = "Xenia",
                    State = "Ohio",
                    About = @"I am a graduate of Sinclair Community College's Software Development program. I have spent the past 19 years 
                            working for Premier Health and I am hoping to start a new career soon.",
                    GameId = 1
                }
            );
            entity
                .HasOne(t => t.VideoGames)
                .WithMany(v => v.TeamMembers)
                .HasForeignKey(v => v.GameId);
        }
    }
}
