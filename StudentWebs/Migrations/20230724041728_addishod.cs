using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentWebs.Migrations
{
    /// <inheritdoc />
    public partial class addishod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHod",
                table: "Teachers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHod",
                table: "Teachers");
        }
    }
}
