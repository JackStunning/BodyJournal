import React from "react";
import { makeStyles, Container } from "@material-ui/core";
import Grid from "@material-ui/core/Grid";
import CardMedia from "@material-ui/core/CardMedia";
import Card from "@material-ui/core/Card";
import PropTypes from "prop-types";
const useStyles = makeStyles({
  media: {
    height: 80,
    width: 80,
  },
  marginTop: {
    marginTop: 20,
  },
});

export const ExerciseHeader = (props) => {
  const classes = useStyles();
  return (
    <React.Fragment>
      <Container className={classes.marginTop}>
        <Grid container spacing={3}>
          <Card onClick={() => props.onShowingExercises(0)}>
            <CardMedia
              className={classes.media}
              image="../../../assets/img/chest.png"
            />
          </Card>
          <Card onClick={() => props.onShowingExercises(1)}>
            <CardMedia
              className={classes.media}
              image="../../../assets/img/back.png"
            />
          </Card>
          <Card onClick={() => props.onShowingExercises(2)}>
            <CardMedia
              className={classes.media}
              image="../../../assets/img/shoulders.png"
            />
          </Card>
          <Card onClick={() => props.onShowingExercises(3)}>
            <CardMedia
              className={classes.media}
              image="../../../assets/img/arms.png"
            />
          </Card>
          <Card>
            <CardMedia
              onClick={() => props.onShowingExercises(4)}
              className={classes.media}
              image="../../../assets/img/abs.png"
            />
          </Card>
        </Grid>
      </Container>
    </React.Fragment>
  );
};

ExerciseHeader.propTypes = {
  onShowingExercises: PropTypes.func,
  ChestExercises: PropTypes.func,
};
