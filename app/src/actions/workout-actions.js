import { workoutConstants } from "../Constants";
import { workoutService } from "../services";
import { alertActions } from "./";
import { history } from "../Helpers";

export const workoutActions = {
  getWorkout,
  getWorkouts,
  createWorkout,
  updateWorkout,
  deleteWorkout,
};

function getWorkout(id) {
  return (dispatch) => {
    dispatch(request(id));

    workoutService.getWorkout(id).then(
      (workout) => dispatch(success(workout)),
      (error) => dispatch(failure(id, error.toString()))
    );
  };

  function request(id) {
    return { type: workoutConstants.GET_REQUEST, id };
  }
  function success(workout) {
    return { type: userConstants.GET_SUCCESS, workout };
  }
  function failure(id, error) {
    return { type: userConstants.GET_FAILURE, id, error };
  }
}

function getWorkouts() {
  return (dispatch) => {
    dispatch(request());

    workoutService.getWorkouts().then(
      (workouts) => dispatch(success(workouts)),
      (error) => dispatch(failure(error.toString()))
    );
  };

  function request() {
    return { type: workoutConstants.GETALL_REQUEST };
  }
  function success(workouts) {
    return { type: workoutConstants.GETALL_SUCCESS, workouts };
  }
  function failure(error) {
    return { type: workoutConstants.GETALL_FAILURE, error };
  }
}

function createWorkout(workout) {
  return (dispatch) => {
    dispatch(request(workout));

    workoutService.createWorkout(workout).then(
      (workout) => {
        dispatch(success());
        history.push("/workouts");
        dispatch(alertActions.success("Workout created"));
      },
      (error) => {
        dispatch(failure(error.toString()));
        dispatch(alertActions.error(error.toString()));
      }
    );
  };

  function request(workout) {
    return { type: workoutConstants.CREATE_REQUEST, workout };
  }
  function success(workout) {
    return { type: workoutConstants.CREATE_SUCCESS, workout };
  }
  function failure(error) {
    return { type: workoutConstants.CREATE_FAILURE, error };
  }
}

function updateWorkout(workout) {
  return (dispatch) => {
    dispatch(request(workout));

    workoutService.updateWorkout(workout).then(
      (workout) => {
        dispatch(success(workout));
        history.push("/workouts");
        dispatch(alertActions.success("Workout updated"));
      },
      (error) => {
        dispatch(failure(error.toString()));
        dispatch(alertActions.error(error.toString()));
      }
    );
  };

  function request(workout) {
    return { type: workoutConstants.UPDATE_REQUEST, workout };
  }
  function success(workout) {
    return { type: workoutConstants.UPDATE_SUCCESS, workout };
  }
  function failure(error) {
    return { type: workoutConstants.UPDATE_FAILURE, error };
  }
}

function deleteWorkout(id) {
  return (dispatch) => {
    dispatch(request(id));

    workoutService.delete(id).then(
      (workout) => dispatch(success(id)),
      (error) => dispatch(failure(id, error.toString()))
    );
  };

  function request(id) {
    return { type: workoutConstants.DELETE_REQUEST, id };
  }
  function success(id) {
    return { type: workoutConstants.DELETE_SUCCESS, id };
  }
  function failure(id, error) {
    return { type: workoutConstants.DELETE_FAILURE, id, error };
  }
}
