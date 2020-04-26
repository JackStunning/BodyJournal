import React, { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { workoutActions } from "../../../actions";

function CreateWorkout() {
  const [workout, setworkout] = useState({
    weight: 0,
    reps: 0,
    sets: 0,
    name: "",
    muscleGroup: "",
    intensity: "",
  });
  const [submitted, setSubmitted] = useState(false);
  const creating = useSelector((state) => state.workouts.creating);
  const dispatch = useDispatch();

  function handleChange(e) {
    const { name, value } = e.target;
    setworkout((workout) => ({ ...workout, [name]: value }));
  }

  function handleSubmit(e) {
    e.preventDefault();

    setSubmitted(true);
    if (
      workout.weight &&
      workout.reps &&
      workout.sets &&
      workout.name &&
      workout.muscleGroup &&
      workout.intensity
    ) {
      dispatch(workoutActions.createworkout(workout));
    }
  }

  return (
    <div className="col-lg-8 offset-lg-2">
      <h2>Create workout</h2>
      <form name="form" onSubmit={handleSubmit}>
        <div className="form-group">
          <label>Name</label>
          <input
            type="text"
            name="name"
            value={workout.name}
            onChange={handleChange}
            className={
              "form-control" + (submitted && !workout.name ? " is-invalid" : "")
            }
          />
          {submitted && !workout.name && (
            <div className="invalid-feedback">Name is required</div>
          )}
        </div>
        <div className="form-group">
          <label>Reps</label>
          <input
            type="text"
            name="reps"
            value={workout.reps}
            onChange={handleChange}
            className={
              "form-control" + (submitted && !workout.reps ? " is-invalid" : "")
            }
          />
          {submitted && !workout.reps && (
            <div className="invalid-feedback">Reps is required</div>
          )}
        </div>
        <div className="form-group">
          <label>Sets</label>
          <input
            type="text"
            name="sets"
            value={workout.sets}
            onChange={handleChange}
            className={
              "form-control" + (submitted && !workout.sets ? " is-invalid" : "")
            }
          />
          {submitted && !workout.sets && (
            <div className="invalid-feedback">Sets is required</div>
          )}
        </div>
        <div className="form-group">
          <label>Muscle Group</label>
          <input
            type="text"
            name="muscleGroup"
            value={workout.muscleGroup}
            onChange={handleChange}
            className={
              "form-control" +
              (submitted && !workout.muscleGroup ? " is-invalid" : "")
            }
          />
          {submitted && !workout.muscleGroup && (
            <div className="invalid-feedback">Muscle group is required</div>
          )}
        </div>
        <div className="form-group">
          <button className="btn btn-primary">
            {creating && (
              <span className="spinner-border spinner-border-sm mr-1"></span>
            )}
            Create workout
          </button>
          <Link to="/home" className="btn btn-link">
            Cancel
          </Link>
        </div>
      </form>
    </div>
  );
}

export { CreateWorkout };
