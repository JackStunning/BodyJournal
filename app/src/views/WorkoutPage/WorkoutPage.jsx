import React, { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { workoutActions } from "../../actions";

function workoutPage() {
  const workouts = useSelector((state) => state.workouts);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(workoutActions.getWorkouts());
  }, []);

  return (
    <div>
      <h1>Your workouts</h1>
      {workouts.items && (
        <ul>
          {workouts.items.map((workout, index) => (
            <li key={workout.id}>{workout.name}</li>
          ))}
        </ul>
      )}
    </div>
  );
}

export { workoutPage };
