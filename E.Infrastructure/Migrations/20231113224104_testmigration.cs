using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    NumeroLicence = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cathegory = table.Column<int>(type: "int", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomAthlete = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrenomAthlete = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => x.NumeroLicence);
                });

            migrationBuilder.CreateTable(
                name: "Piscines",
                columns: table => new
                {
                    NumPiscine = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomPiscine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdressePiscine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piscines", x => x.NumPiscine);
                });

            migrationBuilder.CreateTable(
                name: "Entrainements",
                columns: table => new
                {
                    NumEntrainement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEntrainement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiastanceAParcourir = table.Column<int>(type: "int", nullable: false),
                    NombreSeance = table.Column<int>(type: "int", nullable: false),
                    PiscineNumPiscine = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrainements", x => x.NumEntrainement);
                    table.ForeignKey(
                        name: "FK_Entrainements_Piscines_PiscineNumPiscine",
                        column: x => x.PiscineNumPiscine,
                        principalTable: "Piscines",
                        principalColumn: "NumPiscine",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanEntrainements",
                columns: table => new
                {
                    IdPlanEntrainement = table.Column<int>(type: "int", nullable: false),
                    NumEntrainementFk = table.Column<int>(type: "int", nullable: false),
                    NumLicenceFk = table.Column<int>(type: "int", nullable: false),
                    DistanceParcourue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanEntrainements", x => new { x.IdPlanEntrainement, x.NumEntrainementFk, x.NumLicenceFk });
                    table.ForeignKey(
                        name: "FK_PlanEntrainements_Athletes_NumLicenceFk",
                        column: x => x.NumLicenceFk,
                        principalTable: "Athletes",
                        principalColumn: "NumeroLicence",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanEntrainements_Entrainements_NumEntrainementFk",
                        column: x => x.NumEntrainementFk,
                        principalTable: "Entrainements",
                        principalColumn: "NumEntrainement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrainements_PiscineNumPiscine",
                table: "Entrainements",
                column: "PiscineNumPiscine");

            migrationBuilder.CreateIndex(
                name: "IX_PlanEntrainements_NumEntrainementFk",
                table: "PlanEntrainements",
                column: "NumEntrainementFk");

            migrationBuilder.CreateIndex(
                name: "IX_PlanEntrainements_NumLicenceFk",
                table: "PlanEntrainements",
                column: "NumLicenceFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanEntrainements");

            migrationBuilder.DropTable(
                name: "Athletes");

            migrationBuilder.DropTable(
                name: "Entrainements");

            migrationBuilder.DropTable(
                name: "Piscines");
        }
    }
}
