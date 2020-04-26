import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { workoutActions } from "../../../actions";
import Table from "@material-ui/core/Table";
import TableBody from "@material-ui/core/TableBody";
import TableCell from "@material-ui/core/TableCell";
import TableContainer from "@material-ui/core/TableContainer";
import TableHead from "@material-ui/core/TableHead";
import TableRow from "@material-ui/core/TableRow";
import Paper from "@material-ui/core";

const Workouts = () => {
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
};

export { Workouts };
