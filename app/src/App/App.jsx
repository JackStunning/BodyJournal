import React, { useEffect } from "react";
import { Router, Route, Switch, Redirect } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { Container, makeStyles } from "@material-ui/core";
import { history } from "../helpers";
import { alertActions } from "../actions";
import { UserRoute } from "../components/UserRoute/UserRoute";
import { Home } from "../views/Home";
import Paper from "@material-ui/core/Paper";
import { Exercises } from "../views/Exercises/Index/Exercises";
import { Workouts } from "../views/Workouts/Index/Workouts";
import { Workout } from "../components/Workouts/Workout";
import { Login } from "../views/Login";
import { Register } from "../views/Register";
import { ExerciseDetails } from "../views/Exercises/ExerciseDetails";
import { NavigationBar } from "../components/NavigationBar/NavigationBar";

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
              <UserRoute exact path="/exercises" component={Exercises} />
              <UserRoute
                exact
                path="/exercises/:id"
                component={ExerciseDetails}
              />
              <UserRoute exact path="/workouts" component={Workouts} />
              <UserRoute exact path="/workouts/:id" component={Workout} />
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
