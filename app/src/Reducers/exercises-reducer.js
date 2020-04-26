import { exerciseConstants } from "../constants";

export function exercises(state = {}, action) {
  switch (action.type) {
    case exerciseConstants.GETALL_REQUEST:
      return {
        loading: true,
      };
    case exerciseConstants.GETALL_SUCCESS:
      return {
        items: action.exercises,
      };
    case exerciseConstants.GETALL_FAILURE:
      return {
        error: action.error,
      };
    case exerciseConstants.GET_REQUEST:
      return {
        loading: true,
      };
    case exerciseConstants.GET_SUCCESS:
      return {
        item: action.exercise,
      };
    case exerciseConstants.GET_FAILURE:
      return {
        error: action.error,
      };
    case exerciseConstants.GETBYMUSCLE_REQUEST:
      return {
        loading: true,
      };
    case exerciseConstants.GETBYMUSCLE_SUCCESS:
      return {
        items: action.exercises,
      };
    case exerciseConstants.GETBYMUSCLE_FAILURE:
      return {
        error: action.error,
      };
    case exerciseConstants.CREATE_REQUEST:
      return {
        creating: true,
      };
    case exerciseConstants.CREATE_SUCCESS:
      return {};
    case exerciseConstants.CREATE_FAILURE:
      return {};
    case exerciseConstants.DELETE_REQUEST:
      return {
        ...state,
        items: state.items.map((exercise) =>
          exercise.id === action.id ? { ...exercise, deleting: true } : exercise
        ),
      };
    case exerciseConstants.DELETE_SUCCESS:
      return {
        items: state.items.filter((exercise) => exercise.id !== action.id),
      };
    case exerciseConstants.DELETE_FAILURE:
      return {
        ...state,
        items: state.items.map((exercise) => {
          if (exercise.id === action.id) {
            const { deleting, ...exerciseCopy } = exercise;
            return { ...exerciseCopy, deleteError: action.error };
          }

          return exercise;
        }),
      };
    default:
      return state;
  }
}
