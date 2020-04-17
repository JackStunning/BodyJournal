import { workoutConstants } from "../constants";

export function workouts(state = {}, action) {
  switch (action.type) {
    case workoutConstants.GETALL_REQUEST:
      return {
        loading: true,
      };
    case workoutConstants.GETALL_SUCCESS:
      return {
        items: action.workouts,
      };
    case workoutConstants.GETALL_FAILURE:
      return {
        error: action.error,
      };
    case workoutConstants.DELETE_REQUEST:
      return {
        ...state,
        items: state.items.map((workout) =>
          workout.id === action.id ? { ...workout, deleting: true } : workout
        ),
      };
    case workoutConstants.DELETE_SUCCESS:
      return {
        items: state.items.filter((workout) => workout.id !== action.id),
      };
    case workoutConstants.DELETE_FAILURE:
      return {
        ...state,
        items: state.items.map((workout) => {
          if (workout.id === action.id) {
            const { deleting, ...workoutCopy } = workout;
            return { ...workoutCopy, deleteError: action.error };
          }

          return workout;
        }),
      };
    default:
      return state;
  }
}
