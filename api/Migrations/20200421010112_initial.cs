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
                    WorkoutId = table.Column<int>(nullable: false)
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
                    { 12, 4, "Arms", "Upright Row", 10, 3, 2, 70 },
                    { 4, 3, "Chest", "Decline Bench Press", 10, 3, 1, 100 },
                    { 5, 4, "Back", "Seated Row", 10, 3, 1, 150 },
                    { 6, 2, "Back", "Back Extension", 10, 3, 1, 90 },
                    { 3, 5, "Chest", "Bench Press", 5, 3, 1, 200 },
                    { 8, 4, "Back", "TBar row", 8, 3, 1, 200 },
                    { 9, 4, "Arms", "Hammer Curl", 10, 3, 2, 20 },
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
                    { 4, 18, 2 },
                    { 7, 5, 4 },
                    { 6, 22, 3 },
                    { 5, 21, 3 },
                    { 3, 17, 2 },
                    { 2, 5, 1 },
                    { 1, 1, 1 },
                    { 8, 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "musclegroupfatigue",
                columns: new[] { "Id", "CurrentTime", "Fatigue", "MuscleGroup", "WorkoutId" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(5342), 4, "", 5 },
                    { 3, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(5337), 3, "", 4 },
                    { 4, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(5340), 4, "", 8 },
                    { 1, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(4883), 4, "Chest", 6 },
                    { 2, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(5302), 4, "", 3 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, "a@gmail.com", "a", "a", "a", new byte[] { 131, 185, 200, 35, 150, 226, 72, 63, 14, 215, 73, 94, 245, 246, 245, 61, 208, 194, 163, 239, 114, 152, 57, 55, 40, 173, 128, 180, 76, 190, 21, 142, 177, 214, 138, 189, 179, 253, 217, 209, 223, 89, 39, 33, 78, 95, 135, 117, 88, 167, 60, 198, 100, 62, 253, 110, 227, 44, 59, 241, 160, 235, 236, 138 }, new byte[] { 183, 163, 86, 0, 74, 195, 179, 237, 221, 195, 189, 61, 205, 238, 67, 116, 237, 220, 221, 196, 237, 115, 41, 82, 14, 96, 194, 57, 14, 151, 173, 197, 200, 114, 32, 179, 44, 235, 59, 155, 35, 82, 3, 93, 108, 81, 51, 207, 226, 129, 204, 136, 112, 244, 226, 229, 108, 24, 157, 70, 170, 61, 178, 83, 5, 30, 231, 68, 24, 254, 64, 43, 223, 173, 77, 89, 228, 124, 20, 124, 207, 142, 162, 200, 183, 7, 105, 155, 165, 60, 2, 241, 26, 90, 83, 129, 158, 36, 215, 162, 56, 227, 251, 53, 143, 190, 0, 86, 228, 107, 115, 182, 98, 53, 12, 21, 1, 192, 45, 128, 227, 6, 247, 59, 87, 2, 237, 98 }, "a" },
                    { 2, "b@gmail.com", "b", "b", "b", new byte[] { 16, 75, 133, 96, 3, 126, 63, 191, 212, 99, 146, 119, 2, 248, 100, 152, 196, 132, 57, 110, 208, 12, 159, 22, 210, 205, 3, 211, 31, 183, 106, 129, 93, 70, 210, 152, 254, 115, 135, 42, 84, 174, 181, 19, 108, 109, 37, 14, 63, 134, 127, 250, 253, 156, 163, 164, 132, 106, 147, 186, 14, 92, 80, 22 }, new byte[] { 183, 163, 86, 0, 74, 195, 179, 237, 221, 195, 189, 61, 205, 238, 67, 116, 237, 220, 221, 196, 237, 115, 41, 82, 14, 96, 194, 57, 14, 151, 173, 197, 200, 114, 32, 179, 44, 235, 59, 155, 35, 82, 3, 93, 108, 81, 51, 207, 226, 129, 204, 136, 112, 244, 226, 229, 108, 24, 157, 70, 170, 61, 178, 83, 5, 30, 231, 68, 24, 254, 64, 43, 223, 173, 77, 89, 228, 124, 20, 124, 207, 142, 162, 200, 183, 7, 105, 155, 165, 60, 2, 241, 26, 90, 83, 129, 158, 36, 215, 162, 56, 227, 251, 53, 143, 190, 0, 86, 228, 107, 115, 182, 98, 53, 12, 21, 1, 192, 45, 128, 227, 6, 247, 59, 87, 2, 237, 98 }, "b" }
                });

            migrationBuilder.InsertData(
                table: "workouts",
                columns: new[] { "Id", "IntensityScore", "Name", "Satisfaction", "TimeOfWorkout", "UserId" },
                values: new object[,]
                {
                    { 7, 8, "Arms day", 5, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2971), 2 },
                    { 1, 7, "Upper body day", 5, new DateTime(2020, 4, 20, 18, 1, 12, 395, DateTimeKind.Local).AddTicks(3897), 1 },
                    { 2, 3, "Lower body day", 5, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2910), 1 },
                    { 3, 7, "Shoulder day", 5, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2958), 1 },
                    { 4, 6, "Back day", 5, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2963), 1 },
                    { 5, 4, "Abs day", 5, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2966), 1 },
                    { 6, 8, "Chest day", 5, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2968), 1 },
                    { 8, 6, "Legs day", 5, new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2973), 2 }
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
