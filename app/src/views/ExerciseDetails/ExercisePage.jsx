import React, { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { exerciseActions } from "../../actions";

function ExercisePage() {
  const exercises = useSelector((state) => state.exercises);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(exerciseActions.getExercises());
  }, []);

  return (
    <div>
      <h1>Your exercises</h1>
      {exercises.items && (
        <ul>
          {exercises.items.map((exercise, index) => (
            <li key={exercise.id}>
              {exercise.name}
              {exercise.userId}
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}

export { ExercisePage };
