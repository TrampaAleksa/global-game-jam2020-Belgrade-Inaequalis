using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepHandler : MonoBehaviour
{
      public static StepHandler Instance;
   
    void Awake()
    {
        Instance = this;
    }
    public bool PlacedStepObject(StepObject objectPlaced, Step step){
                if(objectPlaced.gameObject.name == step.stepObjects[step.currentStepObjectIndex].name){
            step.currentStepObjectIndex++;
            if(step.currentStepObjectIndex == step.stepObjects.Length) return FinishStep(step);
            else print("Correct object added, add the next one!");
        }
        else {
            print("Wrong object added, please try again: ");
            step.currentStepObjectIndex = 0;
        }
            return false;
    }

    public bool FinishStep(Step step){
        print("Finished making the item");
        step.isFinished = true;
        return true;
    }
}
