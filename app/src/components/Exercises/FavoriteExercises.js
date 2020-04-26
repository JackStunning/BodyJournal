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

function FavoriteExercises() {
  const exercises = useSelector((state) => state.exercises);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(exerciseActions.getExercises());
  }, []);

  return (
    <div>
      <h1>Favorite Exercise</h1>
      <ExerciseHeader></ExerciseHeader>
      <h1>Chest exercises</h1>
      <div>
        {exercises.items && (
          <ul>
            {exercises.items
              .filter((exercise) => {
                return exercise.muscleGroup === "Chest";
              })
              .map((chestExercise, index) => (
                <li key={chestExercise.id}>
                  {chestExercise.name}
                  {chestExercise.muscleGroup}
                </li>
              ))}
          </ul>
        )}
      </div>
      <h1>Back exercises</h1>
      <div>
        {exercises.items && (
          <ul>
            {exercises.items
              .filter((exercise) => {
                return exercise.muscleGroup === "Back";
              })
              .map((backExercise, index) => (
                <li key={backExercise.id}>
                  {backExercise.name}
                  {backExercise.muscleGroup}
                </li>
              ))}
          </ul>
        )}
      </div>
      <h1>Shoulder exercises</h1>
      <div>
        {exercises.items && (
          <ul>
            {exercises.items
              .filter((exercise) => {
                return exercise.muscleGroup === "Shoulders";
              })
              .map((shoulderExercise, index) => (
                <li key={shoulderExercise.id}>
                  {shoulderExercise.name}
                  {shoulderExercise.muscleGroup}
                </li>
              ))}
          </ul>
        )}
      </div>
      <h1>Arm exercises</h1>
      <div>
        {exercises.items && (
          <ul>
            {exercises.items
              .filter((exercise) => {
                return exercise.muscleGroup === "Arms";
              })
              .map((armExercise, index) => (
                <li key={armExercise.id}>
                  {armExercise.name}
                  {armExercise.muscleGroup}
                </li>
              ))}
          </ul>
        )}
      </div>
      <h1>Ab exercises</h1>
      <div>
        {exercises.items && (
          <ul>
            {exercises.items
              .filter((exercise) => {
                return exercise.muscleGroup === "Abs";
              })
              .map((absExercise, index) => (
                <li key={absExercise.id}>
                  {absExercise.name}
                  {absExercise.muscleGroup}
                </li>
              ))}
          </ul>
        )}
      </div>
    </div>
  );
}
