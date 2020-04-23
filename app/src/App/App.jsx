import React, { useEffect } from "react";
import { Router, Route, Switch, Redirect } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import {
  Container,
  AppBar,
  Toolbar,
  Typography,
  makeStyles,
} from "@material-ui/core";
import { history } from "../helpers";
import { alertActions } from "../actions";
import { UserRoute } from "../components";
import { Home } from "../views/Home";
import Paper from "@material-ui/core/Paper";
import Grid from "@material-ui/core/Grid";
import { Exercises } from "../views/Exercises";
import { Workouts } from "../views/Workouts";
import { Login } from "../views/Login";
import { Register } from "../views/Register";
import { Link } from "react-router-dom";
import PeopleOutlineIcon from "@material-ui/icons/PeopleOutline";

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
  },
  whiteText: {
    color: "white",
  },
  navbar: {
    backgroundColor: "#00acee",
  },
  menuButton: {
    marginRight: theme.spacing(1),
  },
  mainContent: {
    marginTop: "80px",
  },
}));

function App() {
  const classes = useStyles();
  const alert = useSelector((state) => state.alert);
  const dispatch = useDispatch();

  useEffect(() => {
    history.listen((location, action) => {
      dispatch(alertActions.clear());
    });
  }, []);

  return (
    <React.Fragment>
      <Container>
        <Paper>
          <h1>Welcome</h1>
          <div className="col-md-8 offset-md-2">
            {alert.message && (
              <div className={`alert ${alert.type}`}>{alert.message}</div>
            )}
            <Router history={history}>
              <Container>
                <Paper className={classes.paper}>
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
                          <Grid item xs={3}>
                            <Typography variant="h6" className={classes.title}>
                              <Link
                                className={classes.whiteText}
                                to="/exercises"
                              >
                                Exercises
                              </Link>
                            </Typography>
                          </Grid>
                          <Grid item xs={3}>
                            <Typography variant="h6" className={classes.title}>
                              <Link
                                className={classes.whiteText}
                                to="/workouts"
                              >
                                Workouts
                              </Link>
                            </Typography>
                          </Grid>
                          <Grid item xs={3}>
                            <Typography variant="h6" className={classes.title}>
                              <Link className={classes.whiteText} to="/data">
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
                </Paper>
              </Container>
              <Switch>
                <UserRoute exact path="/" component={Home} />
                <UserRoute exact path="/exercises" component={Exercises} />
                <UserRoute exact path="/workouts" component={Workouts} />
                <Route path="/login" component={Login} />
                <Route path="/register" component={Register} />
                <Redirect from="*" to="/" />
              </Switch>
            </Router>
          </div>
        </Paper>
      </Container>
    </React.Fragment>
  );
}
export { App };
