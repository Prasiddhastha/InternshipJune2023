using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsApplication.Migrations
{
    /// <inheritdoc />
    public partial class adresschange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Students",
                newName: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Students",
                newName: "Adress");
        }
    }
}
