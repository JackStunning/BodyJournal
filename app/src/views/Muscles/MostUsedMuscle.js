function mostUsedMuscle() {
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(workoutActions.getWorkouts());
  }, []);

  return (
    <div class="w3-quarter">
      <div class="w3-container w3-red w3-padding-16">
        <div class="w3-left">
          <div id="most-used">
            <i class="w3-xxxlarge"></i>
          </div>
        </div>
        <h4>Most used Muscle Group</h4>
        <p></p>
        <h3>Chest</h3>
        <div class="w3-clear"></div>
      </div>
    </div>
  );
}
