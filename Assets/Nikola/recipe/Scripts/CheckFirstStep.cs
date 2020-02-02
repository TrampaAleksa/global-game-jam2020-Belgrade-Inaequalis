using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFirstStep : MonoBehaviour
{
    public Animator[] animators;
 
    private string[] parameterNames = {
        "firstStepIsFinished",
        "secondStepIsFinished",
        "thirdStepIsFinished"
    };
   

    public void ResetStepsAnimations()
    {
        SetStepIsFinished(false, 0);
        SetStepIsFinished(false, 1);
        SetStepIsFinished(false, 2);
    }

    public void SetStepIsFinished(bool isFinished, int stepIndex) // Prosledi trampin isFinished flag
    {
        animators[stepIndex].SetBool(parameterNames[stepIndex], isFinished);
    }

}
