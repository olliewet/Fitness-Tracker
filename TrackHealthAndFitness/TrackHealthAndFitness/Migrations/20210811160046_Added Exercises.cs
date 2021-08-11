using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackHealthAndFitness.Migrations
{
    public partial class AddedExercises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DifferentExercise",
                schema: "Identity",
                columns: table => new
                {
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfExercise = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DifferentExercise",
                schema: "Identity");
        }
    }
}
