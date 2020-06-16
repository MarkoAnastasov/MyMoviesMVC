using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMoviesMVC.Models.Migrations
{
    public partial class CommentIsVerified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "MovieComments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "MovieComments");
        }
    }
}
