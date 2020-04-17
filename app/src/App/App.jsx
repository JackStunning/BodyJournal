import React, { useEffect } from "react";
import { Router, Route, Switch, Redirect } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";

import { history } from "../helpers";
import { alertActions } from "../actions";
import { UserRoute } from "../components";
import { Home } from "../views/Home";
import { Exercises } from "../views/Exercises";
import { Workouts } from "../views/Workouts";
import { Login } from "../views/Login";
import { Register } from "../views/Register";

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
              <UserRoute exact path="/" component={Home} />
              <UserRoute exact path="/exercises" component={Exercises} />
              <UserRoute exact path="/workouts" component={Workouts} />
              <Route path="/login" component={Login} />
              <Route path="/register" component={Register} />
              <Redirect from="*" to="/" />
            </Switch>
          </Router>
        </div>
      </div>
    </div>
  );
}

export { App };
