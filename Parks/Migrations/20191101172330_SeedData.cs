using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Land = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Land", "Name", "State" },
                values: new object[,]
                {
                    { 1, "National", "Carlsbad Caverns", "NM" },
                    { 2, "National", "Chaco Culture", "NM" },
                    { 3, "National", "Manhattan Project", "NM" },
                    { 4, "National", "Pecos", "NM" },
                    { 5, "National", "Black Canyon Of The Gunnison", "CO" },
                    { 6, "National", "Great Sand Dunes", "CO" },
                    { 7, "National", "Mesa Verde", "CO" },
                    { 8, "National", "Rocky Mountain", "CO" },
                    { 9, "State", "Elephant Butte", "NM" },
                    { 10, "State", "Santa Rosa", "NM" },
                    { 11, "State", "Spinney Mountain", "CO" },
                    { 12, "State", "Castlewood Canyon", "CO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
