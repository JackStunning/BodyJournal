import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { workoutActions } from "../../_actions";
import { BrowserRouter as Router, useParams } from "react-router-dom";
export const WorkoutDetails = () => {
  const { id } = useParams();
  const workout = useSelector((state) => state.workouts.item);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(workoutActions.getWorkout(parseInt(id)));
  }, []);

  return (
    <React.Fragment>
      {workout && (
        <div>
          <h4>{workout.name}</h4>
        </div>
      )}
      {workout &&
        workout.exercises &&
        workout.exercises.map((exercise) => {
          return (
            <div key={exercise.id}>
              <h4>{exercise.name}</h4>
              <h4>{exercise.weight}</h4>
              <h4>{exercise.reps}</h4>
              <h4>{exercise.sets}</h4>
              <h4>{exercise.intensity}</h4>
            </div>
          );
        })}
    </React.Fragment>
  );
};
