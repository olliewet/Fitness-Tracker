using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackHealthAndFitness.Migrations
{
    public partial class addedfitnesstrackertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseTracker",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeOfExercise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalBest = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTracker", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseTracker",
                schema: "Identity");
        }
    }
}
