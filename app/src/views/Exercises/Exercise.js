import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
const Exercise = ({ match, location }) => {
  const {
    params: { id },
  } = match;

  const exercise = useSelector((state) => state.exercise);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(exerciseActions.getExercise(id));
  }, []);
  return (
    <React.Fragment>
      <p>{exercise.name}</p>
      <p>{exercise.weight}</p>
      <p>{exercise.reps}</p>
      <p>{exercise.sets}</p>
      <p>{exercise.intensity}</p>
    </React.Fragment>
  );
};
export { Exercise };
