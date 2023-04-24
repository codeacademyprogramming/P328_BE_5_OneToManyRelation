using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna.Migrations
{
    public partial class CreateRealtionBwPositionsAndTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_PositionId",
                table: "TeamMembers",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_Positions_PositionId",
                table: "TeamMembers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_Positions_PositionId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_PositionId",
                table: "TeamMembers");
        }
    }
}
