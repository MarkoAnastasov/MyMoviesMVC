using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMoviesMVC.Models.Migrations
{
    public partial class UserMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFavourite",
                table: "UserMovies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsWatched",
                table: "UserMovies",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavourite",
                table: "UserMovies");

            migrationBuilder.DropColumn(
                name: "IsWatched",
                table: "UserMovies");
        }
    }
}
