import React from "react";
import Exercise from "./Exercise";
function ExerciseList(props, muscle) {
  const exercises = props;
  return (
    <div>
      <h1>{muscle}</h1>
      {exercises.items && (
        <ul>
          {exercises.items
            .filter((exercise) => {
              return exercise.muscleGroup === muscle;
            })
            .map((exercise) => (
              <Exercise
                key={exercise.id}
                name={exercise.name}
                weight={exercise.weight}
                sets={exercise.sets}
                reps={exercise.reps}
                intensity={exercise.intensity}
              ></Exercise>
            ))}
        </ul>
      )}
    </div>
  );
}

export { ExerciseList };
