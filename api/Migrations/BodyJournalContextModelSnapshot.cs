﻿// <auto-generated />
using System;
using BodyJournalAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BodyJournalApi.Migrations
{
    [DbContext(typeof(BodyJournalContext))]
    partial class BodyJournalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BodyJournalAPI.Entities.Biometric", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("biometrics");
                });

            modelBuilder.Entity("BodyJournalAPI.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Intensity")
                        .HasColumnType("int");

                    b.Property<string>("MuscleGroup")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Intensity = 3,
                            MuscleGroup = "Chest",
                            Name = "Wide Pushup",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Intensity = 4,
                            MuscleGroup = "Chest",
                            Name = "Narrow Pushup",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Intensity = 5,
                            MuscleGroup = "Chest",
                            Name = "Bench Press",
                            Reps = 5,
                            Sets = 3,
                            UserId = 1,
                            Weight = 200
                        },
                        new
                        {
                            Id = 4,
                            Intensity = 3,
                            MuscleGroup = "Chest",
                            Name = "Decline Bench Press",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 100
                        },
                        new
                        {
                            Id = 5,
                            Intensity = 4,
                            MuscleGroup = "Back",
                            Name = "Seated Row",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 150
                        },
                        new
                        {
                            Id = 6,
                            Intensity = 2,
                            MuscleGroup = "Back",
                            Name = "Back Extension",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 90
                        },
                        new
                        {
                            Id = 7,
                            Intensity = 5,
                            MuscleGroup = "Back",
                            Name = "Deadlift",
                            Reps = 5,
                            Sets = 3,
                            UserId = 1,
                            Weight = 300
                        },
                        new
                        {
                            Id = 8,
                            Intensity = 4,
                            MuscleGroup = "Back",
                            Name = "TBar row",
                            Reps = 8,
                            Sets = 3,
                            UserId = 1,
                            Weight = 200
                        },
                        new
                        {
                            Id = 9,
                            Intensity = 4,
                            MuscleGroup = "Arms",
                            Name = "Hammer Curl",
                            Reps = 10,
                            Sets = 3,
                            UserId = 2,
                            Weight = 20
                        },
                        new
                        {
                            Id = 10,
                            Intensity = 4,
                            MuscleGroup = "Arms",
                            Name = "Rotating Curl",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 20
                        },
                        new
                        {
                            Id = 11,
                            Intensity = 4,
                            MuscleGroup = "Arms",
                            Name = "Tricep Extension",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 20
                        },
                        new
                        {
                            Id = 12,
                            Intensity = 4,
                            MuscleGroup = "Arms",
                            Name = "Upright Row",
                            Reps = 10,
                            Sets = 3,
                            UserId = 2,
                            Weight = 70
                        },
                        new
                        {
                            Id = 13,
                            Intensity = 2,
                            MuscleGroup = "Abs",
                            Name = "Sit Up",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 14,
                            Intensity = 2,
                            MuscleGroup = "Abs",
                            Name = "Plank",
                            Reps = 1,
                            Sets = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 15,
                            Intensity = 3,
                            MuscleGroup = "Abs",
                            Name = "Bicycle",
                            Reps = 25,
                            Sets = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 16,
                            Intensity = 2,
                            MuscleGroup = "Abs",
                            Name = "Leg Rasises",
                            Reps = 15,
                            Sets = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 17,
                            Intensity = 2,
                            MuscleGroup = "Legs",
                            Name = "Squat",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 18,
                            Intensity = 1,
                            MuscleGroup = "Legs",
                            Name = "Calf Raise",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 40
                        },
                        new
                        {
                            Id = 19,
                            Intensity = 3,
                            MuscleGroup = "Legs",
                            Name = "Lunge",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 40
                        },
                        new
                        {
                            Id = 20,
                            Intensity = 4,
                            MuscleGroup = "Legs",
                            Name = "DeadLift",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 160
                        },
                        new
                        {
                            Id = 21,
                            Intensity = 4,
                            MuscleGroup = "Shoulders",
                            Name = "Dumbell Shoulder Press",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 35
                        },
                        new
                        {
                            Id = 22,
                            Intensity = 3,
                            MuscleGroup = "Shoulders",
                            Name = "Barbell Shoulder Press",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 70
                        },
                        new
                        {
                            Id = 23,
                            Intensity = 3,
                            MuscleGroup = "Shoulders",
                            Name = "Military Press",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 70
                        },
                        new
                        {
                            Id = 24,
                            Intensity = 3,
                            MuscleGroup = "Shoulders",
                            Name = "Side Lateral Raise",
                            Reps = 10,
                            Sets = 3,
                            UserId = 1,
                            Weight = 35
                        });
                });

            modelBuilder.Entity("BodyJournalAPI.Entities.ExerciseWorkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("exerciseworkouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExerciseId = 1,
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExerciseId = 5,
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 3,
                            ExerciseId = 17,
                            WorkoutId = 2
                        },
                        new
                        {
                            Id = 4,
                            ExerciseId = 18,
                            WorkoutId = 2
                        },
                        new
                        {
                            Id = 5,
                            ExerciseId = 21,
                            WorkoutId = 3
                        },
                        new
                        {
                            Id = 6,
                            ExerciseId = 22,
                            WorkoutId = 3
                        },
                        new
                        {
                            Id = 7,
                            ExerciseId = 5,
                            WorkoutId = 4
                        },
                        new
                        {
                            Id = 8,
                            ExerciseId = 6,
                            WorkoutId = 4
                        },
                        new
                        {
                            Id = 9,
                            ExerciseId = 13,
                            WorkoutId = 5
                        },
                        new
                        {
                            Id = 10,
                            ExerciseId = 14,
                            WorkoutId = 5
                        },
                        new
                        {
                            Id = 11,
                            ExerciseId = 3,
                            WorkoutId = 6
                        },
                        new
                        {
                            Id = 12,
                            ExerciseId = 4,
                            WorkoutId = 6
                        },
                        new
                        {
                            Id = 13,
                            ExerciseId = 9,
                            WorkoutId = 7
                        },
                        new
                        {
                            Id = 14,
                            ExerciseId = 11,
                            WorkoutId = 7
                        },
                        new
                        {
                            Id = 15,
                            ExerciseId = 17,
                            WorkoutId = 8
                        },
                        new
                        {
                            Id = 16,
                            ExerciseId = 20,
                            WorkoutId = 8
                        });
                });

            modelBuilder.Entity("BodyJournalAPI.Entities.MuscleGroupFatigue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CurrentTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Fatigue")
                        .HasColumnType("int");

                    b.Property<string>("MuscleGroup")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("musclegroupfatigue");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentTime = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(4883),
                            Fatigue = 4,
                            MuscleGroup = "Chest",
                            WorkoutId = 6
                        },
                        new
                        {
                            Id = 2,
                            CurrentTime = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(5302),
                            Fatigue = 4,
                            MuscleGroup = "",
                            WorkoutId = 3
                        },
                        new
                        {
                            Id = 3,
                            CurrentTime = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(5337),
                            Fatigue = 3,
                            MuscleGroup = "",
                            WorkoutId = 4
                        },
                        new
                        {
                            Id = 4,
                            CurrentTime = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(5340),
                            Fatigue = 4,
                            MuscleGroup = "",
                            WorkoutId = 8
                        },
                        new
                        {
                            Id = 5,
                            CurrentTime = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(5342),
                            Fatigue = 4,
                            MuscleGroup = "",
                            WorkoutId = 5
                        });
                });

            modelBuilder.Entity("BodyJournalAPI.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("longblob");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "a@gmail.com",
                            FirstName = "a",
                            LastName = "a",
                            Password = "a",
                            PasswordHash = new byte[] { 131, 185, 200, 35, 150, 226, 72, 63, 14, 215, 73, 94, 245, 246, 245, 61, 208, 194, 163, 239, 114, 152, 57, 55, 40, 173, 128, 180, 76, 190, 21, 142, 177, 214, 138, 189, 179, 253, 217, 209, 223, 89, 39, 33, 78, 95, 135, 117, 88, 167, 60, 198, 100, 62, 253, 110, 227, 44, 59, 241, 160, 235, 236, 138 },
                            PasswordSalt = new byte[] { 183, 163, 86, 0, 74, 195, 179, 237, 221, 195, 189, 61, 205, 238, 67, 116, 237, 220, 221, 196, 237, 115, 41, 82, 14, 96, 194, 57, 14, 151, 173, 197, 200, 114, 32, 179, 44, 235, 59, 155, 35, 82, 3, 93, 108, 81, 51, 207, 226, 129, 204, 136, 112, 244, 226, 229, 108, 24, 157, 70, 170, 61, 178, 83, 5, 30, 231, 68, 24, 254, 64, 43, 223, 173, 77, 89, 228, 124, 20, 124, 207, 142, 162, 200, 183, 7, 105, 155, 165, 60, 2, 241, 26, 90, 83, 129, 158, 36, 215, 162, 56, 227, 251, 53, 143, 190, 0, 86, 228, 107, 115, 182, 98, 53, 12, 21, 1, 192, 45, 128, 227, 6, 247, 59, 87, 2, 237, 98 },
                            UserName = "a"
                        },
                        new
                        {
                            Id = 2,
                            Email = "b@gmail.com",
                            FirstName = "b",
                            LastName = "b",
                            Password = "b",
                            PasswordHash = new byte[] { 16, 75, 133, 96, 3, 126, 63, 191, 212, 99, 146, 119, 2, 248, 100, 152, 196, 132, 57, 110, 208, 12, 159, 22, 210, 205, 3, 211, 31, 183, 106, 129, 93, 70, 210, 152, 254, 115, 135, 42, 84, 174, 181, 19, 108, 109, 37, 14, 63, 134, 127, 250, 253, 156, 163, 164, 132, 106, 147, 186, 14, 92, 80, 22 },
                            PasswordSalt = new byte[] { 183, 163, 86, 0, 74, 195, 179, 237, 221, 195, 189, 61, 205, 238, 67, 116, 237, 220, 221, 196, 237, 115, 41, 82, 14, 96, 194, 57, 14, 151, 173, 197, 200, 114, 32, 179, 44, 235, 59, 155, 35, 82, 3, 93, 108, 81, 51, 207, 226, 129, 204, 136, 112, 244, 226, 229, 108, 24, 157, 70, 170, 61, 178, 83, 5, 30, 231, 68, 24, 254, 64, 43, 223, 173, 77, 89, 228, 124, 20, 124, 207, 142, 162, 200, 183, 7, 105, 155, 165, 60, 2, 241, 26, 90, 83, 129, 158, 36, 215, 162, 56, 227, 251, 53, 143, 190, 0, 86, 228, 107, 115, 182, 98, 53, 12, 21, 1, 192, 45, 128, 227, 6, 247, 59, 87, 2, 237, 98 },
                            UserName = "b"
                        });
                });

            modelBuilder.Entity("BodyJournalAPI.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IntensityScore")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Satisfaction")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfWorkout")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("workouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IntensityScore = 7,
                            Name = "Upper body day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 20, 18, 1, 12, 395, DateTimeKind.Local).AddTicks(3897),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            IntensityScore = 3,
                            Name = "Lower body day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2910),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            IntensityScore = 7,
                            Name = "Shoulder day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2958),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            IntensityScore = 6,
                            Name = "Back day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2963),
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            IntensityScore = 4,
                            Name = "Abs day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2966),
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            IntensityScore = 8,
                            Name = "Chest day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2968),
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            IntensityScore = 8,
                            Name = "Arms day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2971),
                            UserId = 2
                        },
                        new
                        {
                            Id = 8,
                            IntensityScore = 6,
                            Name = "Legs day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 20, 18, 1, 12, 397, DateTimeKind.Local).AddTicks(2973),
                            UserId = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
