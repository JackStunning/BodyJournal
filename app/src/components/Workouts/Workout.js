import React from "react";
import PropTypes from "prop-types";
import TableBody from "@material-ui/core/TableBody";
import TableCell from "@material-ui/core/TableCell";
import TableContainer from "@material-ui/core/TableContainer";
import TableHead from "@material-ui/core/TableHead";
import TableRow from "@material-ui/core/TableRow";
import { Exercise } from "../Exercises/Exercise";

export const Workout = (props) => {
  return (
    <TableContainer component={Paper}>
      <Table className={classes.table} aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell component="th" scope="row">
              Exercises
            </TableCell>
            <TableCell align="right">Name</TableCell>
            <TableCell align="right">Weight</TableCell>
            <TableCell align="right">Reps</TableCell>
            <TableCell align="right">Sets</TableCell>
            <TableCell align="right">Intensity</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {props.exercises &&
            props.exercises.map((exercise) => (
              <TableRow key={exercise.id}>
                <TableCell component="th" scope="row">
                  {exercise.name}
                </TableCell>
                <TableCell align="right">{exercise.weight}</TableCell>
                <TableCell align="right">{exercise.reps}</TableCell>
                <TableCell align="right">{exercise.sets}</TableCell>
                <TableCell align="right">{exercise.intensity}</TableCell>
              </TableRow>
            ))}
          }
        </TableBody>
      </Table>
    </TableContainer>
  );
};

Workout.propTypes = {
  id: PropTypes.number,
  name: PropTypes.string,
  timeOfWorkout: PropTypes.string,
  satisfaction: PropTypes.number,
  intensityScore: PropTypes.number,
  exercises: PropTypes.arrayOf(Exercise),
};
