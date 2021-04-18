using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesFinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    System = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "MemberId", "About", "City", "FirstName", "LastName", "State" },
                values: new object[,]
                {
                    { 1, "Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.\r\n                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds.", "Cincinnati", "Jamie", "Miozzi", "Ohio" },
                    { 2, "Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.\r\n                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds.", "Cincinnati", "Travis", "Newberry", "Ohio" },
                    { 3, "Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.\r\n                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds.", "Cincinnati", "John", "Praiser", "Ohio" },
                    { 4, "Java id eu skinny coffee as, cultivar variety crema espresso aroma percolator. Galão milk, chicory turkish single shot irish fair trade saucer fair trade. Skinny fair trade, con panna id flavour ristretto aroma eu caramelization. Aromatic milk roast dripper half and half chicory id half and half organic robust crema half and half.\r\n                            Roast steamed shop sugar irish, single shot, affogato irish cultivar to go caramelization affogato. At breve, kopi-luwak iced doppio plunger pot saucer whipped. Strong body, macchiato eu cultivar whipped single shot eu black grounds latte. Roast cortado rich aroma aromatic ut percolator grounds.", "Cincinnati", "Madison", "Rosas", "Ohio" },
                    { 5, "I am a graduate of Sinclair Community College's Software Development program. I have spent the past 19 years \r\n                            working for Premier Health and I am hoping to start a new career soon.", "Xenia", "Jeremy", "Shepherd", "Ohio" }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "GameId", "Publisher", "System", "Title" },
                values: new object[,]
                {
                    { 18, "Rockstar Games", "PlayStation 3", "Grand Theft Auto IV" },
                    { 17, "Bandai Namco Entertainment", "Arcade", "SoulCalibur" },
                    { 16, "Nintendo", "Wii", "Super Mario Galaxy" },
                    { 15, "Nintendo", "Wii", "Super Mario Galaxy 2" },
                    { 14, "Rockstar Games", "Xbox One", "Red Dead Redemption 2" },
                    { 13, "Rockstar Games", "PlayStation 3", "Grand Theft Auto V" },
                    { 12, "Nintendo", "Wii U", "The Legend of Zelda: Breath of the Wild" },
                    { 11, "Neversoft", "Game Boy Advance", "Tony Hawk's Pro Skater 3" },
                    { 10, "Rare", "Xbox One", "Perfect Dark" },
                    { 8, "Rockstar Games", "PlayStation 2", "Grand Theft Auto III" },
                    { 19, "Activision", "PlayStation", "Tony Hawk's Pro Skater 2" },
                    { 7, "Nintendo", "Switch", "Super Mario Odyssey" },
                    { 6, "Microsoft", "Xbox 360", "Halo: Combat Evolved" },
                    { 5, "Sega", "Dreamcast", "NFL 2K1" },
                    { 4, "Valve", "Xbox 360", "Half-Life 2" },
                    { 3, "2k Games", "PlayStation 4", "BioShock" },
                    { 2, "Nintendo", "Nintendo 64", "GoldenEye 007" },
                    { 1, "Playstation", "PlayStation 4", "Uncharted 2: Among Thieves" },
                    { 9, "Nintendo", "Wii", "Metroid Prime" },
                    { 20, "Nintendo", "Nintendo 64", "The Legend of Zelda: Ocarina of Time" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
