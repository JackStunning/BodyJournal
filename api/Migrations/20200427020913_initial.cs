using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BodyJournalApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "biometrics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_biometrics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "exercises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Weight = table.Column<int>(nullable: true),
                    Reps = table.Column<int>(nullable: false),
                    Sets = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MuscleGroup = table.Column<string>(nullable: true),
                    Intensity = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "exerciseworkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExerciseId = table.Column<int>(nullable: false),
                    WorkoutId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exerciseworkouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "musclegroupfatigue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MuscleGroup = table.Column<string>(nullable: true),
                    Fatigue = table.Column<int>(nullable: false),
                    CurrentTime = table.Column<DateTime>(nullable: false),
                    WorkoutId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musclegroupfatigue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "workouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TimeOfWorkout = table.Column<DateTime>(nullable: false),
                    Satisfaction = table.Column<int>(nullable: false),
                    IntensityScore = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "exercises",
                columns: new[] { "Id", "Intensity", "MuscleGroup", "Name", "Reps", "Sets", "UserId", "Weight" },
                values: new object[,]
                {
                    { 1, 3, "Chest", "Wide Pushup", 10, 3, 1, null },
                    { 24, 3, "Shoulders", "Side Lateral Raise", 10, 3, 1, 35 },
                    { 23, 3, "Shoulders", "Military Press", 10, 3, 1, 70 },
                    { 22, 3, "Shoulders", "Barbell Shoulder Press", 10, 3, 1, 70 },
                    { 21, 4, "Shoulders", "Dumbell Shoulder Press", 10, 3, 1, 35 },
                    { 20, 4, "Legs", "DeadLift", 10, 3, 1, 160 },
                    { 19, 3, "Legs", "Lunge", 10, 3, 1, 40 },
                    { 18, 1, "Legs", "Calf Raise", 10, 3, 1, 40 },
                    { 17, 2, "Legs", "Squat", 10, 3, 1, null },
                    { 15, 3, "Abs", "Bicycle", 25, 3, 1, null },
                    { 14, 2, "Abs", "Plank", 1, 3, 1, null },
                    { 13, 2, "Abs", "Sit Up", 10, 3, 1, null },
                    { 16, 2, "Abs", "Leg Rasises", 15, 3, 1, null },
                    { 11, 4, "Arms", "Tricep Extension", 10, 3, 1, 20 },
                    { 2, 4, "Chest", "Narrow Pushup", 10, 3, 1, null },
                    { 12, 4, "Arms", "Upright Row", 10, 3, 1, 70 },
                    { 4, 3, "Chest", "Decline Bench Press", 10, 3, 1, 100 },
                    { 5, 4, "Back", "Seated Row", 10, 3, 1, 150 },
                    { 6, 2, "Back", "Back Extension", 10, 3, 1, 90 },
                    { 3, 5, "Chest", "Bench Press", 5, 3, 1, 200 },
                    { 8, 4, "Back", "TBar row", 8, 3, 1, 200 },
                    { 9, 4, "Arms", "Hammer Curl", 10, 3, 1, 20 },
                    { 10, 4, "Arms", "Rotating Curl", 10, 3, 1, 20 },
                    { 7, 5, "Back", "Deadlift", 5, 3, 1, 300 }
                });

            migrationBuilder.InsertData(
                table: "exerciseworkouts",
                columns: new[] { "Id", "ExerciseId", "WorkoutId" },
                values: new object[,]
                {
                    { 10, 14, 5 },
                    { 16, 20, 8 },
                    { 15, 17, 8 },
                    { 14, 11, 7 },
                    { 13, 9, 7 },
                    { 12, 4, 6 },
                    { 11, 3, 6 },
                    { 9, 13, 5 },
                    { 3, 17, 2 },
                    { 7, 5, 4 },
                    { 6, 22, 3 },
                    { 5, 21, 3 },
                    { 4, 18, 2 },
                    { 2, 5, 1 },
                    { 1, 1, 1 },
                    { 8, 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "musclegroupfatigue",
                columns: new[] { "Id", "CurrentTime", "Fatigue", "MuscleGroup", "UserId", "WorkoutId" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(1124), 4, "", 1, 5 },
                    { 3, new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(1118), 3, "", 1, 4 },
                    { 4, new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(1121), 4, "", 1, 8 },
                    { 1, new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(510), 4, "Chest", 1, 6 },
                    { 2, new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(1094), 4, "", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { 1, "a@gmail.com", "a", "a", "a", new byte[] { 161, 129, 69, 24, 131, 168, 134, 167, 152, 19, 116, 145, 17, 159, 103, 107, 59, 14, 243, 230, 179, 172, 123, 231, 40, 216, 99, 120, 26, 131, 186, 184, 184, 28, 11, 153, 13, 184, 188, 98, 34, 193, 45, 230, 106, 191, 109, 132, 48, 208, 138, 22, 120, 36, 248, 49, 74, 199, 201, 103, 167, 193, 170, 139 }, new byte[] { 57, 62, 250, 216, 113, 184, 103, 75, 206, 195, 117, 49, 137, 55, 14, 36, 121, 147, 209, 43, 4, 215, 107, 204, 110, 216, 92, 216, 227, 29, 95, 220, 181, 143, 81, 53, 64, 63, 132, 235, 64, 130, 176, 80, 73, 21, 243, 0, 155, 68, 253, 162, 182, 228, 246, 253, 152, 213, 243, 99, 220, 152, 228, 22, 233, 159, 94, 86, 238, 68, 17, 11, 33, 162, 39, 0, 157, 5, 254, 3, 238, 176, 102, 184, 245, 122, 151, 199, 33, 28, 184, 112, 174, 250, 78, 89, 107, 168, 168, 59, 7, 186, 72, 55, 82, 54, 193, 143, 182, 152, 54, 129, 43, 46, 81, 253, 98, 188, 89, 0, 171, 40, 0, 78, 28, 126, 231, 217 }, "a" });

            migrationBuilder.InsertData(
                table: "workouts",
                columns: new[] { "Id", "IntensityScore", "Name", "Satisfaction", "TimeOfWorkout", "UserId" },
                values: new object[,]
                {
                    { 7, 8, "Arms day", 5, new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8632), 1 },
                    { 1, 7, "Upper body day", 5, new DateTime(2020, 4, 26, 19, 9, 13, 738, DateTimeKind.Local).AddTicks(9841), 1 },
                    { 2, 3, "Lower body day", 5, new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8572), 1 },
                    { 3, 7, "Shoulder day", 5, new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8620), 1 },
                    { 4, 6, "Back day", 5, new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8625), 1 },
                    { 5, 4, "Abs day", 5, new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8627), 1 },
                    { 6, 8, "Chest day", 5, new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8630), 1 },
                    { 8, 6, "Legs day", 5, new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8635), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "biometrics");

            migrationBuilder.DropTable(
                name: "exercises");

            migrationBuilder.DropTable(
                name: "exerciseworkouts");

            migrationBuilder.DropTable(
                name: "musclegroupfatigue");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "workouts");
        }
    }
}
