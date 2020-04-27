import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { muscleFatigueActions } from "../../_actions";
import { MuscleFatigueList } from "../../components/MuscleFatigue/MuscleFatigueList";

export const MuscleFatigues = () => {
  const musclesFatigues = useSelector((state) => state.muscleFatigues);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(muscleFatigueActions.getMuscleFatigues());
  }, []);

  const chest = MuscleFatigueList(musclesFatigues, "Chest");
  const back = MuscleFatigueList(musclesFatigues, "Back");
  const shoulders = MuscleFatigueList(musclesFatigues, "Shoulders");
  const arms = MuscleFatigueList(musclesFatigues, "Arms");
  const abs = MuscleFatigueList(musclesFatigues, "Abs");
  const legs = MuscleFatigueList(musclesFatigues, "Legs");
  const fatigues = [chest, back, shoulders, arms, abs, legs];
  // const [muscleFatigueList, setmuscleFatigueList] = useState(null);

  // const handleShowingMuscleFatigues = (fatigue) => {
  //   setExerciseList(fatigues[fatigue]);
  // };
  return (
    <React.Fragment>
      {musclesFatigues &&
        musclesFatigues.items &&
        musclesFatigues.items.map((item) => {
          return (
            <div key={item.id}>
              <h4>{item.muscleGroup}</h4>
              <h4>{item.fatigue}</h4>
              <h4>{item.currentTime}</h4>
            </div>
          );
        })}
    </React.Fragment>
  );
};
