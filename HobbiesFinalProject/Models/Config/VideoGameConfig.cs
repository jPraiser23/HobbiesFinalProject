using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Models.Config
{
    public class VideoGameConfig : IEntityTypeConfiguration<VideoGame>
    {
        //20 greatest video games of all time according to
        //https://www.businessinsider.com/20-best-video-games-of-all-time-according-to-critics-2020-4
        public void Configure(EntityTypeBuilder<VideoGame> entity)
        {
            entity.HasData(
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
                },
                new VideoGame
                {
                    GameId = 21,
                    Title = "Starcraft",
                    Publisher = "Blizard",
                    System = "Computer"
                },
                new VideoGame
                {
                    GameId = 22,
                    Title = "The Last of Us: Reamstered",
                    Publisher = "Naughty Dog",
                    System = "Playstation 4"
                },
                new VideoGame
                {
                    GameId = 23,
                    Title = "Kingdom Hearts II",
                    Publisher = "Square Enix",
                    System = "Playstation"
                }
            );
        }
    }
}