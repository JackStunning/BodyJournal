import { exerciseConstants } from "../Constants";
import { exerciseService } from "../services";
import { alertActions } from "./";
import { history } from "../Helpers";

export const exerciseActions = {
  getExercise,
  getExercises,
  createExercise,
  updateExercise,
  deleteExercise,
};

function getExercise(id) {
  return (dispatch) => {
    dispatch(request(id));

    exerciseService.getExercise(id).then(
      (exercise) => dispatch(success(exercise)),
      (error) => dispatch(failure(id, error.toString()))
    );
  };

  function request(id) {
    return { type: exerciseConstants.GET_REQUEST, id };
  }
  function success(exercise) {
    return { type: userConstants.GET_SUCCESS, exercise };
  }
  function failure(id, error) {
    return { type: userConstants.GET_FAILURE, id, error };
  }
}

function getExercises() {
  return (dispatch) => {
    dispatch(request());

    exerciseService.getExercises().then(
      (exercises) => dispatch(success(exercises)),
      (error) => dispatch(failure(error.toString()))
    );
  };

  function request() {
    return { type: exerciseConstants.GETALL_REQUEST };
  }
  function success(exercises) {
    return { type: exerciseConstants.GETALL_SUCCESS, exercises };
  }
  function failure(error) {
    return { type: exerciseConstants.GETALL_FAILURE, error };
  }
}

function createExercise(exercise) {
  return (dispatch) => {
    dispatch(request(exercise));

    exerciseService.createExercise(exercise).then(
      (exercise) => {
        dispatch(success());
        history.push("/home");
        dispatch(alertActions.success("exercise created"));
      },
      (error) => {
        dispatch(failure(error.toString()));
        dispatch(alertActions.error(error.toString()));
      }
    );
  };

  function request(exercise) {
    return { type: exerciseConstants.CREATE_REQUEST, exercise };
  }
  function success(exercises) {
    return { type: exerciseConstants.CREATE_SUCCESS, exercises };
  }
  function failure(error) {
    return { type: exerciseConstants.CREATE_FAILURE, error };
  }
}

function updateExercise(exercise) {
  return (dispatch) => {
    dispatch(request(exercise));

    exerciseService.updateExercise(exercise).then(
      (exercise) => {
        dispatch(success(exercise));
        history.push("/exercises");
        dispatch(alertActions.success("exercise updated"));
      },
      (error) => {
        dispatch(failure(error.toString()));
        dispatch(alertActions.error(error.toString()));
      }
    );
  };

  function request(exercise) {
    return { type: exerciseConstants.UPDATE_REQUEST, exercise };
  }
  function success(exercise) {
    return { type: exerciseConstants.UPDATE_SUCCESS, exercise };
  }
  function failure(error) {
    return { type: exerciseConstants.UPDATE_FAILURE, error };
  }
}

function deleteExercise(id) {
  return (dispatch) => {
    dispatch(request(id));

    exerciseService.deleteExercise(id).then(
      (exercise) => dispatch(success(id)),
      (error) => dispatch(failure(id, error.toString()))
    );
  };

  function request(id) {
    return { type: exerciseConstants.DELETE_REQUEST, id };
  }
  function success(id) {
    return { type: exerciseConstants.DELETE_SUCCESS, id };
  }
  function failure(id, error) {
    return { type: exerciseConstants.DELETE_FAILURE, id, error };
  }
}
