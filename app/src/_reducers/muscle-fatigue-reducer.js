import { muscleFatigueConstants } from "../_constants";

export function muscleFatigues(state = {}, action) {
  switch (action.type) {
    case muscleFatigueConstants.GETALL_REQUEST:
      return {
        loading: true,
      };
    case muscleFatigueConstants.GETALL_SUCCESS:
      return {
        items: action.muscleFatigues,
      };
    case muscleFatigueConstants.GETALL_FAILURE:
      return {
        error: action.error,
      };
    case muscleFatigueConstants.GET_REQUEST:
      return {
        loading: true,
      };
    case muscleFatigueConstants.GET_SUCCESS:
      return {
        item: action.muscleFatigue,
      };
    case muscleFatigueConstants.GET_FAILURE:
      return {
        error: action.error,
      };
    case muscleFatigueConstants.CREATE_REQUEST:
      return {
        creating: true,
      };
    case muscleFatigueConstants.CREATE_SUCCESS:
      return {};
    case muscleFatigueConstants.CREATE_FAILURE:
      return {};
    case muscleFatigueConstants.DELETE_REQUEST:
      return {
        ...state,
        items: state.items.map((muscleFatigue) =>
          muscleFatigue.id === action.id
            ? { ...muscleFatigue, deleting: true }
            : muscleFatigue
        ),
      };
    case muscleFatigueConstants.DELETE_SUCCESS:
      return {
        items: state.items.filter(
          (muscleFatigue) => muscleFatigue.id !== action.id
        ),
      };
    case muscleFatigueConstants.DELETE_FAILURE:
      return {
        ...state,
        items: state.items.map((muscleFatigue) => {
          if (muscleFatigue.id === action.id) {
            const { deleting, ...muscleFatigueCopy } = muscleFatigue;
            return { ...muscleFatigueCopy, deleteError: action.error };
          }

          return muscleFatigue;
        }),
      };
    default:
      return state;
  }
}
