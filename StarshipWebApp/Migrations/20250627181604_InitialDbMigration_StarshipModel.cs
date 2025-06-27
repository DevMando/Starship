using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarshipWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbMigration_StarshipModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostInCredits = table.Column<long>(type: "bigint", nullable: false),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxAtmospheringSpeed = table.Column<int>(type: "int", nullable: true),
                    Crew = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passengers = table.Column<int>(type: "int", nullable: true),
                    CargoCapacity = table.Column<long>(type: "bigint", nullable: true),
                    Consumables = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HyperdriveRating = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    MGLT = table.Column<int>(type: "int", nullable: true),
                    StarshipClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarshipClassId = table.Column<int>(type: "int", nullable: true),
                    Pilots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Films = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Starships");
        }
    }
}
