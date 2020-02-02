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
    public bool PlacedStepObjectSuccesfully(StepObject objectPlaced, Step step){
        print(step.currentStepObjectIndex);
        if(objectPlaced.gameObject.GetComponent<StepObject>().GetDefaultImage() == step.stepObjects[step.currentStepObjectIndex].GetComponent<StepObject>().GetDefaultImage())
        {
            step.currentStepObjectIndex++;
            if (step.currentStepObjectIndex == step.stepObjects.Length)
            {
                return FinishStep(step);
            }
            else print("Correct object added, add the next one!");
        }
        else {
            step.currentStepObjectIndex = 0;
        }
            return false;
    }

    public bool FinishStep(Step step){
        print("Finished the step");
        step.isFinished = true;
        return true;
    }
}
