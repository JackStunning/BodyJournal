﻿// <auto-generated />
using System;
using BodyJournalAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BodyJournalApi.Migrations
{
    [DbContext(typeof(BodyJournalContext))]
    [Migration("20200427020913_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            UserId = 1,
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
                            UserId = 1,
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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("musclegroupfatigue");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentTime = new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(510),
                            Fatigue = 4,
                            MuscleGroup = "Chest",
                            UserId = 1,
                            WorkoutId = 6
                        },
                        new
                        {
                            Id = 2,
                            CurrentTime = new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(1094),
                            Fatigue = 4,
                            MuscleGroup = "",
                            UserId = 1,
                            WorkoutId = 3
                        },
                        new
                        {
                            Id = 3,
                            CurrentTime = new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(1118),
                            Fatigue = 3,
                            MuscleGroup = "",
                            UserId = 1,
                            WorkoutId = 4
                        },
                        new
                        {
                            Id = 4,
                            CurrentTime = new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(1121),
                            Fatigue = 4,
                            MuscleGroup = "",
                            UserId = 1,
                            WorkoutId = 8
                        },
                        new
                        {
                            Id = 5,
                            CurrentTime = new DateTime(2020, 4, 26, 19, 9, 13, 741, DateTimeKind.Local).AddTicks(1124),
                            Fatigue = 4,
                            MuscleGroup = "",
                            UserId = 1,
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
                            PasswordHash = new byte[] { 161, 129, 69, 24, 131, 168, 134, 167, 152, 19, 116, 145, 17, 159, 103, 107, 59, 14, 243, 230, 179, 172, 123, 231, 40, 216, 99, 120, 26, 131, 186, 184, 184, 28, 11, 153, 13, 184, 188, 98, 34, 193, 45, 230, 106, 191, 109, 132, 48, 208, 138, 22, 120, 36, 248, 49, 74, 199, 201, 103, 167, 193, 170, 139 },
                            PasswordSalt = new byte[] { 57, 62, 250, 216, 113, 184, 103, 75, 206, 195, 117, 49, 137, 55, 14, 36, 121, 147, 209, 43, 4, 215, 107, 204, 110, 216, 92, 216, 227, 29, 95, 220, 181, 143, 81, 53, 64, 63, 132, 235, 64, 130, 176, 80, 73, 21, 243, 0, 155, 68, 253, 162, 182, 228, 246, 253, 152, 213, 243, 99, 220, 152, 228, 22, 233, 159, 94, 86, 238, 68, 17, 11, 33, 162, 39, 0, 157, 5, 254, 3, 238, 176, 102, 184, 245, 122, 151, 199, 33, 28, 184, 112, 174, 250, 78, 89, 107, 168, 168, 59, 7, 186, 72, 55, 82, 54, 193, 143, 182, 152, 54, 129, 43, 46, 81, 253, 98, 188, 89, 0, 171, 40, 0, 78, 28, 126, 231, 217 },
                            UserName = "a"
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
                            TimeOfWorkout = new DateTime(2020, 4, 26, 19, 9, 13, 738, DateTimeKind.Local).AddTicks(9841),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            IntensityScore = 3,
                            Name = "Lower body day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8572),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            IntensityScore = 7,
                            Name = "Shoulder day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8620),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            IntensityScore = 6,
                            Name = "Back day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8625),
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            IntensityScore = 4,
                            Name = "Abs day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8627),
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            IntensityScore = 8,
                            Name = "Chest day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8630),
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            IntensityScore = 8,
                            Name = "Arms day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8632),
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            IntensityScore = 6,
                            Name = "Legs day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 26, 19, 9, 13, 740, DateTimeKind.Local).AddTicks(8635),
                            UserId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
