using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackHealthAndFitness.Migrations
{
    public partial class AddingFavExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavExercise",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    exerciseInputID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavExercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavExercise_ExerciseTracker_exerciseInputID",
                        column: x => x.exerciseInputID,
                        principalSchema: "Identity",
                        principalTable: "ExerciseTracker",
                        principalColumn: "InputID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavExercise_exerciseInputID",
                schema: "Identity",
                table: "FavExercise",
                column: "exerciseInputID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavExercise",
                schema: "Identity");
        }
    }
}
