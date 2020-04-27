import { combineReducers } from "redux";
import { authentication } from "./authentication-reducer";
import { registration } from "./registration-reducer";
import { workouts } from "./workouts-reducer";
import { exercises } from "./exercises-reducer";
import { muscleFatigues } from "./muscle-fatigue-reducer";
import { users } from "./users-reducer";
import { alert } from "./alert-reducer";

const rootReducer = combineReducers({
  authentication,
  registration,
  workouts,
  exercises,
  muscleFatigues,
  users,
  alert,
});

export default rootReducer;
