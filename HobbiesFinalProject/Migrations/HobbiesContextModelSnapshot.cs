﻿// <auto-generated />
using HobbiesFinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HobbiesFinalProject.Migrations
{
    [DbContext(typeof(HobbiesContext))]
    partial class HobbiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HobbiesFinalProject.Models.TeamMember", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            MemberId = 1,
                            About = "Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.\r\n                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds.",
                            City = "Cincinnati",
                            FirstName = "Jamie",
                            LastName = "Miozzi",
                            State = "Ohio"
                        },
                        new
                        {
                            MemberId = 2,
                            About = "My name is Travis and I have been going to UC Clermont following the IT Program. I plan to transfer to main compus in the fall to continue my education. I curently work night shifts at Kroger and enjoy playing chess as well as many video games in my spare time.",
                            City = "Georgetown",
                            FirstName = "Travis",
                            LastName = "Newberry",
                            State = "Ohio"
                        },
                        new
                        {
                            MemberId = 3,
                            About = "Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.\r\n                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds.",
                            City = "Cincinnati",
                            FirstName = "John",
                            LastName = "Praiser",
                            State = "Ohio"
                        },
                        new
                        {
                            MemberId = 4,
                            About = "Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.\r\n                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds.",
                            City = "Cincinnati",
                            FirstName = "Madison",
                            LastName = "Rosas",
                            State = "Ohio"
                        },
                        new
                        {
                            MemberId = 5,
                            About = "I am a graduate of Sinclair Community College's Software Development program. I have spent the past 19 years \r\n                            working for Premier Health and I am hoping to start a new career soon.",
                            City = "Xenia",
                            FirstName = "Jeremy",
                            LastName = "Shepherd",
                            State = "Ohio"
                        });
                });

            modelBuilder.Entity("HobbiesFinalProject.Models.VideoGame", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("System")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            Publisher = "Playstation",
                            System = "PlayStation 4",
                            Title = "Uncharted 2: Among Thieves"
                        },
                        new
                        {
                            GameId = 2,
                            Publisher = "Nintendo",
                            System = "Nintendo 64",
                            Title = "GoldenEye 007"
                        },
                        new
                        {
                            GameId = 3,
                            Publisher = "2k Games",
                            System = "PlayStation 4",
                            Title = "BioShock"
                        },
                        new
                        {
                            GameId = 4,
                            Publisher = "Valve",
                            System = "Xbox 360",
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            GameId = 5,
                            Publisher = "Sega",
                            System = "Dreamcast",
                            Title = "NFL 2K1"
                        },
                        new
                        {
                            GameId = 6,
                            Publisher = "Microsoft",
                            System = "Xbox 360",
                            Title = "Halo: Combat Evolved"
                        },
                        new
                        {
                            GameId = 7,
                            Publisher = "Nintendo",
                            System = "Switch",
                            Title = "Super Mario Odyssey"
                        },
                        new
                        {
                            GameId = 8,
                            Publisher = "Rockstar Games",
                            System = "PlayStation 2",
                            Title = "Grand Theft Auto III"
                        },
                        new
                        {
                            GameId = 9,
                            Publisher = "Nintendo",
                            System = "Wii",
                            Title = "Metroid Prime"
                        },
                        new
                        {
                            GameId = 10,
                            Publisher = "Rare",
                            System = "Xbox One",
                            Title = "Perfect Dark"
                        },
                        new
                        {
                            GameId = 11,
                            Publisher = "Neversoft",
                            System = "Game Boy Advance",
                            Title = "Tony Hawk's Pro Skater 3"
                        },
                        new
                        {
                            GameId = 12,
                            Publisher = "Nintendo",
                            System = "Wii U",
                            Title = "The Legend of Zelda: Breath of the Wild"
                        },
                        new
                        {
                            GameId = 13,
                            Publisher = "Rockstar Games",
                            System = "PlayStation 3",
                            Title = "Grand Theft Auto V"
                        },
                        new
                        {
                            GameId = 14,
                            Publisher = "Rockstar Games",
                            System = "Xbox One",
                            Title = "Red Dead Redemption 2"
                        },
                        new
                        {
                            GameId = 15,
                            Publisher = "Nintendo",
                            System = "Wii",
                            Title = "Super Mario Galaxy 2"
                        },
                        new
                        {
                            GameId = 16,
                            Publisher = "Nintendo",
                            System = "Wii",
                            Title = "Super Mario Galaxy"
                        },
                        new
                        {
                            GameId = 17,
                            Publisher = "Bandai Namco Entertainment",
                            System = "Arcade",
                            Title = "SoulCalibur"
                        },
                        new
                        {
                            GameId = 18,
                            Publisher = "Rockstar Games",
                            System = "PlayStation 3",
                            Title = "Grand Theft Auto IV"
                        },
                        new
                        {
                            GameId = 19,
                            Publisher = "Activision",
                            System = "PlayStation",
                            Title = "Tony Hawk's Pro Skater 2"
                        },
                        new
                        {
                            GameId = 20,
                            Publisher = "Nintendo",
                            System = "Nintendo 64",
                            Title = "The Legend of Zelda: Ocarina of Time"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
