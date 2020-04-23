import React from "react";

import PropTypes from "prop-types";

export default function Exercise(props) {
  return (
    <React.Fragment>
      <h4>
        {props.name}&nbsp;{props.weight}&nbsp;{props.reps}&nbsp;{props.sets}
        &nbsp;{props.Intensity}
      </h4>
    </React.Fragment>
  );
}

Exercise.propTypes = {
  id: PropTypes.number,
  name: PropTypes.string,
  weight: PropTypes.number,
  sets: PropTypes.number,
  reps: PropTypes.number,
  intensity: PropTypes.number,
};
