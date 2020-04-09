using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fatigue",
                table: "MuscleGroupFatigues");

            migrationBuilder.DropColumn(
                name: "MuscleGroup",
                table: "MuscleGroupFatigues");

            migrationBuilder.AddColumn<int>(
                name: "AbsFatigue",
                table: "MuscleGroupFatigues",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArmsFatigue",
                table: "MuscleGroupFatigues",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BackFatigue",
                table: "MuscleGroupFatigues",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChestFatigue",
                table: "MuscleGroupFatigues",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LegsFatigue",
                table: "MuscleGroupFatigues",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShouldersFatigue",
                table: "MuscleGroupFatigues",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArmsFatigue", "BackFatigue", "ChestFatigue", "CurrentTime", "LegsFatigue", "ShouldersFatigue" },
                values: new object[] { 1, 2, 4, new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(8370), 1, 1 });

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArmsFatigue", "BackFatigue", "ChestFatigue", "CurrentTime", "LegsFatigue", "ShouldersFatigue" },
                values: new object[] { 1, 1, 1, new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(9430), 1, 4 });

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArmsFatigue", "BackFatigue", "ChestFatigue", "CurrentTime", "LegsFatigue", "ShouldersFatigue" },
                values: new object[] { 3, 3, 4, new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(9460), 3, 3 });

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArmsFatigue", "BackFatigue", "ChestFatigue", "CurrentTime", "LegsFatigue", "ShouldersFatigue" },
                values: new object[] { 3, 1, 1, new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(9460), 2, 3 });

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArmsFatigue", "BackFatigue", "ChestFatigue", "CurrentTime", "LegsFatigue", "ShouldersFatigue" },
                values: new object[] { 3, 5, 3, new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(9470), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 16, 42, 4, 912, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1130));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbsFatigue",
                table: "MuscleGroupFatigues");

            migrationBuilder.DropColumn(
                name: "ArmsFatigue",
                table: "MuscleGroupFatigues");

            migrationBuilder.DropColumn(
                name: "BackFatigue",
                table: "MuscleGroupFatigues");

            migrationBuilder.DropColumn(
                name: "ChestFatigue",
                table: "MuscleGroupFatigues");

            migrationBuilder.DropColumn(
                name: "LegsFatigue",
                table: "MuscleGroupFatigues");

            migrationBuilder.DropColumn(
                name: "ShouldersFatigue",
                table: "MuscleGroupFatigues");

            migrationBuilder.AddColumn<int>(
                name: "Fatigue",
                table: "MuscleGroupFatigues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MuscleGroup",
                table: "MuscleGroupFatigues",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentTime", "Fatigue", "MuscleGroup" },
                values: new object[] { new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(2660), 3, "Chest" });

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentTime", "Fatigue", "MuscleGroup" },
                values: new object[] { new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(3660), 1, "Shoulders" });

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentTime", "Fatigue", "MuscleGroup" },
                values: new object[] { new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(3690), 1, "Back" });

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentTime", "Fatigue", "MuscleGroup" },
                values: new object[] { new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(3690), 5, "Legs" });

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentTime", "Fatigue", "MuscleGroup" },
                values: new object[] { new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(3700), 1, "Abs" });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 647, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 664, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 664, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 664, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 664, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 664, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 664, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 664, DateTimeKind.Local).AddTicks(6600));
        }
    }
}
