using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna.Migrations
{
    public partial class SlidersTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Title2 = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BgImg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BtnUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BtnText = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
