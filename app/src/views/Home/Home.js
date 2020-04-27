import React, { useEffect } from "react";
import { Link } from "react-router-dom";
import { useSelector } from "react-redux";
import { Grid } from "@material-ui/core";

export const Home = () => {
  const user = useSelector((state) => state.authentication.user);
  return (
    <Grid container>
      <h1>Welcome {user.firstName}!</h1>
      <Grid item xs={12}>
        <p>
          <Link to="/login">Logout</Link>
        </p>
      </Grid>
      <Grid item xs={12}>
        <p>
          <Link to="/exercises">Exercises</Link>
        </p>
      </Grid>
      <Grid item xs={12}>
        <p>
          <Link to="/workouts">Workouts</Link>
        </p>
      </Grid>
    </Grid>
  );
};
