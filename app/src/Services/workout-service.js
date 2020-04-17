import config from "config";
import { authHeader } from "../helpers";
import { handleResponse } from "../helpers";

export const workoutService = {
  getWorkout,
  getWorkouts,
  createWorkout,
  updateWorkout,
  deleteWorkout,
};

function getWorkout(id) {
  const requestOptions = {
    method: "GET",
    headers: authHeader(),
  };

  return fetch(`${config.apiUrl}/users/workouts/${id}`, requestOptions).then(
    handleResponse
  );
}

function getWorkouts() {
  const requestOptions = {
    method: "GET",
    headers: authHeader(),
  };

  return fetch(`${config.apiUrl}/users/workouts`, requestOptions).then(
    handleResponse
  );
}

function createWorkout(Workout) {
  const requestOptions = {
    method: "POST",
    headers: { ...authHeader(), "Content-Type": "application/json" },
    body: JSON.stringify(Workout),
  };

  return fetch(`${config.apiUrl}/users/workouts`, requestOptions).then(
    handleResponse
  );
}

function updateWorkout(workout) {
  const requestOptions = {
    method: "PUT",
    headers: { ...authHeader(), "Content-Type": "application/json" },
    body: JSON.stringify(workout),
  };

  return fetch(`${config.apiUrl}/workouts`, requestOptions).then(
    handleResponse
  );
}

function deleteWorkout(id) {
  const requestOptions = {
    method: "DELETE",
    headers: authHeader(),
  };

  return fetch(`${config.apiUrl}/users/workouts/${id}`, requestOptions).then(
    handleResponse
  );
}
