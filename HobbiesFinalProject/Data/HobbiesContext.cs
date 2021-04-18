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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //20 greatest video games of all time according to
            //https://www.businessinsider.com/20-best-video-games-of-all-time-according-to-critics-2020-4
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame
                {
                    GameId = 1,
                    Title = "Uncharted 2: Among Thieves",
                    Publisher = "Playstation",
                    System = "PlayStation 4"
                },
                new VideoGame
                {
                    GameId = 2,
                    Title = "GoldenEye 007",
                    Publisher = "Nintendo",
                    System = "Nintendo 64"
                },
                new VideoGame
                {
                    GameId = 3,
                    Title = "BioShock",
                    Publisher = "2k Games",
                    System = "PlayStation 4"
                },
                new VideoGame
                {
                    GameId = 4,
                    Title = "Half-Life 2",
                    Publisher = "Valve",
                    System = "Xbox 360"
                },
                new VideoGame
                {
                    GameId = 5,
                    Title = "NFL 2K1",
                    Publisher = "Sega",
                    System = "Dreamcast"
                },
                new VideoGame
                {
                    GameId = 6,
                    Title = "Halo: Combat Evolved",
                    Publisher = "Microsoft",
                    System = "Xbox 360"
                },
                new VideoGame
                {
                    GameId = 7,
                    Title = "Super Mario Odyssey",
                    Publisher = "Nintendo",
                    System = "Switch"
                },
                new VideoGame
                {
                    GameId = 8,
                    Title = "Grand Theft Auto III",
                    Publisher = "Rockstar Games",
                    System = "PlayStation 2"
                },
                new VideoGame
                {
                    GameId = 9,
                    Title = "Metroid Prime",
                    Publisher = "Nintendo",
                    System = "Wii"
                },
                new VideoGame
                {
                    GameId = 10,
                    Title = "Perfect Dark",
                    Publisher = "Rare",
                    System = "Xbox One"
                },
                new VideoGame
                {
                    GameId = 11,
                    Title = "Tony Hawk's Pro Skater 3",
                    Publisher = "Neversoft",
                    System = "Game Boy Advance"
                },
                new VideoGame
                {
                    GameId = 12,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Publisher = "Nintendo",
                    System = "Wii U"
                },
                new VideoGame
                {
                    GameId = 13,
                    Title = "Grand Theft Auto V",
                    Publisher = "Rockstar Games",
                    System = "PlayStation 3"
                },
                new VideoGame
                {
                    GameId = 14,
                    Title = "Red Dead Redemption 2",
                    Publisher = "Rockstar Games",
                    System = "Xbox One"
                },
                new VideoGame
                {
                    GameId = 15,
                    Title = "Super Mario Galaxy 2",
                    Publisher = "Nintendo",
                    System = "Wii"
                },
                new VideoGame
                {
                    GameId = 16,
                    Title = "Super Mario Galaxy",
                    Publisher = "Nintendo",
                    System = "Wii"
                },
                new VideoGame
                {
                    GameId = 17,
                    Title = "SoulCalibur",
                    Publisher = "Bandai Namco Entertainment",
                    System = "Arcade"
                },
                new VideoGame
                {
                    GameId = 18,
                    Title = "Grand Theft Auto IV",
                    Publisher = "Rockstar Games",
                    System = "PlayStation 3"
                },
                new VideoGame
                {
                    GameId = 19,
                    Title = "Tony Hawk's Pro Skater 2",
                    Publisher = "Activision",
                    System = "PlayStation"
                },
                new VideoGame
                {
                    GameId = 20,
                    Title = "The Legend of Zelda: Ocarina of Time",
                    Publisher = "Nintendo",
                    System = "Nintendo 64"
                }
            );

            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    MemberId = 1,
                    FirstName = "Jamie",
                    LastName = "Miozzi",
                    City = "Cincinnati",
                    State = "Ohio",
                    About = @"Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.
                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds."
                },
                new TeamMember
                {
                    MemberId = 2,
                    FirstName = "Travis",
                    LastName = "Newberry",
                    City = "Cincinnati",
                    State = "Ohio",
                    About = @"Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.
                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds."
                },
                new TeamMember
                {
                    MemberId = 3,
                    FirstName = "John",
                    LastName = "Praiser",
                    City = "Cincinnati",
                    State = "Ohio",
                    About = @"Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.
                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds."
                },
                new TeamMember
                {
                    MemberId = 4,
                    FirstName = "Madison",
                    LastName = "Rosas",
                    City = "Cincinnati",
                    State = "Ohio",
                    About = @"I am a 5th year senior at the University of Cincinnati. I am graduating on April 30th! I am an IT major with a focus on Networking/System Administration and Software Development. I currently work part-time for a tech company called Genuen and am transitioning to full time after graduation. I am excited to move on to the 'real world.'"
                },
                new TeamMember
                {
                    MemberId = 5,
                    FirstName = "Jeremy",
                    LastName = "Shepherd",
                    City = "Xenia",
                    State = "Ohio",
                    About = @"I am a graduate of Sinclair Community College's Software Development program. I have spent the past 19 years 
                            working for Premier Health and I am hoping to start a new career soon."
                }
            );
        }
    }
}
