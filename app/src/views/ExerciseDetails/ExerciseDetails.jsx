import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { exerciseActions } from "../../actions";

function ExerciseDetails() {
  const exercise = useSelector((state) => state.exercise);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(exerciseActions.getExercise());
  }, []);

  return (
    <div>
      <h1>Your Exercise</h1>
      {exercise.name}
    </div>
  );
}

export { ExerciseDetails };
