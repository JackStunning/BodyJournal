﻿// <auto-generated />
using System;
using BodyJournalAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace api.Migrations
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

                    b.HasKey("Id");

                    b.ToTable("Biometrics");
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

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Intensity = 3,
                            MuscleGroup = "Chest",
                            Name = "Wide Pushup",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            Id = 2,
                            Intensity = 4,
                            MuscleGroup = "Chest",
                            Name = "Narrow Pushup",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            Id = 3,
                            Intensity = 5,
                            MuscleGroup = "Chest",
                            Name = "Bench Press",
                            Reps = 5,
                            Sets = 3,
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
                            Weight = 70
                        },
                        new
                        {
                            Id = 13,
                            Intensity = 2,
                            MuscleGroup = "Abs",
                            Name = "Sit Up",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            Id = 14,
                            Intensity = 2,
                            MuscleGroup = "Abs",
                            Name = "Plank",
                            Reps = 1,
                            Sets = 3
                        },
                        new
                        {
                            Id = 15,
                            Intensity = 3,
                            MuscleGroup = "Abs",
                            Name = "Bicycle",
                            Reps = 25,
                            Sets = 3
                        },
                        new
                        {
                            Id = 16,
                            Intensity = 2,
                            MuscleGroup = "Abs",
                            Name = "Leg Rasises",
                            Reps = 15,
                            Sets = 3
                        },
                        new
                        {
                            Id = 17,
                            Intensity = 2,
                            MuscleGroup = "Legs",
                            Name = "Squat",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            Id = 18,
                            Intensity = 1,
                            MuscleGroup = "Legs",
                            Name = "Calf Raise",
                            Reps = 10,
                            Sets = 3,
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

                    b.ToTable("ExerciseWorkouts");

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

                    b.Property<int>("AbsFatigue")
                        .HasColumnType("int");

                    b.Property<int>("ArmsFatigue")
                        .HasColumnType("int");

                    b.Property<int>("BackFatigue")
                        .HasColumnType("int");

                    b.Property<int>("ChestFatigue")
                        .HasColumnType("int");

                    b.Property<DateTime>("CurrentTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LegsFatigue")
                        .HasColumnType("int");

                    b.Property<int>("ShouldersFatigue")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MuscleGroupFatigues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AbsFatigue = 0,
                            ArmsFatigue = 1,
                            BackFatigue = 2,
                            ChestFatigue = 4,
                            CurrentTime = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(8370),
                            LegsFatigue = 1,
                            ShouldersFatigue = 1,
                            WorkoutId = 6
                        },
                        new
                        {
                            Id = 2,
                            AbsFatigue = 0,
                            ArmsFatigue = 1,
                            BackFatigue = 1,
                            ChestFatigue = 1,
                            CurrentTime = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(9430),
                            LegsFatigue = 1,
                            ShouldersFatigue = 4,
                            WorkoutId = 3
                        },
                        new
                        {
                            Id = 3,
                            AbsFatigue = 0,
                            ArmsFatigue = 3,
                            BackFatigue = 3,
                            ChestFatigue = 4,
                            CurrentTime = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(9460),
                            LegsFatigue = 3,
                            ShouldersFatigue = 3,
                            WorkoutId = 4
                        },
                        new
                        {
                            Id = 4,
                            AbsFatigue = 0,
                            ArmsFatigue = 3,
                            BackFatigue = 1,
                            ChestFatigue = 1,
                            CurrentTime = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(9460),
                            LegsFatigue = 2,
                            ShouldersFatigue = 3,
                            WorkoutId = 8
                        },
                        new
                        {
                            Id = 5,
                            AbsFatigue = 0,
                            ArmsFatigue = 3,
                            BackFatigue = 5,
                            ChestFatigue = 3,
                            CurrentTime = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(9470),
                            LegsFatigue = 3,
                            ShouldersFatigue = 5,
                            WorkoutId = 5
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

                    b.HasKey("Id");

                    b.ToTable("Workouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IntensityScore = 7,
                            Name = "Upper body day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 8, 16, 42, 4, 912, DateTimeKind.Local).AddTicks(7940)
                        },
                        new
                        {
                            Id = 2,
                            IntensityScore = 3,
                            Name = "Lower body day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1040)
                        },
                        new
                        {
                            Id = 3,
                            IntensityScore = 7,
                            Name = "Shoulder day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1110)
                        },
                        new
                        {
                            Id = 4,
                            IntensityScore = 6,
                            Name = "Back day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1110)
                        },
                        new
                        {
                            Id = 5,
                            IntensityScore = 4,
                            Name = "Abs day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1120)
                        },
                        new
                        {
                            Id = 6,
                            IntensityScore = 8,
                            Name = "Chest day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1120)
                        },
                        new
                        {
                            Id = 7,
                            IntensityScore = 8,
                            Name = "Arms day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1120)
                        },
                        new
                        {
                            Id = 8,
                            IntensityScore = 6,
                            Name = "Legs day",
                            Satisfaction = 5,
                            TimeOfWorkout = new DateTime(2020, 4, 8, 16, 42, 4, 931, DateTimeKind.Local).AddTicks(1130)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
