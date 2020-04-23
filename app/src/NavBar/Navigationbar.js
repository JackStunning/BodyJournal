import {
  Container,
  AppBar,
  Toolbar,
  Typography,
  makeStyles,
  Button,
  InputBase,
} from "@material-ui/core";
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
  title: {
    // flexGrow: 1,
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
const NavigationBar = () => {
  const classes = useStyles();
  return (
    <React.Fragment>
      <Container>
        <Paper className={classes.paper}>
          <AppBar className={classes.navbar} position="fixed">
            <Grid container spacing={3}>
              <Grid item xs={7}>
                <Toolbar>
                  <Typography variant="h6" className={classes.title}>
                    LinkedIn
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
    </React.Fragment>
  );
};
export { NavigationBar };
