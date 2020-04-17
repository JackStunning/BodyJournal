import React, { useEffect } from "react";
import { Link } from "react-router-dom";
import { useSelector } from "react-redux";

function HomePage() {
  const user = useSelector((state) => state.authentication.user);
  return (
    <div className="row">
      <h1>Welcome {user.firstName}!</h1>
      <p>
        <Link to="/login">Logout</Link>
      </p>
      <p>
        <Link to="/exercises">Exercises</Link>
      </p>
      <p>
        <Link to="/workouts">Workouts</Link>
      </p>
    </div>
  );
}

export { HomePage };
