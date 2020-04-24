import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { workoutActions } from "../../actions";
import Table from "@material-ui/core/Table";
import TableBody from "@material-ui/core/TableBody";
import TableCell from "@material-ui/core/TableCell";
import TableContainer from "@material-ui/core/TableContainer";
import TableHead from "@material-ui/core/TableHead";
import TableRow from "@material-ui/core/TableRow";
import Paper from "@material-ui/core";

function Workouts() {
  const workouts = useSelector((state) => state.workouts);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(workoutActions.getWorkouts());
  }, []);

  return (
    <div>
      <TableContainer component={Paper}>
        <Table aria-label="simple table">
          <TableHead>
            <TableRow>
              <TableCell component="th" scope="row">
                Workouts
              </TableCell>
              <TableCell align="right">Time of Workout</TableCell>
              <TableCell align="right">Satisfaction</TableCell>
              <TableCell align="right">IntensityScore</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {workouts.items &&
              workouts.items.map((workout) => (
                <TableRow key={workout.id}>
                  <TableCell component="th" scope="row">
                    {workout.name}
                  </TableCell>
                  <TableCell align="right">{workout.timeOfWorkout}</TableCell>
                  <TableCell align="right">{workout.satisfaction}</TableCell>
                  <TableCell align="right">{workout.intensityScore}</TableCell>
                </TableRow>
              ))}
          </TableBody>
        </Table>
      </TableContainer>
    </div>
  );
}

export { Workouts };

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
//select from all workouts where the muscle group requested was required
//for an exercise in that list.

//select from w in workouts where e
