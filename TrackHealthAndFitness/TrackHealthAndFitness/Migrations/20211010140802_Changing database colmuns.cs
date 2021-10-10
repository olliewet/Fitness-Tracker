using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackHealthAndFitness.Migrations
{
    public partial class Changingdatabasecolmuns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavExercise_ExerciseTracker_exerciseInputID",
                schema: "Identity",
                table: "FavExercise");

            migrationBuilder.DropIndex(
                name: "IX_FavExercise_exerciseInputID",
                schema: "Identity",
                table: "FavExercise");

            migrationBuilder.DropColumn(
                name: "exerciseInputID",
                schema: "Identity",
                table: "FavExercise");

            migrationBuilder.AddColumn<string>(
                name: "ExerciseName",
                schema: "Identity",
                table: "FavExercise",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfExercise",
                schema: "Identity",
                table: "FavExercise",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExerciseName",
                schema: "Identity",
                table: "FavExercise");

            migrationBuilder.DropColumn(
                name: "TypeOfExercise",
                schema: "Identity",
                table: "FavExercise");

            migrationBuilder.AddColumn<string>(
                name: "exerciseInputID",
                schema: "Identity",
                table: "FavExercise",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavExercise_exerciseInputID",
                schema: "Identity",
                table: "FavExercise",
                column: "exerciseInputID");

            migrationBuilder.AddForeignKey(
                name: "FK_FavExercise_ExerciseTracker_exerciseInputID",
                schema: "Identity",
                table: "FavExercise",
                column: "exerciseInputID",
                principalSchema: "Identity",
                principalTable: "ExerciseTracker",
                principalColumn: "InputID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
