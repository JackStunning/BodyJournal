import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { workoutActions } from "../../actions";

function WorkoutDetails() {
  const workout = useSelector((state) => state.workout);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(workoutActions.getWorkout());
  }, []);

  return (
    <div>
      <h1>Your workout</h1>
      {workout.name}
    </div>
  );
}

export { WorkoutDetails };
