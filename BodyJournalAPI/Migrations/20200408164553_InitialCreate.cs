using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 8, 9, 45, 52, 665, DateTimeKind.Local).AddTicks(3700));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "MuscleGroupFatigues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrentTime",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 239, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 240, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfWorkout",
                value: new DateTime(2020, 4, 7, 12, 26, 25, 241, DateTimeKind.Local).AddTicks(40));
        }
    }
}
