import React, { useEffect } from "react";
import { Router, Route, Switch, Redirect } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import {
  Container,
  AppBar,
  Toolbar,
  Typography,
  makeStyles,
  Button,
  InputBase,
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
import HomeOutlinedIcon from "@material-ui/icons/HomeOutlined";
import PeopleOutlineIcon from "@material-ui/icons/PeopleOutline";
import WorkOutlineIcon from "@material-ui/icons/WorkOutline";
import ForumOutlinedIcon from "@material-ui/icons/ForumOutlined";
import NotificationsOutlinedIcon from "@material-ui/icons/NotificationsOutlined";

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
  },
  navbar: {
    backgroundColor: "#283E4A",
  },
  menuButton: {
    marginRight: theme.spacing(1),
  },
  mainContent: {
    marginTop: "80px",
  },
  search: {
    position: "relative",
    borderRadius: theme.shape.borderRadius,
    backgroundColor: "white",
    marginRight: theme.spacing(2),
    marginLeft: 0,
    width: "100%",
    [theme.breakpoints.up("sm")]: {
      marginLeft: theme.spacing(3),
      width: "auto",
    },
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
        <Paper className={classes.paper}>
          <AppBar className={classes.navbar} position="fixed">
            <Grid container spacing={3}>
              <Grid item xs={7}>
                <Toolbar>
                  <Typography variant="h6" className={classes.title}>
                    BodyJournal
                  </Typography>
                  <div className={classes.search}>
                    <InputBase
                      placeholder="Search…"
                      classes={{
                        root: classes.inputRoot,
                        input: classes.inputInput,
                      }}
                      inputProps={{ "aria-label": "search" }}
                    />
                  </div>
                </Toolbar>
              </Grid>
              <Grid item xs={5}>
                <Toolbar>
                  <Grid item xs={2}>
                    <HomeOutlinedIcon />
                  </Grid>
                  <Grid item xs={2}>
                    <PeopleOutlineIcon />
                  </Grid>
                  <Grid item xs={2}>
                    <WorkOutlineIcon />
                  </Grid>
                  <Grid item xs={2}>
                    <ForumOutlinedIcon />
                  </Grid>
                  <Grid item xs={2}>
                    <NotificationsOutlinedIcon />
                  </Grid>
                  <Grid item xs={2}>
                    <Button color="inherit">Login</Button>
                  </Grid>
                </Toolbar>
              </Grid>
            </Grid>
          </AppBar>
        </Paper>
      </Container>
      <Container>
        <Paper>
          <h1>Welcome</h1>
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
        </Paper>
      </Container>
    </React.Fragment>
  );
}
export { App };
