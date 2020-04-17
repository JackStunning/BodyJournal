import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { exerciseActions } from "../../actions";

function CreateExerciseView() {
  const [exercise, setExercise] = useState({
    weight: 0,
    reps: 0,
    sets: 0,
    name: "",
    muscleGroup: "",
    intensity: "",
  });
  const [submitted, setSubmitted] = useState(false);
  // const { weight, reps, sets, name, muscleGroup, intensity } = inputs;
  const creating = useSelector((state) => state.exercises.creating);
  const dispatch = useDispatch();

  function handleChange(e) {
    const { name, value } = e.target;
    setExercise((exercise) => ({ ...exercise, [name]: value }));
  }

  function handleSubmit(e) {
    e.preventDefault();

    setSubmitted(true);
    if (
      exercise.weight &&
      exercise.reps &&
      exercise.sets &&
      exercise.name &&
      exercise.muscleGroup &&
      exercise.intensity
    ) {
      dispatch(exerciseActions.createExercise(exercise));
    }
  }

  return (
    <div className="col-lg-8 offset-lg-2">
      <h2>Create Exercise</h2>
      <form name="form" onSubmit={handleSubmit}>
        <div className="form-group">
          <label>Name</label>
          <input
            type="text"
            name="name"
            value={exercise.name}
            onChange={handleChange}
            className={
              "form-control" +
              (submitted && !exercise.name ? " is-invalid" : "")
            }
          />
          {submitted && !exercise.name && (
            <div className="invalid-feedback">Name is required</div>
          )}
        </div>
        <div className="form-group">
          <label>Reps</label>
          <input
            type="text"
            name="reps"
            value={exercise.reps}
            onChange={handleChange}
            className={
              "form-control" +
              (submitted && !exercise.reps ? " is-invalid" : "")
            }
          />
          {submitted && !exercise.reps && (
            <div className="invalid-feedback">Reps is required</div>
          )}
        </div>
        <div className="form-group">
          <label>Sets</label>
          <input
            type="text"
            name="sets"
            value={exercise.sets}
            onChange={handleChange}
            className={
              "form-control" +
              (submitted && !exercise.sets ? " is-invalid" : "")
            }
          />
          {submitted && !exercise.sets && (
            <div className="invalid-feedback">Sets is required</div>
          )}
        </div>
        <div className="form-group">
          <label>Muscle Group</label>
          <input
            type="text"
            name="muscleGroup"
            value={exercise.muscleGroup}
            onChange={handleChange}
            className={
              "form-control" +
              (submitted && !exercise.muscleGroup ? " is-invalid" : "")
            }
          />
          {submitted && !exercise.muscleGroup && (
            <div className="invalid-feedback">Muscle group is required</div>
          )}
        </div>
        <div className="form-group">
          <button className="btn btn-primary">
            {creating && (
              <span className="spinner-border spinner-border-sm mr-1"></span>
            )}
            Create Exercise
          </button>
          <Link to="/home" className="btn btn-link">
            Cancel
          </Link>
        </div>
      </form>
    </div>
  );
}

export { CreateExerciseView };
