using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentWebs.Migrations
{
    /// <inheritdoc />
    public partial class teacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Teachers");
        }
    }
}
