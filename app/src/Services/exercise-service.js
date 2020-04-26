import config from "config";
import { authHeader } from "../helpers";
import { handleResponse } from "../helpers";

export const exerciseService = {
  getExercise,
  getExercises,
  getExercisesByMuscle,
  createExercise,
  updateExercise,
  deleteExercise,
};

function getExercise(id) {
  console.log("In exercise service :" + id);
  const requestOptions = {
    method: "GET",
    headers: authHeader(),
  };

  return fetch(`${config.apiUrl}/users/exercises/${id}`, requestOptions).then(
    handleResponse
  );
}

function getExercises() {
  const requestOptions = {
    method: "GET",
    headers: authHeader(),
  };

  return fetch(`${config.apiUrl}/users/exercises`, requestOptions).then(
    handleResponse
  );
}

function getExercisesByMuscle(muscle) {
  const requestOptions = {
    method: "GET",
    headers: authHeader(),
  };

  return fetch(
    `${config.apiUrl}/users/exercises/${muscle}`,
    requestOptions
  ).then(handleResponse);
}

function createExercise(exercise) {
  const requestOptions = {
    method: "POST",
    headers: { ...authHeader(), "Content-Type": "application/json" },
    body: JSON.stringify(exercise),
  };

  return fetch(`${config.apiUrl}/users/exercises`, requestOptions).then(
    handleResponse
  );
}

function updateExercise(exercise) {
  const requestOptions = {
    method: "PUT",
    headers: { ...authHeader(), "Content-Type": "application/json" },
    body: JSON.stringify(exercise),
  };

  return fetch(`${config.apiUrl}/users/exercises`, requestOptions).then(
    handleResponse
  );
}

function deleteExercise(id) {
  const requestOptions = {
    method: "DELETE",
    headers: authHeader(),
  };

  return fetch(`${config.apiUrl}/users/exercises/${id}`, requestOptions).then(
    handleResponse
  );
}
