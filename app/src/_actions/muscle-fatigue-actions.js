import { muscleFatigueConstants } from "../_constants";
import { muscleFatigueService } from "../services";
import { alertActions } from ".";
import { history } from "../helpers";

export const muscleFatigueActions = {
  getMuscleFatigue,
  getMuscleFatigues,
  createMuscleFatigue,
  updateMuscleFatigue,
  deleteMuscleFatigue,
};

function getMuscleFatigue(id) {
  return (dispatch) => {
    dispatch(request(id));

    muscleFatigueService.getmuscleFatigue(id).then(
      (muscleFatigue) => dispatch(success(muscleFatigue)),
      (error) => dispatch(failure(id, error.toString()))
    );
  };

  function request(id) {
    return { type: muscleFatigueConstants.GET_REQUEST, id };
  }
  function success(muscleFatigue) {
    return { type: muscleFatigueConstants.GET_SUCCESS, muscleFatigue };
  }
  function failure(id, error) {
    return { type: muscleFatigueConstants.GET_FAILURE, id, error };
  }
}

function getMuscleFatigues() {
  return (dispatch) => {
    dispatch(request());

    muscleFatigueService.getMuscleFatigues().then(
      (muscleFatigues) => dispatch(success(muscleFatigues)),
      (error) => dispatch(failure(error.toString()))
    );
  };

  function request() {
    return { type: muscleFatigueConstants.GETALL_REQUEST };
  }
  function success(muscleFatigues) {
    return { type: muscleFatigueConstants.GETALL_SUCCESS, muscleFatigues };
  }
  function failure(error) {
    return { type: muscleFatigueConstants.GETALL_FAILURE, error };
  }
}

function createMuscleFatigue(muscleFatigue) {
  return (dispatch) => {
    dispatch(request(muscleFatigue));

    muscleFatigueService.createMuscleFatigue(muscleFatigue).then(
      (muscleFatigue) => {
        dispatch(success());
        history.push("/muscleFatigues");
        dispatch(alertActions.success("muscleFatigue created"));
      },
      (error) => {
        dispatch(failure(error.toString()));
        dispatch(alertActions.error(error.toString()));
      }
    );
  };

  function request(muscleFatigue) {
    return { type: muscleFatigueConstants.CREATE_REQUEST, muscleFatigue };
  }
  function success(muscleFatigue) {
    return { type: muscleFatigueConstants.CREATE_SUCCESS, muscleFatigue };
  }
  function failure(error) {
    return { type: muscleFatigueConstants.CREATE_FAILURE, error };
  }
}

function updateMuscleFatigue(muscleFatigue) {
  return (dispatch) => {
    dispatch(request(muscleFatigue));

    muscleFatigueService.updatemuscleFatigue(muscleFatigue).then(
      (muscleFatigue) => {
        dispatch(success(muscleFatigue));
        history.push("/muscleFatigues");
        dispatch(alertActions.success("muscleFatigue updated"));
      },
      (error) => {
        dispatch(failure(error.toString()));
        dispatch(alertActions.error(error.toString()));
      }
    );
  };

  function request(muscleFatigue) {
    return { type: muscleFatigueConstants.UPDATE_REQUEST, muscleFatigue };
  }
  function success(muscleFatigue) {
    return { type: muscleFatigueConstants.UPDATE_SUCCESS, muscleFatigue };
  }
  function failure(error) {
    return { type: muscleFatigueConstants.UPDATE_FAILURE, error };
  }
}

function deleteMuscleFatigue(id) {
  return (dispatch) => {
    dispatch(request(id));

    muscleFatigueService.delete(id).then(
      (muscleFatigue) => dispatch(success(id)),
      (error) => dispatch(failure(id, error.toString()))
    );
  };

  function request(id) {
    return { type: muscleFatigueConstants.DELETE_REQUEST, id };
  }
  function success(id) {
    return { type: muscleFatigueConstants.DELETE_SUCCESS, id };
  }
  function failure(id, error) {
    return { type: muscleFatigueConstants.DELETE_FAILURE, id, error };
  }
}
