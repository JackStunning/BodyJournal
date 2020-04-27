import React, { useState } from "react";
import {
  AppBar,
  Toolbar,
  Typography,
  makeStyles,
  Grid,
} from "@material-ui/core";
import PeopleOutlineIcon from "@material-ui/icons/PeopleOutline";
import { Link } from "react-router-dom";

const useStyles = makeStyles((theme) => ({
  center: {
    justifyContent: "center",
  },
  navLinks: {
    color: "white",
    textDecoration: "none",
  },
  navbar: {
    backgroundColor: "#00acee",
  },
  menuButton: {
    marginRight: theme.spacing(1),
  },
  mainContent: {
    marginBottom: "200",
  },
}));
const NavigationBar = () => {
  const classes = useStyles();
  return (
    <React.Fragment>
      <AppBar className={classes.navbar} position="fixed">
        <Grid container spacing={3}>
          <Grid item xs={3}>
            <Toolbar>
              <Typography variant="h6" className={classes.title}>
                BodyJournal
              </Typography>
            </Toolbar>
          </Grid>
          <Grid item xs={9}>
            <Toolbar>
              <Grid item xs={2}>
                <Typography variant="h6" className={classes.title}>
                  <Link className={classes.navLinks} to="/workouts">
                    Workouts
                  </Link>
                </Typography>
              </Grid>
              <Grid item xs={2}>
                <Typography variant="h6" className={classes.title}>
                  <Link className={classes.navLinks} to="/exercises">
                    Exercises
                  </Link>
                </Typography>
              </Grid>
              <Grid item xs={2}>
                <Typography variant="h6" className={classes.title}>
                  <Link className={classes.navLinks} to="/recovery">
                    Recovery
                  </Link>
                </Typography>
              </Grid>
              <Grid item xs={2}>
                <Typography variant="h6" className={classes.title}>
                  <Link className={classes.navLinks} to="/data">
                    Data
                  </Link>
                </Typography>
              </Grid>
              <Grid item xs={2}>
                <PeopleOutlineIcon />
              </Grid>
            </Toolbar>
          </Grid>
        </Grid>
      </AppBar>
    </React.Fragment>
  );
};
export { NavigationBar };
