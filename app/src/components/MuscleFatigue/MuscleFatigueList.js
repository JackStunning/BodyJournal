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

export const MuscleFatigueList = (props, muscle) => {
  const muscleFatigues = { ...props };
  return (
    <React.Fragment>
      <h1>{muscle}</h1>
      <TableContainer>
        <Table aria-label="simple table">
          <TableHead>
            <TableRow>
              <TableCell component="th" scope="row">
                Muscle Fatigue
              </TableCell>
              <TableCell align="right">Fatigue</TableCell>
              <TableCell align="right">CurrentTime</TableCell>
              <TableCell align="right">WorkoutId</TableCell>
            </TableRow>
          </TableHead>
          <Router history={history}>
            <TableBody>
              {muscleFatigues.items &&
                muscleFatigues.items
                  .filter((item) => {
                    return item.muscleGroup === muscle;
                  })
                  .map((item) => (
                    <TableRow key={item.id}>
                      <TableCell component="th" scope="row">
                        <Link to={`/recovery/${item.id}`}>
                          {item.muscleGroup}
                        </Link>
                      </TableCell>
                      <TableCell align="right">{item.fatigue}</TableCell>
                      <TableCell align="right">{item.currentTime}</TableCell>
                      <TableCell align="right">{item.workoutId}</TableCell>
                    </TableRow>
                  ))}
            </TableBody>
          </Router>
        </Table>
      </TableContainer>
    </React.Fragment>
  );
};
