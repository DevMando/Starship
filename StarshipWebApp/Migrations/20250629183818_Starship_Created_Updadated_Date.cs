using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarshipWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Starship_Created_Updadated_Date : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Edited",
                table: "Starships",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Starships",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Starships",
                newName: "Edited");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Starships",
                newName: "Created");
        }
    }
}
