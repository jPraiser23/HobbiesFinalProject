using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesFinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    System = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    About = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: false),
                    FavoriteGameGameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_TeamMembers_VideoGames_FavoriteGameGameId",
                        column: x => x.FavoriteGameGameId,
                        principalTable: "VideoGames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "MemberId", "About", "City", "FavoriteGameGameId", "FirstName", "GameId", "LastName", "State" },
                values: new object[,]
                {
                    { 1, "Hi my name is Jamie Miozzi. I am from Cleveland Ohio origionally but I've spent the past three years here in Cincinnatti. I am currently a third year student at The University of Cincinnati studying IT software development.", "Cincinnati", null, "Jamie", 1, "Miozzi", "Ohio" },
                    { 2, "My name is Travis and I have been going to UC Clermont following the IT Program. I plan to transfer to main compus in the fall to continue my education. I curently work night shifts at Kroger and enjoy playing chess as well as many video games in my spare time.", "Georgetown", null, "Travis", 3, "Newberry", "Ohio" },
                    { 3, "I am 4th year at the University of Cincinnati. I am planning to graduate next year. I am Software Development major with interests including new technology, software development, and video game development/entertainment.", "Cincinnati", null, "John", 5, "Praiser", "Ohio" },
                    { 4, "I am a 5th year senior at the University of Cincinnati. I am graduating on April 30th! I am an IT major with a focus on Networking/System Administration and Software Development. I currently work part-time for a tech company called Genuen and am transitioning to full time after graduation. I am excited to move on to the 'real world.'", "Cincinnati", null, "Madison", 7, "Rosas", "Ohio" },
                    { 5, @"I am a graduate of Sinclair Community College's Software Development program. I have spent the past 19 years 
                                            working for Premier Health and I am hoping to start a new career soon.", "Xenia", null, "Jeremy", 21, "Shepherd", "Ohio" }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "GameId", "Publisher", "System", "Title" },
                values: new object[,]
                {
                    { 19, "Activision", "PlayStation", "Tony Hawk's Pro Skater 2" },
                    { 18, "Rockstar Games", "PlayStation 3", "Grand Theft Auto IV" },
                    { 17, "Bandai Namco Entertainment", "Arcade", "SoulCalibur" },
                    { 16, "Nintendo", "Wii", "Super Mario Galaxy" },
                    { 15, "Nintendo", "Wii", "Super Mario Galaxy 2" },
                    { 14, "Rockstar Games", "Xbox One", "Red Dead Redemption 2" },
                    { 13, "Rockstar Games", "PlayStation 3", "Grand Theft Auto V" },
                    { 12, "Nintendo", "Wii U", "The Legend of Zelda: Breath of the Wild" },
                    { 11, "Neversoft", "Game Boy Advance", "Tony Hawk's Pro Skater 3" },
                    { 8, "Rockstar Games", "PlayStation 2", "Grand Theft Auto III" },
                    { 9, "Nintendo", "Wii", "Metroid Prime" },
                    { 20, "Nintendo", "Nintendo 64", "The Legend of Zelda: Ocarina of Time" },
                    { 7, "Nintendo", "Switch", "Super Mario Odyssey" },
                    { 6, "Microsoft", "Xbox 360", "Halo: Combat Evolved" },
                    { 5, "Sega", "Dreamcast", "NFL 2K1" },
                    { 4, "Valve", "Xbox 360", "Half-Life 2" },
                    { 3, "2k Games", "PlayStation 4", "BioShock" },
                    { 2, "Nintendo", "Nintendo 64", "GoldenEye 007" },
                    { 1, "Playstation", "PlayStation 4", "Uncharted 2: Among Thieves" },
                    { 10, "Rare", "Xbox One", "Perfect Dark" },
                    { 21, "Naughty Dog", "Playstation 4", "The Last of Us: Remastered" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_FavoriteGameGameId",
                table: "TeamMembers",
                column: "FavoriteGameGameId");
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
