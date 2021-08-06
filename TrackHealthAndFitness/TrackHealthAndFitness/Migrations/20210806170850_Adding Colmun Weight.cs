using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackHealthAndFitness.Migrations
{
    public partial class AddingColmunWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                schema: "Identity",
                table: "ExerciseTracker",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                schema: "Identity",
                table: "ExerciseTracker");
        }
    }
}
