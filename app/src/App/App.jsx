import React, { useEffect } from "react";
import { Router, Route, Switch, Redirect } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";

import { history } from "../helpers";
import { alertActions } from "../actions";
import { UserRoute } from "../components";
import { HomePage } from "../views/HomePage";
import { ExercisesView } from "../views/ExercisesView";
import { WorkoutsView } from "../views/WorkoutsView";
import { LoginPage } from "../views/LoginPage";
import { RegisterPage } from "../views/RegisterPage";

function App() {
  const alert = useSelector((state) => state.alert);
  const dispatch = useDispatch();

  useEffect(() => {
    history.listen((location, action) => {
      dispatch(alertActions.clear());
    });
  }, []);

  return (
    <div className="jumbotron">
      <div className="container">
        <div className="col-md-8 offset-md-2">
          {alert.message && (
            <div className={`alert ${alert.type}`}>{alert.message}</div>
          )}
          <Router history={history}>
            <Switch>
              <UserRoute exact path="/" component={HomePage} />
              <UserRoute exact path="/exercises" component={ExercisesView} />
              <UserRoute exact path="/workouts" component={WorkoutsView} />
              <Route path="/login" component={LoginPage} />
              <Route path="/register" component={RegisterPage} />
              <Redirect from="*" to="/" />
            </Switch>
          </Router>
        </div>
      </div>
    </div>
  );
}

export { App };
