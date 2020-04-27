import React, { useEffect } from "react";
import { Router, Route, Switch, Redirect } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { Container, makeStyles } from "@material-ui/core";
import { history } from "../helpers";
import { alertActions } from "../_actions";
import { UserRoute } from "../components/UserRoute/UserRoute";
import { Home } from "../views/Home/Home";
import { Exercises } from "../views/Exercises/Exercises";
import { Workouts } from "../views/Workouts/Workouts";
import { Login } from "../views/Login/Login";
import { Register } from "../views/Register/Register";
import { ExerciseDetails } from "../views/Exercises/ExerciseDetails";
import { NavigationBar } from "../components/NavigationBar/NavigationBar";
import { CreateExercise } from "../views/Exercises/CreateExercise";
import { CreateWorkout } from "../views/Workouts/CreateWorkout";
import { WorkoutDetails } from "../views/Workouts/WorkoutDetails";
import { MuscleFatigues } from "../views/MuscleFatigue/MuscleFatigues";

const useStyles = makeStyles((theme) => ({
  center: {
    justifyContent: "center",
  },
  whiteText: {
    color: "white",
  },
  fullLength: {
    height: "100%",
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
      <Container className={classes.fullLength}>
        <div className="col-md-8 offset-md-2">
          {alert.message && (
            <div className={`alert ${alert.type}`}>{alert.message}</div>
          )}
          <Router history={history}>
            <NavigationBar></NavigationBar>
            <h1>Welcome</h1>
            <Switch>
              <UserRoute exact path="/" component={Home} />
              <UserRoute exact path="/recovery" component={MuscleFatigues} />
              <UserRoute exact path="/exercises" component={Exercises} />
              <UserRoute
                path="/exercises/new"
                component={CreateExercise}
              ></UserRoute>
              <UserRoute
                exact
                path="/exercises/:id"
                component={ExerciseDetails}
              />
              <UserRoute exact path="/workouts" component={Workouts} />
              <UserRoute
                path="/workouts/new"
                component={CreateWorkout}
              ></UserRoute>
              <UserRoute
                exact
                path="/workouts/:id"
                component={WorkoutDetails}
              />
              <Route path="/login" component={Login} />
              <Route path="/register" component={Register} />
              <Redirect from="*" to="/" />
            </Switch>
          </Router>
        </div>
      </Container>
    </React.Fragment>
  );
}
export { App };
