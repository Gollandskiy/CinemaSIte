using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSIte.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdateFilms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Films");
        }
    }
}
