import React from "react";
import TableBody from "@material-ui/core/TableBody";
import TableCell from "@material-ui/core/TableCell";
import TableContainer from "@material-ui/core/TableContainer";
import TableHead from "@material-ui/core/TableHead";
import TableRow from "@material-ui/core/TableRow";
import Table from "@material-ui/core/Table";
import { Link, Typography } from "@material-ui/core";

function ExerciseList(props, muscle) {
  const exercises = props;
  return (
    <React.Fragment>
      <h1>{muscle}</h1>
      <TableContainer>
        <Table aria-label="simple table">
          <TableHead>
            <TableRow>
              <TableCell component="th" scope="row">
                Exercises
              </TableCell>
              <TableCell align="right">Weight</TableCell>
              <TableCell align="right">Reps</TableCell>
              <TableCell align="right">Sets</TableCell>
              <TableCell align="right">Intensity</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {exercises.items &&
              exercises.items
                .filter((exercise) => {
                  return exercise.muscleGroup === muscle;
                })
                .map((exercise) => (
                  <Link to={`/exercises/${exercise.id}`}>
                    <TableRow key={exercise.id}>
                      <TableCell component="th" scope="row">
                        {exercise.name}
                      </TableCell>
                      <TableCell align="right">{exercise.weight}</TableCell>
                      <TableCell align="right">{exercise.reps}</TableCell>
                      <TableCell align="right">{exercise.sets}</TableCell>
                      <TableCell align="right">{exercise.intensity}</TableCell>
                    </TableRow>
                  </Link>
                ))}
          </TableBody>
        </Table>
      </TableContainer>
    </React.Fragment>
  );
}

export default ExerciseList;
