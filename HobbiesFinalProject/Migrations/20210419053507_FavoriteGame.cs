using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesFinalProject.Migrations
{
    public partial class FavoriteGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "TeamMembers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "MemberId",
                keyValue: 3,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "MemberId",
                keyValue: 4,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "MemberId",
                keyValue: 5,
                column: "GameId",
                value: 1);

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "GameId", "Publisher", "System", "Title" },
                values: new object[] { 21, "Blizard", "Computer", "Starcraft" });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "MemberId",
                keyValue: 2,
                column: "GameId",
                value: 21);

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_GameId",
                table: "TeamMembers",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_VideoGames_GameId",
                table: "TeamMembers",
                column: "GameId",
                principalTable: "VideoGames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_VideoGames_GameId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_GameId",
                table: "TeamMembers");

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "GameId",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "TeamMembers");
        }
    }
}
