using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackHealthAndFitness.Migrations
{
    public partial class AddingRepsColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reps",
                schema: "Identity",
                table: "ExerciseTracker",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reps",
                schema: "Identity",
                table: "ExerciseTracker");
        }
    }
}
