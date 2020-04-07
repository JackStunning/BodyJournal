using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biometrics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biometrics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Weight = table.Column<int>(nullable: true),
                    Reps = table.Column<int>(nullable: false),
                    Sets = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MuscleGroup = table.Column<string>(nullable: true),
                    Intensity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseWorkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExerciseId = table.Column<int>(nullable: false),
                    WorkoutId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseWorkouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MuscleGroupFatigues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MuscleGroup = table.Column<string>(nullable: true),
                    Fatigue = table.Column<int>(nullable: false),
                    CurrentTime = table.Column<DateTime>(nullable: false),
                    WorkoutId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroupFatigues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TimeOfWorkout = table.Column<DateTime>(nullable: false),
                    Satisfaction = table.Column<int>(nullable: false),
                    IntensityScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ExerciseWorkouts",
                columns: new[] { "Id", "ExerciseId", "WorkoutId" },
                values: new object[,]
                {
                    { 3, 17, 2 },
                    { 1, 1, 1 },
                    { 2, 5, 1 },
                    { 4, 18, 2 },
                    { 5, 21, 3 },
                    { 6, 22, 3 },
                    { 7, 5, 4 },
                    { 9, 13, 5 },
                    { 8, 6, 4 },
                    { 11, 3, 6 },
                    { 12, 4, 6 },
                    { 13, 9, 7 },
                    { 14, 11, 7 },
                    { 15, 17, 8 },
                    { 16, 20, 8 },
                    { 10, 14, 5 }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Intensity", "MuscleGroup", "Name", "Reps", "Sets", "Weight" },
                values: new object[,]
                {
                    { 22, 3, "Shoulders", "Barbell Shoulder Press", 10, 3, 70 },
                    { 24, 3, "Shoulders", "Side Lateral Raise", 10, 3, 35 },
                    { 23, 3, "Shoulders", "Military Press", 10, 3, 70 },
                    { 21, 4, "Shoulders", "Dumbell Shoulder Press", 10, 3, 35 },
                    { 1, 3, "Chest", "Wide Pushup", 10, 3, null },
                    { 19, 3, "Legs", "Lunge", 10, 3, 40 },
                    { 2, 4, "Chest", "Narrow Pushup", 10, 3, null },
                    { 3, 5, "Chest", "Bench Press", 5, 3, 200 },
                    { 4, 3, "Chest", "Decline Bench Press", 10, 3, 100 },
                    { 20, 4, "Legs", "DeadLift", 10, 3, 160 },
                    { 6, 2, "Back", "Back Extension", 10, 3, 90 },
                    { 7, 5, "Back", "Deadlift", 5, 3, 300 },
                    { 8, 4, "Back", "TBar row", 8, 3, 200 },
                    { 9, 4, "Arms", "Hammer Curl", 10, 3, 20 },
                    { 10, 4, "Arms", "Rotating Curl", 10, 3, 20 },
                    { 5, 4, "Back", "Seated Row", 10, 3, 150 },
                    { 12, 4, "Arms", "Upright Row", 10, 3, 70 },
                    { 13, 2, "Abs", "Sit Up", 10, 3, null },
                    { 14, 2, "Abs", "Plank", 1, 3, null },
                    { 15, 3, "Abs", "Bicycle", 25, 3, null },
                    { 16, 2, "Abs", "Leg Rasises", 15, 3, null },
                    { 17, 2, "Legs", "Squat", 10, 3, null },
                    { 18, 1, "Legs", "Calf Raise", 10, 3, 40 },
                    { 11, 4, "Arms", "Tricep Extension", 10, 3, 20 }
                });

            migrationBuilder.InsertData(
                table: "MuscleGroupFatigues",
                columns: new[] { "Id", "CurrentTime", "Fatigue", "MuscleGroup", "WorkoutId" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(2408), 1, "Abs", 5 },
                    { 4, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(2405), 5, "Legs", 8 },
                    { 3, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(2402), 1, "Back", 4 },
                    { 1, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(1960), 3, "Chest", 6 },
                    { 2, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(2378), 1, "Shoulders", 3 }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "IntensityScore", "Name", "Satisfaction", "TimeOfWorkout" },
                values: new object[,]
                {
                    { 7, 8, "Arms day", 5, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(37) },
                    { 1, 7, "Upper body day", 5, new DateTime(2020, 4, 7, 12, 26, 25, 239, DateTimeKind.Local).AddTicks(695) },
                    { 2, 3, "Lower body day", 5, new DateTime(2020, 4, 7, 12, 26, 25, 240, DateTimeKind.Local).AddTicks(9980) },
                    { 3, 7, "Shoulder day", 5, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(24) },
                    { 4, 6, "Back day", 5, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(30) },
                    { 5, 4, "Abs day", 5, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(32) },
                    { 6, 8, "Chest day", 5, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(35) },
                    { 8, 6, "Legs day", 5, new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(40) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biometrics");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "ExerciseWorkouts");

            migrationBuilder.DropTable(
                name: "MuscleGroupFatigues");

            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
