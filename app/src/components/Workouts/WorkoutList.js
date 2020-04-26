import React from "react";
import TableBody from "@material-ui/core/TableBody";
import TableCell from "@material-ui/core/TableCell";
import TableContainer from "@material-ui/core/TableContainer";
import TableHead from "@material-ui/core/TableHead";
import TableRow from "@material-ui/core/TableRow";
import Table from "@material-ui/core/Table";
import { Link } from "react-router-dom";
import { Router } from "react-router-dom";
import { history } from "../../helpers";

function WorkoutList(props, muscle) {
  const workouts = props;

  return (
    <div>
      <h1>{muscle}</h1>
      {workouts.items && (
        <ul>
          {workouts.items
            .filter((workout) => {
              return workout.muscleGroup === muscle;
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
