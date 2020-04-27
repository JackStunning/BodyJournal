import config from "config";
import { authHeader } from "../helpers";
import { handleResponse } from "../helpers";

export const muscleFatigueService = {
  getMuscleFatigue,
  getMuscleFatigues,
  createMuscleFatigue,
  updateMuscleFatigue,
  deleteMuscleFatigue,
};

function getMuscleFatigue(id) {
  const requestOptions = {
    method: "GET",
    headers: authHeader(),
  };

  return fetch(
    `${config.apiUrl}/users/musclefatigues/${id}`,
    requestOptions
  ).then(handleResponse);
}

function getMuscleFatigues() {
  const requestOptions = {
    method: "GET",
    headers: authHeader(),
  };

  return fetch(`${config.apiUrl}/users/musclefatigues`, requestOptions).then(
    handleResponse
  );
}

function createMuscleFatigue(muscleFatigue) {
  const requestOptions = {
    method: "POST",
    headers: { ...authHeader(), "Content-Type": "application/json" },
    body: JSON.stringify(muscleFatigue),
  };

  return fetch(`${config.apiUrl}/users/musclefatigues`, requestOptions).then(
    handleResponse
  );
}

function updateMuscleFatigue(muscleFatigue) {
  const requestOptions = {
    method: "PUT",
    headers: { ...authHeader(), "Content-Type": "application/json" },
    body: JSON.stringify(muscleFatigue),
  };

  return fetch(`${config.apiUrl}/musclefatigues`, requestOptions).then(
    handleResponse
  );
}

function deleteMuscleFatigue(id) {
  const requestOptions = {
    method: "DELETE",
    headers: authHeader(),
  };

  return fetch(
    `${config.apiUrl}/users/musclefatigues/${id}`,
    requestOptions
  ).then(handleResponse);
}
