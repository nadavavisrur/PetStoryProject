using Microsoft.EntityFrameworkCore.Migrations;

namespace PetStory.Migrations
{
    public partial class update_FB_to_string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "facebookID",
                table: "Owner",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "facebookID",
                table: "Owner");
        }
    }
}
