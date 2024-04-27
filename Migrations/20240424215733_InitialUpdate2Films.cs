using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSIte.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdate2Films : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Films");
        }
    }
}
