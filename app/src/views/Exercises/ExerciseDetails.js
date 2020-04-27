import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { exerciseActions } from "../../_actions";
import { BrowserRouter as Router, useParams } from "react-router-dom";
import { Container } from "@material-ui/core";

export const ExerciseDetails = () => {
  const { id } = useParams();
  const exercise = useSelector((state) => state.exercises.item);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(exerciseActions.getExercise(parseInt(id)));
  }, []);

  return (
    <React.Fragment>
      {exercise && (
        <div>
          <h4>{exercise.name}</h4>
          <h4>{exercise.weight}</h4>
          <h4>{exercise.reps}</h4>
          <h4>{exercise.sets}</h4>
          <h4>{exercise.intensity}</h4>
        </div>
      )}
    </React.Fragment>
  );
};
