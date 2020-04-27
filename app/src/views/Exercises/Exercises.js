import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { exerciseActions } from "../../_actions";
import { ExerciseHeader } from "../../components/Exercises/ExerciseHeader";
import PropTypes from "prop-types";
import { ExerciseList } from "../../components/Exercises/ExerciseList";
import { Grid, makeStyles } from "@material-ui/core";
import { Link } from "react-router-dom";

const useStyles = makeStyles((theme) => ({
  mainContent: {
    marginTop: "200",
    justifyContent: "center",
    borderColor: "red",
    width: "100%",
  },
}));
export const Exercises = () => {
  const classes = useStyles;
  const exercises = useSelector((state) => state.exercises);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(exerciseActions.getExercises());
  }, []);

  const chest = ExerciseList(exercises, "Chest");
  const back = ExerciseList(exercises, "Back");
  const shoulders = ExerciseList(exercises, "Shoulders");
  const arms = ExerciseList(exercises, "Arms");
  const abs = ExerciseList(exercises, "Abs");
  const legs = ExerciseList(exercises, "Legs");
  const exer = [chest, back, shoulders, arms, abs, legs];
  const [exerciseList, setExerciseList] = useState(null);

  const handleShowingExercises = (muscle) => {
    setExerciseList(exer[muscle]);
  };
  return (
    <Grid container className={classes.mainContent}>
      <Grid item xs={12}>
        <ExerciseHeader onShowingExercises={handleShowingExercises} />
        <br></br>
        <br></br>
        <Link to="/exercises/new">Create Exercise</Link>
        {exerciseList}
      </Grid>
    </Grid>
  );
};
