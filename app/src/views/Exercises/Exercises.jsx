import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { exerciseActions } from "../../actions";
import ExerciseHeader from "./ExerciseHeader";
import PropTypes from "prop-types";
import { ExerciseList } from "./ExerciseList";
import { Grid } from "@material-ui/core";

function Exercises() {
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

  const handle = (f) => {
    setExerciseList(exer[f]);
  };
  return (
    <React.Fragment>
      <ExerciseHeader onShowingExercises={handle} />
      {exerciseList}
    </React.Fragment>
  );
}

Exercises.propTypes = {
  exercises: PropTypes.array,
};

export { Exercises };
