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
                    BackFatigue = table.Column<int>(nullable: false),
                    ChestFatigue = table.Column<int>(nullable: false),
                    ArmsFatigue = table.Column<int>(nullable: false),
                    AbsFatigue = table.Column<int>(nullable: false),
                    LegsFatigue = table.Column<int>(nullable: false),
                    ShouldersFatigue = table.Column<int>(nullable: false),
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
                columns: new[] { "Id", "AbsFatigue", "ArmsFatigue", "BackFatigue", "ChestFatigue", "CurrentTime", "LegsFatigue", "ShouldersFatigue", "WorkoutId" },
                values: new object[,]
                {
                    { 5, 0, 3, 5, 3, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(3470), 3, 5, 5 },
                    { 3, 0, 3, 3, 4, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(3464), 3, 3, 4 },
                    { 4, 0, 3, 1, 1, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(3467), 2, 3, 8 },
                    { 1, 0, 1, 2, 4, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(3020), 1, 1, 6 },
                    { 2, 0, 1, 1, 1, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(3444), 1, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, "a@gmail.com", "a", "a", "a", new byte[] { 213, 230, 46, 198, 77, 232, 89, 31, 30, 215, 237, 65, 45, 140, 199, 180, 38, 24, 25, 123, 72, 150, 123, 127, 152, 159, 229, 148, 58, 145, 154, 239, 83, 22, 6, 180, 191, 104, 219, 31, 41, 53, 45, 92, 118, 232, 98, 137, 65, 191, 248, 139, 1, 49, 28, 221, 152, 221, 71, 62, 250, 142, 86, 53 }, new byte[] { 152, 226, 225, 155, 182, 95, 252, 27, 171, 17, 195, 99, 234, 159, 225, 249, 121, 125, 70, 103, 37, 121, 172, 233, 166, 226, 155, 217, 197, 45, 161, 117, 207, 127, 223, 93, 73, 194, 176, 30, 75, 165, 223, 130, 12, 172, 153, 176, 2, 148, 210, 95, 206, 133, 225, 243, 39, 150, 86, 3, 226, 44, 245, 73, 18, 27, 186, 178, 241, 49, 78, 178, 153, 32, 71, 159, 196, 125, 221, 17, 71, 47, 10, 64, 212, 197, 122, 157, 92, 187, 237, 43, 102, 103, 251, 218, 135, 142, 156, 218, 16, 69, 96, 172, 204, 34, 211, 204, 111, 72, 81, 27, 160, 143, 166, 88, 72, 59, 188, 199, 227, 51, 156, 219, 202, 105, 140, 75 }, "a" },
                    { 2, "b@gmail.com", "b", "b", "b", new byte[] { 144, 135, 101, 128, 23, 168, 238, 94, 254, 128, 202, 91, 63, 59, 92, 138, 72, 85, 236, 55, 14, 53, 107, 117, 192, 243, 79, 136, 181, 4, 26, 12, 95, 205, 232, 66, 218, 73, 201, 161, 107, 217, 113, 81, 236, 33, 135, 160, 192, 195, 118, 178, 7, 83, 174, 20, 222, 115, 250, 222, 184, 197, 21, 211 }, new byte[] { 152, 226, 225, 155, 182, 95, 252, 27, 171, 17, 195, 99, 234, 159, 225, 249, 121, 125, 70, 103, 37, 121, 172, 233, 166, 226, 155, 217, 197, 45, 161, 117, 207, 127, 223, 93, 73, 194, 176, 30, 75, 165, 223, 130, 12, 172, 153, 176, 2, 148, 210, 95, 206, 133, 225, 243, 39, 150, 86, 3, 226, 44, 245, 73, 18, 27, 186, 178, 241, 49, 78, 178, 153, 32, 71, 159, 196, 125, 221, 17, 71, 47, 10, 64, 212, 197, 122, 157, 92, 187, 237, 43, 102, 103, 251, 218, 135, 142, 156, 218, 16, 69, 96, 172, 204, 34, 211, 204, 111, 72, 81, 27, 160, 143, 166, 88, 72, 59, 188, 199, 227, 51, 156, 219, 202, 105, 140, 75 }, "b" }
                });

            migrationBuilder.InsertData(
                table: "workouts",
                columns: new[] { "Id", "IntensityScore", "Name", "Satisfaction", "TimeOfWorkout", "UserId" },
                values: new object[,]
                {
                    { 7, 8, "Arms day", 5, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(520), 2 },
                    { 1, 7, "Upper body day", 5, new DateTime(2020, 4, 11, 15, 53, 22, 95, DateTimeKind.Local).AddTicks(1644), 1 },
                    { 2, 3, "Lower body day", 5, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(456), 1 },
                    { 3, 7, "Shoulder day", 5, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(506), 1 },
                    { 4, 6, "Back day", 5, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(512), 1 },
                    { 5, 4, "Abs day", 5, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(514), 1 },
                    { 6, 8, "Chest day", 5, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(517), 1 },
                    { 8, 6, "Legs day", 5, new DateTime(2020, 4, 11, 15, 53, 22, 97, DateTimeKind.Local).AddTicks(523), 2 }
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
