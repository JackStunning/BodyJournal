function leastUsedMuscle() {
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(workoutActions.getWorkouts());
  }, []);
  return (
    <div class="w3-quarter">
      <div class="w3-container w3-blue w3-padding-16">
        <div class="w3-left">
          <i class="w3-xxxlarge"></i>
        </div>
        <h4>Least used Muscle Group</h4>
        <p></p>
        <h3>Core</h3>
        <div class="w3-clear"></div>
      </div>
    </div>
  );
}
